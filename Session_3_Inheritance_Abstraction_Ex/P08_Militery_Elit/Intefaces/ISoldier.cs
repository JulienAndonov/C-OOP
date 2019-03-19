using System;
using System.Collections.Generic;
using System.Text;

namespace P08_Militery_Elite.Interfaces
{
    public interface ISoldier
    {
        int Id { get; }

        string FirstName { get; }

        string LastName { get; }
    }
}
