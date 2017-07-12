using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LightningFastWordFinder
{
    class LightningWordFinder
    {
        public string GetLongestWord(string text)
        {
            string[] stringOfWords = text.Split(' ');
            int maxLength = stringOfWords[0].Length;
            string longestWord = stringOfWords[0];
            for (int i = 1; i < stringOfWords.Length; i++)
            {
                if (maxLength < stringOfWords[i].Length)
                {
                    if (Regex.IsMatch(stringOfWords[i], @"^[a-zA-Z]+$"))
                    {
                        maxLength = stringOfWords[i].Length;
                        longestWord = stringOfWords[i];
                    }
                }
            }
            return longestWord;
        }
    }
}
