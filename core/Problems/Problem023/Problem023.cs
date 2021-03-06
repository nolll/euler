using Core.Common.Numbers;
using Core.Platform;

namespace Core.Problems.Problem023;

public class Problem023 : Problem
{
    private const int UpperLimit = 28123;

    public override string Name => "Non-abundant sums";

    public override ProblemResult Run()
    {
        var abundantNumbers = FindAbundantNumbers(UpperLimit).ToList();
        var sumsOfAbundantNumbers = GetSums(abundantNumbers);

        var sum = 0;
        for (var i = 0; i < UpperLimit; i++)
        {
            if (!sumsOfAbundantNumbers.Contains(i))
                sum += i;
        }
            
        return new ProblemResult(sum, 4179871);
    }

    private HashSet<int> GetSums(List<int> abundantNumbers)
    {
        var sums = new HashSet<int>();
        foreach (var outer in abundantNumbers)
        {
            foreach (var inner in abundantNumbers)
            {
                var sum = inner + outer;
                if (sum < 28123 && !sums.Contains(sum))
                    sums.Add(sum);
            }
        }

        return sums;
    }

    public IEnumerable<int> FindAbundantNumbers(int upperLimit)
    {
        for (var i = 12; i <= upperLimit; i++)
        {
            var divisors = Factorization.GetProperDivisors(i);
            var sum = Enumerable.Sum((IEnumerable<int>)divisors);
            if(sum > i)
                yield return i;
        }
    }
}