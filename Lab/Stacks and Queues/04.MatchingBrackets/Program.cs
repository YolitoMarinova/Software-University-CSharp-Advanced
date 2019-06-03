using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Stack<int> index = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    index.Push(i);
                }
                else if (input[i]==')')
                {
                    int startIndex = index.Pop();
                    int lenght = i-startIndex+1;

                    Console.WriteLine(input.Substring(startIndex,lenght));
                }
            }
        }
    }
}
