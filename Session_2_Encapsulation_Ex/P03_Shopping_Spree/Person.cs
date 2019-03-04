﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Shopping_Spree
{
    public class Person
    {

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        public string Name
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

        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new NullReferenceException("Money cannot be negative");
                }
                this.money = value;
            }
        }


        public bool Buy(Product product)
        {
            if (product.Cost <= this.Money)
            {
                this.products.Add(product);
                this.Money -= product.Cost;
                return true;
            }
            return false;
        }
        

        public List<Product> Products
        {
            get
            {
                return this.products;
            }
        }


        private string name;
        private decimal money;
        private List<Product> products;
    }
}
