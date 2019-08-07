﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    class UsingDeclarations
    {


        // before C# 8.0
        static void WriteLinesToFile(IEnumerable<string> lines)
        {
            using (var file = new System.IO.StreamWriter("WriteLines2.txt"))
            {
                foreach (string line in lines)
                {
                    // If the line doesn't contain the word 'Second', write the line to the file.
                    if (!line.Contains("Second"))
                    {
                        file.WriteLine(line);
                    }
                }
            } // file is disposed here
        }

        // C# 8.0
        static void WriteLinesToFile2(IEnumerable<string> lines)
        {
            using var file = new System.IO.StreamWriter("WriteLines2.txt");
            foreach (string line in lines)
            {
                // If the line doesn't contain the word 'Second', write the line to the file.
                if (!line.Contains("Second"))
                {
                    file.WriteLine(line);
                }
            }
            // file is disposed here
        }
    }
}
