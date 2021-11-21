using System.Collections.Generic;

namespace ConsoleApp
{
    public class IntFactorizer
    {
        private readonly int _num;
        private Dictionary<int, int> _cache;

        public IntFactorizer(int num)
        {
            _num = num;
            _cache = new Dictionary<int, int>();
        }

        public int GetFactorCount(int num)
        {
            var factorCount = 0;
            for (var i = num; i >= 0; i--)
            {
                if (num % (i + 1) == 0)
                    factorCount++;
            }

            return factorCount;
        }
    }
}