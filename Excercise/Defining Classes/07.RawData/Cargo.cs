using System;
using System.Collections.Generic;
using System.Text;

namespace _07.RawData
{
   public class Cargo
    {
        private int weight;
        private string type;

        public int Weight { get { return weight; } set { weight = value; } }
        public string Type { get { return type; } set { type = value; } }

        public Cargo(int weight,string type)
        {
            this.weight = weight;
            this.type = type;
        }
    }
}
