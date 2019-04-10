using System.Collections;
using System.Collections.Generic;

namespace AnimalCentre.Models.Contracts
{
    interface IProcedure
    {
        string History();
        void DoService(IAnimal animal, int procedureTime);
    }
}
