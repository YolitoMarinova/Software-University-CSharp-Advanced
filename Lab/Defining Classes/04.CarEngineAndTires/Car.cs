using System;
using System.Collections.Generic;
using System.Text;

namespace _04.CarEngineAndTires
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private Engine engine;
        private Tire[] tires;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public Tire[] Tire{ get { return tires; } set { tires = value; } }

        public void Drive(double distance)
        {
            double neededFuel = distance * FuelConsumption;

            if (FuelQuantity - neededFuel >= 0)
            {
                FuelQuantity -= neededFuel;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nFuel: {FuelQuantity:F2}";
        }

        public Car()
        {

        }
        public Car(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }
        public Car(string make,string model,int year, double fuelQuantity, double fuelConsumption)
            : this(make,model,year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public Car(string make,string model,int year,double fuelQuantity, double fuelConsumption,Engine engine,Tire[] tires)
            :this (make,model,year,fuelQuantity,fuelConsumption)
        {
            this.engine = engine;
            this.tires = tires;
        }
    }
}
