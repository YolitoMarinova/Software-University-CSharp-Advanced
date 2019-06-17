using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TheGarden
{
    public class StartUp
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            char[][] garden = new char[rows][];
            garden = FillGardenWithVegetables(garden);


            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var countOfRemovedVegetables = new Dictionary<string, int>();
            countOfRemovedVegetables["carrots"] = 0;
            countOfRemovedVegetables["potatos"] = 0;
            countOfRemovedVegetables["lettuce"] = 0;
            countOfRemovedVegetables["harmed"] = 0;

            while (command[0] != "End")
            {
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);

                switch (command[0])
                {
                    case "Harvest":
                        Harvest(garden, row, col, countOfRemovedVegetables);
                        break;
                    case "Mole":
                        string direction = command[3];
                        Mole(garden, row, col, direction, countOfRemovedVegetables);
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            for (int row = 0; row < garden.GetLength(0); row++)
            {
                Console.WriteLine(string.Join(" ",garden[row]));
            }

            Console.WriteLine($"Carrots: {countOfRemovedVegetables["carrots"]}");
            Console.WriteLine($"Potatoes: {countOfRemovedVegetables["potatos"]}");
            Console.WriteLine($"Lettuce: {countOfRemovedVegetables["lettuce"]}");
            Console.WriteLine($"Harmed vegetables: {countOfRemovedVegetables["harmed"]}");
        }

        private static void Mole(char[][] garden, int row, int col, string direction, Dictionary<string, int> countOfRemovedVegetables)
        {

            while (IsValidIndex(garden, row, col))
            {
                if (char.IsLetter(garden[row][col]))
                {
                    garden[row][col] = ' ';
                    countOfRemovedVegetables["harmed"]++;
                }

                switch (direction)
                {
                    case "up":
                        row -= 2;
                        break;
                    case "down":
                        row += 2;
                        break;
                    case "left":
                        col -= 2;
                        break;
                    case "right":
                        col += 2;
                        break;
                }
            }
        }

        private static void Harvest(char[][] garden, int row, int col, Dictionary<string, int> countOfRemovedVegetables)
        {
            if (!IsValidIndex(garden, row, col))
            {
                return;
            }

            if (char.IsLetter(garden[row][col]))
            {
                switch (garden[row][col])
                {
                    case 'C':
                        countOfRemovedVegetables["carrots"]++;
                        break;
                    case 'P':
                        countOfRemovedVegetables["potatos"]++;
                        break;
                    case 'L':
                        countOfRemovedVegetables["lettuce"]++;
                        break;
                    default:
                        break;
                }

                garden[row][col] = ' ';
            }
        }

        private static bool IsValidIndex(char[][] garden, int row, int col)
        {
            return row >= 0 && row < garden.GetLength(0) && col >= 0 && col < garden[row].Length;
        }

        private static char[][] FillGardenWithVegetables(char[][] garden)
        {
            for (int row = 0; row < garden.GetLength(0); row++)
            {
                char[] vegetables = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                garden[row] = vegetables;
            }

            return garden;
        }
    }
}
