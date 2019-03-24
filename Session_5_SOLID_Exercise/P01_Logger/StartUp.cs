using P01_Logger.Core;
using P01_Logger.Core.Contracts;
using System;

namespace P01_Logger
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ICommandInterpreter commandInterpreter = new CommandInterpreter();
            Engine engine = new Engine(commandInterpreter);
            engine.Run();
        }
    }
}
