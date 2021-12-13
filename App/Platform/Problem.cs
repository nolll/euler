namespace App.Platform
{
    public abstract class Problem
    {
        public abstract string Name { get; }
        public virtual string Comment => "";
        public virtual bool IsSlow => false;
        public virtual bool NeedsRewrite => false;

        public abstract ProblemResult Run();
    }
}