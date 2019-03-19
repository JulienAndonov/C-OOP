using System;
using System.Collections.Generic;
using System.Text;
using P08_Militery_Elite.Enums;
using P08_Militery_Elite.Intefaces;
using P08_Militery_Elite.Interfaces;

namespace P08_Militery_Elite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id,firstName,lastName,salary,corps)
        {
            this.Missions = new List<IMission>();
        }

        public ICollection<IMission> Missions { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(base.ToString());
            builder.AppendLine($"Corps: {this.Corps}");
            builder.AppendLine("Missions:");

            foreach (var mission in this.Missions)
            {
                builder.AppendLine(mission.ToString());
            }

            return builder.ToString().TrimEnd();
        }
    }
}
