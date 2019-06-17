using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _02.MakeASalad
{
    public class Program
    {
        public static void Main()
        {
            string[] vegetablesInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Queue<Dictionary<string, int>> vegetables = new Queue<Dictionary<string, int>>();

            foreach (var vegetable in vegetablesInput)
            {
                if (vegetable == "tomato")
                {
                    Dictionary<string, int> currentProduct = new Dictionary<string, int>();
                    currentProduct.Add("tomato", 80);

                    vegetables.Enqueue(currentProduct);
                }
                else if (vegetable == "carrot")
                {
                    Dictionary<string, int> currentProduct = new Dictionary<string, int>();
                    currentProduct.Add("carrot", 136);

                    vegetables.Enqueue(currentProduct);
                }
                else if (vegetable == "lettuce")
                {
                    Dictionary<string, int> currentProduct = new Dictionary<string, int>();
                    currentProduct.Add("lettuce", 109);

                    vegetables.Enqueue(currentProduct);
                }
                else if (vegetable == "potato")
                {
                    Dictionary<string, int> currentProduct = new Dictionary<string, int>();
                    currentProduct.Add("potato", 215);

                    vegetables.Enqueue(currentProduct);
                }
            }


            int[] caloriesInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> calories = new Stack<int>(caloriesInput);

            Queue<int> madedSalads = new Queue<int>();

            while (calories.Count > 0)
            {
                int currentCalories = calories.Peek();

                while (currentCalories > 0 && vegetables.Count > 0)
                {
                    var curretnvegetable = vegetables.Dequeue();
                    int vegetableValue = curretnvegetable.Values.Sum();

                    currentCalories -= vegetableValue;
                }

                int calcal = calories.Peek();

                if (currentCalories <= 0 || (calcal>currentCalories && vegetables.Count==0))
                {
                    madedSalads.Enqueue(calories.Pop());
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", madedSalads));

            if (calories.Count > 0)
            {
                Console.WriteLine(String.Join(" ", calories));
            }

            foreach (var item in vegetables)
            {
                Console.Write(String.Join(" ", item.Keys) + " ");
            }
        }
    }
}
