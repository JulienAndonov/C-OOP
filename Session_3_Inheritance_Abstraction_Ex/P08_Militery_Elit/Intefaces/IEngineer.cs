using P08_Militery_Elite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P08_Militery_Elite.Intefaces
{
    public interface IEngineer : ISpecialisedSoldier
    {
        ICollection<IRepair> Repairs { get; set; }
    }
}
