using System;
using System.Linq;

namespace _08.CustomComparator
{
    class CustomComparator
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> func = (x, y) =>
                (x % 2 == 0 && y % 2 != 0) ? -1
                : (x % 2 != 0 && y % 2 == 0) ? 1
                : x > y ? 1 : x < y ? -1 : 0;

            Array.Sort(numbers, (x, y) => func(x,y));

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
