using System;
using System.IO;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        public static void Main()
        {
            var reader = new StreamReader(@"files\Input.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                int index = 1;

                using (var writer=new StreamWriter(@"files\Output.txt"))
                {
                    while (line!=null)
                    {
                        writer.WriteLine($"{index}. {line}");
                        index++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
