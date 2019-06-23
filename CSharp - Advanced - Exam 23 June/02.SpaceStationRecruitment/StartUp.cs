using System;

namespace SpaceStationRecruitment
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SpaceStation spaceStation = new SpaceStation("Apolo",10);

            Astronaut firstAstronaut = new Astronaut("Stephen",40,"Bulgaria");

            Console.WriteLine(firstAstronaut);

            spaceStation.Add(firstAstronaut);

            Astronaut secondAstronaut = new Astronaut("John",50,"America");

            spaceStation.Add(secondAstronaut);

            Console.WriteLine(spaceStation.GetOldestAstronaut());

            Console.WriteLine(spaceStation.GetAstronaut("John"));

            Console.WriteLine(spaceStation.Count);

            Console.WriteLine(spaceStation.Report());
        }
    }
}
