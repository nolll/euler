using System;
using System.Linq;

namespace ConsoleApp.Problems
{
    public class Problem012 : Problem
    {
        public override int Id => 12;
        public override string Name => "Highly divisible triangular number";
        
        public override PuzzleResult Run()
        {
            var result = Run(501);
            return new PuzzleResult(result);
        }

        public int Run(int maxFactorCount)
        {
            var current = 1;
            var triangle = current;
            var highest = 0;

            while (true)
            {
                var factorCount = Tools.GetFactors(triangle).Count();

                if (factorCount > highest)
                {
                    Console.WriteLine($"Triangle: {triangle}, factors: {factorCount}");
                    highest = factorCount;
                }
                
                if (factorCount > maxFactorCount)
                    return triangle;

                current++;
                triangle += current;
            }
        }
    }
}