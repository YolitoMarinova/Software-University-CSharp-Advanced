using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class CustomMinFunction
    {
        public static void Main()
        {
            Func<int[], int> getMinValue = nums =>
              {
                  int minValue = int.MaxValue;

                  foreach (var number in nums)
                  {
                      if (number < minValue)
                      {
                          minValue = number;
                      }
                  }

                  return minValue;
              };

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(getMinValue(numbers));
        }
    }
}
