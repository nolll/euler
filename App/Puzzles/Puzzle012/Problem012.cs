using App.Common.Numbers;
using App.Platform;

namespace App.Puzzles.Puzzle012
{
    public class Problem012 : Problem
    {
        public override int Id => 12;
        public override string Name => "Highly divisible triangular number";
        
        public override PuzzleResult Run()
        {
            var result = Run(501);
            return new PuzzleResult(result, 76576500);
        }

        public int Run(int maxFactorCount)
        {
            var current = 1;
            var triangle = current;

            while (true)
            {
                var factorCount = Enumerable.Count<int>(Factorization.GetAllDivisors(triangle));

                if (factorCount > maxFactorCount)
                    return triangle;

                current++;
                triangle += current;
            }
        }
    }
}