using ConsoleApp.Problems;
using NUnit.Framework;

namespace Tests.ProblemTests
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