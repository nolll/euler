using System.Linq;
using ConsoleApp.Problems;
using NUnit.Framework;

namespace Tests.ProblemTests
{
    public class Problem023Tests
    {
        [Test]
        public void Test()
        {
            var problem = new Problem023();
            var result = problem.FindAbundantNumbers(13);

            Assert.That(result.Count(), Is.EqualTo(1));
        }
    }
}