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
            bool result = true;

            Console.WriteLine(wordArray);
            Console.WriteLine(wordArray2);

            for (int i = 0; i <wordArray.Length; i++)
            {
                if (wordArray[i] == wordArray2[i])
                {
                    continue;
                }
                result = false;
            }

            return result;
        }
    }
}
