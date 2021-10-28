using System;

namespace ConsoleApp
{
    public static class Tools
    {
        public static bool IsPrime(long num)
        {
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
    }
}