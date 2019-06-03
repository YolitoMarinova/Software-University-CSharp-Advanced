using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            int n=int.Parse(Console.ReadLine());
            Queue<string> kids = new Queue<string>(input);

            while (kids.Count > 1)
            {
                for (int i = 1; i < n; i++)
                {
                    string player = kids.Dequeue();
                    kids.Enqueue(player);
                }

                Console.WriteLine($"Removed {kids.Dequeue()}");
            }

            Console.WriteLine($"Last is {kids.Peek()}");
        }
    }
}
