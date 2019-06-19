using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop
{
    public class DoublyLinkedList
    {
        private class LinkNode
        {
            public int Value { get; }
            public LinkNode NextNode { get; set; }
            public LinkNode PreviousNode { get; set; }

            public LinkNode(int value)
            {
                this.Value = value;
            }
        }

        private LinkNode head;
        private LinkNode tail;

        public int Count { get; private set; }

        public void AddFirst(int value)
        {
            LinkNode newHead = new LinkNode(value);

            if (this.Count == 0)
            {
                this.tail = this.head = newHead;
            }
            else
            {
                newHead.NextNode = this.head;
                this.head.PreviousNode = newHead;
                this.head = newHead;
            }

            this.Count++;
        }

        public void AddLast(int value)
        {
            LinkNode newTail = new LinkNode(value);

            if (this.Count == 0)
            {
                this.head = this.tail = newTail;
            }
            else
            {
                newTail.PreviousNode = this.tail;
                this.tail.NextNode = newTail;
                this.tail = newTail;
            }

            this.Count++;
        }

        public void Print(Action<int> action)
        {
            LinkNode currentNode = this.head;

            while (currentNode != null)
            {
                action(currentNode.Value);

                currentNode = currentNode.NextNode;
            }
        }

        public int RemoveFirst()
        {
            if (this.Count ==0)
            {
                throw new InvalidOperationException("DoublyLinkedList is empty!");
            }

            int firstElement = this.head.Value;
            this.head = this.head.NextNode;

            if (this.head == null)
            {
                this.tail = null;
            }
            else
            {
                this.head.PreviousNode = null;
            }

            this.Count--;
            return firstElement;
        }

        public int RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("DoublyLinkedList is empty!");
            }

            int lastElement = this.tail.Value;
            this.tail = this.tail.PreviousNode;

            if (this.tail == null)
            {
                this.head = null;
            }
            else
            {
                this.tail.NextNode = null;
            }

            this.Count--;
            return lastElement;
        }

        public int[] ToArray()
        {
            int[] array = new int[this.Count];
            int index = 0;

            LinkNode currentNode = this.head;

            while(currentNode!=null)
            {
                array[index] = currentNode.Value;
                currentNode = currentNode.NextNode;
                index++;
            }

            return array;
        }

        public List<int> ToList()
        {
            List<int> list = new List<int>();

            LinkNode currentNode = this.head;

            while (currentNode != null)
            {
                list.Add(currentNode.Value);
                currentNode = currentNode.NextNode;
            }

            return list;
        }

        public bool Contains(int value)
        {
            LinkNode currentnode = this.head;

            while (currentnode!=null)
            {
                if (currentnode.Value == value)
                {
                    return true;
                }

                currentnode = currentnode.NextNode;
            }

            return false;
        }
    }
}
