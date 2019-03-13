using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Person
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age)
        {

        }


        public override int Age
        {
            get
            {
                if (base.Age > 15)
                {
                    throw new ArgumentException("Child's age must be less than 15!");
                }
                return base.Age;
            }
            set
            {
                base.Age = value;
            }
        }

        public override string Name {
            get => base.Name;
            set => base.Name = value;
        }

    }
}
