namespace ConsoleApp
{
    public class EmptyPuzzleResult : PuzzleResult
    {
        public EmptyPuzzleResult()
            : base("No puzzle here", PuzzleResultStatus.Empty)
        {
        }
    }
}