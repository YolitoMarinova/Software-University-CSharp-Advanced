using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class ParkingLot
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            HashSet<string> carNumbers = new HashSet<string>();

            while (input[0] != "END")
            {
                string carNumber = input[1];

                switch (input[0])
                {
                    case "IN":
                        carNumbers.Add(carNumber);
                        break;
                    case "OUT":
                        carNumbers.Remove(carNumber);
                        break;
                }

                input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);
            }

            if (carNumbers.Count > 0)
            {
                foreach (var carNum in carNumbers)
                {
                    Console.WriteLine(carNum);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
