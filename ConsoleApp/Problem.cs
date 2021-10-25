namespace ConsoleApp
{
    public abstract class Problem
    {
        public int Id { get; }
        public virtual string Comment => "";
        public virtual bool IsSlow => false;
        public virtual bool NeedsRewrite => false;

        protected Problem(int problemId)
        {
            Id = problemId;
        }

        public virtual PuzzleResult Run()
        {
            return null;
        }
    }
}