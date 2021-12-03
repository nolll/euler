using ConsoleApp.Problems;
using NUnit.Framework;

namespace Tests.ProblemTests
{
    public class Problem007Tests
    {
        [Test]
        public void Test()
        {
            var problem = new Problem007();
            var result = problem.Run(6);

            Assert.That(result, Is.EqualTo(13));
        }
    }
}