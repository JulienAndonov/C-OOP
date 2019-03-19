using System;

namespace P03_Ferrari
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var driverName = Console.ReadLine();

            var driver = new Driver(driverName);

            var car = new Car(driver);

            Console.WriteLine($"{car.Model}/{car.UseBrakes()}/{car.PushGas()}/{car.Driver.Name}");


        }
    }
}
