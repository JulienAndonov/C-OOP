using P08_Militery_Elite.Enums;
using P08_Militery_Elite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P08_Militery_Elite.Models

{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id,firstName,lastName,salary)
        {
            this.Corps = corps;
        }

        public Corps Corps { get; }
    }

}
