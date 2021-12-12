using System;
using App.Platform;

namespace Cli.Printing
{
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
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("| problem     | result     | comment                  |");
            Console.WriteLine("-------------------------------------------------------");
        }

        public void PrintProblem(ProblemResult problemResult)
        {
            var problem = problemResult.Problem.Id.ToString().PadLeft(2, '0');
            var problemTitle = $"Problem {problem}";
            var result = GetTableResult(problemResult.Result).PadRight(10, ' ');
            var resultColor = GetColor(problemResult.Result);
            var comment = problemResult.Comment.Length > (CommentLength - 3)
                ? problemResult.Comment.Substring(0, CommentLength - 3) + "..."
                : problemResult.Comment;
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

        private string GetTableResult(TimedPuzzleResult result)
        {
            if (result.Status == PuzzleResultStatus.Empty)
                return "";

            if (result.Status == PuzzleResultStatus.Failed)
                return "failed";

            if (result.Status == PuzzleResultStatus.Missing)
                return "missing";

            var timeTaken = result.Status == PuzzleResultStatus.Timeout
                ? TimeSpan.FromSeconds(_timeout)
                : result.TimeTaken;

            var formattedTime = Formatter.FormatTime(timeTaken);

            return result.Status == PuzzleResultStatus.Timeout
                ? $">{formattedTime}"
                : formattedTime;
        }

        public void PrintFooter()
        {
            Console.WriteLine("--------------------------------------------------------------------");
        }
    }
}