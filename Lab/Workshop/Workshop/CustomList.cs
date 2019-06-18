using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop
{
    public class CustomList
    {
        private const int initialCapacity = 2;
        private int[] items;

        public CustomList()
        {
            items = new int[initialCapacity];
        }

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                return items[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                items[index] = value;
            }
        }

        private void Resize()
        {
            int[] copy = new int[items.Length * 2];

            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        public void Add(int value)
        {
            if (Count == items.Length)
            {
                Resize();
            }

            items[Count] = value;
            Count++;
        }

        public int RemoveAt(int index)
        {
            if (!IsValidIndex(index))
            {
                throw new ArgumentOutOfRangeException();
            }

            int removedElement = items[index];
            items[index] = default;

            ShiftToLeft(index);

            Count--;

            if (Count < (items.Length / 4))
            {
                Shrink();
            }

            return removedElement;
        }

        private void ShiftToLeft(int index)
        {
            for (int i = index; i < Count; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void ShiftToRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                items[i] = items[i - 1];
            }
        }

        private void Shrink()
        {
            int[] copy = new int[items.Length / 2];

            for (int i = 0; i < items.Length; i++)
            {
                copy[i] = items[i];
            }

            items = copy;
        }

        public void Insert(int index, int item)
        {
            if (!IsValidIndex(index))
            {
                throw new ArgumentOutOfRangeException();
            }

            if (Count == items.Length)
            {
                Resize();
            }

            ShiftToRight(index);

            items[index] = item;
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i] == element)
                {
                    return true;
                }
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (!IsValidIndex(firstIndex) ||
                !IsValidIndex(secondIndex))
            {
                throw new ArgumentOutOfRangeException();
            }

            int swapItem = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = items[firstIndex];
        }

        private bool IsValidIndex(int index)
        {
            return index < 0 && index >= Count;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var item in items)
            {
                result.AppendLine(item.ToString());
            }
            return result.ToString(); 
        }
    }
}
