using System;

namespace _02.GenericBoxOfInteger
{
    public class Program
    {
       public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                int input = int.Parse(Console.ReadLine());

                var currentData = new Box<int>(input);

                Console.WriteLine(currentData.ToString());
            }
        }
    }
}
