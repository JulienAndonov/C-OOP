using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_Food_Shortage
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var buyers = new List<IBuyer>();

            int numOfPeople = int.Parse(Console.ReadLine());


            for (int i = 1; i <= numOfPeople; i++)
            {
                var input = Console.ReadLine().Split();

                var name = input[0];
                var age = int.Parse(input[1]);

                if (input.Length == 4)
                {
                    var id = input[2];
                    var birthDay = input[3];
                    buyers.Add(new Citizen(id, age, name, birthDay));
                }
                else
                {
                    var group = input[2];
                    buyers.Add(new Rebel(name, age, group));
                }
            }

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "End")
                {
                    Console.WriteLine(buyers
                        .Select(b => b.Food)
                        .Sum());
                    break;
                }


                if(buyers.Any(b => b.Name == input))
                {
                    buyers.First(b => b.Name == input).BuyFood();
                }
                
            }


        }
    }
}
