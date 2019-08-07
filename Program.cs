using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

#nullable enable

namespace CSharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            PositionalPatterns.Test();


            Ranges.Test();
            SwitchExpressions.Test();
            NullCoalescingAssignment.Test();
        }

    }
}
