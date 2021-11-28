using System.Linq;
using ConsoleApp.Tools;

namespace ConsoleApp.Problems
{
    public class Problem024 : Problem
    {
        private const int UpperLimit = 28123;

        public override int Id => 24;
        public override string Name => "Lexicographic permutations";

        public override PuzzleResult Run()
        {
            var numbers = Enumerable.Range(0, 10).ToList();
            var permutations = PermutationGenerator.GetPermutations(numbers);
            var strings = permutations.Select(o => string.Concat(o)).OrderBy(o => o).ToList();
            var result = strings[999999];
            
            return new PuzzleResult(result, "2783915460");
        }
    }
}