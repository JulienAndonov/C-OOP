using AnimalCentre.Models.Procedures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnimalCentre.Core.Contracts;
using AnimalCentre.Core.Factories;
using AnimalCentre.Models;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre
{
    public class AnimalCentre
    {
        private IHotel hotel;
        private IAnimalFactory animalFactory;
        private IProcedure chip;
        private IProcedure vaccinate;
        private IProcedure fitness;
        private IProcedure nailTrim;
        private IProcedure play;
        private IProcedure dentailCare;
        private Dictionary<string, List<string>> owners;



        public AnimalCentre()
        {
            this.hotel = new Hotel();
            this.animalFactory = new AnimalFactory();
            this.chip = new Chip();
            this.vaccinate = new Vaccinate();
            this.fitness = new Fitness();
            this.nailTrim = new NailTrim();
            this.play = new Play();
            this.dentailCare = new DentalCare();
            this.owners = new Dictionary<string, List<string>>();
        }


        public string RegisterAnimal(string type, string name, int energy, int happiness, int procedureTime)
        {
            IAnimal animal = animalFactory.Create(type, name, energy, happiness, procedureTime);

            if (this.hotel.Animals.ContainsKey(name))
            {
                throw new ArgumentException($"Animal {name} already exist");
            }

            this.hotel.Accommodate(animal);
            return $"Animal {animal.Name} registered successfully";
        }

        public string Chip(string name, int procedureTime)
        {
            CheckIfExists(name);
            chip.DoService(this.hotel.Animals[name], procedureTime);
            return $"{name} had chip procedure";

        }

        public string Vaccinate(string name, int procedureTime)
        {
            CheckIfExists(name);
            vaccinate.DoService(this.hotel.Animals[name], procedureTime);
            return $"{name} had vaccination procedure";
        }

        public string Fitness(string name, int procedureTime)
        {
            CheckIfExists(name);
            fitness.DoService(this.hotel.Animals[name], procedureTime);
            return $"{name} had fitness procedure";

        }

        public string Play(string name, int procedureTime)
        {
            CheckIfExists(name);
            play.DoService(this.hotel.Animals[name], procedureTime);
            return $"{name} was playing for {procedureTime} hours";
        }

        public string DentalCare(string name, int procedureTime)
        {
            CheckIfExists(name);
            dentailCare.DoService(this.hotel.Animals[name], procedureTime);
            return $"{name} had dental care procedure";
        }

        public string NailTrim(string name, int procedureTime)
        {
            CheckIfExists(name);
            nailTrim.DoService(this.hotel.Animals[name], procedureTime);
            return $"{name} had nail trim procedure";
        }

        public string Adopt(string animalName, string owner)
        {
            CheckIfExists(animalName);
            IAnimal animal = this.hotel.Animals[animalName];


            if (!this.owners.ContainsKey(owner))
            {
                this.owners[owner] = new List<string>();
            }

            this.hotel.Adopt(animalName, owner);
            this.owners[owner].Add(animal.Name);

            if (animal.IsChipped)
            {
                return $"{owner} adopted animal with chip";
            }
            else
            {
                return $"{owner} adopted animal without chip";
            }

            
        }

        public string History(string type)
        {
            string result = string.Empty;
            switch (type)
            {
                case "Chip":
                    result = chip.History();
                    break;
                case "DentalCare":
                    result = dentailCare.History();
                    break;
                case "Fitness":
                    result = fitness.History();
                    break;
                case "NailTrim":
                    result = nailTrim.History();
                    break;
                case "Play":
                    result = play.History();
                    break;
                case "Vaccinate":
                    result = vaccinate.History();
                    break;
            }
            return result;
        }

        public string GetOwnersDetails()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var owner in this.owners.OrderBy(o => o.Key))
            {
                sb.AppendLine($"--Owner: {owner.Key}");
                sb.AppendLine($"   - Adopted animals: {string.Join(" ", owner.Value)}");
            }

            return sb.ToString().TrimEnd();
        }

        public void CheckIfExists(string name)
        {
            if (!this.hotel.Animals.ContainsKey(name))
            {
                throw new ArgumentException($"Animal {name} does not exist");
            }

        }

    }
}
