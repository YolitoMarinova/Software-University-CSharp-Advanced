using System;
using System.Linq;

namespace _02.SumNumbers
{
    class SumNumbers
    {
        public static void Main()
        {
            Func<string, int> parser = n => int.Parse(n);

            int[] numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(parser)
                .ToArray();

            Console.WriteLine($"{numbers.Count()} \n{numbers.Sum()}");
        }
    }
}
