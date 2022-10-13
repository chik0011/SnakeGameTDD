using System;
using static ConsoleApp1.Play;
using static ConsoleApp1.Player;

namespace SnakeGameTest
{
    [TestClass]
    public class PlayTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            ConsoleApp1.Player[] players = {
                new ConsoleApp1.Player("John", 0),
                new ConsoleApp1.Player("Toto", 0)
            };

            var play = new ConsoleApp1.Play(50, players);
        }

        [TestMethod]
        [DataRow(50, 50)]
        [DataRow(100, 100)]
        [DataRow(125, 125)]
        public void AddFinalScore_VerifyEqualToResult(int finalScore, int result)
        {
            ConsoleApp1.Player[] players = {
                new ConsoleApp1.Player("John", 0),
                new ConsoleApp1.Player("Toto", 0)
            };

            var play = new ConsoleApp1.Play(finalScore, players);

            Assert.AreEqual(play.FinalScore, result);
        }

        [TestMethod]
        [DataRow(50)]
        public void AddPlayers_VerifyIsNotNull(int finalScore)
        {
            ConsoleApp1.Player[] players = {
                new ConsoleApp1.Player("John", 0),
                new ConsoleApp1.Player("Toto", 0)
            };

            var play = new ConsoleApp1.Play(finalScore, players);

            Assert.IsNotNull(play.Players);
        }

        [TestMethod]
        [DataRow(50, 25)]
        [DataRow(55, 25)]
        public void CheckIsPlayerGoBackIfScoreIsUpperToFinalScore(int finalScore, int result)
        {
            ConsoleApp1.Player[] players = {
                new ConsoleApp1.Player("John", 0),
                new ConsoleApp1.Player("Toto", 0)
            };

            ConsoleApp1.Player player = new ConsoleApp1.Player("John", 60);

            var play = new ConsoleApp1.Play(finalScore, players);

            Assert.AreEqual(play.goBack(player), result);
        }

        [TestMethod]
        [DataRow(50)]
        [DataRow(55)]
        public void CheckIfTheGameIsFinish(int finalScore)
        {
            ConsoleApp1.Player[] players = {
                new ConsoleApp1.Player("John", finalScore),
                new ConsoleApp1.Player("Toto", 0)
            };

            var play = new ConsoleApp1.Play(finalScore, players);

            Assert.IsFalse(play.isGameFinished());
        }
    }
}