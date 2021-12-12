using NUnit.Framework;

namespace App.Puzzles.Puzzle030
{
    public class Problem030Tests
    {
        [Test]
        public void Test()
        {
            var problem = new Problem030();
            var result = problem.Run(4);

            Assert.That(result, Is.EqualTo(19316));
        }
    }
}