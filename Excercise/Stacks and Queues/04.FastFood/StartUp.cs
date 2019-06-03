using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class StartUp
    {
       public static void Main()
        {
            int availableFood = int.Parse(Console.ReadLine());
            int[] ordersQuantities = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> orders = new Queue<int>(ordersQuantities);

            Console.WriteLine(orders.Max());

            bool isEnoughFood = true;

            while (availableFood > 0 && orders.Count>0 && isEnoughFood)
            {
                int currentOrder = orders.Peek();

                if (availableFood >= currentOrder)
                {
                    availableFood -= currentOrder;
                    orders.Dequeue();
                }
                else
                {
                    isEnoughFood = false;
                }
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else if (orders.Count > 0)
            {
                Console.WriteLine($"Orders left: {String.Join(" ",orders)}");
            }
        }
    }
}
