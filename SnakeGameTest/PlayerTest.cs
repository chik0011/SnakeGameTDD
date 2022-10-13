using System;
using static ConsoleApp1.Player;

namespace SnakeGameTest
{
    [TestClass]
    public class PlayerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var player = new ConsoleApp1.Player("Jhon", 0);
        }

        [TestMethod]
        [DataRow("Fay�al", 0, "Fay�al")]
        [DataRow("Andr�", 10, "Andr�")]
        public void GetName_CheckIfIsEqualToResult(string name, int score, string result)
        {
            var player = new ConsoleApp1.Player(name, score);
            Assert.AreEqual(player.Name, result);
        }

        [TestMethod]
        [DataRow("Fay�al", 0, "Fay�al")]
        [DataRow("Andr�", 15, "Andr�")]
        public void SetName_CheckIfIsEqualToResult(string name, int score, string result)
        {
            var player = new ConsoleApp1.Player("Jhon", score);
            Assert.AreEqual(player.Name = name, result);
        }

        [TestMethod]
        [DataRow("Fay�al", 10, 10)]
        [DataRow("Andr�", 20, 20)]
        public void GetScore_CheckIfIsEqualToResult(string name, int score, int result)
        {
            var player = new ConsoleApp1.Player(name, score);
            Assert.AreEqual(player.Score, result);
        }

        [TestMethod]
        [DataRow("Fay�al", 10, 10)]
        [DataRow("Andr�", 20, 20)]
        public void SetScore_CheckIfIsEqualToResult(string name, int score, int result)
        {
            var player = new ConsoleApp1.Player(name, 39);
            Assert.AreEqual(player.Score = score, result);
        }
    }
}