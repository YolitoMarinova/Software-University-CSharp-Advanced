using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class AppliedArithmetics
    {
        public static void Main()
        {
            Func<double, double> add = x => x + 1;
            Func<double, double> subtract = x => x - 1;
            Func<double, double> multiply = x => x * 2;
            Action<List<double>> printNumbers=nums=>
            Console.WriteLine(string.Join(" ",nums));

            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command!="end")
            {
                if (command == "add")
                {
                    numbers = numbers.Select(x => add(x)).ToList();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(x => subtract(x)).ToList();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(x => multiply(x)).ToList();
                }
                else if (command == "print")
                {
                    printNumbers(numbers);
                }

                command = Console.ReadLine();
            }

        }
    }
}
