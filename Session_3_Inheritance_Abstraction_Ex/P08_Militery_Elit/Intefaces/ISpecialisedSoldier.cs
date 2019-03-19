using System;
using System.Collections.Generic;
using System.Text;
using P08_Militery_Elite.Enums;

namespace P08_Militery_Elite.Interfaces
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
    }
}
