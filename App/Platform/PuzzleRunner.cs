namespace App.Platform
{
    public class PuzzleRunner
    {
        private readonly ISingleProblemPrinter _singleProblemPrinter;
        private readonly IMultiProblemPrinter _multiProblemPrinter;
        private readonly bool _throwExceptions;
        private readonly int? _timeout;

        public PuzzleRunner(ISingleProblemPrinter singleProblemPrinter, IMultiProblemPrinter multiProblemPrinter, bool throwExceptions = false, int? timeout = null)
        {
            _singleProblemPrinter = singleProblemPrinter;
            _multiProblemPrinter = multiProblemPrinter;
            _throwExceptions = throwExceptions;
            _timeout = timeout;
        }

        public void Run(IList<ProblemWrapper> problems)
        {
            _multiProblemPrinter.PrintHeader();
            foreach (var problem in problems)
            {
                var result = RunProblem(problem);
                _multiProblemPrinter.PrintProblem(result);
            }
            _multiProblemPrinter.PrintFooter();
        }

        public void Run(ProblemWrapper problem)
        {
            var result = RunProblem(problem);
            _singleProblemPrinter.PrintProblem(result);
        }

        private ProblemWrapperResult RunProblem(ProblemWrapper problem)
        {
            var p1 = RunPuzzleWithTimer(problem.Problem.Run, problem.Problem.IsSlow);

            return new ProblemWrapperResult(problem, p1, problem.Problem.Comment);
        }

        private TimedPuzzleResult RunPuzzleWithTimer(Func<PuzzleResult> func, bool isSlow)
        {
            var timer = new Common.Timing.Timer();
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