using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethodString
{
    public class Data<T>
    {
        private List<T> data=new List<T>();


        public void Add(T item)
        {
            data.Add(item);
        }
        public void Swap(int firstIndex,int secondIndex)
        {
            T item = data[firstIndex];
            data[firstIndex] = data[secondIndex];
            data[secondIndex] = item;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var item in data)
            {
                result.Append($"{item.GetType().FullName}: {item}" + Environment.NewLine);
            }

            return result.ToString().TrimEnd();
        }
    }
}
