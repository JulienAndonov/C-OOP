using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using P01_Logger.Layouts.Contracts;
using P01_Logger.Loggers.Contracts;
using P01_Logger.Loggers.Enums;

namespace P01_Logger.Appenders
{
    public class FileAppender : IAppender
    {
        private const string Path = @"..\..\..\log.txt";
        private ILogfile logfile { get; }


        public FileAppender(ILayout layout, ILogfile logfile)
        {
            this.layout = layout;
            this.logfile = logfile;
        }

        public ILayout layout { get; }
        public ReportLevel ReportLevel { get; set; }

        public void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel <= reportLevel)
            {
                var content = String.Format(this.layout.Format, dateTime, reportLevel, message) + Environment.NewLine;
                File.AppendAllText(Path, content);
            }


        }
    }
}
