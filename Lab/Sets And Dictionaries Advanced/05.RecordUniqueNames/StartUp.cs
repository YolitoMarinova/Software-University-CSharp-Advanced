using System;
using System.Collections.Generic;

namespace _05.RecordUniqueNames
{
    class StartUp
    {
       public static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            HashSet<string> uniqueNames = new HashSet<string>();

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();

                uniqueNames.Add(name);
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
