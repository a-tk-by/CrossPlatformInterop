using System;
using System.Collections.Generic;
using System.Text;

namespace CrossPlatformInterop
{
    class Program
    {
        static void Main(string[] args)
        {
            ILibraryImport import = LibraryImport.Select();
            import.ProcessData(1, 10, s => Console.WriteLine(s));
        }
    }
}
