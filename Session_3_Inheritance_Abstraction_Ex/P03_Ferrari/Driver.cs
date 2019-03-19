using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Ferrari
{
    public class Driver
    {
        public Driver(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }

}
