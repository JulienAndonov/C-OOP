using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P01_RawData
{
    public class CarFactory
    {
        private EngineFactory engineFactory;
        private const int tireCount = 4;

        public Car Create(string[] parameters)
        {
            engineFactory = new EngineFactory();
            string model = parameters[0];
            int engineSpeed = int.Parse(parameters[1]);
            int enginePower = int.Parse(parameters[2]);
            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];

            Engine engine = engineFactory.Create(enginePower, engineSpeed);
            Cargo cargo = new Cargo(cargoType, cargoWeight);
            Tire[] tires = GetTires(parameters.Skip(5).ToList());

            Car car = new Car(model, engine, cargo, tires);

            return car;
        }


        private Tire[] GetTires(List<string> tireParameters)
        {
            Tire[] tires = new Tire[tireCount];

            int tireIndex = 0;
            for (int j = 0; j <= 7; j += 2)
            {
                double tirePressure = double.Parse(tireParameters[j]);
                int tireAge = int.Parse(tireParameters[j + 1]);
                Tire tire = new Tire(tirePressure, tireAge);
                tires[tireIndex] = tire;

                tireIndex++;
            }
            return tires;
        }
    }
}
