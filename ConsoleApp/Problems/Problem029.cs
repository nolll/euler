﻿using System;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp.Problems
{
    public class Problem029 : Problem
    {
        public override int Id => 29;
        public override string Name => "Distinct powers";

        public override PuzzleResult Run()
        {
            var result = Run(100);

            return new PuzzleResult(result, 9183);
        }

        public int Run(int limit)
        {
            var cache = new HashSet<BigInteger>();

            for (var a = 2; a <= limit; a++)
            {
                for (var b = 2; b <= limit; b++)
                {
                    var result = BigInteger.Pow(a, b);
                    if (!cache.Contains(result))
                        cache.Add(result);
                }
            }

            return cache.Count;
        }
    }
}