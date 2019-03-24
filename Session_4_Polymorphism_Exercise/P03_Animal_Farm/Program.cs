using System;
using System.Collections.Generic;
using P03_Wild_Farm.Base;
using P03_Wild_Farm.Children;
using P03_Wild_Farm.Children.Felines;
using P03_Wild_Farm.Children.Mammals;
using P03_Wild_Farm.Factories;

namespace P03_Animal_Farm
{
    class Program
    {
        public static void Main(string[] args)
        {
            int index = 0;
            var animalType = "";

            List<Animal> animals = new List<Animal>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                var splittedInput = input.Split();

                if (index % 2 == 0)
                {
                    var currentAnimal = AnimalFactory.Create(splittedInput);
                    animals.Add(currentAnimal);
                    animalType = currentAnimal.GetType().Name;
                }
                else
                {
                    try
                    {
                        var currentFood = FoodFactory.Create(splittedInput);
                        var currentAnimal = animals[animals.Count - 1];
                        Console.WriteLine(currentAnimal.SayHello());
                        currentAnimal.Eat(currentFood);
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }

                }
                index++;
            }
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
    }
}

