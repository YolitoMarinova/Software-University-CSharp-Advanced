using System;
using System.Collections.Generic;
using System.Text;

namespace _07.Tuple
{
   public class Tuple<T,V>
    {
        private T firstObject;
        private V secondObject;
               
        public Tuple(T item1,V item2)
        {
            firstObject = item1;
            secondObject = item2;
        }

        public override string ToString()
        {
            return $"{firstObject} -> {secondObject}";
        }
    }
}
