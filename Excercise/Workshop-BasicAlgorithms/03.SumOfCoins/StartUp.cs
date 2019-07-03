using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SumOfCoins
{
    public class StartUp
    {
        public static void Main()
        {
            int[] coins = Console.ReadLine()
                .Split(new char[] { ',',' '}, StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .ToArray();

            string sumInput = Console.ReadLine();
            int sum = int.Parse(sumInput.Substring(4));

            Dictionary<int, int> neededCoins = new Dictionary<int, int>();

            int index = 0;

            while (sum != 0)
            {
                if (index == coins.Length)
                {
                    break;
                }

                int currentCoin = coins[index];

                if (sum - currentCoin < 0)
                {
                    index++;
                    continue;
                }

                sum -= currentCoin;

                if (!neededCoins.ContainsKey(currentCoin))
                {
                    neededCoins[currentCoin] = 0;
                }

                neededCoins[currentCoin]++;
            }

            if (sum > 0)
            {
                Console.WriteLine("Error");
                return;
            }

            Console.WriteLine($"Number of coins to take: {neededCoins.Values.Sum()}");

            foreach (var coin in neededCoins)
            {
                Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
            }
        }
    }
}
