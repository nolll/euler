using App.Puzzles;
using NUnit.Framework;

namespace Tests.ProblemTests
{
    public class Problem009Tests
    {
        [Test]
        public void Test()
        {
            var problem = new Problem009();
            var result = problem.Run(12);

            Assert.That(result, Is.EqualTo(60));
        }
    }
}