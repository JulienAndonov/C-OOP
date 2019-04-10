using System;
using System.Collections.Generic;
using System.Text;
using AnimalCentre.Core.Contracts;
using AnimalCentre.Models.Animals;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Core.Factories
{
    public class AnimalFactory : IAnimalFactory
    {
        public IAnimal Create(string type, string name, int energy, int happiness, int procedureTime)
        {
            IAnimal animal = null;
            switch (type)
            {
                case "Cat":
                    animal = new Cat(name, energy, happiness, procedureTime);
                    break;
                case "Dog":
                    animal = new Dog(name, energy, happiness, procedureTime);
                    break;
                case "Lion":
                    animal = new Lion(name, energy, happiness, procedureTime);
                    break;
                case "Pig":
                    animal = new Pig(name, energy, happiness, procedureTime);
                    break;
            }

            return animal;
        }
    }
}
