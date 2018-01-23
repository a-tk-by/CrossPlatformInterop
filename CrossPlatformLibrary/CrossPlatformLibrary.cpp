// CrossPlatformLibrary.cpp : Defines the exported functions for the DLL application.
//

#include "CrossPlatformLibrary.h"
#include <Windows.h>
#include <stdio.h>

int32_t __stdcall ProcessData(int32_t start, int32_t count, Notification notification)
{
    if (notification == nullptr)
    {
        return 0;
    }
    int32_t result = 0;
    for (int32_t i = 0; i < count; ++i)
    {
        char buffer[64];
        result += sprintf_s(buffer, "Notification %d from C++", i);
        notification(buffer);
        Sleep(rand() % 500 + 500);
    }
    return result;
}
