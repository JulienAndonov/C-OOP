﻿using System;
using System.Collections.Generic;
using System.Text;
using AnimalCentre.Models.Contracts;

namespace AnimalCentre.Models.Procedures
{
    public class Vaccinate : Procedure
    {
        public override void DoService(IAnimal animal, int procedureTime)
        {
            base.DoService(animal, procedureTime);
            animal.IsVaccinated = true;
            animal.Energy -= 8;
            this.ProcedureHistory.Add(animal);
        }
    }
}
