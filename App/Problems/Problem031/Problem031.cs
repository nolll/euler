using App.Platform;

namespace App.Problems.Problem031;

public class Problem031 : Problem
{
    private readonly int[] _coins;
    public override string Name => "Coin sums";

    public Problem031()
    {
        _coins = new[] { 200, 100, 50, 20, 10, 5, 2, 1 };
    }

    public override ProblemResult Run()
    {
        var result = Run(200);

        return new ProblemResult(result);
    }

    public int Run(int largestCoinInPennies)
    {
        for (var i = 0; i < _coins.Length; i++)
        {
            
        }

        return 0;
    }
}