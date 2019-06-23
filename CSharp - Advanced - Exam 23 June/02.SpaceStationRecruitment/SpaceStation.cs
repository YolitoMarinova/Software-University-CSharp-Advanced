using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> astronauts;

        public string Name { get; set; }
        public int Capacity { get; set; }

        public int Count { get; private set; }

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Count = 0;
            astronauts = new List<Astronaut>();
            
        }

        public void Add(Astronaut astronaut)
        {
            if (Capacity > Count)
            {
                astronauts.Add(astronaut);
                this.Count++;
            }
        }

        public bool Remove(string name)
        {
            Astronaut astronautToRemove = astronauts.FirstOrDefault(x => x.Name == name);

            if (astronautToRemove != null)
            {
                astronauts.Remove(astronautToRemove);
                Count--;
                return true;
            }

            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            int maxAge = astronauts.Max(x => x.Age);

            Astronaut oldestAstronaut = astronauts.First(x => x.Age == maxAge);

            return oldestAstronaut;
        }

        public Astronaut GetAstronaut(string name)
        {
            Astronaut astronaut = astronauts.FirstOrDefault(x => x.Name == name);

            if (astronaut != null)
            {
                return astronaut;
            }

            return null;
        }

        

        public string Report()
        {
            return $"Astronauts working at Space Station {this.Name}:" +
                Environment.NewLine +
            (String.Join(Environment.NewLine, astronauts));
        }
    }
}
