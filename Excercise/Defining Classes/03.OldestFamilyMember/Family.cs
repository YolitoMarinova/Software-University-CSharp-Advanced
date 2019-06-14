using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.OldestFamilyMember
{
    class Family
    {
        private List<Person> people=new List<Person>();

        public List<Person> People { get { return people; } set { people = value; } }

        public void AddMember(Person member)
        {
            people.Add(member);
        }

        public Person GetOldestMember()
        {
            int oldestPersonAge =people.Max(x => x.Age);

            return people.FirstOrDefault(x=>x.Age==oldestPersonAge);
        }
    }
}
