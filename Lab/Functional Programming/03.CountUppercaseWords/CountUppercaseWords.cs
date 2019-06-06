using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class CountUppercaseWords
    {
        public static void Main()
        {
            Func<string, bool> checkIsUpper = n => n[0] == n.ToUpper()[0];

            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(checkIsUpper)
                .ToArray();

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }

    }
}
