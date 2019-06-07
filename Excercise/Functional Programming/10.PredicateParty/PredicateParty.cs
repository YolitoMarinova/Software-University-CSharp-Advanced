using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty
{
    class PredicateParty
    {
        public static void Main()
        {
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, int, bool> lengthFilter = (name, length) => name.Length == length;
            Func<string, string, bool> startsWithFilter = (name, parameters) => name.StartsWith(parameters);
            Func<string, string, bool> endWithFilter = (name, parameters) => name.EndsWith(parameters);

            Func<List<string>, string, int> findIndex = (listOfNames, nameToFind) => listOfNames.FindIndex(x=>x==nameToFind);

            List<string> namesToAdd = new List<string>();

            while (commands[0]!="Party!")
            {
                if (commands[0] == "Double")
                {
                    if (commands[1] == "Length")
                    {
                        namesToAdd = names.Where(name=>lengthFilter(name,int.Parse(commands[2]))).ToList();    
                    }
                    else if (commands[1] == "StartsWith")
                    {
                        namesToAdd = names.Where(name => startsWithFilter(name, commands[2])).ToList();
                    }
                    else if (commands[1] == "EndsWith")
                    {
                        namesToAdd = names.Where(name => endWithFilter(name,commands[2])).ToList();
                    }


                    foreach (var name in namesToAdd)
                    {
                        int index = findIndex(names, name);

                        names.Insert(index, name);
                    }

                }
                else if (commands[0] == "Remove")
                {
                    if (commands[1] == "Length")
                    {
                        names = names.Where(name => !lengthFilter(name, int.Parse(commands[2]))).ToList();
                    }
                    else if (commands[1] == "StartsWith")
                    {
                        names = names.Where(name => !startsWithFilter(name, commands[2])).ToList();
                    }
                    else if (commands[1] == "EndsWith")
                    {
                        names = names.Where(name => !endWithFilter(name, commands[2])).ToList();
                    }
                }

                commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }


            if (names.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
    }
}
