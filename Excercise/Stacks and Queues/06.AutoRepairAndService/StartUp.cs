using System;
using System.Collections.Generic;

namespace _06.AutoRepairAndService
{
    class StartUp
    {
       public static void Main()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Queue<string> cars = new Queue<string>(input);
            Stack<string> servedCars = new Stack<string>();

            string command = Console.ReadLine();

            while (command != "End")
            {
                if (command == "Service" && cars.Count > 0)
                {
                        string currentCar = cars.Peek();
                        servedCars.Push(currentCar);
                        cars.Dequeue();
                        Console.WriteLine($"Vehicle {currentCar} got served.");
                }
                else if (command.Contains("CarInfo-"))
                {
                    string carName = command.Substring(8);

                    if (cars.Contains(carName))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else if (servedCars.Contains(carName))
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (command == "History")
                {
                    Console.WriteLine(String.Join(", ",servedCars));
                }

                command = Console.ReadLine();
            }

            if (cars.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {String.Join(", ", cars)}");
            }
            if (servedCars.Count > 0)
            {
                Console.WriteLine($"Served vehicles: {String.Join(", ", servedCars)}");
            }
        }
    }
}
