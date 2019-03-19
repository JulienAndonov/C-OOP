using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Ferrari
{
    public interface ICar
    {
        string Model { get;}
        Driver Driver { get;set; }

        string PushGas();
        string UseBrakes();

    }
}
