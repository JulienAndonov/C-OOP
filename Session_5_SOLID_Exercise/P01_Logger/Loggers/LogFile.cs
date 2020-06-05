using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using P01_Logger.Loggers.Contracts;
using System.Linq;

namespace P01_Logger.Loggers
{
    public class LogFile : ILogfile
    {
        public LogFile(string Path)
        {
            this.Path = Path;
        }

        public int Size { get; private set; }

        public string Path { get; private set; }

        public void ComputeSize(string message)
        {
            this.Size += message.Where(char.IsLetter).Sum(x => x);
        }
    }
}

