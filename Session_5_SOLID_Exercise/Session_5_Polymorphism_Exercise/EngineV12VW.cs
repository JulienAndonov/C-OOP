using System;
using System.Collections.Generic;
using System.Text;

namespace Session_5_Polymorphism_Exercise
{
    public class EngineV12VW : IEngine
    {
        public string Type { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int volume { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Originator { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
