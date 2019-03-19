﻿using P08_Militery_Elite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P08_Militery_Elite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
            : base(id,firstName,lastName,salary)
        {
            this.Privates = new List<IPrivate>();
        }

        public ICollection<IPrivate> Privates { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(base.ToString());
            builder.AppendLine("Privates:");

            foreach (var privateSoldier in this.Privates)
            {
                builder.AppendLine("  " + privateSoldier.ToString());
            }

            return builder.ToString().TrimEnd();
        }
    }
}
