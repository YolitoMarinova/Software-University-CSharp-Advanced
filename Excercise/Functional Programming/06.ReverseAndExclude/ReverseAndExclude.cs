using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class ReverseAndExclude
    {
        public static void Main()
        {
            Func<int, int, bool> isNotDivisible = (num, n) => num % n != 0;
            Func<List<int>, List<int>> reverseNumbers = nums =>
               {
                   var revNums = new List<int>();

                   for (int i = nums.Count - 1; i >= 0; i--)
                   {
                       revNums.Add(nums[i]);
                   }

                   return revNums;
               };

            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int divisior = int.Parse(Console.ReadLine());

            numbers = reverseNumbers(numbers).Where(x => isNotDivisible(x, divisior)).ToList();

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
