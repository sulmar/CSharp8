using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    static class NullCoalescingAssignment
    {
        public static void Test()
        {
            Repository repository = new Repository();

            // < C# 7.0
            if (repository.Keys == null)
                repository.Keys = new List<string>();

            repository.Keys = repository.Keys ?? new List<string>();

            // C# 8.0 Null-Coalescing Assignment
            repository.Keys ??= new List<string>();

        }
    }

    class Repository
    {
        public IEnumerable<string> Keys { get; set; }
    }
}
