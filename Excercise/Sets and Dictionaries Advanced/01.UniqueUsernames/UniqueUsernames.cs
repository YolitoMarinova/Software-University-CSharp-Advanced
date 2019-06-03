using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class UniqueUsernames
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            HashSet<string> usernames = new HashSet<string>();

            for (int i = 0; i < rows; i++)
            {
                usernames.Add(Console.ReadLine());
            }

            foreach (var name in usernames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
