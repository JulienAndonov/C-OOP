using P08_Militery_Elite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace P08_Militery_Elite.Interfaces
{
    public interface IMission
    {
        string CodeName { get;}
        State State { get; }
        void CompleteMission();
    }
}

