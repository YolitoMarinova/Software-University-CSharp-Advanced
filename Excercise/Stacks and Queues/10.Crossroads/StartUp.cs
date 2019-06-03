using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
    class Program
    {
       public static void Main()
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindowSeconds = int.Parse(Console.ReadLine());

            Queue<string> queueOfCars = new Queue<string>();

            int countOfCrossCars = 0;

            string input = Console.ReadLine();

            while (input != "END")
            {
                if (input != "green")
                {
                    queueOfCars.Enqueue(input);
                    input = Console.ReadLine();
                    continue;
                }


                int currentGreenLightSeconds = greenLightSeconds;

                while (queueOfCars.Count>0)
                {
                    string carName = queueOfCars.Peek();
                    int carLenght = carName.Length;

                    if (currentGreenLightSeconds - carLenght > 0)
                    {
                        currentGreenLightSeconds -= carLenght;
                        queueOfCars.Dequeue();
                        countOfCrossCars++;
                    }
                    else if (currentGreenLightSeconds - carLenght == 0)
                    {
                        queueOfCars.Dequeue();
                        countOfCrossCars++;
                        break;
                    }
                    else if (currentGreenLightSeconds - carLenght < 0)
                    {
                        currentGreenLightSeconds += freeWindowSeconds;
                        if (currentGreenLightSeconds - carLenght >= 0)
                        {
                            queueOfCars.Dequeue();
                            countOfCrossCars++;
                            break;
                        }
                        else if (currentGreenLightSeconds - carLenght < 0)
                        {
                            int crashIndex = currentGreenLightSeconds;

                            Console.WriteLine("A crash happened!");
                            Console.WriteLine($"{carName} was hit at {carName[crashIndex]}.");
                            return;
                        }
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{countOfCrossCars} total cars passed the crossroads.");
        }
    }
}
