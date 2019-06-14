using System;
using System.Collections.Generic;
using System.Text;

namespace _08.CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private string weight;
        private string color;

        public string Model { get { return model; } set { model = value; } }
        public Engine Engine { get { return engine; } set { engine = value; } }
        public string Weight { get { return weight; } set { weight = value; } }
        public string Color { get { return color; } set { color = value; } }

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
            weight = "n/a";
            color = "n/a";
        }
    }
}
