using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace P01_Vehicles
{
    public abstract class Vehicle
    {
        public double fuelQuantity { get; set; }
        public double fuelConsumptionPerKm { get; set; }

        public Vehicle(double FuelQuantity, double FuelConsumptionPerKm)
        {
            this.fuelQuantity = FuelQuantity;
            this.fuelConsumptionPerKm = FuelConsumptionPerKm;
        }


        public virtual string Drive(double distance)
        {
            var neededFuel = this.fuelConsumptionPerKm * distance;
            if (fuelQuantity >= neededFuel)
            {
                this.fuelQuantity -= neededFuel;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }


        public abstract void Refuel(double amount);

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.fuelQuantity:F2}";
        }

    }
}
