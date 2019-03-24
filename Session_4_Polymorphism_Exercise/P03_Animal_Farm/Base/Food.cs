using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Wild_Farm.Base
{
    public abstract class Food
    {
        public int Quantity { get; set; }

        public Food(int Quantity)
        {
            this.Quantity = Quantity;
        }
    }
}
