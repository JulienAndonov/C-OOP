using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    public class EngineFactory
    {
        public Engine Create(int power, int speed)
        {
            return new Engine(speed, power);
        }
    }
}
