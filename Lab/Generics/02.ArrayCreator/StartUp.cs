using System;

namespace GenericArrayCreator
{
    public class Program
    {
        public static void Main()
        {
            string[] textArray = ArrayCreator.Create(5, "Yolito");
            int[] numberArray = ArrayCreator.Create(5, 15);

            Console.WriteLine(String.Join(" ",textArray));
            Console.WriteLine(String.Join(" ", numberArray));
        }
    }
}
