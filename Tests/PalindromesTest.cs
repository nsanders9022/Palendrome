using Xunit;
using System;

namespace PalindromeApp
{
    public class PalindromeTest
    {
        [Fact]
        public void PaliChecker_Palindromecheck_Truebool()
        {
            string wordInput = "racecar";

            Palindromes testPali = new Palindromes(wordInput);
            bool result = testPali.PaliChecker();

            Assert.Equal(true, result);
        }

        [Fact]
        public void PaliChecker_PalindromecheckWithSpace_Truebool()
        {
            string wordInput = "Hello olleH";

            Palindromes testPali = new Palindromes(wordInput);
            bool result = testPali.PaliChecker();

            Assert.Equal(true, result);
        }

        [Fact]
        public void PaliChecker_PalindromecheckWithNumber_Truebool()
        {
            string wordInput = "10100101";

            Palindromes testPali = new Palindromes(wordInput);
            bool result = testPali.PaliChecker();

            Assert.Equal(true, result);
        }
    }
}
