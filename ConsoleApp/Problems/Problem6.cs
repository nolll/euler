using System;
using System.Linq;

namespace ConsoleApp.Problems
{
    public class Problem6 : Problem
    {
        public override int Id => 6;
        public override string Name => "Sum square difference";
        
        public override PuzzleResult Run()
        {
            var numbers = Enumerable.Range(1, 100).ToList();
            var sum = numbers.Sum();
            var squareOfSum = sum * sum;
            var sumOfSquares = numbers.Select(o => o * o).Sum();
            var diff = squareOfSum - sumOfSquares;
            
            return new PuzzleResult(diff, 25164150);
        }
    }
}