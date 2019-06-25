using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
   public class StartUp
    {
       public static void Main()
        {
            List<string> createCommand = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Skip(1)
                .ToList();

            ListyIterator<string> listyIterator = new ListyIterator<string>(createCommand);

            string command = Console.ReadLine();

            while (command!="END")
            {
                switch (command)
                {
                    case "Move":
                        Console.WriteLine(listyIterator.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listyIterator.HasNext());
                        break;
                    case "Print":
                        listyIterator.Print();
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
