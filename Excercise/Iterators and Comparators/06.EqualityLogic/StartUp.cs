using System;
using System.Collections.Generic;

namespace _06.EqualityLogic
{
    public class StartUp
    {
        public static void Main()
        {
            int counter = int.Parse(Console.ReadLine());

            HashSet<Person> hashSet = new HashSet<Person>();
            SortedSet<Person> sordetSet = new SortedSet<Person>();

            for (int i = 0; i < counter; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person curretnPerson = new Person(name, age);

                hashSet.Add(curretnPerson);
                sordetSet.Add(curretnPerson);
            }

            Console.WriteLine(hashSet.Count);
            Console.WriteLine(sordetSet.Count);
        }
    }
}

