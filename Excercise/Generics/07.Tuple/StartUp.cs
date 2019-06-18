using System;
using System.Collections.Generic;

namespace _07.Tuple
{
   public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split();

            string names = input[0] + " " + input[1];
            string city = input[2];

            Tuple<string, string> firstLine = new Tuple<string, string>(names, city);
            Console.WriteLine(firstLine.ToString());

            input = Console.ReadLine()
                .Split();

            string name = input[0];
            double littersOfBeers = double.Parse(input[1]);

            Tuple<string, double> secondLine = new Tuple<string, double>(name, littersOfBeers);
            Console.WriteLine(secondLine.ToString());

            input = Console.ReadLine()
                .Split();

            int intNum = int.Parse(input[0]);
            double doubleNum = double.Parse(input[1]);

            Tuple<int, double> thirdLine = new Tuple<int, double>(intNum, doubleNum);
            Console.WriteLine(thirdLine.ToString());
        }
    }
}
