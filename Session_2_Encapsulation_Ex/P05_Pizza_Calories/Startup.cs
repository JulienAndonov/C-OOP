using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Pizza_Calories
{
    class Startup
    {
        static void Main(string[] args)
        {
            try
            {
                var pizzaDetails = Console.ReadLine().Split(" ");
                var pizzaName = pizzaDetails[1];
                var doughDetails = Console.ReadLine().Split(" ");

                var flourType = doughDetails[1];
                var bakingTechnique = doughDetails[2];
                var doughWweight = int.Parse(doughDetails[3]);

                Dough dough = new Dough(flourType, bakingTechnique, doughWweight);
                Pizza pizza = new Pizza(pizzaName, dough);

                while (true)
                {
                    var toppingDetails = Console.ReadLine().Split(" ");

                    if (toppingDetails[0] == "END")
                    {
                        break;
                    }

                    var type = toppingDetails[1];
                    var toppingWeight = int.Parse(toppingDetails[2]);

                    Topping topping = new Topping(type, toppingWeight);
                    pizza.AddTopping(topping);
                }
                Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():F2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
