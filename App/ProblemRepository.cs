using System.Reflection;
using App.Platform;

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