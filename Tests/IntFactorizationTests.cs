using System.Linq;
using App.Common.Numbers;
using ConsoleApp;
using NUnit.Framework;

namespace Tests
{
    public class IntFactorizationTests
    {
        [TestCase(1, 1)]
        [TestCase(3, 2)]
        [TestCase(6, 4)]
        [TestCase(10, 4)]
        [TestCase(15, 4)]
        [TestCase(21, 4)]
        [TestCase(28, 6)]
        public void Factors(int n, int expected)
        {
            var factors = Factorization.GetAllDivisors(n);
            var result = factors.Count();

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}