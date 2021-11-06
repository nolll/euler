﻿using System;
using System.Linq;

namespace ConsoleApp.Problems
{
    public class Problem6 : Problem
    {
        public override int Id => 6;
        public override string Name => "Sum square difference";

        public override PuzzleResult Run()
        {
            var diff = Run(100);

            return new PuzzleResult(diff, 25164150);
        }
        
        public int Run(int numCount)
        {
            var numbers = Enumerable.Range(1, numCount).ToList();
            var sum = numbers.Sum();
            var squareOfSum = sum * sum;
            var sumOfSquares = numbers.Select(o => o * o).Sum();
            var diff = squareOfSum - sumOfSquares;
            
            return diff;
        }
    }
}