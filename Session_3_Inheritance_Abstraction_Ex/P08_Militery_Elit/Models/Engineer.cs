using System;
using System.Collections.Generic;
using System.Text;
using P08_Militery_Elite.Enums;
using P08_Militery_Elite.Intefaces;
using P08_Militery_Elite.Interfaces;

namespace P08_Militery_Elite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, Corps corps)
                    : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = new List<IRepair>();
        }

        public ICollection<IRepair> Repairs { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(base.ToString());
            builder.AppendLine($"Corps: {this.Corps}");
            builder.AppendLine("Repairs:");

            foreach (var repair in this.Repairs)
            {
                builder.AppendLine(repair.ToString());
            }

            return builder.ToString().TrimEnd();
        }
    }
}
