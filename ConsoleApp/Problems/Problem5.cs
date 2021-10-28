namespace ConsoleApp.Problems
{
    public class Problem5 : Problem
    {
        public override int Id => 5;
        public override string Name => "Smallest multiple";
        
        public override PuzzleResult Run()
        {
            var smallest = 0;
            var i = 0;
            while (smallest == 0)
            {
                i += 2;
                var c = 0;
                for (var p = 2; p <= 20; p++)
                {
                    if (i % p != 0)
                        break;

                    c++;
                }

                if (c == 19)
                    smallest = i;
            }
            
            return new PuzzleResult(smallest, 232792560);
        }
    }
}