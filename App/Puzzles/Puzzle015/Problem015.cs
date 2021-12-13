﻿using App.Platform;

namespace App.Puzzles.Puzzle015
{
    public class Problem015 : Problem
    {
        public override string Name => "Lattice paths";

        public override PuzzleResult Run()
        {
            var result = Run(20);
            return new PuzzleResult(result, 137846528820);
        }

        public long Run(int gridSize)
        {
            return PascalTriangle(gridSize).Max();
        }

        private List<long> PascalTriangle(int levels)
        {
            var list = new List<long> {1};
            for (var i = 0; i < levels; i++)
            {
                list = ExpandTriangle(list.ToList());
                list = ExpandTriangle(list.ToList());
            }

            return list;
        }

        private List<long> ExpandTriangle(List<long> lastList)
        {
            var list = new List<long> {1};
            for (var i = 1; i < lastList.Count; i++)
            {
                var a = lastList[i - 1];
                var b = lastList[i];
                list.Add(a + b);
            }
            
            list.Add(1);

            return list;
        }
    }
}