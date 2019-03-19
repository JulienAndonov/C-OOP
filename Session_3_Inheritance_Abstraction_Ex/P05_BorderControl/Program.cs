using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_BorderControl
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var subjects = new List<IIDable>();

            while (true)
            {
                var input = Console.ReadLine().Split(" ");

                if (input[0] == "End")
                {
                    break;
                }

                var inputType = input.Length;

                if (inputType == 3)
                {
                    var name = input[0];
                    var age = int.Parse(input[1]);
                    var id = input[2];
                    subjects.Add(new Citizen(id, age, name));
                }
                else if (inputType == 2)
                {
                    var model = input[0];
                    var id = input[1];
                    subjects.Add(new Robot(id, model));
                }
            }

            var idToDetain = Console.ReadLine();

            subjects
                .Select(s => s.ID)
                .Where(x => x.EndsWith(idToDetain))
                .ToList()
                .ForEach(z => Console.WriteLine(z));
        }
    }
}
