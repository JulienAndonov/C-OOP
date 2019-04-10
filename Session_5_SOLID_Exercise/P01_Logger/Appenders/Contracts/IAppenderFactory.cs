using P01_Logger.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Logger.Appenders.Contracts
{
    public interface IAppenderFactory
    {
        IAppender CreateAppender(string type, ILayout layout);
    }
}
