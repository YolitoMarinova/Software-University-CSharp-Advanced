using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SpeedRacing
{
   public class StartUp
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();
            cars = ReadCarsFromConsole(cars);

            string[] command = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            while (command[0]!="End")
            {
                string carModel = command[1];
                double kilometersCount = double.Parse(command[2]);

                Car carToDrive = cars.Where(x => x.Model == carModel).FirstOrDefault();
                carToDrive.Drive(kilometersCount);
                
                command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }

        private static List<Car> ReadCarsFromConsole(List<Car> cars)
        {
            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] currentCar = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string name = currentCar[0];
                double fuelAmount = double.Parse(currentCar[1]);
                double fuelConsumPerKM = double.Parse(currentCar[2]);

                var car = new Car(name,fuelAmount,fuelConsumPerKM);

                cars.Add(car);
            }

            return cars;
        }
    }
}
