namespace App.Platform
{
    public class ProblemWrapperResult
    {
        public ProblemWrapper Problem { get; }
        public TimedPuzzleResult Result { get; }
        public string Comment { get; }

        public ProblemWrapperResult(ProblemWrapper problem, TimedPuzzleResult result, string comment)
        {
            Problem = problem;
            Result = result;
            Comment = comment ?? "";
        }
    }
}