using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Mankind
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }



        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value <= 10)
                {
                    throw new ArgumentException($"Expected value mismatch! Argument: weekSalary");
                }
                this.weekSalary = value;

            }
        }

        public decimal WorkHoursPerDay
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
        private decimal workHoursPerDay;


        private decimal PayPerHour()
        {
            return (decimal)(this.WeekSalary / (this.WorkHoursPerDay * 5));

        }

        public override string ToString()
        {
            StringBuilder studentStringed = new StringBuilder();
            studentStringed.AppendLine($"{base.ToString()}");
            studentStringed.AppendLine($"Week Salary: {this.WeekSalary:F2}");
            studentStringed.AppendLine($"Hours per day: {this.WorkHoursPerDay:F2}");
            studentStringed.AppendLine($"Salary per hour: {this.PayPerHour():F2}");
            return studentStringed.ToString().TrimEnd();
        }

    }
}
