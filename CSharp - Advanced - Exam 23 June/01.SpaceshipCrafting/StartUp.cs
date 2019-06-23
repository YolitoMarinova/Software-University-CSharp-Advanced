using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SpaceshipCrafting
{
    public class StartUp
    {
        public static void Main()
        {
            int[] liquidsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] itemsInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> liquids = new Queue<int>(liquidsInput);
            Stack<int> items = new Stack<int>(itemsInput);

            int glassCount = 0;
            int aluminiumCount = 0;
            int lithiumCount = 0;
            int carbonFiberCount = 0;

            while (liquids.Count > 0 && items.Count > 0)
            {
                int currentLiquid = liquids.Dequeue();
                int currentItem = items.Pop();

                int sum = currentLiquid + currentItem;

                if (sum == 25)
                {
                    glassCount++;
                }
                else if (sum == 50)
                {
                    aluminiumCount++;
                }
                else if (sum == 75)
                {
                    lithiumCount++;
                }
                else if (sum == 100)
                {
                    carbonFiberCount++;
                }
                else
                {
                    currentItem += 3;
                    items.Push(currentItem);
                }
            }

            bool isSucsses = glassCount > 0 &&
                aluminiumCount > 0 &&
                lithiumCount > 0 &&
                carbonFiberCount > 0;

            if (isSucsses)
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {String.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (items.Count > 0)
            {
                Console.WriteLine($"Physical items left: {String.Join(", ", items)}");
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            Console.WriteLine($"Aluminium: {aluminiumCount}\nCarbon fiber: {carbonFiberCount}\nGlass: {glassCount}\nLithium: {lithiumCount}");
        }
    }
}
