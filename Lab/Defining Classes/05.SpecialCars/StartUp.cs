using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SpecialCars
{
    class StartUp
    {
        public static void Main()
        {
            var cars = new List<Car>();
            var tires = new List<Tire[]>();
            var engines = new List<Engine>();

            string[] tiresInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (tiresInfo[0] != "No")
            {
                var currentTires = new Tire[4];
                int counter = 0;

                for (int i = 0; i < tiresInfo.Length / 2; i++)
                {
                    int year = int.Parse(tiresInfo[counter]);
                    double pressure = double.Parse(tiresInfo[counter + 1]);
                    counter += 2;

                    currentTires[i] = new Tire(year, pressure);
                }

                tires.Add(currentTires);

                tiresInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string[] enginesInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (enginesInfo[0] != "Engines")
            {
                int horsePower = int.Parse(enginesInfo[0]);
                double cubicCapacity = double.Parse(enginesInfo[1]);

                var engine = new Engine(horsePower, cubicCapacity);

                engines.Add(engine);

                enginesInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            while (carInfo[0] != "Show" && carInfo[1] != "special")
            {
                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = int.Parse(carInfo[3]);
                double fuelConsumption = int.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                Engine engine = engines[engineIndex];
                Tire[] tire = tires[tiresIndex];

                var car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, tire);
                cars.Add(car);

                carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }



            var specialCars = cars
              .Where(x => x.Drive(20) == true)
               .Where(y => y.Year >= 2017)
                .Where(h => h.Engine.HorsePower >= 330)
                .Where(t => t.Tires.Sum(x => x.Pressure) >= 9 && t.Tires.Sum(x => x.Pressure) <= 10)
                .ToList();

            foreach (var car in specialCars)
            {
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
