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
    }
}
