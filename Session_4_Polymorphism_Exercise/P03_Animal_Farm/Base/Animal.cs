using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Wild_Farm.Base
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        public Animal(string Name, double Weight, int FoodEaten)
        {
            this.Name = Name;
            this.Weight = Weight;
            this.FoodEaten = FoodEaten;
        }

        public abstract string SayHello();

        public abstract void Eat(Food food);

    }
}
