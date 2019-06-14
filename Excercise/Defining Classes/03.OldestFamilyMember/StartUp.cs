using System;

namespace _03.OldestFamilyMember
{
   public class StartUp
    {
       public static void Main()
        {
            var family = new Family();

            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                string[] personInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = personInput[0];
                int age = int.Parse(personInput[1]);


                Person currentPerson = new Person(name, age);
                family.AddMember(currentPerson);
            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
