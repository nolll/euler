using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Problems
{
    public class Problem1 : Problem
    {
        public override int Id => 1;
        public override string Name => "Multiples of 3 or 5";

        public override PuzzleResult Run()
        {
            var multiplesOf3Or5 = new List<int>();
            for (var i = 0; i < 1000; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                    multiplesOf3Or5.Add(i);
            }

            var sum = multiplesOf3Or5.Sum();

            return new PuzzleResult(sum, 233168);
        }
    }
}