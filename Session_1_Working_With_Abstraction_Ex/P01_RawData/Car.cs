using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace P01_RawData
{
    public class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tire1Pressure, int tire1Age, double tire2Pressure, int tire2Age, double tire3Pressure, int tire3age, double tire4Pressure, int tire4age)
        {
            this.Model = model;
            this.EngineSpeed = engineSpeed;
            this.EnginePower = enginePower;
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
            this.tires = new Dictionary<double, int>[]
            {
                
            };
        }


        public string Model { get; private set; }
        public int EngineSpeed { get; private set; }
        public int EnginePower { get; private set; }
        public int CargoWeight { get; private set; }
        public string CargoType { get; private set; }
        public Dictionary<double, int>[] tires;
    }
}
