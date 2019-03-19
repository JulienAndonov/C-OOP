using System;
using System.Collections.Generic;
using System.Text;

namespace P07_Food_Shortage
{
    public class Citizen : IIDable, IBirthDaytable,IBuyer
    {
        private string id;
        private int age;
        public string Name { get; set; }
        public string BirthDate
        {
            get;
            set;
        }

        public string Id
        {
            get;
            set;
        }


        public Citizen(string id,int age, string name,string birthDate)
        {
            this.age = age;
            this.Name = name;
            this.ID = id;
            this.BirthDate = birthDate;
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
        public int Food { get; set; } = 0;

        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
