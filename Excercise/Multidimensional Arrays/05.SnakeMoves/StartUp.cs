using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class StartUp
    {
        public static void Main()
        {
            int[] matrixParameters = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[matrixParameters[0],matrixParameters[1]];

            string snake = Console.ReadLine();

            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (counter >= snake.Length)
                    {
                        counter = 0;
                    }

                    matrix[row, col] = snake[counter++];
                }

            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]}");
                }

                Console.WriteLine();
            }
        }
    }
}
