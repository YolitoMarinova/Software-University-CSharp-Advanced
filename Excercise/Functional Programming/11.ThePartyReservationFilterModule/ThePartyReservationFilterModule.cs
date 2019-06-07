using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.ThePartyReservationFilterModule
{
    public class ThePartyReservationFilterModule
    {
        static void Main()
        {
            List<string> names = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            List<string> filters = new List<string>();

            filters = AddValidFilters(filters);

            Func<string, int, bool> lenghtFilter = (name, lenght) => name.Length == lenght;
            Func<string, string, bool> startsWithFilter = (name, parameters) => name.StartsWith(parameters);
            Func<string, string, bool> endWithFilter = (name, parameters) => name.EndsWith(parameters);
            Func<string, string, bool> containsFilter = (name, parameters) => name.Contains(parameters);


            foreach (var filter in filters)
            {
                string[] filterInfo = filter.Split(";");

                string command = filterInfo[0];
                string parameter = filterInfo[1];

                if (command == "Starts with")
                {
                    names = names.Where(x => !startsWithFilter(x, parameter)).ToList();
                }
                else if (command == "Ends with")
                {
                    names = names.Where(x => !endWithFilter(x, parameter)).ToList();
                }
                else if (command == "Length")
                {
                    names = names.Where(x => !lenghtFilter(x, int.Parse(parameter))).ToList();
                }
                else if (command == "Contains")
                {
                    names = names.Where(x => !containsFilter(x, parameter)).ToList();
                }
            }

            Console.WriteLine(string.Join(" ",names));
        }

        private static List<string> AddValidFilters(List<string> filters)
        {
            string[] command = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "Print")
            {
                if (command[0] == "Add filter")
                {
                    filters.Add($"{command[1]};{command[2]}");
                }
                else if (command[0] == "Remove filter")
                {
                    filters.Remove($"{command[1]};{command[2]}");
                }

                command = Console.ReadLine()
                .Split(";", StringSplitOptions.RemoveEmptyEntries);
            }

            return filters;
        }
    }
}
