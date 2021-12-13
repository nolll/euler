﻿using App.Platform;

namespace App.Puzzles.Puzzle006
{
    public class Problem006 : Problem
    {
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