using System;
using System.Collections.Generic;
using System.Text;
using P03_Wild_Farm.Base;

namespace P03_Wild_Farm.Children
{
    public abstract class Bird : Animal
    {
        public double WingSize { get; set; }

        public Bird(string Name, double Weight, int FoodEaten, double WingSize) : base(Name, Weight, FoodEaten)
        {
            this.WingSize = WingSize;
        }


        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSize}, {this.Weight}, {this.FoodEaten}]";
        }

    }
}
