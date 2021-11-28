using System.Collections.Generic;
using System.Linq;
using ConsoleApp.Problems;

namespace ConsoleApp
{
    public class ProblemSelector
    {
        private readonly IList<Problem> _problems = new List<Problem>
        {
            new Problem001(),
            new Problem002(),
            new Problem003(),
            new Problem004(),
            new Problem005(),
            new Problem006(),
            new Problem007(),
            new Problem008(),
            new Problem009(),
            new Problem010(),
            new Problem011(),
            new Problem012(),
            new Problem013(),
            new Problem014(),
            new Problem015(),
            new Problem016(),
            new Problem017(),
            new Problem018(),
            new Problem019(),
            new Problem020()
        };

        public Problem GetProblem(int? problemId)
        {
            return problemId != null
                ? _problems.FirstOrDefault(o => o.Id == problemId.Value)
                : _problems.Last();
        }

        public IList<Problem> GetAll()
        {
            return _problems;
        }
    }
}