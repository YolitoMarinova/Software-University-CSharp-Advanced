using System;
using System.Linq;

namespace _01.RecursiveArraySum
{
    public class StartUp
    {
       public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int result = Sum(array, 0);

            Console.WriteLine(result);
        }

        public static int Sum(int[] array,int index)
        {
            if (index < array.Length)
            {
               return array[index] + Sum(array, ++index);
            }

            return 0;
        }
    }
}
