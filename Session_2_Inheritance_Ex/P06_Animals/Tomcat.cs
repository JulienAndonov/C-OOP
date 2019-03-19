using System;
using System.Collections.Generic;
using System.Text;

namespace P06_Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string Name, int Age, string Gender = "Male") : base(Name, Age, Gender)
        {

        }

        public override string ProduceSound()
        {
            return "MEOW";
        }
    }
}
