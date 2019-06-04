using System;
using System.IO;
using System.Linq;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        public static void Main()
        {
            string[] textLines=File.ReadAllLines("text.txt");

            int counter = 1;

            foreach (var currentLine in textLines)
            {
                int lettersCount = currentLine.Count(char.IsLetter);
                int punctuationsCount = currentLine.Count(char.IsPunctuation);

                File.AppendAllText("output.txt",$"Line {counter}: {currentLine} ({lettersCount})({punctuationsCount})" +
                    $"{Environment.NewLine}");

                counter++;
            }
        }
    }
}
