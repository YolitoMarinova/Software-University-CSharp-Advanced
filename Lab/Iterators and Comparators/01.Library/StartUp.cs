 using System;

namespace IteratorsAndComparators
{
   public class StartUp
    {
       public static void Main()
        {
            Book firstBook = new Book("Proizhod",2018,"Daun Brown");
            Book secondBook = new Book("To", 2018, "Steaven King");
            Book thirdBook = new Book("The Secret", 2018, "Random");

            Library firstLibrary = new Library();
            Library secondLibrary = new Library(firstBook,secondBook,thirdBook);

            foreach (var book in secondLibrary)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine(secondBook.CompareTo(secondBook));
        }
    }
}
