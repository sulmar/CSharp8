using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    class DisposableRefStructs
    {
        public static void Test()
        {
            using (new RefStruct()) // no error with C# 8
            {
            }
        }
    }

    ref struct RefStruct
    {
        public void Dispose()
        {
        }
    }

}
