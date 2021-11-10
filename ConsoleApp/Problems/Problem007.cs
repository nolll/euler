namespace ConsoleApp.Problems
{
    public class Problem007 : Problem
    {
        public override int Id => 7;
        public override string Name => "10001st prime";

        public override PuzzleResult Run()
        {
            var nthPrime = Run(10001);

            return new PuzzleResult(nthPrime, 104743);
        }

        public int Run(int index)
        {
            var primeCount = 0;
            var lastPrime = 0;
            var i = 2;
            
            while (primeCount < index)
            {
                if (Tools.IsPrime(i))
                {
                    lastPrime = i;
                    primeCount++;
                }

                i++;
            }
            
            return lastPrime;
        }
    }
}