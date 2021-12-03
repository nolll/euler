using ConsoleApp.Problems;
using NUnit.Framework;

namespace Tests.ProblemTests
{
    public class Problem021Tests
    {
        [Test]
        public void Test()
        {
            const int a = 220;
            const int b = 284;

            var problem = new Problem021();
            var sumA = problem.GetFactorialSum(a);
            var sumB = problem.GetFactorialSum(b);

            Assert.That(sumA, Is.EqualTo(b));
            Assert.That(sumB, Is.EqualTo(a));
        }
    }
}