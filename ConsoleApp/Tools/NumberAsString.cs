namespace ConsoleApp.Tools
{
    public class NumberAsString
    {
        private readonly int _number;

        public NumberAsString(int number)
        {
            _number = number;
        }

        public override string ToString()
        {
            var s = _number.ToString();

            if (s.Length == 4)
                return GetWordsForFourDigits();

            if (s.Length == 3)
                return GetWordsForThreeDigits(_number);

            if (s.Length == 2)
                return GetWordsForTwoDigits(_number);

            return GetWordsForOneDigit(_number);
        }

        private string GetWordsForOneDigit(int n)
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

        private string GetWordsForTwoDigits(int n)
        {
            return n < 20
                ? GetWordsForLowTwoDigits(n)
                : GetWordsForHighTwoDigits(n);
        }

        private string GetWordsForHighTwoDigits(int n)
        {
            var s = n.ToString();
            var tens = GetWordsForTens(int.Parse(s.Substring(0, 1)));
            var rest = s.Substring(1);
            var singles = GetWordsForTwoDigits(int.Parse(rest));

            return $"{tens}{singles}";
        }

        private string GetWordsForTens(int n)
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

        private string GetWordsForThreeDigits(int n)
        {
            var s = n.ToString();
            var hundreds = GetWordsForHundreds(int.Parse(s.Substring(0, 1)));
            var rest = s.Substring(1);
            var tens = GetWordsForTwoDigits(int.Parse(rest));
            
            return tens.Length > 0
                ? $"{hundreds} and {tens}"
                : hundreds;
        }

        private string GetWordsForLowTwoDigits(int n)
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

        private string GetWordsForFourDigits()
        {
            return "one thousand";
        }

        private string GetWordsForHundreds(int n)
        {
            return $"{GetWordsForOneDigit(n)} hundred";
        }
    }
}