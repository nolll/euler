using System;
using System.Collections.Generic;
using System.Linq;
using App;
using App.Platform;
using Cli.ConsoleTools;
using Cli.Printing;

namespace Cli
{
    public class Program
    {
        private const int PuzzleTimeout = 10;

        private const int DebugProblem = 30;

        static void Main(string[] args)
        {
            var parameters = ParseParameters(args);

            if (parameters.ShowHelp)
                ShowHelp();
            else
                RunPuzzles(parameters);
        }

        private static void RunPuzzles(Parameters parameters)
        {
            if (parameters.ProblemId != null)
                RunSingle(parameters);
            else
                RunAll(parameters);
        }

        private static void RunSingle(Parameters parameters)
        {
            var puzzleRepository = new ProblemRepository();
            var foundProblem = puzzleRepository.GetProblem(parameters.ProblemId);

            RunDays(new List<ProblemWrapper> { foundProblem }, null, true);
        }
        
        private static void RunAll(Parameters parameters)
        {
            var puzzleRepository = new ProblemRepository();
            var allProblems = puzzleRepository.GetAll();
            var filteredProblems = FilterProblems(allProblems, parameters);
            RunDays(filteredProblems, PuzzleTimeout, false);
        }

        private static void RunDays(IList<ProblemWrapper> days, int? timeout, bool throwExceptions)
        {
            var runner = GetPuzzleRunner(timeout, throwExceptions);

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
            return Parameters.Parse(args);
        }

        private static Parameters ParseParameters1(string[] args)
        {
#if DEBUG
            return new Parameters(problemId: DebugProblem);
#else
            return Parameters.Parse(args);
#endif
        }

        private static PuzzleRunner GetPuzzleRunner(int? timeout, bool throwExceptions)
        {
            return new PuzzleRunner(new SingleProblemPrinter(), new MultiProblemPrinter(timeout), throwExceptions, timeout);
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
}
