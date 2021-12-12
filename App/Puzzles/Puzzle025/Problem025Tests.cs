using NUnit.Framework;

namespace App.Puzzles.Puzzle025
{
    public class Problem025Tests
    {
        [Test]
        public void Test()
        {
            var problem = new Problem025();
            var result = problem.Run(3);

            Assert.That(result, Is.EqualTo(12));
        }
    }
}