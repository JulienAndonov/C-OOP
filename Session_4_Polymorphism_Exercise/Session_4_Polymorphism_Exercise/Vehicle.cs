using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace P01_Vehicles
{
    public abstract class Vehicle
    {

        public Vehicle(double FuelQuantity, double FuelConsumptionPerKm, double TankCapacity)
        {
            this.TankCapacity = TankCapacity;
            this.FuelQuantity = FuelQuantity;
            this.FuelConsumptionPerKm = FuelConsumptionPerKm;
            
        }

        public double FuelQuantity
        {
            get => this.fuelQuantity;
            set
            {
                if (value <= this.TankCapacity)
                {
                    this.fuelQuantity = value;
                }
                else
                {

                    this.fuelQuantity = 0;
                }
            }
        }

        public double TankCapacity
        {
            get; set;
        }

        public double FuelConsumptionPerKm { get; set; }



        public virtual string Drive(double distance, double consumption)
        {
            var neededFuel = consumption * distance;

            if (this.FuelQuantity >= neededFuel)
            {
                this.FuelQuantity -= neededFuel;
                return $"{this.GetType().Name} travelled {distance} km";
            }

            return $"{this.GetType().Name} needs refueling";
        }


        public virtual void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }


            if (this.FuelQuantity + amount > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {amount} fuel in the tank");

            }
            this.FuelQuantity += amount;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:F2}";
        }

        private double fuelQuantity;
    }
}
