using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SpaceStationEstablishment
{
    public class StartUp
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            char[,] galaxy = new char[rows, rows];
            FillTheGalaxy(galaxy);

            int[] stevenPosition = FindStevenPosition(galaxy);
            List<int[]> blackHolesPosition = FindBlackHolesPosition(galaxy);

            int starsPower = 0;


            while (true)
            {
                string currentCommand = Console.ReadLine();

                if (currentCommand == "left")
                {
                    stevenPosition[1] -= 1;
                }
                else if (currentCommand == "right")
                {
                    stevenPosition[1] += 1;
                }
                else if (currentCommand == "up")
                {
                    stevenPosition[0] -= 1;
                }
                else if (currentCommand == "down")
                {
                    stevenPosition[0] += 1;
                }

                if (IsOutOfGalaxy(stevenPosition, galaxy) == true)
                {
                    Console.WriteLine("Bad news, the spaceship went to the void.");
                    Console.WriteLine($"Star power collected: {starsPower}");
                    PrintGalaxyMatrix(galaxy);
                    return;
                }

                int stevenRow = stevenPosition[0];
                int stevenCol = stevenPosition[1];

                if (char.IsDigit(galaxy[stevenRow, stevenCol]))
                {
                    starsPower +=(int)char.GetNumericValue(galaxy[stevenRow,stevenCol]);
                    galaxy[stevenRow, stevenCol] = '-';
                }

                if (starsPower >= 50)
                {
                    Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                    Console.WriteLine($"Star power collected: {starsPower}");
                    galaxy[stevenRow, stevenCol] = 'S';
                    PrintGalaxyMatrix(galaxy);
                    return;
                }

                if (blackHolesPosition.Count > 0)
                {
                    int firstHoleRow = blackHolesPosition[0][0];
                    int firstHoleCol = blackHolesPosition[0][1];

                    int secondHoleRow = blackHolesPosition[1][0];
                    int secondHoleCol = blackHolesPosition[1][1];

                    if (stevenRow == firstHoleRow &&
                        stevenCol == firstHoleCol)
                    {
                        stevenPosition[0] = secondHoleRow;
                        stevenPosition[1] = secondHoleCol;

                        blackHolesPosition.Clear();
                    }
                    else if (stevenRow == secondHoleRow &&
                        stevenCol == secondHoleCol)
                    {
                        stevenPosition[0] = firstHoleRow;
                        stevenPosition[1] = firstHoleCol;

                        blackHolesPosition.Clear();
                    }
                }


            }
        }

        private static void PrintGalaxyMatrix(char[,] galaxy)
        {
            for (int row = 0; row < galaxy.GetLength(0); row++)
            {
                for (int col = 0; col < galaxy.GetLength(1); col++)
                {
                    Console.Write(galaxy[row, col]);
                }

                Console.WriteLine();
            }
        }

        private static bool IsOutOfGalaxy(int[] stevenPosition, char[,] galaxy)
        {
            int row = stevenPosition[0];
            int col = stevenPosition[1];

            return row < 0 || row >= galaxy.GetLength(0) || col < 0 || col >= galaxy.GetLength(1);
        }

        private static List<int[]> FindBlackHolesPosition(char[,] galaxy)
        {
            List<int[]> positions = new List<int[]>();

            for (int row = 0; row < galaxy.GetLength(0); row++)
            {
                for (int col = 0; col < galaxy.GetLength(1); col++)
                {
                    if (galaxy[row, col] == 'O')
                    {
                        int[] positon = new int[] { row, col };
                        positions.Add(positon);
                        galaxy[row, col] = '-';
                    }
                }
            }

            return positions;
        }

        private static int[] FindStevenPosition(char[,] galaxy)
        {
            int stevenRow = -1;
            int StevenCol = -1;

            for (int row = 0; row < galaxy.GetLength(0); row++)
            {
                for (int col = 0; col < galaxy.GetLength(1); col++)
                {
                    if (galaxy[row, col] == 'S')
                    {
                        stevenRow = row;
                        StevenCol = col;

                        galaxy[row, col] = '-';
                    }
                }
            }

            return new[] { stevenRow, StevenCol };
        }

        private static void FillTheGalaxy(char[,] galaxy)
        {
            for (int row = 0; row < galaxy.GetLength(0); row++)
            {
                string currentCol = Console.ReadLine();

                for (int col = 0; col < galaxy.GetLength(1); col++)
                {
                    galaxy[row, col] = currentCol[col];
                }
            }
        }
    }
}
