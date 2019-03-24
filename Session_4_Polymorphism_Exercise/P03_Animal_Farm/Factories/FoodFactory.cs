using System;
using System.Collections.Generic;
using System.Text;
using P03_Wild_Farm.Base;
using P03_Wild_Farm.Children;
using P03_Wild_Farm.Children.Felines;
using P03_Wild_Farm.Children.Mammals;

namespace P03_Wild_Farm.Factories
{
    public static class FoodFactory
    {
        public static Food Create(string[] input)
        {
            var foodType = input[0];
            var quantity = int.Parse(input[1]);

            switch (foodType)
            {
                case "Vegetable":
                    return new Vegetable(quantity);
                case "Fruit":
                    return new Fruit(quantity);
                case "Meat":
                    return new Meat(quantity);
                case "Seeds":
                    return new Seeds(quantity);
            }
            return null;
        }
    }
}
