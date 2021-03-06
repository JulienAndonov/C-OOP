﻿using Logger.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Core
{
    public class Engine : IEngine
    {
        private ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }
        public void Run()
        {
            int appendersCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < appendersCount; i++)
            {
                string[] appenderArgs = Console.ReadLine().Split();

                commandInterpreter.AddAppender(appenderArgs);
            }

            string input = Console.ReadLine();

            while (input!="END")
            {
                string[] reportArgs = input.Split("|");
                this.commandInterpreter.AddReport(reportArgs);

                input = Console.ReadLine();
            }

            this.commandInterpreter.PrintInfo();
        }
    }
}
