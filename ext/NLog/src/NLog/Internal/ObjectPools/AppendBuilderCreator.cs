// 
// Copyright (c) 2004-2021 Jaroslaw Kowalski <jaak@jkowalski.net>, Kim Christensen, Julian Verdurmen
// 
// All rights reserved.
// 
// Redistribution and use in source and binary forms, with or without 
// modification, are permitted provided that the following conditions 
// are met:
// 
// * Redistributions of source code must retain the above copyright notice, 
//   this list of conditions and the following disclaimer. 
// 
// * Redistributions in binary form must reproduce the above copyright notice,
//   this list of conditions and the following disclaimer in the documentation
//   and/or other materials provided with the distribution. 
// 
// * Neither the name of Jaroslaw Kowalski nor the names of its 
//   contributors may be used to endorse or promote products derived from this
//   software without specific prior written permission. 
// 
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE 
// IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE 
// ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE 
// LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR 
// CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
// SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS 
// INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN 
// CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
// ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF 
// THE POSSIBILITY OF SUCH DAMAGE.
// 

using System;
using System.Text;

namespace NLog.Internal
{
    /// <summary>
    /// Allocates new builder and appends to the provided target builder on dispose
    /// </summary>
    internal struct AppendBuilderCreator : IDisposable
    {
        private static readonly StringBuilderPool _builderPool = new StringBuilderPool(Environment.ProcessorCount * 2);
        private readonly StringBuilder _appendTarget;

        /// <summary>
        /// Access the new builder allocated
        /// </summary>
        public StringBuilder Builder => _builder.Item;

        private StringBuilderPool.ItemHolder _builder;  // Not readonly to avoid struct-copy on Dispose(), and to avoid VerificationException when medium-trust AppDomain

        public AppendBuilderCreator(bool mustBeEmpty)
        {
            _builder = _builderPool.Acquire();
            _appendTarget = _builder.Item;
        }

        public AppendBuilderCreator(StringBuilder appendTarget, bool mustBeEmpty)
        {
            _appendTarget = appendTarget;
            if (_appendTarget.Length > 0 && mustBeEmpty)
            {
                _builder = _builderPool.Acquire();
            }
            else
            {
                _builder = new StringBuilderPool.ItemHolder(_appendTarget, null, 0);
            }
        }

        public void Dispose()
        {
            if (!ReferenceEquals(_builder.Item, _appendTarget))
            {
                _builder.Item.CopyTo(_appendTarget);
                _builder.Dispose();
            }
        }
    }
}
