using ConsoleApp.Problems;
using NUnit.Framework;

namespace Tests
{
    public class ProblemTests
    {
        [Test]
        public void TestProblem001()
        {
            var problem = new Problem001();
            var result = problem.Run(10);

            Assert.That(result, Is.EqualTo(23));
        }

        [Test]
        public void TestProblem002()
        {
            var problem = new Problem002();
            var result = problem.Run(100);

            Assert.That(result, Is.EqualTo(44));
        }

        [Test]
        public void TestProblem003()
        {
            var problem = new Problem003();
            var result = problem.Run(13195);

            Assert.That(result, Is.EqualTo(29));
        }

        [Test]
        public void TestProblem004()
        {
            var problem = new Problem004();
            var result = problem.Run(10, 99);

            Assert.That(result, Is.EqualTo(9009));
        }

        [Test]
        public void TestProblem005()
        {
            var problem = new Problem005();
            var result = problem.Run(10);

            Assert.That(result, Is.EqualTo(2520));
        }

        [Test]
        public void TestProblem006()
        {
            var problem = new Problem006();
            var result = problem.Run(10);

            Assert.That(result, Is.EqualTo(2640));
        }

        [Test]
        public void TestProblem007()
        {
            var problem = new Problem007();
            var result = problem.Run(6);

            Assert.That(result, Is.EqualTo(13));
        }

        [Test]
        public void TestProblem008()
        {
            var problem = new Problem008();
            var result = problem.Run(4);

            Assert.That(result, Is.EqualTo(5832));
        }

        [Test]
        public void TestProblem009()
        {
            var problem = new Problem009();
            var result = problem.Run(12);

            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void TestProblem010()
        {
            var problem = new Problem010();
            var result = problem.Run(10);

            Assert.That(result, Is.EqualTo(17));
        }

        [Test]
        public void TestProblem011()
        {
            const string grid = @"
01 01 01 01 01
01 02 02 02 01
01 02 02 02 01
01 02 02 03 01
01 01 01 01 04";

            var problem = new Problem011();
            var result = problem.Run(grid);

            Assert.That(result, Is.EqualTo(48));
        }

        [Test]
        public void TestProblem012()
        {
            var problem = new Problem012();
            var result = problem.Run(5);

            Assert.That(result, Is.EqualTo(28));
        }
    }
}