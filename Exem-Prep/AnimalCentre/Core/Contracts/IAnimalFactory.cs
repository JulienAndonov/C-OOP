using AnimalCentre.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Core.Contracts
{
    public interface IAnimalFactory
    {
        IAnimal Create(string type, string name, int energy, int happiness, int procedureTime);
    }
}
