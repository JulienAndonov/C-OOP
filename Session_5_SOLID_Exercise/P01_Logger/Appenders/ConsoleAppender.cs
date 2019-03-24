using System;
using P01_Logger.Layouts.Contracts;
using P01_Logger.Loggers.Enums;

namespace P01_Logger.Appenders
{
    public class ConsoleAppender : IAppender
    {

        public ILayout layout { get; }

        public ConsoleAppender(ILayout layout)
        {
            this.layout = layout;
        }

        public ReportLevel ReportLevel { get; set; }

        public void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if(this.ReportLevel <= reportLevel)
            {
                Console.WriteLine(String.Format(this.layout.Format, dateTime, reportLevel, message));
            }
        }
    }
}

