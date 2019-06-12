using System;
using System.Collections.Generic;
using System.Text;

namespace _05.SpecialCars
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
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
        public double FuelQuantity { get { return fuelQuantity; } set { fuelQuantity = value; } }
        public double FuelConsumption { get { return fuelConsumption; } set { fuelConsumption = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public Tire[] Tires{ get { return tires; } set { tires = value; } }

        public bool Drive(double distance)
        {
            double neededFuel = distance/100 * fuelConsumption;

            if (fuelQuantity - neededFuel >= 0)
            {
                fuelQuantity -= neededFuel;
               return true;
            }
            else
            {
                return false;
            }
        }

        public string WhoAmI()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nHorsePowers: {engine.HorsePower}\nFuel: {FuelQuantity:F2}";
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
