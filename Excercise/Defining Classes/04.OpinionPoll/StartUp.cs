using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.OpinionPoll
{
    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();

            int row = int.Parse(Console.ReadLine());

            for (int i = 0; i < row; i++)
            {
                string[] personInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = personInput[0];
                int age = int.Parse(personInput[1]);

                Person currentPerson = new Person(name, age);

                people.Add(currentPerson);
            }

            people.OrderBy(x => x.Name)
                .Where(x => x.Age > 30)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x.Name} - {x.Age}"));
        }
    }
}
