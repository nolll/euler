using ConsoleApp.Tools;

namespace ConsoleApp.Problems
{
    public class Problem003 : Problem
    {
        public override int Id => 3;
        public override string Name => "Largest prime factor";

        public override PuzzleResult Run()
        {
            var largestPrime = Run(600_851_475_143);
            
            return new PuzzleResult(largestPrime, 6857);
        }

        public long Run(long number)
        {
            return Factorization.FindLargestPrimeFactor(number);
        }
    }
}