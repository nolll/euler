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
            var numbers = new List<int> {1, 2};
            while (numbers.Last() <= 4_000_000)
            {
                var lastNumbers = numbers.TakeLast(2);
                numbers.Add(lastNumbers.Sum());
            }

            var evenNumbers = numbers.Where(o => o % 2 == 0);
            var sum = evenNumbers.Sum();

            return new PuzzleResult(sum, 4613732);
        }
    }
}