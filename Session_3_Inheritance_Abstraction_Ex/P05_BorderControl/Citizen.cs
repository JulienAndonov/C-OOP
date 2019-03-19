using System;
using System.Collections.Generic;
using System.Text;

namespace P05_BorderControl
{
    public class Citizen : IIDable
    {
        private string id;
        private int age;
        private string name;

        public Citizen(string id,int age, string name)
        {
            this.age = age;
            this.name = name;
            this.ID = id;
        }


        public int Age
        {
            get
            {
                return this.age;
            }
        }

        public string ID
        {
            get => this.id;
            set => this.id = value;
        }
    }
}
