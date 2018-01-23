using System.Runtime.InteropServices;

namespace CrossPlatformInterop
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
    public delegate void Notification(string value);

    public interface ILibraryImport
    {
        int ProcessData(int start, int count, Notification notification);
    }
}