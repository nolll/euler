namespace ConsoleApp
{
    public class ProblemResult
    {
        public Problem Problem { get; }
        public TimedPuzzleResult Result { get; }
        public string Comment { get; }

        public ProblemResult(Problem problem, TimedPuzzleResult result, string comment)
        {
            Problem = problem;
            Result = result;
            Comment = comment ?? "";
        }
    }
}