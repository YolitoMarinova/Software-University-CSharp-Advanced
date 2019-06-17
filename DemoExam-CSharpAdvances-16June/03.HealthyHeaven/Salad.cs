using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    public class Salad
    {
        private string name;
        private List<Vegetable> products;

        public string Name { get { return name; } set { name = value; } }
        //public List<Vegetable> Products { get { return products; } set { products = value; } }

        public Salad(string name)
        {
            this.name = name;
            products = new List<Vegetable>();
        }

        public int GetTotalCalories()
        {
            int sum = products.Sum(x => x.Calories);

            return sum;
        }

        public int GetProductCount()
        {
            return products.Count;
        }

        public void Add(Vegetable product)
        {
            products.Add(product);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append($"* Salad {name} is {GetTotalCalories()} calories and have {GetProductCount()} products:");

            foreach (var product in products)
            {
                result.Append(Environment.NewLine+ product.ToString());
            }

            return result.ToString();
        }
    }
}
