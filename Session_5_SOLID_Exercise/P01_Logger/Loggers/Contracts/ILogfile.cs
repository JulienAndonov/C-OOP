using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Logger.Loggers.Contracts
{
    public interface ILogfile
    {
        void ComputeSize(string message);
        int Size { get; }
        string Path { get; }

    }
}
