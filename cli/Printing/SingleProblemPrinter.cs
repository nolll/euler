using System;
using Core.Platform;

namespace Cli.Printing;

public class SingleProblemPrinter : ProblemPrinter, ISingleProblemPrinter
{
    private const string Divider = "--------------------------------------------------";

    public void PrintProblem(ProblemWrapperResult problemWrapperResult)
    {
        PrintProblemTitle(problemWrapperResult.Problem);
        PrintProblem(1, problemWrapperResult.Result);
        PrintProblemEnd(problemWrapperResult, problemWrapperResult.Result.TimeTaken);
    }

    private void PrintProblem(int part, TimedProblemResult problemResult)
    {
        var time = Formatter.FormatTime(problemResult.TimeTaken);
        Console.WriteLine($"Part {part}: {time}");
        var color = GetColor(problemResult);
        SetColor(color);
        Console.Write(problemResult.Answer);
        ResetColor();
        Console.WriteLine();
    }
        
    private static void PrintProblemTitle(ProblemWrapper problem)
    {
        Console.WriteLine();
        Console.WriteLine($"Problem {problem.Id}:");
        Console.WriteLine($"{problem.Problem.Name}");
        PrintDivider();
    }

    private void PrintProblemEnd(ProblemWrapperResult problemWrapperResult, TimeSpan timeTaken)
    {
        PrintDivider();
        if (!string.IsNullOrEmpty(problemWrapperResult.Comment))
        {
            SetColor(ConsoleColor.Yellow);
            Console.WriteLine(problemWrapperResult.Comment);
            ResetColor();
            PrintDivider();
        }
        var time = Formatter.FormatTime(timeTaken);
        Console.WriteLine(time.PadLeft(Divider.Length));
    }

    private static void PrintDivider()
    {
        Console.WriteLine(Divider);
    }
}