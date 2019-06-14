using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.RawData
{
    public class StartUp
    {
        public static void Main()
        {
            List<Car> cars = new List<Car>();
            cars = GetCarsInfo(cars);

            string cargoType = Console.ReadLine();

            if (cargoType == "fragile")
            {
                cars = cars.Where(x=>x.Cargo.Type==cargoType)
                    .Where(x => x.Tires.Any(y => y.Pressure < 1))
                    .ToList();
            }
            else if (cargoType == "flamable")
            {
               cars= cars.Where(x => x.Cargo.Type == cargoType)
                    .Where(x => x.Engine.Power > 250)
                    .ToList();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.Model);
            }
        }

        private static List<Car> GetCarsInfo(List<Car> cars)
        {
            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] carInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInput[0];

                int engineSpeed = int.Parse(carInput[1]);
                int enginePower = int.Parse(carInput[2]);
                Engine currentEngine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(carInput[3]);
                string cargoType = carInput[4];
                Cargo currentCargo = new Cargo(cargoWeight, cargoType);

                List<Tire> currentTires = new List<Tire>();
                currentTires = GetTiresInfo(currentTires, carInput);

                Car currentCar = new Car(model, currentEngine, currentCargo, currentTires);
                cars.Add(currentCar);
            }

            return cars;
        }

        private static List<Tire> GetTiresInfo(List<Tire> tires, string[] carInput)
        {
            for (int i = 5; i < carInput.Length; i += 2)
            {
                double pressure = double.Parse(carInput[i]);
                int age = int.Parse(carInput[i + 1]);

                Tire currentTire = new Tire(pressure, age);

                tires.Add(currentTire);
            }

            return tires;
        }
    }
}
