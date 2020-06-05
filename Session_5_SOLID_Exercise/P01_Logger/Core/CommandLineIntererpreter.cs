﻿using P01_Logger.Appenders;
using P01_Logger.Appenders.Contracts;
using P01_Logger.Core.Contracts;
using P01_Logger.Layouts;
using P01_Logger.Layouts.Contracts;
using P01_Logger.Loggers.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Logger.Core
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
            string typeAppender = args[0];
            string typeLayout = args[1];
            ReportLevel reportLevel = ReportLevel.INFO;

            if (args.Length == 3)
            {
                reportLevel = Enum.Parse<ReportLevel>(args[2]);
            }

            ILayout layout = layoutFactory.CreateLayout(typeLayout);
            IAppender appender = this.appenderFactory.CreateAppender(typeAppender, layout);
            appender.ReportLevel = reportLevel;
            appenders.Add(appender);
        }

        public void AddReport(string[] args)
        {
            string reportType = args[0];
            string date = args[1];
            string message = args[2];

            ReportLevel reportLevel = Enum.Parse<ReportLevel>(reportType);

            foreach (var appender in appenders)
            {
                appender.Append(date, reportLevel, message);
            }
        }

        public void PrintInfo()
        {
            Console.WriteLine("Logger info");

            foreach(var appender in appenders)
            {
                Console.WriteLine(appender);
            }
        }
    }
}
