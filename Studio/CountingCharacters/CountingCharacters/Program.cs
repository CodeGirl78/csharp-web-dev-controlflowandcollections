using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            var countDictionary = new Dictionary<char, int>();

            // To loop through each character in the string input 
            foreach (char c in inputString)
            {
                // If already there, increment the count
                if (countDictionary.ContainsKey(c))
                    countDictionary[c] += 1;

                // If first time, add to the dictionary
                else
                    countDictionary.Add(c, 1);
            }

            // To loop through the dictionary and output the counts
            foreach (var item in countDictionary)
                Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
