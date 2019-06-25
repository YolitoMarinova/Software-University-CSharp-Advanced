using System;
using System.Linq;

namespace _03.Stack
{
    public class StartUp
    {
        public static void Main()
        {
            Stack<int> stack = new Stack<int>();

            string[] command = Console.ReadLine()
                 .Split(new char[] { ' ',','},StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Push":
                        int[] array = command
                            .Skip(1)
                            .Select(int.Parse)
                            .ToArray();

                        stack.Push(array);
                        break;
                    case "Pop":
                       stack.Pop();
                        break;
                }

                command = Console.ReadLine()
                 .Split(new char[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
