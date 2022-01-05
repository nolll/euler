namespace Core.Platform;

public class EmptyProblemResult : ProblemResult
{
    public EmptyProblemResult()
        : base("No problem here", ProblemResultStatus.Empty)
    {
    }
}