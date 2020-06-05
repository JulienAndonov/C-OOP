using P01_Logger.Appenders.Contracts;
using P01_Logger.Layouts.Contracts;
using P01_Logger.Loggers;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Logger.Appenders
{
    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            string typeAsLower = type.ToLower();
            switch (typeAsLower)
            {
                case "consoleappender":
                    return new ConsoleAppender(layout);
                case "fileappender":
                    return new FileAppender(layout, new LogFile(@"..\..\..\log.txt"));
                default:
                    throw new ArgumentException($"Invalid appender type: {type}");
            }
        }
    }
}
