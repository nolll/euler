using NUnit.Framework;

namespace App.Puzzles.Puzzle012
{
    public class Problem012Tests
    {
        [Test]
        public void Test()
        {
            var problem = new Problem012();
            var result = problem.Run(5);

            Assert.That(result, Is.EqualTo(28));
        }
    }
}