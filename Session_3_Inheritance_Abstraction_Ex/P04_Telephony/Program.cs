using System;

namespace P04_Telephony
{
    class Program
    {
        public static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();

            var numbers = Console.ReadLine().Split();
            foreach (var number in numbers)
            {
                try
                {
                    Console.WriteLine(smartphone.Call(number));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            var webSites = Console.ReadLine().Split();

            foreach (var webSite in webSites)
            {
                try
                {
                    Console.WriteLine(smartphone.Browse(webSite));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

            }

        }
    }
}

