using System;
using System.Linq;

namespace _04.SymbolInMatrix
{
    class StartUp
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            char[,] squareMatrix = new char[size, size];

            //Fill matrix
            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    squareMatrix[row, col] = input[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    if (squareMatrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
