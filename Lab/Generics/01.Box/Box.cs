using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        public List<T> TheBox { get; set; }
        public int Count { get { return TheBox.Count; } }

        public Box()
        {
            TheBox = new List<T>();
        }
        public void Add(T element)
        {
            TheBox.Add(element);
        }

        public T Remove()
        {
            T lastElement = TheBox.Last();

            TheBox.RemoveAt(TheBox.Count-1);

            return lastElement;
        }
    }
}
