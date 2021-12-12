using System.Collections.Generic;
using System.Linq;
using App.Platform;
using App.Puzzles.Puzzle001;
using App.Puzzles.Puzzle002;
using App.Puzzles.Puzzle003;
using App.Puzzles.Puzzle004;
using App.Puzzles.Puzzle005;
using App.Puzzles.Puzzle006;
using App.Puzzles.Puzzle007;
using App.Puzzles.Puzzle008;
using App.Puzzles.Puzzle009;
using App.Puzzles.Puzzle010;
using App.Puzzles.Puzzle011;
using App.Puzzles.Puzzle012;
using App.Puzzles.Puzzle013;
using App.Puzzles.Puzzle014;
using App.Puzzles.Puzzle015;
using App.Puzzles.Puzzle016;
using App.Puzzles.Puzzle017;
using App.Puzzles.Puzzle018;
using App.Puzzles.Puzzle019;
using App.Puzzles.Puzzle020;
using App.Puzzles.Puzzle021;
using App.Puzzles.Puzzle022;
using App.Puzzles.Puzzle023;
using App.Puzzles.Puzzle024;
using App.Puzzles.Puzzle025;
using App.Puzzles.Puzzle026;
using App.Puzzles.Puzzle027;
using App.Puzzles.Puzzle028;
using App.Puzzles.Puzzle029;
using App.Puzzles.Puzzle030;

namespace Cli
{
    public class ProblemRepository
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
            new Problem020(),
            new Problem021(),
            new Problem022(),
            new Problem023(),
            new Problem024(),
            new Problem025(),
            new Problem026(),
            new Problem027(),
            new Problem028(),
            new Problem029(),
            new Problem030()
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