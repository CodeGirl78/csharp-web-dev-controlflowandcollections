using System;
using System.Collections.Generic;

namespace ListStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new List<string> { "Italy", "Canada", "Egypt", "US", "Madagascar", "Spain" };
            PrintFiveLetterWords(words);
        }
        private static void PrintFiveLetterWords(List<string> words)
        {
            foreach (var word in words)
            {
                if (word.Length == 5) Console.WriteLine(word);
            }

        }
    }
}
