using App.Puzzles;
using NUnit.Framework;

namespace Tests.ProblemTests
{
    public class Problem028Tests
    {
        [Test]
        public void Test()
        {
            var problem = new Problem028();
            var result = problem.Run(5);

            Assert.That(result, Is.EqualTo(101));
        }
    }
}