using System;
using System.Collections.Generic;
using System.Text;

namespace P07_Food_Shortage
{
    public class Rebel : IBuyer
    {
        public int Food { get; set; }
        public string Name { get; set; }
        private int age { get; set; }
        private string group { get; set; }

        public Rebel(string Name, int Age, string Group)
        {
            this.Name = Name;
            this.age = Age;
            this.group = Group;
        }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
