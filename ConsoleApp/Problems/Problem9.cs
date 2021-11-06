namespace ConsoleApp.Problems
{
    public class Problem9 : Problem
    {
        public override int Id => 9;
        public override string Name => "Special Pythagorean triplet";
        
        public override PuzzleResult Run()
        {
            var product = Run(1000);
            return new PuzzleResult(product);
        }

        public int Run(int sum)
        {
            return 0;
        }
    }
}