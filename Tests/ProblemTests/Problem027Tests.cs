using ConsoleApp.Problems;
using NUnit.Framework;

namespace Tests.ProblemTests
{
    public class Problem027Tests
    {
        [Test]
        public void Test1()
        {
            var problem = new Problem027();
            var result = problem.GetPrimeCount(-79, 1601);

            Assert.That(result, Is.EqualTo(80));
        }
    }
}