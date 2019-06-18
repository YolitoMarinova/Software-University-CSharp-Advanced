using System;
using System.Collections.Generic;
using System.Text;

namespace _01.GenericBoxOfString
{
    public class Box<T>
    {
        private T data;

        public Box(T input)
        {
            data =input;
        }

        public override string ToString()
        {
            return $"{data.GetType()}: {data}";
        }
    }
}
