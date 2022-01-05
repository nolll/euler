namespace Core.Platform;

public class MissingProblemResult : ProblemResult
{
    public MissingProblemResult(string message)
        : base(message, ProblemResultStatus.Missing)
    {
    }
}