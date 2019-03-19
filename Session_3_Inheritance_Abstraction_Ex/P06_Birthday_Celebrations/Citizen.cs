using System;
using System.Collections.Generic;
using System.Text;

namespace P06_Birthday_Celebrations
{
    public class Citizen : IIDable, IBirthDaytable
    {
        private string id;
        private int age;
        private string name;
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
            this.name = name;
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
    }
}
