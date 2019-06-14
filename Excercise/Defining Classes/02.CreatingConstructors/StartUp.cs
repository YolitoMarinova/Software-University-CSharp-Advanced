using System;

namespace _02.CreatingConstructors
{
   public class StartUp
    {
       public static void Main()
        {
            Person person = new Person("Yoana", 21);

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}
