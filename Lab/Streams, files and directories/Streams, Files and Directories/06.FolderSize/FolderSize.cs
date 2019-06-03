using System;
using System.IO;
using System.Reflection;

namespace _06.FolderSize
{
    class FolderSize
    {
        public static void Main()
        {
            string[] files = Directory.GetFiles(@"files\TestFolder");

            double sum = 0;

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }

            sum = sum / 1024 / 1024;

            File.WriteAllText(@"files\output.txt", sum.ToString());
        }
    }
}
