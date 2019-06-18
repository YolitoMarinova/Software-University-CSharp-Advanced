using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
   public class StartUp
    {
       public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            Data<int> data = new Data<int>();

            for (int i = 0; i < rows; i++)
            {
                int input = int.Parse(Console.ReadLine());

                data.Add(input);
            }

            int[] indexes = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            data.Swap(firstIndex, secondIndex);

            Console.WriteLine(data.ToString());
        }
    }
}
