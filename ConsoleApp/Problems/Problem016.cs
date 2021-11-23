using System.Linq;
using System.Numerics;

namespace ConsoleApp.Problems
{
    public class Problem016 : Problem
    {
        public override int Id => 16;
        public override string Name => "Power digit sum";

        public override PuzzleResult Run()
        {
            var result = Run(1000);
            return new PuzzleResult(result, 1366);
        }

        public int Run(int power)
        {
            var product = ToPowerOf(2, power);
            return product.ToString()
                .ToCharArray()
                .Select(o => o.ToString())
                .Select(int.Parse)
                .Sum();
        }

        private BigInteger ToPowerOf(int num, int power)
        {
            var product = new BigInteger(num);
            for (var i = 1; i < power; i++)
            {
                product *= 2;
            }

            return product;
        }
    }
}