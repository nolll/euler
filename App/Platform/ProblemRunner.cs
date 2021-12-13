namespace App.Platform
{
    public class ProblemRunner
    {
        private readonly ISingleProblemPrinter _singleProblemPrinter;
        private readonly IMultiProblemPrinter _multiProblemPrinter;
        private readonly bool _throwExceptions;
        private readonly int? _timeout;

        public ProblemRunner(ISingleProblemPrinter singleProblemPrinter, IMultiProblemPrinter multiProblemPrinter, bool throwExceptions = false, int? timeout = null)
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
            var p1 = RunProblemWithTimer(problem.Problem.Run, problem.Problem.IsSlow);

            return new ProblemWrapperResult(problem, p1, problem.Problem.Comment);
        }

        private TimedProblemResult RunProblemWithTimer(Func<ProblemResult> func, bool isSlow)
        {
            var timer = new Common.Timing.Timer();
            var result = RunProblem(func, isSlow);
            return new TimedProblemResult(result, timer.FromStart);
        }

        private ProblemResult RunProblem(Func<ProblemResult> func, bool isSlow)
        {
            ProblemResult result = null;
            try
            {
                if (isSlow && _timeout != null)
                {
                    var task = Task.Run(() => result = func());
                    if (!task.Wait(TimeSpan.FromSeconds(_timeout.Value)))
                        return new TimeoutProblemResult($"Problem failed to finish within {_timeout.Value} seconds");
                }
                else
                {
                    result = func();
                }

                return result ?? new MissingProblemResult("Problem returned null");
            }
            catch (Exception)
            {
                if (_throwExceptions)
                    throw;
                return new FailedProblemResult("Problem failed");
            }
        }
    }
}