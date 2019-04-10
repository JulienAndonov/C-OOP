using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models
{
    public class Hotel : IHotel
    {

        private readonly Dictionary<string, IAnimal> animals;
        private const int Capacity = 10;

        public Hotel()
        {
            this.animals = new Dictionary<string, IAnimal>();
        }


        public void Accommodate(IAnimal animal)
        {
            if (this.animals.Count == Capacity)
            {
                throw new InvalidOperationException("Not enough capacity");
            }

            if (this.animals.ContainsKey(animal.Name))
            {
                throw new ArgumentException($"Animal {animal.Name} already exist");
            }

            this.animals[animal.Name] = animal;
        }

        public void Adopt(string animalName, string owner)
        {
            if (!this.animals.ContainsKey(animalName))
            {
                throw new ArgumentException($"Animal {animalName} does not exist");
            }

            this.animals[animalName].Owner = owner;
            this.animals[animalName].IsAdopt = true;
            this.animals.Remove(animalName);
        }

        public IReadOnlyDictionary<string, IAnimal> Animals
        {
            get => this.animals.ToImmutableDictionary();
        }
    }
}
