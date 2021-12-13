using App.Common.Numbers;
using App.Platform;

namespace App.Problems.Problem010
{
    public class Problem010 : Problem
    {
        public override string Name => "Summation of primes";
        
        public override ProblemResult Run()
        {
            var result = Run(2_000_000);
            return new ProblemResult(result, 142913828922);
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