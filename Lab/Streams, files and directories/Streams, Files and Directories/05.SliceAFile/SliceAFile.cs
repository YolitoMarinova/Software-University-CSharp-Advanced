using System;
using System.Collections.Generic;
using System.IO;

namespace _05.SliceAFile
{
    class SliceAFile
    {
        public static void Main()
        {
            string destination = "files\\";
            string sourceFile = @"files\sliceMe.txt";
            int parts = 4;

            List<string> files = new List<string> { "Part-1.txt", "Part-2.txt", "Part-3.txt", "Part-4.txt" };

            using (var fileReader=new FileStream(sourceFile,FileMode.Open))
            {
                long pieceSize = (long)Math.Ceiling((double)fileReader.Length/parts);

                for (int i = 0; i < parts; i++)
                {
                    long currentPieceSize = 0;

                    using (var streamWriter=new FileStream((destination+files[i]),FileMode.Create))
                    {
                        byte[] buffer = new byte[4096];

                        while (fileReader.Read(buffer,0,buffer.Length)==buffer.Length)
                        {
                            currentPieceSize += buffer.Length;
                            streamWriter.Write(buffer, 0, buffer.Length);

                            if (currentPieceSize>=pieceSize)
                            {
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
