using System.Reflection;
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

namespace App
{
    public class ProblemRepository
    {
        private readonly List<ProblemWrapper> _allProblems;

        public ProblemRepository()
        {
            _allProblems = CreateProblems();
        }

        public ProblemWrapper GetProblem(int? problemId)
        {
            var p = problemId != null
                ? _allProblems.FirstOrDefault(o => o.Id == problemId.Value)
                : _allProblems.LastOrDefault();

            if (p == null)
                throw new Exception($"The specified problem could not be found {problemId}.");

            return p;
        }

        public IList<ProblemWrapper> GetAll()
        {
            return _allProblems;
        }

        private List<ProblemWrapper> CreateProblems()
        {
            var types = GetConcreteSubclassesOf<Problem>();
            return types.Select(CreateProblem).OrderBy(o => o.Id).ToList();
        }

        private ProblemWrapper CreateProblem(Type t)
        {
            var id = ProblemParser.ParseType(t);
            var problem = (Problem)Activator.CreateInstance(t);
            if (problem == null)
                throw new Exception($"Could not create Problem {id}");

            return new ProblemWrapper(id, problem);
        }

        private static IEnumerable<Type> GetConcreteSubclassesOf<T>() where T : class
        {
            var assembly = Assembly.GetAssembly(typeof(T));

            if (assembly == null)
                return new List<Type>();

            return assembly.GetTypes().Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T)));
        }
    }
}