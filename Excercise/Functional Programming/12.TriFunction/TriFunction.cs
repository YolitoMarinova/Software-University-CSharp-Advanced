using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    class TriFunction
    {
        public static void Main()
        {

            int length = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, int, bool> isLarger = (name, charsLength)
                => name.Sum(x => x) >= charsLength;

            Func<List<string>, Func<string, int, bool>, string> namesFilter =
                (listOfNames, isLargerFilter) 
                => listOfNames.FirstOrDefault(x => isLargerFilter(x, length));

            string resultName = namesFilter(names, isLarger);

            Console.WriteLine(resultName);

        }
    }
}
