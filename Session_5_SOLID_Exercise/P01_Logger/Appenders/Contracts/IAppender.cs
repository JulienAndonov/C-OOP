using P01_Logger.Layouts.Contracts;
using P01_Logger.Loggers.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Logger.Appenders
{
    public interface IAppender
    {
        ILayout layout { get;}

        void Append(string dateTime,ReportLevel reportLevel,string message);

        ReportLevel ReportLevel { get; set; }
    }
}
