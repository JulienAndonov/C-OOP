using System;
using System.Collections.Generic;
using System.Text;
using P03_Wild_Farm.Base;

namespace P03_Wild_Farm.Children.Mammals
{
    public class Dog : Mammal
    {
        public Dog(string Name, double Weight, int FoodEaten, string LivingRegion) : base(Name, Weight, FoodEaten, LivingRegion)
        {

        }

        public override string SayHello()
        {
            return "Woof!";
        }


        public override void Eat(Food food)
        {

            if (food is Meat meat)
            {
                this.Weight += 0.40 * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
            else
            {

                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");

            }

        }
    }
}
