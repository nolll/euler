namespace App.Platform;

public interface IMultiProblemPrinter
{
    void PrintHeader();
    void PrintProblem(ProblemResult dayResult);
    void PrintFooter();
}