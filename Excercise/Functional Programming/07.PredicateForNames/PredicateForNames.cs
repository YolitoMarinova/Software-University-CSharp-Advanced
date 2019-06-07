using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class PredicateForNames
    {
        public static void Main()
        {
            Func<string, int, bool> filterNames = (name, lenght) =>
                {
                    return name.Length <= lenght;
                };

            int number = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            names = names.Where(x => filterNames(x, number)).ToList();

            Console.WriteLine(string.Join(Environment.NewLine,names));
        }
    }
}
