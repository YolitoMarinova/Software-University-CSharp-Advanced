using System;

namespace _01.Car
{
    class StartUp
    {
        public static void Main()
        {
            Car car = new Car();

            car.Make = "Ferrari";
            car.Model = "NewModel";
            car.Year = 2019;

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}
