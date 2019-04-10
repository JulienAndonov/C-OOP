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


                try
                {
                    switch (command)
                    {
                        case "RegisterAnimal":
                            string type = args[1];
                            string name = args[2];
                            int energy = int.Parse(args[3]);
                            int happiness = int.Parse(args[4]);
                            int procedureTime = int.Parse(args[5]);
                            Console.WriteLine(this.animalCenter.RegisterAnimal(type, name, energy, happiness,
                                procedureTime));

                            break;





                    }



                }
                catch (InvalidOperationException)
                {

                }
                catch (ArgumentException)
                {

                }



            }




        }
    }
}
