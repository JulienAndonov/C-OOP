using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace P04_Telephony
{
    public class Smartphone : ICalling, IBrowsing
    {
        public string Browse(string webSite)
        {
            if (webSite.Any(c => char.IsDigit(c) == true))
            {
                throw new ArgumentException("Invalid URL!");
            }

            return $"Browsing: {webSite}!";
        }


        public string Call(string number)
        {
            if (number.Any(c => char.IsLetter(c) == true))
            {
                throw new ArgumentException("Invalid number!");
            }
            return $"Calling... {number}";
        }
    }
}
