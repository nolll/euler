namespace ConsoleApp
{
    public abstract class Problem
    {
        public abstract int Id { get; }
        public abstract string Name { get; }
        public virtual string Comment => "";
        public virtual bool IsSlow => false;
        public virtual bool NeedsRewrite => false;

        public abstract PuzzleResult Run();
    }
}