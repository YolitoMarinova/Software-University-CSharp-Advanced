using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParenthesis
{
    class StartUp
    {
        public static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();

            Stack<char> stackOfParenteses = new Stack<char>();

            char[] openParenteses = new char[] {'(','{','[' };

            bool isValid = true;

            foreach (char parentes in input)
            {
                if (openParenteses.Contains(parentes))
                {
                    stackOfParenteses.Push(parentes);
                }

                if (stackOfParenteses.Count > 0)
                {
                    if (stackOfParenteses.Peek() == '(' && parentes == ')')
                    {
                        stackOfParenteses.Pop();
                    }
                    else if (stackOfParenteses.Peek() == '{' && parentes == '}')
                    {
                        stackOfParenteses.Pop();
                    }
                    else if (stackOfParenteses.Peek() == '[' && parentes == ']')
                    {
                        stackOfParenteses.Pop();
                    }
                }
                else
                {
                    isValid = false;
                    break;
                }
                    
            }

            if (stackOfParenteses.Count > 0)
            {
                isValid = false;
            }

            if (!isValid)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
