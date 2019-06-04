using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class WordCount
    {
        public static void Main()
        {
            string text = File.ReadAllText("text.txt");
            string[] words = File.ReadAllLines("words.txt");

            Dictionary<string, int> results = new Dictionary<string, int>();

            using (var writer = new StreamWriter("actualResult.txt"))
            {
                string[] lineContent = text.ToLower().Split(new char[] { ' ', ',', '.', '!', '?', '-', ':', ';', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var word in words)
                {
                    int count = lineContent.Count(x=>x==word);
                    results.Add(word,count);
                    writer.WriteLine($"{word} - {count}");
                }
            }

            using (var writer = new StreamWriter("expectedResult.txt"))
            {
                foreach (var (key,value) in results.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{key} - {value}");
                }
            }
        }
    }
}
