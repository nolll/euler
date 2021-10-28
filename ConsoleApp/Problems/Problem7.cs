using System;

namespace ConsoleApp.Problems
{
    public class Problem7 : Problem
    {
        public override int Id => 7;
        public override string Name => "10001st prime";
        
        public override PuzzleResult Run()
        {
            var primeCount = 0;
            var lastPrime = 0;
            var i = 2;
            
            while (primeCount < 10001)
            {
                if (Tools.IsPrime(i))
                {
                    lastPrime = i;
                    primeCount++;
                }

                i++;
            }
            
            return new PuzzleResult(lastPrime, 104743);
        }
    }
}