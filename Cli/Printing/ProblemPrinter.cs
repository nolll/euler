using System;
using App.Platform;

namespace Cli.Printing
{
    public abstract class ProblemPrinter
    {
        private readonly ConsoleColor _defaultColor;

        protected ProblemPrinter()
        {
            _defaultColor = Console.ForegroundColor;
        }

        protected void ResetColor()
        {
            Console.ForegroundColor = _defaultColor;
        }

        protected void SetColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        protected static ConsoleColor GetColor(ProblemResult result)
        {
            var status = result.Status;
            if (status == ProblemResultStatus.Failed || status == ProblemResultStatus.Missing || status == ProblemResultStatus.Timeout || status == ProblemResultStatus.Wrong)
                return ConsoleColor.Red;

            return status == ProblemResultStatus.Correct
                ? ConsoleColor.Green
                : ConsoleColor.Yellow;
        }
    }
}