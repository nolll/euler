using App.Common.Numbers;
using App.Platform;

namespace App.Problems.Problem007;

public class Problem007 : Problem
{
    public override string Name => "10001st prime";

    public override ProblemResult Run()
    {
        var nthPrime = Run(10001);

        return new ProblemResult(nthPrime, 104743);
    }

    public int Run(int index)
    {
        var primeCount = 0;
        var lastPrime = 0;
        var i = 2;
            
        while (primeCount < index)
        {
            if (Factorization.IsPrime(i))
            {
                lastPrime = i;
                primeCount++;
            }

            i++;
        }
            
        return lastPrime;
    }
}