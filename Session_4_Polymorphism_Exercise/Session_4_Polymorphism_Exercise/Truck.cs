using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Vehicles
{
    public class Truck : Vehicle
    {

        public Truck(double quantity, double consumption) : base(quantity, consumption)
        {
            this.fuelConsumptionPerKm += 1.6;
        }


        public override void Refuel(double amount)
        {
            this.fuelQuantity += (amount * 0.95);
        }
    }
}
