using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private List<T> stack;

        public Stack()
        {
           this.stack = new List<T>();
        }

        public void Push(params T[] items)
        {
            foreach (var item in items)
            {
                stack.Add(item);
            }
        }

        public void Pop()
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("No elements");
            }

            T currentItem = stack.LastOrDefault();
            stack.Remove(currentItem);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = stack.Count - 1; i >= 0; i--)
            {
                
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
