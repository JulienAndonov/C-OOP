using System;
using System.Collections.Generic;
using System.Text;

namespace P08_Militery_Elite.Interfaces
{
    public interface ILieutenantGeneral : IPrivate
    {
        ICollection<IPrivate> Privates { get; set; }
    }
}
