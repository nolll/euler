using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Problems
{
    public class Problem2 : Problem
    {
        public override int Id => 2;
        public override string Name => "Even Fibonacci numbers";

        public override PuzzleResult Run()
        {
            var sum = Run(4_000_000);
            return new PuzzleResult(sum, 4613732);
        }

        public int Run(int limit)
        {
            var numbers = new List<int> { 1, 2 };
            while (true)
            {
                var lastNumbers = numbers.TakeLast(2);
                var nextNumber = lastNumbers.Sum();

                if (nextNumber > limit)
                    break;
                
                numbers.Add(nextNumber);
            }

            var evenNumbers = numbers.Where(o => o % 2 == 0);
            var sum = evenNumbers.Sum();

            return sum;
        }
    }
}