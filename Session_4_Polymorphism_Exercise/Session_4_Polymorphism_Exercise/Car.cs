using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Vehicles
{
    public class Car : Vehicle
    {

        public Car(double quantity, double consumption) : base(quantity, consumption)
        {
            this.fuelConsumptionPerKm += 0.9;

        }

        public override void Refuel(double amount)
        {
            this.fuelQuantity += amount;
        }
    }
}
