using System;
using System.Collections.Generic;
using System.Text;
using P03_Wild_Farm.Base;

namespace P03_Wild_Farm.Children.Mammals
{
    public class Mouse : Mammal
    {
        public Mouse(string Name, double Weight, int FoodEaten, string LivingRegion) : base(Name, Weight, FoodEaten, LivingRegion)
        {

        }

        public override string SayHello()
        {
            return "Squeak";
        }


        public override void Eat(Food food)
        {
            if (food is Vegetable vegetable || food is Fruit fruit)
            {
                this.Weight += 0.10 * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }

    }
}
