using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace P03_Mankind
{
    public class Student : Human
    {
        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        private string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value.Any(s => !char.IsLetterOrDigit(s)) || value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentException("Invalid faculty number!");
                }
                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            StringBuilder studentStringed = new StringBuilder();
            studentStringed.AppendLine(base.ToString());
            studentStringed.AppendLine($"Faculty number: {this.FacultyNumber}");
            return studentStringed.ToString();
        }


        private string facultyNumber;
    }
}
