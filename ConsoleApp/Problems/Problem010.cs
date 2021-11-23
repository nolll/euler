using System;
using System.Linq;
using ConsoleApp.Tools;

namespace ConsoleApp.Problems
{
    public class Problem010 : Problem
    {
        public override int Id => 10;
        public override string Name => "Summation of primes";
        
        public override PuzzleResult Run()
        {
            var result = Run(2_000_000);
            return new PuzzleResult(result, 142913828922);
        }

        public long Run(int limit)
        {
            var primes = Factorization.FindPrimesBelow(limit);

            long sum = 0;
            foreach (var p in primes)
            {
                sum += p;
            }

            return sum;
        }
    }
}