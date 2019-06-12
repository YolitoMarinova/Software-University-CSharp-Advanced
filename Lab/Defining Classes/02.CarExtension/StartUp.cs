using System;

namespace _02.CarExtension
{
    class StartUp
    {
        public static void Main()
        {
            Car car = new Car();

            car.Make = "Ferrari";
            car.Model = "NewModel";
            car.Year = 2019;
            car.FuelQuantity = 200;
            car.FuelConsumption = 200;

            car.Drive(2000);

            Console.WriteLine(car.WhoAmI());
        }
    }
}
