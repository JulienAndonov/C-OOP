using Logger.Layouts;

namespace Logger.Appenders.Contracts
{
    public interface IAppender
    {
        int MessageCounter { get; }
        ReportLevel ReportLevel { get; set; }
        void Append(string dateTime, ReportLevel reportLevel, string message);
    }
}
