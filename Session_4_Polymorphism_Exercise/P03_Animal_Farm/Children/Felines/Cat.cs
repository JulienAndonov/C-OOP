using System;
using System.Collections.Generic;
using System.Text;
using P03_Wild_Farm.Children.Felines;
using P03_Wild_Farm.Base;

namespace P03_Wild_Farm.Children.Felines
{
    public class Cat : Feline
    {
        public Cat(string Name,double Weight,int FoodEaten,string LivingRegion,string Breed) : base(Name, Weight, FoodEaten, LivingRegion, Breed)
        {

        }

        public override void Eat(Food food)
        {
            if (food is Vegetable vegetable || food is Meat meat)
            {
                this.Weight += 0.30 * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

        }

        public override string SayHello()
        {
            return "Meow";
        }
    }
}
