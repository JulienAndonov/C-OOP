using System;

namespace P01_Person
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                try
                {
                    Child child = new Child(name, age);
                    Console.WriteLine(child);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}
