using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace P01_Vehicles
{
    public class StartUp
    {
        private static Car currentCar;
        private static Truck currentTruck;
        private static Bus currentBus;

        public static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            for (int i = 0; i < 3; i++)
            {
                var input = Console.ReadLine().Split();
                var quantity = double.Parse(input[1]);
                var consumption = double.Parse(input[2]);
                var capacity = double.Parse(input[3]);

                switch (input[0])
                {
                    case "Car":
                        currentCar = new Car(quantity, consumption, capacity);
                        break;
                    case "Truck":
                        currentTruck = new Truck(quantity, consumption, capacity);
                        break;
                    case "Bus":
                        currentBus = new Bus(quantity, consumption, capacity);

                        break;
                }
            }

            int numOfCommands = int.Parse(Console.ReadLine());



            for (int i = 0; i < numOfCommands; i++)
            {
                var input = Console.ReadLine().Split();

                var action = input[0];
                var vehicleType = input[1];
                var amount = double.Parse(input[2]);
                Vehicle currentVehicle = null;


                switch (vehicleType)
                {
                    case "Car":
                        currentVehicle = currentCar;
                        break;
                    case "Truck":
                        currentVehicle = currentTruck;
                        break;
                    case "Bus":
                        currentVehicle = currentBus;

                        break;
                }
                PerformAction(currentVehicle, action, amount);
            }

            Console.WriteLine($"{currentCar.ToString()}");
            Console.WriteLine($"{currentTruck.ToString()}");
            Console.WriteLine($"{currentBus.ToString()}");

        }

        public static void PerformAction(Vehicle vehicle, string action, double amount)
        {
            switch (action)
            {
                case "Drive":
                    Console.WriteLine(vehicle.Drive(amount, vehicle.FuelConsumptionPerKm));
                    break;
                case "Refuel":
                    try
                    {
                        vehicle.Refuel(amount);
                    }
                    catch (ArgumentException ae)
                    {
                        Console.WriteLine(ae.Message);
                    }

                    break;
                case "DriveEmpty":
                    Console.WriteLine(currentBus.DriveEmpty(amount, vehicle.FuelConsumptionPerKm));
                    break;
            }
        }

    }
}
