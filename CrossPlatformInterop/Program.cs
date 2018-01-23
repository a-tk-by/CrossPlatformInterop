using System;
using System.Collections.Generic;
using System.Text;

namespace CrossPlatformInterop
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryImport.ProcessData(1, 10, s => Console.WriteLine(s));
        }
    }
}
