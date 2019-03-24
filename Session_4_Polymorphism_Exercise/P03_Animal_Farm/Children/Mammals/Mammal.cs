using System;
using System.Collections.Generic;
using System.Text;
using P03_Wild_Farm.Base;

namespace P03_Wild_Farm.Children.Mammals
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; set; }

        public Mammal(string Name, double Weight, int FoodEaten, string LivingRegion) : base(Name, Weight, FoodEaten)
        {
            this.LivingRegion = LivingRegion;
        }


        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {FoodEaten}]";
        }
    }
}
