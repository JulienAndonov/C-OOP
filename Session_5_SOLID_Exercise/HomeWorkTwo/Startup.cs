namespace Logger
{
    using Logger.Appenders;
    using Logger.Core;
    using Logger.Core.Contracts;
    using Logger.Layouts;
    using Logger.Loggers;
    public class Program
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            Engine enginie = new Engine(commandInterpreter);
            enginie.Run();
        }
    }
}
