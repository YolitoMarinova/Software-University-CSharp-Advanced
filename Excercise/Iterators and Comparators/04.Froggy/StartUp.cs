using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Froggy
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            Lake lake = new Lake(numbers);

            List<int> list = new List<int>();

            foreach (var currentStone in lake)
            {
                list.Add(currentStone);
            }

            Console.WriteLine(String.Join(", ",list));
        }
    }
}
