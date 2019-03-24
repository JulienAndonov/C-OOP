using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Session_5_Polymorphism_Exercise
{
    public class QuickSort<T> : ISortStrategy
    {
        public IEnumerable<T> Sort<T>(IEnumerable<T> enumrable)
        {
            List<T> list = new List<T>(enumrable);
            list.Sort();
            enumrable = list;
            return enumrable;
        }
    }

  

}

