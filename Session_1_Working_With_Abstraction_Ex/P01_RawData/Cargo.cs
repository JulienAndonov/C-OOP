using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    public class Cargo
    {

        private int weight;


        public Cargo(string type, int weight)
        {
            this.Type = type;
            this.weight = weight;
        }


        public string Type { get; private set; }
    }
}
