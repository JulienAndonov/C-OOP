using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Mankind
{
    public class Student : Human
    {
        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value.Length <= 4 || value.Length >= 11)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public override string ToString()
        {
            StringBuilder studentStringed = new StringBuilder();
            studentStringed.AppendLine($"First Name: {this.FirstName}");
            studentStringed.AppendLine($"Last Name: {this.LastName}");
            studentStringed.AppendLine($"Faculty number: {this.FacultyNumber}");
            return studentStringed.ToString();
        }


        private string facultyNumber;
    }
}
