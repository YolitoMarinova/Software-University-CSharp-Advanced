using System;
using System.Collections.Generic;
using System.Text;

namespace _05.SpecialCars
{
   public class Engine
    {
        private int horsePower;
        private double cubicCapacity;

        public int HorsePower { get { return horsePower; } set { horsePower = value; } }
        public double CubicCapacity { get { return cubicCapacity; } set { cubicCapacity = value; } }

        public Engine()
        {

        }

        public Engine(int horsePower,double cubicCapacity)
        {
            this.horsePower = horsePower;
            this.cubicCapacity = cubicCapacity;
        }
    }
}
