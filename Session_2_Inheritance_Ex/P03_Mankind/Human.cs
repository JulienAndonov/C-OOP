using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Mankind
{
    public class Human
    {

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        protected string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                validateName(value, 4,nameof(firstName));
                this.firstName = value;
            }

        }


        protected string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                validateName(value, 3,nameof(lastName));
                this.lastName = value;

            }
        }


        public static void validateName(string name, int minLength,string attribute)
        {
            if (!char.IsUpper(name[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {attribute}");
            }
            if (name.Length < minLength)
            {
                throw new ArgumentException($"Expected length at least {minLength} symbols! Argument: {attribute}");
            }
        }


        public override string ToString()

        {

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"First Name: {FirstName}");
            stringBuilder.Append($"Last Name: {LastName}");
            return stringBuilder.ToString();

        }

        private string firstName;
        private string lastName;
    }
}
