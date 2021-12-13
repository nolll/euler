namespace App.Platform;

public interface IMultiProblemPrinter
{
    void PrintHeader();
    void PrintProblem(ProblemWrapperResult dayWrapperResult);
    void PrintFooter();
}