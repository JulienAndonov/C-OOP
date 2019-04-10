using System;
using System.Collections.Generic;
using System.Text;
using P03_Wild_Farm.Base;

namespace P03_Wild_Farm.Children
{
    public class Hen : Bird
    {
        public Hen(string Name, double Weight, int FoodEaten, double WingSize) : base(Name, Weight, FoodEaten, WingSize)
        {

        }

        public override void Eat(Food food)
        {
            this.Weight += 0.35 * food.Quantity;
            this.FoodEaten += food.Quantity;
        }


        public override string SayHello()
        {
            return "Cluck";
        }

    }
}
