using NUnit.Framework;

namespace App.Puzzles.Puzzle029
{
    public class Problem029Tests
    {
        [Test]
        public void Test()
        {
            var problem = new Problem029();
            var result = problem.Run(5);

            Assert.That(result, Is.EqualTo(15));
        }
    }
}