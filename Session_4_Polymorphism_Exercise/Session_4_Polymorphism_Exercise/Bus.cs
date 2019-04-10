using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double quantity, double consumption, double tankCapacity) : base(quantity, consumption, tankCapacity)
        {

        }

        public override void Refuel(double amount)
        {
            base.Refuel(amount);
        }

        public override string Drive(double distance,double consumption)
        {
            return base.Drive(distance, consumption + 1.4);
        }

        public string DriveEmpty(double distance,double consumption)
        {
            return base.Drive(distance, consumption);
        }

    }
}
