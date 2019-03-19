using System;
using System.Collections.Generic;
using System.Text;

namespace P07_Food_Shortage
{
    public class Pet : IBirthDaytable
    {
        public Pet(string Name, string BirthDate)
        {
            this.name = Name;
            this.BirthDate = BirthDate;
        }

        public string BirthDate
        {
            get => this.birthDate;
            set => this.birthDate = value;
        }

        private string name { get; set; }
        private string birthDate;
    }
}
