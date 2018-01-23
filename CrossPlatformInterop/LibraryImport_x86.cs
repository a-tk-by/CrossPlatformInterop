using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CrossPlatformInterop
{
    internal class LibraryImport_x86 : ILibraryImport
    {
        [DllImport("CrossPlatformLibrary-x86", CallingConvention = CallingConvention.StdCall, ExactSpelling = false, EntryPoint = "_ProcessData@12")]
        private static extern int ProcessDataInternal(int start, int count, Notification notification);

        public int ProcessData(int start, int count, Notification notification)
        {
            return ProcessDataInternal(start, count, notification);
        }
    }
}
