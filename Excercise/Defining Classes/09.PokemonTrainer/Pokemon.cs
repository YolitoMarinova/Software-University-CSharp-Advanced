using System;
using System.Collections.Generic;
using System.Text;

namespace _09.PokemonTrainer
{
    public class Pokemon
    {
        private string name;
        private string element;
        private int health;

        public string Name { get { return name; } set { name = value; } }
        public string Element { get { return element; } set { element = value; } }
        public int Health { get { return health; } set { health = value; } }

        public Pokemon(string name,string element, int health)
        {
            this.name = name;
            this.element = element;
            this.health = health;
        }
    }
}
