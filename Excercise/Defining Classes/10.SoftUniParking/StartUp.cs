using System;

namespace SoftUniParking
{
    public class StartUp
    {
        public static void Main()
        {
            Parking parking = new Parking(2);

            Car car = new Car("Skoda","Fabia",65,"CC1856BG");

            Console.WriteLine(parking.AddCar(car));

            Console.WriteLine(parking.GetCar(car.RegistrationNumber));


        }
    }
}
