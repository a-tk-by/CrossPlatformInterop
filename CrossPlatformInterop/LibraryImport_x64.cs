using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CrossPlatformInterop
{
    internal class LibraryImport_x64 : ILibraryImport
    {
        [DllImport("CrossPlatformLibrary-x64", CallingConvention = CallingConvention.StdCall, ExactSpelling = false, EntryPoint = "ProcessData")]
        private static extern int ProcessDataInternal(int start, int count, Notification notification);

        public int ProcessData(int start, int count, Notification notification)
        {
            return ProcessDataInternal(start, count, notification);
        }
    }
}
