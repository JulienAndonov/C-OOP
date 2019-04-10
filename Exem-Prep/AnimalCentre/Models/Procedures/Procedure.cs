
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Procedures
{
    public abstract class Procedure : IProcedure
    {

        private AnimalCentre animalCentre;

        protected Procedure()
        {
            this.ProcedureHistory = new List<IAnimal>();
            this.animalCentre = new AnimalCentre();
        }

        protected ICollection<IAnimal> ProcedureHistory { get; set; }

        public string History()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name}");

            foreach (var animal in this.ProcedureHistory)
            {
                sb.AppendLine($"    - {animal.Name} - Happiness: {animal.Happiness} - Energy: {animal.Energy}");
            }
            return sb.ToString().TrimEnd();
        }

        public virtual void DoService(IAnimal animal, int procedureTime)
        {
            if (this.animalCentre.Hotel.Animals.ContainsKey(animal.Name))
            {
                throw new ArgumentException($"Animal {animal.Name} does not exist");
            }
            if (procedureTime > animal.ProcedureTime)
            {
                throw new ArgumentException("Animal doesn't have enough procedure time");
            }

            animal.ProcedureTime -= procedureTime;
        }
    }
}
