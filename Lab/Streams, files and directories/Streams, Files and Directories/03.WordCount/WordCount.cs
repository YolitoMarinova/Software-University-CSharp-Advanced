using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.WordCount
{
    class WordCount
    {
        private const string V = @"files\Output.txt";

        public static void Main()
        {
            using (var writer = new StreamWriter(@"files\Output.txt"))
            {
                var output = new Dictionary<string, int>();

                using (var wordsReader = new StreamReader(@"files\words.txt"))
                {
                    string[] words = wordsReader.ReadToEnd().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < words.Length; i++)
                    {
                        string currentWord = words[i];
                        output.Add(currentWord,0);

                        using (var textReader = new StreamReader(@"files\text.txt"))
                        {
                            string input = textReader.ReadToEnd().ToLower();
                            MatchCollection inputWords = Regex.Matches(input,@"\b\w\S*\b");

                            foreach (Match item in inputWords)
                            {
                                if (item.Value == currentWord)
                                {
                                    output[currentWord]++;
                                }
                            }
                        }
                    }
                }

                foreach (var kvp in output.OrderByDescending(v => v.Value))
                {
                    writer.WriteLine($"{kvp.Key} - {kvp.Value}");
                }
            }
        }
    }
}
