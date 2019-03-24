using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Logger.Layouts.Contracts
{
    public class XmlLayout : ILayout
    {
        public string Format { get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("<log>");
                sb.AppendLine("\t<date>{0}</date>");
                sb.AppendLine("\t<level>{1}</level>");
                sb.AppendLine("\t<message>{2}</message>");
                sb.Append("</log>");
                return sb.ToString();

            }
        }
    }
}
