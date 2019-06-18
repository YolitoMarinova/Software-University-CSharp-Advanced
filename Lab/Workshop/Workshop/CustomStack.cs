using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop
{
   public class CustomStack
    {
        private const int initialCapacity = 4;
        private int[] items;
        private int count;

        public CustomStack()
        {
            count = 0;
            items = new int[initialCapacity];
        }

        public int Count { get {return count; } private set { count = value; } }

        private void Resize()
        {
            int[] copy = new int[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        public void Push(int element)
        {
            if (Count == items.Length)
            {
                Resize();
            }

            items[Count]=element;
            Count++;
        }

        public int Pop()
        {
            if (items.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            int lastElement = items[Count - 1];
            items[Count - 1] = default;
            count--;

            return lastElement;
        }

        public int Peek()
        {
            if (items.Length == 0)
            {
                throw new InvalidOperationException("CustomStack is empty");
            }

            int lastElement = items[Count - 1];

            return lastElement;
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < Count; i++)
            {
                action(items[i]);
            }
        }
    }
}
