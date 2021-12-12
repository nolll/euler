using NUnit.Framework;

namespace App.Puzzles.Puzzle004
{
    public class Problem004Tests
    {
        [Test]
        public void Test()
        {
            var problem = new Problem004();
            var result = problem.Run(10, 99);

            Assert.That(result, Is.EqualTo(9009));
        }
    }
}