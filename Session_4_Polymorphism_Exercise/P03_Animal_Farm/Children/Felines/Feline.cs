using System;
using System.Collections.Generic;
using System.Text;
using P03_Wild_Farm.Children.Mammals;

namespace P03_Wild_Farm.Children.Felines
{
    public abstract class Feline : Mammal
    {
        public string Breed { get; set; }

        public Feline(string Name, double Weight, int FoodEaten, string LivingRegion, string Breed) : base(Name, Weight, FoodEaten, LivingRegion)
        {
            this.Breed = Breed;
        }


        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
