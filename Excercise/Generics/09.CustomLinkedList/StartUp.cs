using System;

namespace _09.CustomLinkedList
{
   public class StartUp
    {
       public static void Main()
        {
            var doublyLinkedList = new DoublyLinkedList<string>();

            doublyLinkedList.AddFirst("string");
            doublyLinkedList.AddFirst("string");
            doublyLinkedList.AddFirst("string");

            doublyLinkedList.Print(Console.WriteLine);
            Console.WriteLine(doublyLinkedList.Contains("string"));
        }
    }
}
