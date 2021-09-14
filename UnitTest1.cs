using System;
using BowlingGame;
using Xunit;

namespace Bowling_Test
{
    public class BowlingGameTest

    {
        [Fact]
        public void TestGutterGame()
        {
            Game game = new Game();

            for (int i = 0; i < 20; i++)
            {
                game.Roll(0);
            }

            Assert.Equal(0, game.Score());
        }
    }
}
