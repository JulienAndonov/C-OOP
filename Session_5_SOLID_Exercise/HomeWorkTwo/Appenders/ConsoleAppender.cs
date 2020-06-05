namespace Logger.Appenders
{
    using System;
    using Logger.Appenders.Contracts;
    using Logger.Layouts;
    using Logger.Layouts.Contracts;
    public class ConsoleAppender :Appender, IAppender
    {
        public ConsoleAppender(ILayout layout)
            :base(layout)
        {
        }

        public ReportLevel ReportLevel { get ; set; }

        public override void Append(string dateTime, ReportLevel reportLevel, string message)
        {
            if (this.ReportLevel<=reportLevel)
            {
            Console.WriteLine(string.Format(this.Layout.Format, dateTime, reportLevel, message));
                this.MessageCounter++;
            }
        }
        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.ReportLevel}, Messages appended: {this.MessageCounter}";
        }
    }
}
