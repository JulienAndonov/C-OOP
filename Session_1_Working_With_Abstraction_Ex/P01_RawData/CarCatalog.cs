using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P01_RawData
{
    public class CarCatalog
    {
        private List<Car> cars;
        private EngineFactory engineFactory;


        public CarCatalog(EngineFactory engineFactory)
        {
            this.cars = new List<Car>();
            this.engineFactory = engineFactory;
        }


        public void Add(string[] parameters)
        {
            CarFactory carfactory = new CarFactory();
            Car car = carfactory.Create(parameters);
            cars.Add(car);
        }

        public List<Car> GetCars() => this.cars;

    }
}
