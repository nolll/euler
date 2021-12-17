using System.Numerics;
using App.Platform;

namespace App.Problems.Problem016;

public class Problem016 : Problem
{
    public override string Name => "Power digit sum";

    public override ProblemResult Run()
    {
        var result = Run(1000);
        return new ProblemResult(result, 1366);
    }

    public int Run(int power)
    {
        var product = ToPowerOf(2, power);
        return product.ToString()
            .ToCharArray()
            .Select(o => o.ToString())
            .Select(int.Parse)
            .Sum();
    }

    private BigInteger ToPowerOf(int num, int power)
    {
        var product = new BigInteger(num);
        for (var i = 1; i < power; i++)
        {
            product *= 2;
        }

        return product;
    }
}