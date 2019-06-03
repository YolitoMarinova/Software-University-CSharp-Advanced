using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>(input.Reverse());

            while (stack.Count > 1)
            {
                int operannda1 = int.Parse(stack.Pop());
                string @operator = stack.Pop();
                int operannda2 = int.Parse(stack.Pop());

                switch (@operator)
                {
                    case "+":
                        int result = operannda1 + operannda2;
                        stack.Push(result.ToString());
                        break;
                    case "-":
                        int resulttt = operannda1 - operannda2;
                        stack.Push(resulttt.ToString());
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(stack.Pop());
        }
    }
}
