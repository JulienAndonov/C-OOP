using Logger.Appenders.Contracts;
using Logger.Layouts;
using Logger.Layouts.Contracts;
using Logger.Loggers.Contracts;
using System;
using System.IO;

namespace Logger.Appenders
{
    public class FileAppender :Appender, IAppender
    {
        private const string Path = @"../../../log.txt";
        private ILogFile logFile;

        public FileAppender(ILayout layout, ILogFile logFile)
            :base(layout)
        {
            this.logFile = logFile;
        }

        public ReportLevel ReportLevel { get; set; }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel<=ReportLevel)
            {
            string content = string.Format(this.Layout.Format, dateTime, reportLevel, message)+Environment.NewLine;

                this.logFile.Write(content); //
            File.AppendAllText(Path, content);
                this.MessageCounter++;
            }
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel}, Messages appended: {this.MessageCounter}, File size: {this.logFile.Size}";
        }
    }
}
