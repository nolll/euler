using System;
using App.Platform;

namespace Cli.Printing;

public class MultiProblemPrinter : ProblemPrinter, IMultiProblemPrinter
{
    private readonly int _timeout;
    private const int CommentLength = 24;

    public MultiProblemPrinter(int? timeout = null)
    {
        _timeout = timeout ?? 0;
    }

    public void PrintHeader()
    {
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine("| problem     | result     | comment                 |");
        Console.WriteLine("------------------------------------------------------");
    }

    public void PrintProblem(ProblemWrapperResult problemWrapperResult)
    {
        var problem = problemWrapperResult.Problem.Id.ToString().PadLeft(2, '0');
        var problemTitle = $"Problem {problem}";
        var result = GetTableResult(problemWrapperResult.Result).PadRight(10, ' ');
        var resultColor = GetColor(problemWrapperResult.Result);
        var comment = problemWrapperResult.Comment.Length > (CommentLength - 3)
            ? problemWrapperResult.Comment.Substring(0, CommentLength - 3) + "..."
            : problemWrapperResult.Comment;
        var paddedComment = comment.PadRight(CommentLength, ' ');

        Console.Write("| ");
        Console.Write(problemTitle);
        Console.Write(" | ");
        SetColor(resultColor);
        Console.Write(result);
        ResetColor();
        Console.Write(" | ");
        SetColor(ConsoleColor.Yellow);
        Console.Write(paddedComment);
        ResetColor();
        Console.Write(" |"); 
        Console.WriteLine();
    }

    private string GetTableResult(TimedProblemResult result)
    {
        if (result.Status == ProblemResultStatus.Empty)
            return "";

        if (result.Status == ProblemResultStatus.Failed)
            return "failed";

        if (result.Status == ProblemResultStatus.Missing)
            return "missing";

        var timeTaken = result.Status == ProblemResultStatus.Timeout
            ? TimeSpan.FromSeconds(_timeout)
            : result.TimeTaken;

        var formattedTime = Formatter.FormatTime(timeTaken);

        return result.Status == ProblemResultStatus.Timeout
            ? $">{formattedTime}"
            : formattedTime;
    }

    public void PrintFooter()
    {
        Console.WriteLine("--------------------------------------------------------------------");
    }
}