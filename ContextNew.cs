using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace CSharp8
{
    static class ContextNew
    {
        public static void Test()
        {
            Point[] points = new Point[]
            {
                new Point(1, 4),
                new Point(3, -2),
                new Point(9, 5)
            };

            // before C# 8.0
            Point[] ps = { new Point (1, 4), new Point(3,-2), new Point(9, 5) }; // all Points


          
            // Point[] ps2 = { new (1, 4), new Point(3, -2), new Point(9, 5) }; // all Points

            // List<int> numbers = new List<int>() { 98, 75 };

            // List<int> numbers2 = new() { 98, 75 };

        }
    }

    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
