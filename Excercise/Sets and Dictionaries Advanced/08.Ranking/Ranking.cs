using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Ranking
    {
        public static void Main()
        {
            var contests = new Dictionary<string, string>();

            string[] contestInput = Console.ReadLine()
                .Split(":", StringSplitOptions.RemoveEmptyEntries);

            while (contestInput[0] != "end of contests")
            {
                string name = contestInput[0];
                string password = contestInput[1];

                contests[name] = password;

                contestInput = Console.ReadLine()
               .Split(":", StringSplitOptions.RemoveEmptyEntries);
            }

            var students = new Dictionary<string, Dictionary<string, int>>();

            string[] studentsInput = Console.ReadLine().Split("=>");

            while (studentsInput[0] != "end of submissions")
            {
                string contestName = studentsInput[0];
                string contestPass = studentsInput[1];
                string studentName = studentsInput[2];
                int points = int.Parse(studentsInput[3]);

                if (!contests.ContainsKey(contestName) ||
                    contests[contestName] != contestPass)
                {
                    studentsInput = Console.ReadLine().Split("=>");
                    continue;
                }

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new Dictionary<string, int>());
                }

                if (!students[studentName].ContainsKey(contestName))
                {
                    students[studentName].Add(contestName, points);
                }
                else if (students[studentName].ContainsKey(contestName))
                {
                    if (students[studentName][contestName] < points)
                    {
                        students[studentName][contestName] = points;
                    }
                }

                studentsInput = Console.ReadLine().Split("=>");
            }

            var bestCandidate = students
                .OrderByDescending(v => v.Value.Values.Sum())
                .FirstOrDefault();

            string bestName = bestCandidate.Key;
            int bestPoints = bestCandidate.Value.Values.Sum();

            Console.WriteLine($"Best candidate is {bestName} with total {bestPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var (student,value) in students.OrderBy(x=>x.Key))
            {
                Console.WriteLine(student);

                foreach (var (contestname,points) in value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contestname} -> {points}");
                }
            }

        }
    }
}
