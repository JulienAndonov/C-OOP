using System;
using System.Collections.Generic;
using System.Text;
using P08_Militery_Elite.Interfaces;

namespace P08_Militery_Elite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(base.ToString());
            builder.Append($"Code Number: {this.CodeNumber}");

            return builder.ToString();
        }
    }
}
