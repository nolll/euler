using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp.Problems
{
    public class Problem0001 : Problem
    {
        public Problem0001() : base(1)
        {
        }

        public override PuzzleResult Run()
        {
            var multiplesOf3Or5 = new List<int>();
            for (var i = 0; i < 10; i++)
            {
                if(i % 3 == 0 || i % 5 == 0)
                    multiplesOf3Or5.Add(i);
            }

            var sum = multiplesOf3Or5.Sum();

            return new PuzzleResult(sum);
        }
    }
}