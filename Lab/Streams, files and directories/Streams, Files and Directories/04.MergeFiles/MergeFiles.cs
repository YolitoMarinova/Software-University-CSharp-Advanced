using System;
using System.IO;

namespace _04.MergeFiles
{
    class MergeFiles
    {
        public static void Main()
        {
            using (var firstReader=new StreamReader(@"files\FileOne.txt"))
            {
                string firstLine = firstReader.ReadLine();

                using (var secondReader=new StreamReader(@"files\FileTwo.txt"))
                {
                    string secondLine = secondReader.ReadLine();

                    using (var writer=new StreamWriter(@"files\Output.txt"))
                    {
                        while (firstLine != null && secondLine!=null)
                        {
                            if (firstLine != null)
                            {
                                writer.WriteLine(firstLine);
                            }

                            if (secondLine != null)
                            {
                                writer.WriteLine(secondLine);
                            }

                            firstLine = firstReader.ReadLine();
                            secondLine = secondReader.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
