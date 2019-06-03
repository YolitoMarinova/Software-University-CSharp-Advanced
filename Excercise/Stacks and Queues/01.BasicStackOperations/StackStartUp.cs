using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class StackStartUp
    {
       public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int countOfElements = input[0];
            int popCount = input[1];
            int wantedElement = input[2];

            int[] arrayOfNumbers = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //FillStackWithNumbers
            Stack<int> elements = new Stack<int>();
            elements = FillWithElements(elements,arrayOfNumbers,countOfElements);

            //Delete elements
            elements=DeleteElements(elements,popCount);
            

            //Search element
            SearchingElement(elements,wantedElement);
           
        }

        public static Stack<int> FillWithElements(Stack<int> elements,int[] array,int countOfElements)
        {
            for (int i = 0; i < countOfElements; i++)
            {
                elements.Push(array[i]);
            }

            return elements;
        }

        public static Stack<int> DeleteElements(Stack<int> elements,int popCount)
        {
            for (int i = 1; i <= popCount; i++)
            {
                if (elements.Count > 0)
                {
                    elements.Pop();
                }
            }

            return elements;
        }

        public static void SearchingElement(Stack<int> elements, int wantedElement)
        {
            if (elements.Count > 0)
            {
                if (elements.Contains(wantedElement))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(elements.Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
