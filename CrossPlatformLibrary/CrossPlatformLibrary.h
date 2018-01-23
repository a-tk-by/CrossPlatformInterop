// The following ifdef block is the standard way of creating macros which make exporting 
// from a DLL simpler. All files within this DLL are compiled with the CROSSPLATFORMLIBRARY_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see 
// CROSSPLATFORMLIBRARY_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef CROSSPLATFORMLIBRARY_EXPORTS
#define CROSSPLATFORMLIBRARY_API __declspec(dllexport)
#else
#define CROSSPLATFORMLIBRARY_API __declspec(dllimport)
#endif

#include <cstdint>

typedef void(__stdcall* Notification)(const char*);

extern "C" int32_t CROSSPLATFORMLIBRARY_API __stdcall ProcessData(int32_t start, int32_t count, Notification notification);

