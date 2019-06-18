using System;

namespace _05.GenericCountMethodString
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

            string element = Console.ReadLine();

            Console.WriteLine(data.GetCountOfLargerElements(element));
        }
    }
}
