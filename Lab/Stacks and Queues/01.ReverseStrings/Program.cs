using System;
using System.Collections;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack stack = new Stack();

            foreach (var symbol in input)
            {
                stack.Push(symbol);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
