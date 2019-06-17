using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
   public class Restaurant
    {
        private string name;
        private List<Salad> salads;

        public string Name { get { return name; } set { name = value; } }
        public List<Salad> Salads { get { return salads; } set { salads = value; } }

        public Restaurant(string name)
        {
            this.name = name;
            salads = new List<Salad>();
        }

        public void Add(Salad salad)
        {
            salads.Add(salad);
        }

        public bool Buy(string name)
        {

            if (!salads.Any(x=>x.Name==name))
            {
                return false;
            }

            salads.Remove(salads.First(x=>x.Name==name));
            return true;
        }

        public Salad GetHealthiestSalad()
        {
            if (salads.Count > 0)
            {
                int minCalories = int.MaxValue;

                foreach (var salad in salads)
                {
                    int currentCalories = salad.GetTotalCalories();

                    if (currentCalories < minCalories)
                    {
                        minCalories = currentCalories;
                    }
                }

                Salad healthiestSalad = salads.First(x => x.GetTotalCalories() == minCalories);

                return healthiestSalad;
            }

            return null;
        }

        public string GenerateMenu()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"{name} have {salads.Count} salads:");

            foreach (var salad in salads)
            {
                result.Append(Environment.NewLine + salad.ToString());
            }

            return result.ToString();
        }
    }
}
