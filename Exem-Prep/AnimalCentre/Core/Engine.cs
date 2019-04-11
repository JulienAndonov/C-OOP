using System;
using System.Collections.Generic;
using System.Text;
using AnimalCentre.Core.Contracts;
using AnimalCentre.Models.Animals;

namespace AnimalCentre.Core
{
    class Engine : IEngine
    {

        private AnimalCentre animalCenter;


        public Engine()
        {
            this.animalCenter = new AnimalCentre();
        }

        public void Run()
        {
            while (true)
            {
                var args = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = args[0];


                if (command == "End")
                {
                    Console.WriteLine(animalCenter.GetOwnersDetails());
                    break;
                }

                try
                {
                    string name = string.Empty;
                    string owner = string.Empty;
                    string type = string.Empty;
                    int procedureTime = 0;
                    switch (command)
                    {
                        case "RegisterAnimal":
                            type = args[1];
                            name = args[2];
                            int energy = int.Parse(args[3]);
                            int happiness = int.Parse(args[4]);
                            procedureTime = int.Parse(args[5]);
                            Console.WriteLine(this.animalCenter.RegisterAnimal(type, name, energy, happiness, procedureTime));
                            break;
                        case "Chip":
                            name = args[1];
                            procedureTime = int.Parse(args[2]);
                            Console.WriteLine(this.animalCenter.Chip(name, procedureTime));
                            break;
                        case "Vaccinate":
                            name = args[1];
                            procedureTime = int.Parse(args[2]);
                            Console.WriteLine(this.animalCenter.Vaccinate(name, procedureTime));
                            break;
                        case "Fitness":
                            name = args[1];
                            procedureTime = int.Parse(args[2]);
                            Console.WriteLine(this.animalCenter.Fitness(name, procedureTime));
                            break;
                        case "Play":
                            name = args[1];
                            procedureTime = int.Parse(args[2]);
                            Console.WriteLine(this.animalCenter.Play(name, procedureTime));
                            break;
                        case "DentalCare":
                            name = args[1];
                            procedureTime = int.Parse(args[2]);
                            Console.WriteLine(this.animalCenter.DentalCare(name, procedureTime));
                            break;
                        case "NailTrim":
                            name = args[1];
                            procedureTime = int.Parse(args[2]);
                            Console.WriteLine(this.animalCenter.NailTrim(name, procedureTime));
                            break;
                        case "Adopt":
                            name = args[1];
                            owner = args[2];
                            Console.WriteLine(this.animalCenter.Adopt(name, owner));
                            break;
                        case "History":
                            type = args[1];
                            Console.WriteLine(this.animalCenter.History(type));
                            break;
                    }
                }
                catch (InvalidOperationException ie)
                {
                    Console.WriteLine($"InvalidOperationException: {ie.Message}");
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine($"ArgumentException: {ae.Message}");
                }
            }
        }
    }
}
