using System;

namespace _06.GenericCountMethodDouble
{
    public class StartUp
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            Data<double> data = new Data<double>();

            for (int i = 0; i < rows; i++)
            {
                double input = double.Parse(Console.ReadLine());

                data.Add(input);
            }

            double element = double.Parse(Console.ReadLine());

            Console.WriteLine(data.GetCountOfLargerElements(element));
        }
    }
}
