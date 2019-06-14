using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
   public class Engine
    {
        private string model;
        private int power;
        private string displacement;
        private string efficiency;

        public string Model { get { return model; } set { model = value; } }
        public int Power { get { return power; } set { power = value; } }
        public string Displacement { get { return displacement; } set { displacement = value; } }
        public string Efficiency { get { return efficiency; } set { efficiency = value; } }

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
            displacement = "n/a";
            efficiency = "n/a";
        }

        public Engine(string model, int power, string displacement,string efficiency)
            :this(model,power)
        {
            this.displacement = displacement;
            this.efficiency = efficiency;
        }
    }
}
