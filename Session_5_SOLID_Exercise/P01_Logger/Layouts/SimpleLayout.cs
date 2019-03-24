using System;
using System.Collections.Generic;
using System.Text;
using P01_Logger.Layouts.Contracts;

namespace P01_Logger.Layouts
{
    public class SimpleLayout : ILayout
    {
        public string Format => "{0} - {1} - {2}";
    }
}
    