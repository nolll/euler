using ConsoleApp.Problems;
using NUnit.Framework;

namespace Tests.ProblemTests
{
    public class Problem001Tests
    {
        [Test]
        public void Test()
        {
            var problem = new Problem001();
            var result = problem.Run(10);

            Assert.That(result, Is.EqualTo(23));
        }
    }
}