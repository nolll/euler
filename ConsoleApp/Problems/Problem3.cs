namespace ConsoleApp.Problems
{
    public class Problem3 : Problem
    {
        public override int Id => 3;
        public override string Name => "Largest prime factor";

        public override PuzzleResult Run()
        {
            const long input = 600_851_475_143;

            var largestPrime = Tools.FindLargestPrimeFactor(input);
            
            return new PuzzleResult(largestPrime, 6857);
        }
    }
}