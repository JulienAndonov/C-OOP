using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using P01_Logger.Layouts.Contracts;
using P01_Logger.Loggers.Contracts;
using P01_Logger.Loggers.Enums;
using System.Linq;
using P01_Logger.Appenders.Contracts;

namespace P01_Logger.Appenders
{
    public class FileAppender : Appender
    {
        private ILogfile logfile;

        public FileAppender(ILayout layout, ILogfile logfile) : base(layout)
        {
            this.logfile = logfile;
        }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                var content = String.Format(this.Layout.Format, dateTime, reportLevel, message) + Environment.NewLine;
                this.MessageCount++;
                File.AppendAllText(logfile.Path, content);
                logfile.ComputeSize(content);
            }
        }

        public override string ToString()
        {
            var stringResult = $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel}, Messeges appended: {this.MessageCount}, File size: {this.logfile.Size}";
            return stringResult;
        }
    }
}
