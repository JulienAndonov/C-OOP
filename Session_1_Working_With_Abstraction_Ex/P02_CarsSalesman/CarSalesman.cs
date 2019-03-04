using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P02_CarsSalesman
{
    public class CarSalesman
    {
        private List<Car> cars;
        private List<Engine> engines;
        private CarFactory carFactory;
        private EngineFactory engineFactory;


        public CarSalesman(CarFactory carFactory,EngineFactory engineFactory)
        {
            this.cars = new List<Car>();
            this.engines = new List<Engine>();
            this.carFactory = carFactory;
            this.engineFactory = engineFactory;
        }

        public void AddEngine(string[] parameters)
        {
            Engine engine = engineFactory.Create(parameters);
            engines.Add(engine);

        }

        public void AddCar(string[] parameters)
        {
            Car car = carFactory.Create(parameters, this.engines);
            cars.Add(car);

        }

        public List<Car> getCars() => this.cars;

    }
}
