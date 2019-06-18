using System;

namespace _01.GenericBoxOfString
{
    public class StartUp
    {
       public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                string input = Console.ReadLine();

                var currentData = new Box<string>(input);

                Console.WriteLine(currentData.ToString());
            }
        }
    }
}
