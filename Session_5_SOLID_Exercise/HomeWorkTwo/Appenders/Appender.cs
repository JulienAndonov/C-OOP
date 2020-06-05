using Logger.Appenders.Contracts;
using Logger.Layouts;
using Logger.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Appenders
{
    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
        }
        public ReportLevel ReportLevel { get; set; }

        protected ILayout Layout { get; }
        public int MessageCounter { get;protected set; }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);
       
    }
}
