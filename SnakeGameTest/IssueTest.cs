using System;
using ConsoleApp1;
using static ConsoleApp1.Issue;

namespace SnakeGameTest
{
    [TestClass]
    public class IssueTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Random random = new Random();
            var issue = new ConsoleApp1.Issue(0, 7, random);
        }

        [TestMethod]
        [DataRow(1, 7, 1)]
        [DataRow(5, 7, 5)]
        public void Add_CheckIfMinIsNotEmpty(int min, int max, int result)
        {
            Random random = new Random();
            var issue = new Issue(min, max, random);
            Assert.AreEqual(issue.Min, result);
        }

        [TestMethod]
        [DataRow(1, 7, 7)]
        [DataRow(5, 10, 10)]
        public void Add_CheckIfMaxIsNotEmpty(int min, int max, int result)
        {
            Random random = new Random();
            var issue = new Issue(min, max, random);
            Assert.AreEqual(issue.Max, result);
        }

        [TestMethod]
        [DataRow(1, 7, 7)]
        [DataRow(5, 10, 10)]
        public void CheckIfIssueIsBetweenMinAndMax(int min, int max, int result)
        {
            Random random = new Random();
            var issue = new Issue(min, max, random);
            int radomNumber = issue.getRandomNumber();

            Assert.IsTrue(issue.issueIsBetweenLimit(radomNumber));
        }

        [TestMethod]
        [DataRow(1, 7, 7)]
        [DataRow(5, 10, 10)]
        public void CheckIfIssueIsNotBetweenMinAndMax(int min, int max, int result)
        {
            Random random = new Random();
            var issue = new Issue(min, max, random);
            int radomNumber = 25;

            Assert.ThrowsException<RandomNumberIsNotBetweenLimit>(() => (issue.issueIsBetweenLimit(radomNumber)));
        }
    }
}