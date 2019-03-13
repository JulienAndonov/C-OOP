using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P05_Pizza_Calories
{
    public class Pizza
    {


        public double GetCalories()
        {
            double calories = 0;
            calories = this.dought.getCalories() + this.toppings.Select(t => t.GetCalories()).Sum();
            return calories;
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count >= 0 && this.toppings.Count < 10)
            {
                this.Toppings.Add(topping);
            }
            else
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
        }

        public Pizza(string name,Dough dough)
        {
            this.Name = name;
            this.Dough = dough;
            this.toppings = new List<Topping>();
        }


        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length >= 1 && value.Length <= 15)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
            }
        }


        public List<Topping> Toppings
        {
            get
            {
                return this.toppings;
            }
        }

        public Dough Dough
        {
            get
            {
                return this.dought;
            }
            set
            {
                this.dought = value;
            }
        }




        private string name;
        private List<Topping> toppings;
        private Dough dought;






    }
}
