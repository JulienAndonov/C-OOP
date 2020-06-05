using System;
using P01_Logger.Layouts.Contracts;
using P01_Logger.Loggers.Enums;

namespace P01_Logger.Appenders
{
    public class ConsoleAppender : Appender
    {

        public ConsoleAppender(ILayout layout) : base(layout)
        {
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if(this.ReportLevel <= reportLevel)
            {
                Console.WriteLine(String.Format(this.Layout.Format, dateTime, reportLevel, message));
                this.MessageCount++;
            }
        }

        public override string ToString()
        {
            var stringResult = $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel}, Messeges appended: {this.MessageCount}";
            return stringResult;
        }
    }
}

