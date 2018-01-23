using System;

namespace CrossPlatformInterop
{
    public static class LibraryImport
    {
        public static ILibraryImport Select()
        {
            if (IntPtr.Size == 4) // 32-bit application
            {
                return new LibraryImport_x86();
            }
            else // 64-bit application
            {
                return new LibraryImport_x64();
            }
        }
    }
}
