using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Vehicles
{
    public class Truck : Vehicle
    {

        public Truck(double quantity, double consumption, double tankCapacity) : base(quantity, consumption, tankCapacity)
        {
            this.FuelConsumptionPerKm += 1.6;
        }


        public override void Refuel(double amount)
        {
            if(amount > this.TankCapacity)
            {
                Console.WriteLine($"Cannot fit {amount} fuel in the tank");
            }
            else
            {
                base.Refuel(amount * 0.95);
            }
            
        }
    }
}
