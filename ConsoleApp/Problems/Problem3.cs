using System;

namespace ConsoleApp.Problems
{
    public class Problem3 : Problem
    {
        public Problem3() : base(3)
        {
        }

        public override PuzzleResult Run()
        {
            const long input = 600_851_475_143;

            var largestPrime = FindLargestPrime(input);
            
            return new PuzzleResult(largestPrime, 6857);
        }

        private static long FindLargestPrime(long num)
        {
            long largest = 0;
            
            if (num % 2 == 0)
            {
                largest = 2;
                while (num % 2 == 0)
                {
                    num /= 2;
                }
            }

            for (long i = 3; i <= Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    largest = i;
                    num /= i;
                }
            }

            if (num > largest)
                largest = num;

            return largest;
        }
    }
}