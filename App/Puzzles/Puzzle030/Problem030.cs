using App.Platform;

namespace App.Puzzles.Puzzle030
{
    public class Problem030 : Problem
    {
        public override int Id => 30;
        public override string Name => "Digit fifth powers";

        public override PuzzleResult Run()
        {
            var result = Run(5);

            return new PuzzleResult(result, 443839);
        }

        public int Run(int power)
        {
            var upperBound = GetUpperBound(power);
            var results = GetNumbers(power, upperBound);
            
            return results.Sum();
        }

        private IEnumerable<int> GetNumbers(int power, int upperBound)
        {
            for (var i = 2; i < upperBound; i++)
            {
                var digits = i.ToString().ToCharArray().Select(o => int.Parse(o.ToString()));
                var sumOfPowers = digits.Select(o => Pow(o, power)).Sum();
                if (sumOfPowers == i)
                    yield return i;
            }
        }

        private int GetUpperBound(int power)
        {
            var n = Pow(9, power);
            var s = n.ToString();
            var l = s.Length + 1;
            return Pow(10, l);
        }

        private int Pow(int n, int power)
        {
            var result = n;
            for (var i = 1; i < power; i++)
            {
                result *= n;
            }

            return result;
        }
    }
}