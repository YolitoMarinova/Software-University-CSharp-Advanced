using System;
using System.IO;
using System.Linq;

namespace _01.EvenLines
{
    class EvenLines
    {
        public static void Main()
        {
            using (var reader = new StreamReader(@"text.txt"))
            {
                while (true)
                {
                    string line = reader.ReadLine();

                    if (line == null) break;

                    line = ReplaceSymbols(line);
                    string[] reverseWords = line.Split().Reverse().ToArray();
                    Console.Write(String.Join(" ", reverseWords));
                    Console.WriteLine();

                    line = reader.ReadLine();
                }
            }
        }

        private static string ReplaceSymbols(string line)
        {
            return line.Replace("-", "@")
                .Replace(",", "@")
                .Replace(".", "@")
                .Replace("!", "@")
                .Replace("?", "@");
        }
    }
}
