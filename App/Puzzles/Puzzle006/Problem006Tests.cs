using NUnit.Framework;

namespace App.Puzzles.Puzzle006
{
    public class Problem006Tests
    {
        [Test]
        public void Test()
        {
            var problem = new Problem006();
            var result = problem.Run(10);

            Assert.That(result, Is.EqualTo(2640));
        }
    }
}