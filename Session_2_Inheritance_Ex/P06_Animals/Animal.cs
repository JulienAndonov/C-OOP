using System;
using System.Collections.Generic;
using System.Text;

namespace P06_Animals
{
    public class Animal : ISoundProducable
    {
        private string name;
        private int age;
        private string gender;


        public Animal(string Name, int Age, string Gender)
        {
            this.Name = Name;
            this.Age = Age;
            this.Gender = Gender;
        }

        private string Name
        {
            get => this.name;
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.name = value;
            }
        }


        private int Age
        {
            get => this.age;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                this.age = value;
            }
        }

        private string Gender
        {
            get => this.gender;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value) || (value != "Male" && value != "Female"))
                {
                    throw new ArgumentException("Invalid input!" );
                }
                this.gender = value;
            }
        }


        public virtual string ProduceSound()
        {
            return null;
        }


        public override string ToString()
        {
            StringBuilder animalToStringed = new StringBuilder();
            animalToStringed.AppendLine(this.GetType().Name);
            animalToStringed.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            animalToStringed.Append(this.ProduceSound());
            return animalToStringed.ToString();
        }
    }
}
