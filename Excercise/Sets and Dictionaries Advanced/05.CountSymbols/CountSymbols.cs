using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class CountSymbols
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> letters = new SortedDictionary<char, int>();

            foreach (var letter in input)
            {
                if (letters.ContainsKey(letter))
                {
                    letters[letter]++;
                }
                else
                {
                    letters[letter] = 1;
                }
            }

            foreach (var letter in letters)
            {
                Console.WriteLine($"{letter.Key}: {letter.Value} time/s");
            }
        }
    }
}
