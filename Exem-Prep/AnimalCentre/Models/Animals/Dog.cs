﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalCentre.Models.Animals
{
    class Dog : Animal
    {

        public Dog(string name, int energy, int happiness, int procedureTime)
            : base(name, energy, happiness, procedureTime)
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"    Animal type: {this.GetType().Name} - {this.Name} - Happiness: {this.Happiness} - Energy: {this.Energy}");
            return sb.ToString();
        }

    }
}
