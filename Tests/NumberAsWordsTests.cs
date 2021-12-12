using App.Common.Strings;
using NUnit.Framework;

namespace Tests
{
    public class NumberAsWordsTests
    {
        [TestCase(5, "five")]
        [TestCase(14, "fourteen")]
        [TestCase(37, "thirtyseven")]
        [TestCase(98, "ninetyeight")]
        [TestCase(107, "one hundred and seven")]
        [TestCase(342, "three hundred and fortytwo")]
        [TestCase(560, "five hundred and sixty")]
        [TestCase(900, "nine hundred")]
        [TestCase(999, "nine hundred and ninetynine")]
        [TestCase(1000, "one thousand")]
        public void Factors(int n, string expected)
        {
            var result = new NumberAsString(n).ToString();

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}