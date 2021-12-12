using System;
using App.Platform;

namespace Cli.Printing
{
    public class SingleProblemPrinter : ProblemPrinter, ISingleProblemPrinter
    {
        private const string Divider = "--------------------------------------------------";

        public void PrintProblem(ProblemResult problemResult)
        {
            PrintProblemTitle(problemResult.Problem);
            PrintPuzzle(1, problemResult.Result);
            PrintProblemEnd(problemResult, problemResult.Result.TimeTaken);
        }

        private void PrintPuzzle(int part, TimedPuzzleResult puzzleResult)
        {
            var time = Formatter.FormatTime(puzzleResult.TimeTaken);
            Console.WriteLine($"Part {part}: {time}");
            var color = GetColor(puzzleResult);
            SetColor(color);
            Console.Write(puzzleResult.Answer);
            //if (puzzleResult.Status == PuzzleResultStatus.Wrong)
            //{
            //    Console.WriteLine();
            //    SetColor(ConsoleColor.DarkRed);
            //    Console.Write(puzzleResult.CorrectAnswer);
            //}
            ResetColor();
            Console.WriteLine();
        }

        private static void PrintProblemTitle(Problem problem)
        {
            Console.WriteLine();
            Console.WriteLine($"Problem {problem.Id}:");
            PrintDivider();
        }

        private void PrintProblemEnd(ProblemResult problemResult, TimeSpan timeTaken)
        {
            PrintDivider();
            if (!string.IsNullOrEmpty(problemResult.Comment))
            {
                SetColor(ConsoleColor.Yellow);
                Console.WriteLine(problemResult.Comment);
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
}