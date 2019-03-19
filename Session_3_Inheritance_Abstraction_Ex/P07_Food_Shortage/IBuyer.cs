using System;
using System.Collections.Generic;
using System.Text;

namespace P07_Food_Shortage
{
    public interface IBuyer
    {
        string Name { get; set; }
        int Food { get; set; }
        void BuyFood();
    }
}
