using ConsoleApp.Problems;
using NUnit.Framework;

namespace Tests
{
    public class ProblemTests
    {
        [Test]
        public void TestProblem1()
        {
            var problem = new Problem1();
            var result = problem.Run(10);

            Assert.That(result, Is.EqualTo(23));
        }

        [Test]
        public void TestProblem2()
        {
            var problem = new Problem2();
            var result = problem.Run(100);

            Assert.That(result, Is.EqualTo(44));
        }

        [Test]
        public void TestProblem3()
        {
            var problem = new Problem3();
            var result = problem.Run(13195);

            Assert.That(result, Is.EqualTo(29));
        }

        [Test]
        public void TestProblem4()
        {
            var problem = new Problem4();
            var result = problem.Run(10, 99);

            Assert.That(result, Is.EqualTo(9009));
        }

        [Test]
        public void TestProblem5()
        {
            var problem = new Problem5();
            var result = problem.Run(10);

            Assert.That(result, Is.EqualTo(2520));
        }

        [Test]
        public void TestProblem6()
        {
            var problem = new Problem6();
            var result = problem.Run(10);

            Assert.That(result, Is.EqualTo(2640));
        }

        [Test]
        public void TestProblem7()
        {
            var problem = new Problem7();
            var result = problem.Run(6);

            Assert.That(result, Is.EqualTo(13));
        }

        [Test]
        public void TestProblem8()
        {
            var problem = new Problem8();
            var result = problem.Run(4);

            Assert.That(result, Is.EqualTo(5832));
        }
    }
}