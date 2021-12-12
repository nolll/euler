using App.Puzzles;
using NUnit.Framework;

namespace Tests.ProblemTests
{
    public class Problem016Tests
    {
        [Test]
        public void Test()
        {
            var problem = new Problem016();
            var result = problem.Run(15);

            Assert.That(result, Is.EqualTo(26));
        }
    }
}