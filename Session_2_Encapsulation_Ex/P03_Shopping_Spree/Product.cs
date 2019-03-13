using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Shopping_Spree
{
    public class Product
    {
        public Product(string name, int cost)
        {
            this.name = name;
            this.Cost = cost;
        }


        public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new NullReferenceException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public int Cost
        {
            get
            {
                return this.cost;
            }
            set
            {
                if (value < 0)
                {
                    throw new NullReferenceException("Money cannot be negative");
                }
                this.cost = value;
            }
        }

        private string name;
        private int cost;





    }
}
