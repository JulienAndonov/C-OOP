using System;
using System.Collections.Generic;
using System.Text;

namespace Session_5_Polymorphism_Exercise
{
    public class Car
    {
        public string Type;
        public IEngine engine;


        public Car(string Type, IEngine engine)
        {
            this.Type = Type;
            this.engine = engine;
        }
    }
}
