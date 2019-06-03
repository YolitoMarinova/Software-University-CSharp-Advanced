using System;
using System.Linq;

namespace _06.BombTheBasement
{
    class StartUp
    {
        public static object Select { get; private set; }

        public static void Main()
        {
            int[] parameters=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[,] matrix = new int[parameters[0], parameters[1]];

            int[] coordinates= Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int targetRow = coordinates[0];
            int targetCol = coordinates[1];
            int radius = coordinates[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    bool isInRadius = Math.Pow(row - targetRow, 2) + Math.Pow(col - targetCol, 2) <= Math.Pow(radius, 2);

                    if (isInRadius)
                    {
                        matrix[row, col] = 1;
                    }
                }
            }

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int count = 0;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    if (matrix[row, col] == 1)
                    {
                        count++;
                        matrix[row, col] = 0;
                    }
                }

                if (count > 0)
                {
                    for (int i = 0; i < count; i++)
                    {
                        matrix[i, col] = 1;
                    }
                }

            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }

                Console.WriteLine();
            }
        }
    }
}
