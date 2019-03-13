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

        public string FirstName
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


        public string LastName
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


        public static void validateName(string value, int charCount,string attribute)
        {
            if (!char.IsUpper(value[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {attribute}");
            }
            if (!(value.Length >= charCount))
            {
                throw new ArgumentException($"Expected length at least {charCount} symbols! Argument: {attribute}");
            }
        }

        private string firstName;
        private string lastName;
    }
}
