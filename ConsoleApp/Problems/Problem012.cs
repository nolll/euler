using System;
using System.Linq;
using ConsoleApp.Tools;

namespace ConsoleApp.Problems
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
                var factorCount = Factorization.GetAllDivisors(triangle).Count();

                if (factorCount > maxFactorCount)
                    return triangle;

                current++;
                triangle += current;
            }
        }
    }
}