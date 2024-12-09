namespace SharpGambit.Tests.Bindings;

using gambit;

public class GameTests
{
    [Fact]
    public void Test1()
    {
        var g = game.NewStrategicFormGame("foo", 1, ["A"], [1]);
        var p = game.AddPlayer(g);
        Assert.NotEqual(p, nint.Zero);
        player.SetPlayerLabel(p, "foo");
        Assert.Equal("foo", player.GetPlayerLabel(p));
        var s = player.NewPlayerStrategy(p);
        var n = player.GetPlayerStrategies(p);

        Assert.Equal(2, player.GetPlayerNumStrategies(p));
        //var n = p.Rep.NewPlayer();
        //Marshal.
        //Assert.NotEqual(g, nint.Zero);

        /*
        g = sharpgambit.NewGame("untitled game", 0, null);
        Assert.NotEqual(nint.Zero, g);
        p = sharpgambit.AddPlayerToGame(g);
        Assert.NotEqual(p, nint.Zero);
        g = sharpgambit.NewGame("my title", 2, ["A", "B"]);
        Assert.NotEqual(nint.Zero, g);
        p = sharpgambit.GetPlayer(g, 1);
        Assert.Equal("A", sharpgambit.GetPlayerLabel(p));
        p = sharpgambit.GetPlayer(g, 2);
        Assert.Equal("B", sharpgambit.GetPlayerLabel(p));

        var s = sharpgambit.NewPlayerStrategy(p);
        Assert.Equal(1, sharpgambit.GetPlayerStrategies(p));
        */
    }
}
