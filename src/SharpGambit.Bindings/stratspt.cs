// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required

namespace gambit
{
    namespace Gambit
    {
        /// <summary>A support on a strategic game</summary>
        /// <remarks>
        /// <para>This class represents a subset of the strategies in strategic game.</para>
        /// <para>It is enforced that each player has at least one strategy; thus,</para>
        /// <para>the strategies in a support can be viewed as a restriction of a game</para>
        /// <para>to a subset of its strategies.  This is useful for eliminating</para>
        /// <para>dominated strategies from consideration, and in computational</para>
        /// <para>approaches that enumerate possible equilibrium supports.</para>
        /// <para>Within the support, strategies are maintained in the same order</para>
        /// <para>in which they appear in the underlying game.</para>
        /// </remarks>
        public unsafe partial class StrategySupportProfile : IDisposable
        {
            [StructLayout(LayoutKind.Sequential, Size = 56)]
            public partial struct __Internal
            {
                internal global::gambit.Gambit.GameObjectPtr.__Internal m_nfg;
                internal global::gambit.Gambit.Array.__Internal m_support;
                internal global::gambit.Gambit.Array.__Internal m_profileIndex;

                [SuppressUnmanagedCodeSecurity, DllImport("sharpgambit", EntryPoint = "c__N_Gambit_S_StrategySupportProfile__StrategySupportProfile", CallingConvention = __CallingConvention.Cdecl)]
                internal static extern void dtor(__IntPtr __instance);
            }

            public unsafe partial class Iterator : IDisposable
            {
                [StructLayout(LayoutKind.Sequential, Size = 16)]
                public partial struct __Internal
                {
                    internal __IntPtr support;
                    internal int pl;
                    internal int strat;

                    [SuppressUnmanagedCodeSecurity, DllImport("sharpgambit", EntryPoint = "??0iterator@StrategySupportProfile@Gambit@@QEAA@AEBV012@@Z", CallingConvention = __CallingConvention.Cdecl)]
                    internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr _0);
                }

                public __IntPtr __Instance { get; protected set; }

                internal static readonly new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::gambit.Gambit.StrategySupportProfile.Iterator> NativeToManagedMap =
                    new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::gambit.Gambit.StrategySupportProfile.Iterator>();

                internal static void __RecordNativeToManagedMapping(IntPtr native, global::gambit.Gambit.StrategySupportProfile.Iterator managed)
                {
                    NativeToManagedMap[native] = managed;
                }

                internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::gambit.Gambit.StrategySupportProfile.Iterator managed)
                {
    
                    return NativeToManagedMap.TryGetValue(native, out managed);
                }

                protected bool __ownsNativeInstance;

                internal static Iterator __CreateInstance(__IntPtr native, bool skipVTables = false)
                {
                    if (native == __IntPtr.Zero)
                        return null;
                    return new Iterator(native.ToPointer(), skipVTables);
                }

                internal static Iterator __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
                {
                    if (native == __IntPtr.Zero)
                        return null;
                    if (__TryGetNativeToManagedMapping(native, out var managed))
                        return (Iterator)managed;
                    var result = __CreateInstance(native, skipVTables);
                    if (saveInstance)
                        __RecordNativeToManagedMapping(native, result);
                    return result;
                }

                internal static Iterator __CreateInstance(__Internal native, bool skipVTables = false)
                {
                    return new Iterator(native, skipVTables);
                }

                private static void* __CopyValue(__Internal native)
                {
                    var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                    *(__Internal*) ret = native;
                    return ret.ToPointer();
                }

                private Iterator(__Internal native, bool skipVTables = false)
                    : this(__CopyValue(native), skipVTables)
                {
                    __ownsNativeInstance = true;
                    __RecordNativeToManagedMapping(__Instance, this);
                }

                protected Iterator(void* native, bool skipVTables = false)
                {
                    if (native == null)
                        return;
                    __Instance = new __IntPtr(native);
                }

                public Iterator(global::gambit.Gambit.StrategySupportProfile.Iterator _0)
                {
                    __Instance = Marshal.AllocHGlobal(sizeof(global::gambit.Gambit.StrategySupportProfile.Iterator.__Internal));
                    __ownsNativeInstance = true;
                    __RecordNativeToManagedMapping(__Instance, this);
                    *((global::gambit.Gambit.StrategySupportProfile.Iterator.__Internal*) __Instance) = *((global::gambit.Gambit.StrategySupportProfile.Iterator.__Internal*) _0.__Instance);
                }

                public void Dispose()
                {
                    Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
                }

