using System;

namespace GenericScale
{
    public class StartUp
    {
        public static void Main()
        {
            EqualityScale<int> equalityScale = new EqualityScale<int>(5, 5);

            Console.WriteLine(equalityScale.AreEqual());
        }
    }
}
