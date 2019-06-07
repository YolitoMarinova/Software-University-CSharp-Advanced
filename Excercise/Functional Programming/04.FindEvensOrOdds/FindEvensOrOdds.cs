using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class FindEvensOrOdds
    {
        public static void Main()
        {
            int[] bounds = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int lowerBound = bounds[0];
            int upperBound = bounds[1];

            List<int> numbers = new List<int>();

            for (int i = lowerBound; i <= upperBound; i++)
            {
                numbers.Add(i);
            }

            string typeOfNumbers = Console.ReadLine();

            Predicate<int> isEven = number => number % 2 == 0;
            Predicate<int> isOdd = number => number % 2 != 0;
            Action<List<int>> printNumbers = nums =>
            Console.WriteLine(string.Join(" ", nums));

            if (typeOfNumbers == "odd")
            {
                numbers = numbers.Where(x => isOdd(x)).ToList();
            }
            else if (typeOfNumbers == "even")
            {
                numbers = numbers.Where(x => isEven(x)).ToList();
            }

            printNumbers(numbers);
        }
    }
}
