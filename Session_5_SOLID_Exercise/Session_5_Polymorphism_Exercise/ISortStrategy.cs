using System;
using System.Collections.Generic;
using System.Text;

namespace Session_5_Polymorphism_Exercise
{
    public interface ISortStrategy
    {
        IEnumerable<T> Sort<T>(IEnumerable<T> enumrable);
    }
}
