using System;
using System.Collections.Generic;
using System.Text;

namespace HealthyHeaven
{
   public class Vegetable
    {
        private string name;
        private int calories;

        public string Name { get { return name; } set { name = value; } }
        public int Calories { get { return calories; } set { calories = value; } }

        public Vegetable(string name,int calories)
        {
            this.name = name;
            this.calories = calories;
        }

        public override string ToString()
        {
            return $" - {name} have {calories} calories";
        }
    }
}
