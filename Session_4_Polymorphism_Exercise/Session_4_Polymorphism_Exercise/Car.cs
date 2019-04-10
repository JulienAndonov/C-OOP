using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Vehicles
{
    public class Car : Vehicle
    {

        public Car(double quantity, double consumption,double capacity) : base(quantity, consumption,capacity)
        {
            this.FuelConsumptionPerKm += 0.9;

        }

        public override void Refuel(double amount)
        {
            base.Refuel(amount);
        }
    }
}
