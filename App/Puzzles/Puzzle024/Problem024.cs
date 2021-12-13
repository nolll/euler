﻿using App.Common.Combinatorics;
using App.Platform;

namespace App.Puzzles.Puzzle024
{
    public class Problem024 : Problem
    {
        private const int UpperLimit = 28123;

        public override string Name => "Lexicographic permutations";
        public override bool IsSlow => true;
        public override bool NeedsRewrite => true;

        public override PuzzleResult Run()
        {
            var numbers = Enumerable.Range(0, 10).ToList();
            var permutations = PermutationGenerator.GetPermutations(numbers);
            var strings = permutations.Select(string.Concat<int>).OrderBy(o => o).ToList();
            var result = strings[999999];
            
            return new PuzzleResult(result, "2783915460");
        }
    }
}