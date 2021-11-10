using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Problems
{
    public class Problem001 : Problem
    {
        public override int Id => 1;
        public override string Name => "Multiples of 3 or 5";

        public override PuzzleResult Run()
        {
            var sum = Run(1000);
            return new PuzzleResult(sum, 233168);
        }

        public int Run(int limit)
        {
            var multiplesOf3Or5 = new List<int>();
            for (var i = 0; i < limit; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    multiplesOf3Or5.Add(i);
            }

            var sum = multiplesOf3Or5.Sum();

            return sum;
        }
    }
}