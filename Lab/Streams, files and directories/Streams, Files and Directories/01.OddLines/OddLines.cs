using System;
using System.IO;

namespace _01.OddLines
{
    class OddLines
    {
        public static void Main()
        {
            using (var reader = new StreamReader(@"files\Input.txt"))
            {
                int counter = 0;

                string line = reader.ReadLine();

                using (var writer=new StreamWriter(@"files\Output.txt"))
                {
                    while (line != null)
                    {
                        if (counter % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }

                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
