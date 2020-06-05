using Logger.Appenders.Contracts;
using Logger.Core.Contracts;
using Logger.Core.Factories;
using Logger.Core.Factories.Contracts;
using Logger.Layouts;
using Logger.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private ICollection<IAppender> appenders;
        private IAppenderFactory appenderFactory;
        private ILayoutFactory layoutFactory;
        public CommandInterpreter()
        {
            this.appenders = new List<IAppender>();
            this.appenderFactory = new AppenderFactory();
            this.layoutFactory = new LayoutFactory();
        }
        public void AddAppender(string[] args)
        {
            string appenderType = args[0];
            string layoutType = args[1];
            ReportLevel reportLevel = ReportLevel.INFO;

            if (args.Length==3)
            {
                reportLevel = Enum.Parse<ReportLevel>(args[2]);
            }

            ILayout layout = this.layoutFactory.CreateLayout(layoutType);
           IAppender appender= this.appenderFactory.CreateAppender(appenderType, layout);

            appender.ReportLevel = reportLevel;
            this.appenders.Add(appender);
        }

        public void AddReport(string[] args)
        {
            string reportType = args[0];
            string dateTime = args[1];
            string message = args[2];

            ReportLevel reportLevel = Enum.Parse<ReportLevel>(reportType);

            foreach (var appender in this.appenders)
            {
                appender.Append(dateTime, reportLevel, message);
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Logger info"+Environment.NewLine);

            foreach (var appender in this.appenders)
            {
                Console.WriteLine(appender.ToString()+Environment.NewLine);
            }
        }
    }
}
