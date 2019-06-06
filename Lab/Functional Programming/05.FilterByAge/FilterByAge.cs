using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    class FilterByAge
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            List<KeyValuePair<string,int>> people = new List<KeyValuePair<string, int>>();

            for (int i = 0; i < rows; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                if (input.Length == 2)
                {
                    string currentName = input[0];
                    int currentAge =int.Parse(input[1]);

                    people.Add(new KeyValuePair<string, int>(currentName,currentAge));
                }
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string[] format = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            people.Where(p => condition == "younger" ? p.Value < age : p.Value >= age)
                .ToList()
                .ForEach(p => Printer(p, format));

        }

        private static void Printer(KeyValuePair<string, int> person, string[] format)
        {
            if (format.Length == 2)
            {
                Console.WriteLine(format[0] == "name" ?
                    $"{person.Key} - {person.Value}" :
                    $"{person.Value} - {person.Key}"
                    );
            }
            else if (format.Length==1)
            {
                Console.WriteLine(format[0] == "name" ?
                    $"{person.Key}" :
                    $"{person.Key}" );
            }
        }
    }
}
