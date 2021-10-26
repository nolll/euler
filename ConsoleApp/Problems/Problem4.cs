using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Problems
{
    public class Problem4 : Problem
    {
        public Problem4() : base(4)
        {
        }

        public override PuzzleResult Run()
        {
            const int minFactor = 100;
            const int maxFactor = 999;

            var tried = new HashSet<(int, int)>();
            var largestPalindrome = 0;

            for (var a = minFactor; a <= maxFactor; a++)
            {
                for (var b = minFactor; b <= maxFactor; b++)
                {
                    var min = Math.Min(a, b);
                    var max = Math.Max(a, b);

                    if (!tried.Contains((min, max)))
                    {
                        tried.Add((min, max));
                        var product = min * max;
                        var str = product.ToString();
                        var reverse = string.Concat(str.ToCharArray().Reverse());

                        if (str == reverse && product > largestPalindrome)
                        {
                            largestPalindrome = product;
                        }
                    }
                }
            }

            return new PuzzleResult(largestPalindrome, 906609);
        }
    }
}