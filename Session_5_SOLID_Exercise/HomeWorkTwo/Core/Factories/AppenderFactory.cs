using Logger.Appenders;
using Logger.Appenders.Contracts;
using Logger.Core.Factories.Contracts;
using Logger.Layouts.Contracts;
using Logger.Loggers;
using System;

namespace Logger.Core.Factories
{
    public class AppenderFactory : IAppenderFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            switch (type.ToLower())
            {
                case "consoleappender":
                    return new ConsoleAppender(layout);
                case "fileappender":
                    return new FileAppender(layout, new LogFile());
                default:
                    throw new ArgumentException("Invalid appender type!");
            }
        }
    }
}
