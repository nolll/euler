using NUnit.Framework;

namespace App.Puzzles.Puzzle023
{
    public class Problem023Tests
    {
        [Test]
        public void Test()
        {
            var problem = new Problem023();
            var result = problem.FindAbundantNumbers(13);

            Assert.That(result.Count(), Is.EqualTo(1));
        }
    }
}