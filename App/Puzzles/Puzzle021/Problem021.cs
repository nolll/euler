﻿using App.Common.Numbers;
using App.Platform;

namespace App.Puzzles.Puzzle021
{
    public class Problem021 : Problem
    {
        public override string Name => "Amicable numbers";

        public override PuzzleResult Run()
        {
            var sums = new Dictionary<int, int>();
            var amicableNumbers = new HashSet<int>();
            for (var i = 3; i < 10000; i++)
            {
                var sum = GetFactorialSum(i);
                sums.Add(i, sum);
            }

            foreach (var a in sums.Keys)
            {
                if (amicableNumbers.Contains(a))
                    continue;
                
                var dA = sums[a];
                
                if(!sums.ContainsKey(dA))
                    continue;

                var b = dA;

                if (a == b)
                    continue;
                
                var dB = sums[dA];

                if (dA == b && dB == a)
                {
                    amicableNumbers.Add(dA);
                    amicableNumbers.Add(dB);
                }
            }

            var amicableSum = amicableNumbers.Sum();
            
            return new PuzzleResult(amicableSum, 31626);
        }

        public int GetFactorialSum(int n)
        {
            var factors = Factorization.GetProperDivisors(n);
            return Enumerable.Sum((IEnumerable<int>)factors);
        }
    }
}