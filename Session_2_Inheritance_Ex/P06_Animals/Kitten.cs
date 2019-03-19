using System;
using System.Collections.Generic;
using System.Text;

namespace P06_Animals
{
    public class Kitten : Cat
    {
        public Kitten(string Name, int Age, string Gender = "Female") : base(Name, Age, Gender)
        {

        }
        public override string ProduceSound()
        {
            return "Meow";
        }

    }
}
