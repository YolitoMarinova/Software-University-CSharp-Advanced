using System;
using System.Collections.Generic;

namespace _08.Threeuple
{
   public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split();

            string names = input[0] + " " + input[1];
            string adress = input[2];
            string city = input[3];

            Threeuple<string, string,string> firstLine = new Threeuple<string, string,string>(names,adress, city);
            Console.WriteLine(firstLine.ToString());

            input = Console.ReadLine()
                .Split();

            string name = input[0];
            double littersOfBeers = double.Parse(input[1]);
            bool drunkOrNot=input[2] == "drunk" ? true : false;

            Threeuple<string, double, bool> secondLine = new Threeuple<string, double, bool>(name, littersOfBeers, drunkOrNot);
            Console.WriteLine(secondLine.ToString());

            input = Console.ReadLine()
                .Split();

            string personName = input[0];
            double accountBalance = double.Parse(input[1]);
            string bankNmae = input[2];

            Threeuple<string, double, string> thirdLine = new Threeuple<string, double, string>(personName, accountBalance, bankNmae);
            Console.WriteLine(thirdLine.ToString());
        }
    }
}
