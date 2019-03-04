using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital
{
    public class Room
    {
        private List<string> patients;


        public Room()
        {
            this.patients = new List<string>();
        }

        public List<string> Patients
        {
            get
            {
                return this.patients;
            }
            set
            {
                this.patients = value;
            }
        }
    }
}
