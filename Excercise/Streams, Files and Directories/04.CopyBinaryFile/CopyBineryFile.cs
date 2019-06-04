using System;
using System.IO;

namespace _04.CopyBinaryFile
{
    class CopyBineryFile
    {
        public static void Main()
        {
            string picPath = "copyMe.png";
            string picCopyPath = "copyMe-copy.png";

            using (FileStream reader=new FileStream(picPath,FileMode.Open))
            {
                using (FileStream writer=new FileStream(picCopyPath,FileMode.Create))
                {
                    while (true)
                    {
                        byte[] byteArray = new byte[5000];

                        int size = reader.Read(byteArray, 0, byteArray.Length);

                        if (size == 0) break;

                        writer.Write(byteArray,0,size);
                    }
                }
            }
        }
    }
}
