using P01_Logger.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P01_Logger.Layouts
{
    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            string typeAsLower = type.ToLower();
            switch (typeAsLower)
            {
                case "simplelayout":
                    return new SimpleLayout();
                case "xmllayout":
                    return new XmlLayout();
                default:
                    throw new ArgumentException($"Invalid Layout type: {type}!");


            }
        }
    }
}
