using System;

namespace Workshop
{
   public class StartUp
    {
       public static void Main()
        {
            CustomList customList = new CustomList();

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);

            Console.WriteLine(customList.Count);
            Console.WriteLine(customList.RemoveAt(2));
            Console.WriteLine(customList.Count);

            customList.Insert(3,7);

            Console.WriteLine(customList.Contains(15));

        }
    }
}
