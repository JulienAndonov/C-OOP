using System;
using System.Collections.Generic;
using System.Text;

namespace Session_5_Polymorphism_Exercise
{
    public abstract class IEngine
    {
         string Type { get; set; }
         int volume { get; set; }
         int Originator { get; set; }

        public IEngine()
        {

        }
    }
}
