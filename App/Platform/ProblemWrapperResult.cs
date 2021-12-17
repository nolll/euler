namespace App.Platform;

public class ProblemWrapperResult
{
    public ProblemWrapper Problem { get; }
    public TimedProblemResult Result { get; }
    public string Comment { get; }

    public ProblemWrapperResult(ProblemWrapper problem, TimedProblemResult result, string comment)
    {
        Problem = problem;
        Result = result;
        Comment = comment ?? "";
    }
}