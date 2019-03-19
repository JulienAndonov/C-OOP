using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_Birthday_Celebrations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var subjects = new List<IIDable>();
            var subjectsWithBirthDay = new List<IBirthDaytable>();

            while (true)
            {
                var input = Console.ReadLine().Split(" ");

                if (input[0] == "End")
                {
                    break;
                }

                switch (input[0])
                {
                    case "Citizen":
                        var name = input[1];
                        var age = int.Parse(input[2]);
                        var citizenId = input[3];
                        var birthDate = input[4];
                        subjects.Add(new Citizen(citizenId, age, name, birthDate));
                        subjectsWithBirthDay.Add(new Citizen(citizenId, age, name, birthDate));
                        break;
                    case "Robot":
                        var model = input[1];
                        var robotId = input[2];
                        subjects.Add(new Robot(model, robotId));
                        break;
                    case "Pet":
                        var petName = input[1];
                        var petBirthDay = input[2];
                        subjectsWithBirthDay.Add(new Pet(petName, petBirthDay));
                        break;
                }
            }

            var yearToDetain = Console.ReadLine();

            if (yearToDetain != "")
            {
                subjectsWithBirthDay
                    .Select(s => s.BirthDate)
                    .Where(x => x.EndsWith(yearToDetain))
                    .ToList()
                    .ForEach(z => Console.WriteLine(z));
            }
        }
    }
}
