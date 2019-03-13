using System;
using System.Collections.Generic;
using System.Text;

namespace P05_Pizza_Calories
{
    public class Topping
    {

        public Topping(string type, int weight)
        {
            this.Type = type;
            this.Weight = weight;
        }


        public double GetCalories()
        {
            double calories = this.Weight * 2;
            double toppingModifier = 0;
            switch (this.Type.ToUpper())
            {
                case "MEAT":
                    toppingModifier = 1.2;
                    break;
                case "VEGGIES":
                    toppingModifier = 0.8;
                    break;
                case "CHEESE":
                    toppingModifier = 1.1;
                    break;
                case "SAUCE":
                    toppingModifier = 0.9;
                    break;
            }

            calories *= toppingModifier;

            return calories;
        }

        public string Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                if (value.ToUpper() == "MEAT" || value.ToUpper() == "VEGGIES" || value.ToUpper() == "CHEESE" || value.ToUpper() == "SAUCE")
                {
                    this.type = value;
                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }

        public int Weight
        {
            get
            {
                return this.weight;
            }
            private set
            {
                if (value >= 1 && value <= 50)
                {
                    this.weight = value;
                }
                else
                {
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                }
            }
        }

        private string type;
        private int weight;

    }
}
