using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class ListOfPredicates
    {
         static void Main()
        {
            int endRange = int.Parse(Console.ReadLine());

            List<int> numbers = Enumerable.Range(1,endRange).ToList();

            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Distinct()
                .Select(int.Parse)
                .ToArray();

            List<Predicate<int>> predicates = new List<Predicate<int>>();

            for (int i = 0; i < dividers.Length; i++)
            {
                Predicate<int> divisible = num => num % dividers[i] == 0;
                numbers = numbers.FindAll(divisible);
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