                partial void DisposePartial(bool disposing);

                internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
                {
                    if (__Instance == IntPtr.Zero)
                        return;
                    NativeToManagedMap.TryRemove(__Instance, out _);
                    DisposePartial(disposing);
                    if (__ownsNativeInstance)
                        Marshal.FreeHGlobal(__Instance);
                    __Instance = IntPtr.Zero;
                }
            }

            public __IntPtr __Instance { get; protected set; }

            internal static readonly new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::gambit.Gambit.StrategySupportProfile> NativeToManagedMap =
                new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::gambit.Gambit.StrategySupportProfile>();

            internal static void __RecordNativeToManagedMapping(IntPtr native, global::gambit.Gambit.StrategySupportProfile managed)
            {
                NativeToManagedMap[native] = managed;
            }

            internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::gambit.Gambit.StrategySupportProfile managed)
            {
    
                return NativeToManagedMap.TryGetValue(native, out managed);
            }

            protected bool __ownsNativeInstance;

            internal static StrategySupportProfile __CreateInstance(__IntPtr native, bool skipVTables = false)
            {
                if (native == __IntPtr.Zero)
                    return null;
                return new StrategySupportProfile(native.ToPointer(), skipVTables);
            }

            internal static StrategySupportProfile __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
            {
                if (native == __IntPtr.Zero)
                    return null;
                if (__TryGetNativeToManagedMapping(native, out var managed))
                    return (StrategySupportProfile)managed;
                var result = __CreateInstance(native, skipVTables);
                if (saveInstance)
                    __RecordNativeToManagedMapping(native, result);
                return result;
            }

            internal static StrategySupportProfile __CreateInstance(__Internal native, bool skipVTables = false)
            {
                return new StrategySupportProfile(native, skipVTables);
            }

            private static void* __CopyValue(__Internal native)
            {
                var ret = Marshal.AllocHGlobal(sizeof(__Internal));
                *(__Internal*) ret = native;
                return ret.ToPointer();
            }

            private StrategySupportProfile(__Internal native, bool skipVTables = false)
                : this(__CopyValue(native), skipVTables)
            {
                __ownsNativeInstance = true;
                __RecordNativeToManagedMapping(__Instance, this);
            }

            protected StrategySupportProfile(void* native, bool skipVTables = false)
            {
                if (native == null)
                    return;
                __Instance = new __IntPtr(native);
            }

            public void Dispose()
            {
                Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
            }

            partial void DisposePartial(bool disposing);

            internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
            {
                if (__Instance == IntPtr.Zero)
                    return;
                NativeToManagedMap.TryRemove(__Instance, out _);
                DisposePartial(disposing);
                if (__ownsNativeInstance)
                    Marshal.FreeHGlobal(__Instance);
                __Instance = IntPtr.Zero;
            }

            protected global::gambit.Gambit.GameObjectPtr<global::gambit.Gambit.GameRep> MNfg
            {
                get
                {
                    return global::gambit.Gambit.GameObjectPtr<global::gambit.Gambit.GameRep>.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_nfg));
                }

                set
                {
                    if (ReferenceEquals(value, null))
                        throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                    ((__Internal*)__Instance)->m_nfg = *(global::gambit.Gambit.GameObjectPtr.__Internal*) value.__Instance;
                }
            }

            protected global::gambit.Gambit.Array<global::gambit.Gambit.Array<global::gambit.Gambit.GameObjectPtr<global::gambit.Gambit.GameStrategyRep>>> MSupport
            {
                get
                {
                    return global::gambit.Gambit.Array<global::gambit.Gambit.Array<global::gambit.Gambit.GameObjectPtr<global::gambit.Gambit.GameStrategyRep>>>.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_support));
                }

                set
                {
                    if (ReferenceEquals(value, null))
                        throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                    ((__Internal*)__Instance)->m_support = *(global::gambit.Gambit.Array.__Internal*) value.__Instance;
                }
            }

            /// <summary>The index into a strategy profile for a strategy (-1 if not in support)</summary>
            protected global::gambit.Gambit.Array<int> MProfileIndex
            {
                get
                {
                    return global::gambit.Gambit.Array<int>.__CreateInstance(new __IntPtr(&((__Internal*)__Instance)->m_profileIndex));
                }

                set
                {
                    if (ReferenceEquals(value, null))
                        throw new global::System.ArgumentNullException("value", "Cannot be null because it is passed by value.");
                    ((__Internal*)__Instance)->m_profileIndex = *(global::gambit.Gambit.Array.__Internal*) value.__Instance;
                }
            }
        }
    }
}