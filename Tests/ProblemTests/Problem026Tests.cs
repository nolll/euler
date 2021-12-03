using ConsoleApp.Problems;
using NUnit.Framework;

namespace Tests.ProblemTests
{
    public class Problem026Tests
    {
        [Test]
        public void Test()
        {
            var problem = new Problem026();
            var result = problem.Run(10);

            Assert.That(result, Is.EqualTo(7));
        }
    }
}