using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CarSalesman
{
    public class StartUp
    {
        public static void Main()
        {
            List<Engine> engines = new List<Engine>();
            engines = GetEngines(engines);

            List<Car> cars = new List<Car>();
            cars = GetCars(cars, engines);

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($" {car.Engine.Model}:");
                Console.WriteLine($"  Power: {car.Engine.Power}");
                Console.WriteLine($"  Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"  Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($" Weight: {car.Weight}");
                Console.WriteLine($" Color: {car.Color}");
            }
        }

        private static List<Car> GetCars(List<Car> cars, List<Engine> engines)
        {
            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] carInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carInput[0];
                string engineModel = carInput[1];

                Engine currentEngine = engines.FirstOrDefault(x => x.Model == engineModel);

                Car currentCar = new Car(model, currentEngine);

                if (carInput.Length == 3)
                {
                    if (char.IsDigit(carInput[2][0]))
                    {
                        string weight = carInput[2];

                        currentCar.Weight = weight;
                    }
                    else
                    {
                        string color = carInput[2];

                        currentCar.Color = color;
                    }
                }
                else if (carInput.Length == 4)
                {
                    string weight = carInput[2];
                    string color = carInput[3];

                    currentCar.Weight = weight;
                    currentCar.Color = color;
                }

                cars.Add(currentCar);
            }

            return cars;
        }

        private static List<Engine> GetEngines(List<Engine> engines)
        {
            int enginesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < enginesCount; i++)
            {
                string[] engineInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = engineInput[0];
                int power = int.Parse(engineInput[1]);

                Engine currentEngine = new Engine(model, power);

                if (engineInput.Length == 3)
                {
                    if (char.IsDigit(engineInput[2][0]))
                    {
                        string displacement = engineInput[2];

                        currentEngine.Displacement = displacement;
                    }
                    else
                    {
                        string efficiency = engineInput[2];

                        currentEngine.Efficiency = efficiency;
                    }
                }
                else if (engineInput.Length == 4)
                {
                    string displacement = engineInput[2];
                    string efficiency = engineInput[3];

                    currentEngine.Displacement = displacement;
                    currentEngine.Efficiency = efficiency;
                }

                engines.Add(currentEngine);
            }

            return engines;
        }
    }
}
