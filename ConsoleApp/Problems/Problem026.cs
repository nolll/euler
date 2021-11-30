using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ConsoleApp.Problems
{
    public class Problem026 : Problem
    {
        public override int Id => 26;
        public override string Name => "Reciprocal cycles";

        public override PuzzleResult Run()
        {
            var result = Run(1000);
            return new PuzzleResult(result);
        }

        public int Run(int maxDivisor)
        {
            var divisor = 2;
            
            var multiplier = BigInteger.Pow(10, 999);
            var maxRepeatLength = 0;
            
            while (divisor <= maxDivisor)
            {
                var n = multiplier / divisor;
                var s = n.ToString();
                s = s.Substring(0, s.Length - 1);
                var lastChar = s.Last();
                s = s.TrimEnd(lastChar);
                var repeatLength = GetRepeatLength(s);
                if (repeatLength > maxRepeatLength)
                    maxRepeatLength = repeatLength;
                divisor++;
            }

            return maxRepeatLength;
        }

        public int GetRepeatLength(string input)
        {
            if (input.Length == 0)
                return 0;

            var repeatLength = 0;
            var regex = new Regex("^(.+?)(?:\\1)+");
            var s = input;
            while (s.Length > 0)
            {
                var matches = regex.Match(s);
                var match = matches.Groups.Count > 0
                    ? matches.Groups[1].Value
                    : null;

                if (match?.Length > repeatLength)
                    repeatLength = match.Length;

                s = s.Substring(1);
            }

            return repeatLength;
        }
    }
}