using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace P01_Vehicles
{
    public class StartUp
    {
        private static Car currentCar;
        private static Truck currentTruck;

        public static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            for (int i = 0; i < 2; i++)
            {
                var input = Console.ReadLine().Split();
                var quantity = double.Parse(input[1]);
                var consumption = double.Parse(input[2]);

                switch (input[0])
                {
                    case "Car":
                        currentCar = new Car(quantity, consumption);
                        break;
                    case "Truck":
                        currentTruck = new Truck(quantity, consumption);
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

                if (vehicleType == "Car")
                {
                    currentVehicle = currentCar;
                }
                else
                {
                    currentVehicle = currentTruck;
                }

                PerformAction(currentVehicle, vehicleType, action, amount);
            }

            Console.WriteLine($"{currentCar.ToString()}");
            Console.WriteLine($"{currentTruck.ToString()}");

        }

        public static void PerformAction(Vehicle vehicle, string vehicleType, string action, double amount)
        {
            switch (action)
            {
                case "Drive":
                    Console.WriteLine(vehicle.Drive(amount));
                    break;
                case "Refuel":
                    vehicle.Refuel(amount);
                    break;
            }
        }

    }
}
