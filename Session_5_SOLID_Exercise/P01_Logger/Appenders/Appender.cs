using System;
using System.Collections.Generic;
using System.Text;
using P01_Logger.Layouts.Contracts;
using P01_Logger.Loggers.Enums;

namespace P01_Logger.Appenders
{
    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            this.Layout = layout;
            this.MessageCount = 0;
        }

        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(string dateTime, ReportLevel reportLevel, string message);

        public ILayout Layout { get; }

        public int MessageCount { get; set; }
    }
}

