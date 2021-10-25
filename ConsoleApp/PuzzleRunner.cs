using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class PuzzleRunner
    {
        private readonly bool _throwExceptions;
        private readonly int? _timeout;

        public PuzzleRunner(bool throwExceptions = false, int? timeout = null)
        {
            _throwExceptions = throwExceptions;
            _timeout = timeout;
        }

        public void Run(IList<Problem> problems)
        {
            var printer = new MultiProblemPrinter(_timeout ?? 0);
            printer.PrintHeader();
            foreach (var problem in problems)
            {
                var result = RunProblem(problem);
                printer.PrintProblem(result);
            }
            printer.PrintFooter();
        }

        public void Run(Problem problem)
        {
            var result = RunProblem(problem);
            var printer = new SingleProblemPrinter();
            printer.PrintProblem(result);
        }

        private ProblemResult RunProblem(Problem problem)
        {
            var p1 = RunPuzzleWithTimer(problem.Run, problem.IsSlow);

            return new ProblemResult(problem, p1, problem.Comment);
        }

        private TimedPuzzleResult RunPuzzleWithTimer(Func<PuzzleResult> func, bool isSlow)
        {
            var timer = new Timer();
            var result = RunPuzzle(func, isSlow);
            return new TimedPuzzleResult(result, timer.FromStart);
        }

        private PuzzleResult RunPuzzle(Func<PuzzleResult> func, bool isSlow)
        {
            PuzzleResult result = null;
            try
            {
                if (isSlow && _timeout != null)
                {
                    var task = Task.Run(() => result = func());
                    if (!task.Wait(TimeSpan.FromSeconds(_timeout.Value)))
                        return new TimeoutPuzzleResult($"Puzzle failed to finish within {_timeout.Value} seconds");
                }
                else
                {
                    result = func();
                }

                return result ?? new MissingPuzzleResult("Puzzle returned null");
            }
            catch (Exception)
            {
                if (_throwExceptions)
                    throw;
                return new FailedPuzzleResult("Puzzle failed");
            }
        }
    }
}