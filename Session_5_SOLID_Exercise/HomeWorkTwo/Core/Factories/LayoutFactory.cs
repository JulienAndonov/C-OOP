using Logger.Core.Factories.Contracts;
using Logger.Layouts;
using Logger.Layouts.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Core.Factories
{
    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            switch (type.ToLower())
            {
                case "simplelayout":
                    return new SimpleLayout();
                case "xmllayout":
                    return new XmlLayout();
                default:throw new ArgumentException("Invalid layout type!");
            }
        }
    }
}
