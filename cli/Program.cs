using System.Collections.Generic;
using System.Linq;
using Cli.ConsoleTools;
using Cli.Printing;
using Core;
using Core.Platform;

namespace Cli;

public class Program
{
    private const int ProblemTimeout = 10;
    private const int DebugProblem = 30;

    static void Main(string[] args)
    {
        var parameters = ParseParameters(args);

        if (parameters.ShowHelp)
            ShowHelp();
        else
            RunProblems(parameters);
    }

    private static void RunProblems(Parameters parameters)
    {
        if (parameters.ProblemId != null)
            RunSingle(parameters);
        else
            RunAll(parameters);
    }

    private static void RunSingle(Parameters parameters)
    {
        var problemRepository = new ProblemRepository();
        var foundProblem = problemRepository.GetProblem(parameters.ProblemId);

        RunDays(new List<ProblemWrapper> { foundProblem }, null, true);
    }
        
    private static void RunAll(Parameters parameters)
    {
        var puzzleRepository = new ProblemRepository();
        var allProblems = puzzleRepository.GetAll();
        var filteredProblems = FilterProblems(allProblems, parameters);
        RunDays(filteredProblems, ProblemTimeout, false);
    }

    private static void RunDays(IList<ProblemWrapper> days, int? timeout, bool throwExceptions)
    {
        var runner = GetProblemRunner(timeout, throwExceptions);

        if (days.Count == 1)
            runner.Run(days.First());
        else
            runner.Run(days);
    }

    private static void ShowHelp()
    {
        var helpPrinter = new HelpPrinter();
        helpPrinter.Print();
    }

    private static Parameters ParseParameters(string[] args)
    {
#if SINGLE
            return new Parameters(problemId: DebugProblem);
#else
        return Parameters.Parse(args);
#endif
    }

    private static ProblemRunner GetProblemRunner(int? timeout, bool throwExceptions)
    {
        return new ProblemRunner(new SingleProblemPrinter(), new MultiProblemPrinter(timeout), throwExceptions, timeout);
    }

    private static IList<ProblemWrapper> FilterProblems(IList<ProblemWrapper> problems, Parameters parameters)
    {
        if (parameters.RunSlowOnly)
            return problems.Where(o => o.Problem.IsSlow).ToList();

        if (parameters.RunCommentedOnly)
            return problems.Where(o => !string.IsNullOrEmpty(o.Problem.Comment)).ToList();

        return problems;
    }
}