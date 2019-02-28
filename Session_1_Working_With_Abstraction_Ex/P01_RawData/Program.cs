using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
    
    public class RawData
    {
        static void Main(string[] args)
        {
            
            CarParser carParser = new CarParser();
            int numOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = carParser.Parse(numOfCars);

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(x => x.CargoType == "fragile" && x.tires.Any(y => y.ke < 1))
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = cars
                    .Where(x => x.CargoType == "flamable" && x.EnginePower > 250)
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }
    }
}
