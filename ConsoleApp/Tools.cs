using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    public static class Tools
    {
        public static IEnumerable<int> FindPrimesBelow(int limit)
        {
            var primes = new List<int> {2};

            for (var i = 3; i < limit; i += 2)
            {
                var root = Math.Sqrt(i);
                var found = false;
                
                for (int j = 0, count = primes.Count; j < count; j++)
                {
                    int divisor;
                    if ((divisor = primes[j]) > root)
                        break;

                    if ((i % divisor) == 0)
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                    primes.Add(i);
            }

            return primes;
        }

        public static bool IsPrime(long num)
        {
            if (num == 1)
                return false;

            if (num == 2)
                return true;

            if (num % 2 == 0)
                return false;
            
            for (long i = 3; i < num; i += 2)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        }
        
        public static long FindLargestPrimeFactor(long num)
        {
            long largest = 0;

            if (num % 2 == 0)
            {
                largest = 2;
                while (num % 2 == 0)
                {
                    num /= 2;
                }
            }

            for (long i = 3; i <= Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    largest = i;
                    num /= i;
                }
            }

            if (num > largest)
                largest = num;

            return largest;
        }

        //public static int GetFactorCount(int num)
        //{
        //    var factorCount = 0;
        //    for (var i = num; i >= 0; i--)
        //    {
        //        if (num % (i + 1) == 0)
        //            factorCount++;
        //    }

        //    return factorCount;
        //}

        //public static int GetFactorCount2(int n)
        //{
        //    var count = 0;
        //    while (n % 2 == 0)
        //    {
        //        count++;
        //        n /= 2;
        //    }

        //    var f = 3;


        //    while (f * f <= n)
        //    {
        //        if (n % f == 0)
        //        {
        //            count++;
        //            n /= f;
        //        }
        //        else
        //        {
        //            f += 2;
        //        }
        //    }

        //    if (n != 1)
        //        count++;
        //    return count;
        //}

        public static IEnumerable<int> GetFactors(int x)
        {
            for (var i = 1; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    yield return i;
                    if (i != x / i)
                        yield return x / i;
                }
            }
        }

        //public static int GetFactorCount(int x)
        //{
        //    private int NumberOfDivisors(int number)
        //    {
        //        int nod = 0;
        //        int sqrt = (int)Math.Sqrt(number);

        //        for (int i = 1; i <= sqrt; i++)
        //        {
        //            if (number % i == 0)
        //            {
        //                nod += 2;
        //            }
        //        }
        //        //Correction if the number is a perfect square
        //        if (sqrt * sqrt == number)
        //        {
        //            nod--;
        //        }

        //        return nod;
        //    }
        //}
    }
}