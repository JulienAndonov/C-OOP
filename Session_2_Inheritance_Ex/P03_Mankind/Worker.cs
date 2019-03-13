using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Mankind
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }


        private decimal PayPerHour
        {
            get
            {
                return (decimal)(this.WeekSalary / (this.WorkHoursPerDay * 5));
            }
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value < 10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;

            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workHoursPerDay = value;
            }
        }


        private decimal weekSalary;
        private int workHoursPerDay;



        public override string ToString()
        {
            StringBuilder studentStringed = new StringBuilder();
            studentStringed.AppendLine($"First Name: {this.FirstName}");
            studentStringed.AppendLine($"Last Name: {this.LastName}");
            studentStringed.AppendLine($"Week Salary: {this.WeekSalary:F2}");
            studentStringed.AppendLine($"Hours per day: {this.WorkHoursPerDay:F2}");
            studentStringed.AppendLine($"Salary per hour: {this.PayPerHour:F2}");
            return studentStringed.ToString().TrimEnd();
        }

    }
}
