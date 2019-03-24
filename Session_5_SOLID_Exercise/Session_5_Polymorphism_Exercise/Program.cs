using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Session_5_Polymorphism_Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new int[] { 1, 3, 2, 5, 7 };

            var type = Console.ReadLine();

            var strategy = new QuickSort<int>();

            var result = new List<int>(Sort(numbers, strategy));

            Console.WriteLine(string.Join(" ", result));
        }


        public static IEnumerable<T> Sort<T>(IEnumerable<T> numbers, ISortStrategy sortStrategy)
        {
            return sortStrategy.Sort(numbers);
        }
    }
}
