using System;
using System.Collections.Generic;
using System.Text;

namespace _04.CarEngineAndTires
{
   public class Tire
    {
        private int year;
        private double pressure;

        public int Year { get { return year; } set { year = value; } }
        public double Pressure { get { return pressure; } set { pressure = value; } }

        public Tire()
        {

        }

        public Tire(int year,double pressure)
        {
            this.year = year;
            this.pressure = pressure;
        }
    }
}
