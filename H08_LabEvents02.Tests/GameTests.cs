using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace H08_LabEvents02.Tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void GivenANewGameAndTwoPlayers_WhenStartingAndPlayer1PlaysANumberGreaterThanPlayer2_ThenPlayer1ShouldBeReturned_() {
            //GivenANewGameAndTwoPlayers
            WinnerPlayer p1 = new WinnerPlayer();
            LoserPlayer p2 = new LoserPlayer();

            Game g = new Game(p1, p2);

            //WhenStartingAndPlayer1PlaysANumberGreaterThanPlayer2
            IPlayer winner = g.Start();

            //ThenPlayer1ShouldBeReturned
            Assert.AreEqual(g.Player1, winner);
        }

        [TestMethod]
        public void GivenANewGameAndTwoPlayers_WhenStartingAndPlayer2PlaysANumberGreaterThanPlayer1_ThenPlayer2ShouldBeReturned_() {
            //GivenANewGameAndTwoPlayers
            WinnerPlayer p2 = new WinnerPlayer();
            LoserPlayer p1 = new LoserPlayer();

            Game g = new Game(p1, p2);

            //WhenStartingAndPlayer1PlaysANumberGreaterThanPlayer2
            IPlayer winner = g.Start();

            //ThenPlayer1ShouldBeReturned
            Assert.AreEqual(g.Player2, winner);
        }

        [TestMethod]
        public void GivenANewGameAndTwoPlayers_WhenStartingAndPlayer1PlaysANumberEqualToPlayer1_ThenNullShouldBeReturned_() {
            //GivenANewGameAndTwoPlayers
            WinnerPlayer p1 = new WinnerPlayer();
            WinnerPlayer p2 = new WinnerPlayer();

            Game g = new Game(p1, p2);

            //WhenStartingAndPlayer1PlaysANumberGreaterThanPlayer2
            IPlayer winner = g.Start();

            //ThenPlayer1ShouldBeReturned
            Assert.IsNull(winner);
        }
    }
}
