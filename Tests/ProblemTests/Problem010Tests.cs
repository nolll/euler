using App.Puzzles;
using NUnit.Framework;

namespace Tests.ProblemTests
{
    public class Problem010Tests
    {
        [Test]
        public void Test()
        {
            var problem = new Problem010();
            var result = problem.Run(10);

            Assert.That(result, Is.EqualTo(17));
        }
    }
}