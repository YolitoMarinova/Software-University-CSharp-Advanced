using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.PokemonTrainer
{
    public class Trainer
    {
        private string name;
        private int badges=0;
        private List<Pokemon> pokemons = new List<Pokemon>();

        public string Name { get { return name; } set { name = value; } }
        public int Badges { get { return badges; } set { badges = value; } }
        public List<Pokemon> Pokemons { get { return pokemons; } set { pokemons = value; } }

        public Trainer Where { get; internal set; }

        public Trainer(string name)
        {
            this.name = name;
        }

        public void Action(string element)
        {
            if (pokemons.Any(x => x.Element == element))
            {
                badges++;
            }
            else
            {
                pokemons.ForEach(x => x.Health -= 10);
                pokemons = pokemons.Where(x => x.Health > 0).ToList();
            }
        }
    }
}
