using App.Common.Strings;
using App.Platform;

namespace App.Puzzles.Puzzle017
{
    public class Problem017 : Problem
    {
        public override int Id => 17;
        public override string Name => "Number letter counts";

        public override PuzzleResult Run()
        {
            var result = Run(1000);
            return new PuzzleResult(result, 21124);
        }

        public int Run(int target)
        {
            var strings = new List<string>();
            for (var i = 1; i <= target; i++)
            {
                var numberAsWords = new NumberAsString(i).ToString();
                strings.Add(numberAsWords);
            }

            return CountLetters(strings);
        }
        
        private static int CountLetters(List<string> strings)
        {
            return strings.Select(CountLetters).Sum();
        }

        private static int CountLetters(string s)
        {
            return s.Replace(" ", "").Length;
        }
    }
}