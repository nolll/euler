﻿using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Problems
{
    public class Problem9 : Problem
    {
        public override int Id => 9;
        public override string Name => "Special Pythagorean triplet";
        
        public override PuzzleResult Run()
        {
            var product = Run(1000);
            return new PuzzleResult(product, 31_875_000);
        }

        public int Run(int targetSum)
        {
            var combinations = GetPermutations(targetSum);

            foreach (var (a, b, c) in combinations)
            {
                if (a + b + c == targetSum && a * a + b * b == c * c)
                {
                    return a * b * c;
                }
            }

            return 0;
        }

        private static IEnumerable<(int a, int b, int c)> GetPermutations(int max)
        {
            for (var a = 1; a <= max; a++)
            {
                for (var b = a + 1; b <= max; b++)
                {
                    for (var c = b + 1; c <= max; c++)
                    {
                        if (a + b + c == max)
                            yield return (a, b, c);
                    }
                }
            }
        }
    }
}