using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CrossPlatformInterop
{
    public class LibraryImport
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet=CharSet.Ansi)]
        public delegate void Notification(string value);

        [DllImport("CrossPlatformLibrary-x64", CallingConvention=CallingConvention.StdCall, ExactSpelling = false)]
        public static extern int ProcessData(int start, int count, Notification notification);
    }
}
