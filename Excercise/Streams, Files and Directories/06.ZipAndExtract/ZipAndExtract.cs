using System;
using System.IO;
using System.IO.Compression;

namespace _06.ZipAndExtract
{
    class ZipAndExtract
    {
        public static void Main()
        {
            string zipFile = @"..\..\..\myZipImage.zip";
            string fileToZip = "copyMe.png";

            using (var archive=ZipFile.Open(zipFile,ZipArchiveMode.Create))
            {
                archive.CreateEntryFromFile(fileToZip,Path.GetFileName(zipFile));
            }
        }
    }
}
