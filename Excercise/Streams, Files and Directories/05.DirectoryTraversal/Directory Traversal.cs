using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05.DirectoryTraversal
{
    class DirectoryTraversal
    {
        public static void Main()
        {
            var dirInfo = new Dictionary<string, Dictionary<string, double>>();

            DirectoryInfo filesInfo = new DirectoryInfo(".");

            FileInfo[] allFiles = filesInfo.GetFiles();

            foreach (FileInfo file in allFiles)
            {
                double size = Math.Round((file.Length / 1024d), 3);
                string fileName = file.Name;
                string extension = file.Extension;

                if (!dirInfo.ContainsKey(extension))
                {
                    dirInfo.Add(extension, new Dictionary<string, double>());
                }

                dirInfo[extension].Add(fileName, size);
            }

                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"/report.txt";

            var sortedDirInfo = dirInfo
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x=>x.Key,v=>v.Value);

            foreach (var (extension, value) in sortedDirInfo)
            {
                File.AppendAllText(path,extension+Environment.NewLine);

                foreach (var (fileName, size) in value.OrderBy(x => x.Value))
                {
                    File.AppendAllText(path,$"--{fileName} - {size}kb" + Environment.NewLine);
                }
            }
        }
    }
}
