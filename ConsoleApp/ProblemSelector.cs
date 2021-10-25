using System.Collections.Generic;
using System.Linq;
using ConsoleApp.Problems;

namespace ConsoleApp
{
    public class ProblemSelector
    {
        private readonly IList<Problem> _problems = new List<Problem>
        {
            new Problem1(),
            new Problem2()
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