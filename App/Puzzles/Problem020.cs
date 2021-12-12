using System.Numerics;
using App.Platform;

namespace App.Puzzles
{
    public class Problem020 : Problem
    {
        public override int Id => 20;
        public override string Name => "Factorial digit sum";

        public override PuzzleResult Run()
        {
            BigInteger factorial = 100;
            var result = Run(factorial);
            return new PuzzleResult(result, 648);
        }

        public int Run(BigInteger factorial)
        {
            BigInteger product = 1;
            var current = factorial;
            while (current > 0)
            {
                product *= current;
                current--;
            }

            var numbers = product.ToString().ToCharArray().Select(o => o.ToString()).Select(int.Parse);
            return numbers.Sum();
        }
    }
}