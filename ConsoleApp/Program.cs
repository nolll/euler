using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    public class Program
    {
        private static ProblemSelector _problemSelector;
        private const int PuzzleTimeout = 10;

        private const int DebugProblem = 10;

        static void Main(string[] args)
        {
            _problemSelector = new ProblemSelector();
            var parameters = Parameters.Parse(args);

            if (parameters.ShowHelp)
            {
                var helpPrinter = new HelpPrinter();
                helpPrinter.Print();
                return;
            }
            
            if (parameters.ProblemId == null)
            {
#if DEBUG
                parameters = new Parameters(problemId: DebugProblem);
#else
                var allProblems = _problemSelector.GetAll();
                var filteredProblems = FilterProblems(allProblems, parameters);
                var allRunner = new PuzzleRunner(timeout: PuzzleTimeout);
                allRunner.Run(filteredProblems);
                return;
#endif
            }

            var problem = _problemSelector.GetProblem(parameters.ProblemId);
            if (problem == null)
            {
                throw new Exception("The specified problem could not be found.");
            }

            var problemRunner = new PuzzleRunner(throwExceptions: true);
            problemRunner.Run(problem);
        }

        private static IList<Problem> FilterProblems(IList<Problem> problems, Parameters parameters)
        {
            if (parameters.RunSlowOnly)
                return problems.Where(o => o.IsSlow).ToList();

            if (parameters.RunCommentedOnly)
                return problems.Where(o => !string.IsNullOrEmpty(o.Comment)).ToList();

            return problems;
        }
    }
}
