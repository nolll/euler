﻿using Core.Platform;

namespace Core.Problems.Problem014;

public class Problem014 : Problem
{
    public override string Name => "Longest Collatz sequence";
        
    public override ProblemResult Run()
    {
        var result = Run(1_000_000);
        return new ProblemResult(result, 837799);
    }

    private int Run(int limit)
    {
        var longestSequence = (Num: 1, Length: 1);
        var i = 0;

        while (i < limit)
        {
            var sequence = GenerateCollatzSequence(i);

            var length = sequence.Count();

            if (length > longestSequence.Length)
            {
                longestSequence = (i, length);
            }

            i++;
        }

        return longestSequence.Num;
    }

    public IEnumerable<long> GenerateCollatzSequence(long n)
    {
        yield return n;
            
        while (n > 1)
        {
            if (n % 2 == 0)
            {
                n /= 2;
            }
            else
            {
                n = n * 3 + 1;
            }

            yield return n;
        }
    }
}