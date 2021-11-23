using System;
using System.Linq;

namespace ConsoleApp.Tools
{
    public static class StringTools
    {
        public static string NumberAsWords(int n)
        {
            var s = n.ToString();

            if (s.Length == 4)
                return GetWordsForFourDigits();

            if (s.Length == 3)
                return GetWordsForThreeDigits(n);

            if (s.Length == 2)
                return GetWordsForTwoDigits(n);

            return GetWordsForOneDigit(n);
        }

        private static string GetWordsForOneDigit(int n)
        {
            switch (n)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
            }

            return "";
        }

        private static string GetWordsForTwoDigits(int n)
        {
            return n < 20
                ? GetWordsForLowTwoDigits(n)
                : GetWordsForHighTwoDigits(n);
        }

        private static string GetWordsForHighTwoDigits(int n)
        {
            var s = n.ToString();
            var tens = GetWordsForTens(int.Parse(s.Substring(0, 1)));
            var rest = s.Substring(1);
            var singles = GetWordsForTwoDigits(int.Parse(rest));

            return $"{tens}{singles}";
        }

        private static string GetWordsForTens(int n)
        {
            switch (n)
            {
                case 2:
                    return "twenty";
                case 3:
                    return "thirty";
                case 4:
                    return "forty";
                case 5:
                    return "fifty";
                case 6:
                    return "sixty";
                case 7:
                    return "seventy";
                case 8:
                    return "eighty";
                case 9:
                    return "ninety";
            }

            return "";
        }

        private static string GetWordsForThreeDigits(int n)
        {
            var s = n.ToString();
            var hundreds = GetWordsForHundreds(int.Parse(s.Substring(0, 1)));
            var rest = s.Substring(1);
            var tens = GetWordsForTwoDigits(int.Parse(rest));
            
            return tens.Length > 0
                ? $"{hundreds} and {tens}"
                : hundreds;
        }

        private static string GetWordsForLowTwoDigits(int n)
        {
            if (n < 10)
                return GetWordsForOneDigit(n);

            switch (n)
            {
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";
                case 13:
                    return "thirteen";
                case 14:
                    return "fourteen";
                case 15:
                    return "fifteen";
                case 16:
                    return "sixteen";
                case 17:
                    return "seventeen";
                case 18:
                    return "eighteen";
                case 19:
                    return "nineteen";
            }

            return "";
        }

        private static string GetWordsForFourDigits()
        {
            return "one thousand";
        }

        private static string GetWordsForHundreds(int n)
        {
            return $"{GetWordsForOneDigit(n)} hundred";
        }
    }
}