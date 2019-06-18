using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.GenericSwapMethodString
{
   public class StartUp
    {
       public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            Data<string> data = new Data<string>();

            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine();

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
