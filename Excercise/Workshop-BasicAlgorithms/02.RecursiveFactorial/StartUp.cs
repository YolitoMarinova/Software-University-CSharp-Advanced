using System;

namespace _02.RecursiveFactorial
{
    public class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int factorialNumber = Factorial(number);

            Console.WriteLine(factorialNumber);
        }

        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new InvalidOperationException();
            }

            if (number == 0)
            {
                return 1;
            }

            return number * Factorial(number - 1);
        }
    }
}
