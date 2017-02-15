using System.Collections.Generic;
using System;

namespace PalindromeApp
{
    public class Palindromes
    {
        private string _wordInput;

        public Palindromes(string wordInput)
        {
            _wordInput = wordInput;
        }

        public string GetWord()
        {
            return _wordInput;
        }

        public bool PaliChecker()
        {
            string userWord = GetWord();
            char[] wordArray = userWord.ToCharArray();
            char[] wordArray2 = userWord.ToCharArray();
            Array.Reverse(wordArray2);
            bool result = false;

            if (wordArray == wordArray)
            {
                result = true;
            }

            return result;
        }
    }
}
