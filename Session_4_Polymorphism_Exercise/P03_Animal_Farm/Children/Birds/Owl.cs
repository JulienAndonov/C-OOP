using System;
using System.Collections.Generic;
using System.Text;
using P03_Wild_Farm.Base;

namespace P03_Wild_Farm.Children
{
    public class Owl : Bird
    {
        public Owl(string Name,double Weight,int FoodEaten,double WingSize) : base(Name, Weight, FoodEaten,WingSize)
        {

        }

        public override void Eat(Food food)
        {
            if(food is Meat meat)
            {
                this.Weight += 0.25 * food.Quantity;
                this.FoodEaten += food.Quantity;
            }
            else
            {
                throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            
        }

        public override string SayHello()
        {
            return "Hoot Hoot";
        }

    }
}
