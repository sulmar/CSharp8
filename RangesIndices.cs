using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharp8
{
    static class RangesIndices
    {
        public static void Test()
        {
            Range range = 1..4;


            IndicesTest();

        }

        public static void IndicesTest()
        {
            Index d1 = 2;  // number 2 from beginning
            Index d2 = ^3; // number 3 from end

            string[] week = 
            {
               "Monday",
               "Tuesday",
               "Wednesday",
               "Thursday",
               "Friday",
               "Saturday",
               "Sunday"
            };

            Console.WriteLine($"{week[d1]}, {week[d2]}");

            // before C# 8.0
            var lastDay = week[week.Count() - 1]; // Sunday

            // C# 8.0
           // var lastDay = week[^1]; // Sunday


        }
    }


}
