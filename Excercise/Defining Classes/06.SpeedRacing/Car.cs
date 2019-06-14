using System;
using System.Collections.Generic;
using System.Text;

namespace _06.SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance = 0;

        public string Model { get { return model; } set { model = value; } }
        public double FuelAmount { get { return fuelAmount; } set { fuelAmount = value; } }
        public double FuelConsumptionPerKilometer { get { return fuelConsumptionPerKilometer; } set { fuelConsumptionPerKilometer = value; } }
        public double TravelledDistance { get { return travelledDistance; } set { travelledDistance = value; } }

        public Car()
        {

        }

        public Car(string model,double fuelAmount,double fuelConsumption)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            fuelConsumptionPerKilometer = fuelConsumption;
        }

        public void Drive(double kilometersCount)
        {
            double fuelNeeded = kilometersCount * fuelConsumptionPerKilometer;

            if (fuelAmount - fuelNeeded >= 0)
            {
                fuelAmount -= fuelNeeded;
                travelledDistance += kilometersCount;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
