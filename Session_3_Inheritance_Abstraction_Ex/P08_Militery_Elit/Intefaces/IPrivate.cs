using System;
using System.Collections.Generic;
using System.Text;

namespace P08_Militery_Elite.Interfaces
{
    public interface IPrivate : ISoldier
    {
        decimal Salary { get; }
    }
}
