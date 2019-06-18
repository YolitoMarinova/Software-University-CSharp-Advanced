using System;
using System.Collections.Generic;
using System.Text;

namespace _08.Threeuple
{
   public class Threeuple<T,V,W>
    {
        private T firstObject;
        private V secondObject;
        private W thirdObject;
               
        public Threeuple(T item1,V item2,W item3)
        {
            firstObject = item1;
            secondObject = item2;
            thirdObject = item3;
        }

        public override string ToString()
        {
            return $"{firstObject} -> {secondObject} -> {thirdObject}";
        }
    }
}
