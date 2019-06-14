using System;

namespace _05.DateModifier
{
    public class StartUp
    {
        public static void Main()
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            var diffrence = new DateModifier(firstDate, secondDate);

            Console.WriteLine(diffrence.DateDiffrence);
        }
    }
}
