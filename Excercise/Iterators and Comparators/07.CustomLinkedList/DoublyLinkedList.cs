using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _09.CustomLinkedList
{
    public class DoublyLinkedList<T> : IEnumerable<T>
         where T: IComparable<T>
    {
        private class LinkNode
        {
            public LinkNode(T value)
            {
                this.Value = value;
            }
            public T Value { get; }
            public LinkNode NextNode { get; set; }
            public LinkNode PreviousNode { get; set; }

        }

        private LinkNode head;
        private LinkNode tail;

        public int Count { get; private set; }

        public void AddFirst(T value)
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

        public void AddLast(T value)
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

        public void Print(Action<T> action)
        {
            LinkNode currentNode = this.head;

            while (currentNode != null)
            {
                action(currentNode.Value);

                currentNode = currentNode.NextNode;
            }
        }

        public T RemoveFirst()
        {
            if (this.Count ==0)
            {
                throw new InvalidOperationException("DoublyLinkedList is empty!");
            }

            T firstElement = this.head.Value;
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

        public T RemoveLast()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("DoublyLinkedList is empty!");
            }

            T lastElement = this.tail.Value;
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

        public T[] ToArray()
        {
            T[] array = new T[this.Count];
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

        public List<T> ToList()
        {
            List<T> list = new List<T>();

            LinkNode currentNode = this.head;

            while (currentNode != null)
            {
                list.Add(currentNode.Value);
                currentNode = currentNode.NextNode;
            }

            return list;
        }

        public bool Contains(T value)
        {
            LinkNode currentnode = this.head;

            while (currentnode!=null)
            {
                if (currentnode.Value.CompareTo(value)==0)
                {
                    return true;
                }

                currentnode = currentnode.NextNode;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkNode linkNode = this.head;

            while (head!=null)
            {
                yield return linkNode.Value;

                linkNode = linkNode.NextNode;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
