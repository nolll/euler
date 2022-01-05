﻿using App.Platform;

namespace App.Problems.Problem002;

public class Problem002 : Problem
{
    public override string Name => "Even Fibonacci numbers";

    public override ProblemResult Run()
    {
        var sum = Run(4_000_000);
        return new ProblemResult(sum, 4613732);
    }

    public int Run(int limit)
    {
        var numbers = new List<int> { 1, 2 };
        while (true)
        {
            var lastNumbers = numbers.TakeLast(2);
            var nextNumber = lastNumbers.Sum();

            if (nextNumber > limit)
                break;
                
            numbers.Add(nextNumber);
        }

        var evenNumbers = numbers.Where(o => o % 2 == 0);
        var sum = evenNumbers.Sum();

        return sum;
    }
}