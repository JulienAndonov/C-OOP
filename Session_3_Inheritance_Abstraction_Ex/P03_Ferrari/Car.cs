using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Ferrari
{
    public class Car : ICar
    {
        public Car(Driver driver)
        {
            this.Driver = driver;
        }

        public string Model { get; } = "488-Spider";

        public Driver Driver
        {
            get;
            set;
        }

        public string PushGas()
        {
            return "Gas!";
        }

        public string UseBrakes()
        {
            return "Brakes!";
        }
    }
}
