namespace ACBindings.Internal;

// DebugFlagBits
public enum DebugFlagBits : ushort
{
    DbgOutputToDebugger = 0x1,
    DbgOutputToFile = 0x2,
    DbgOutputToUser = 0x4,
    DbgOutputAssertDlgs = 0x8,
    DbgPrintfEnabled = 0x10,
    DbgDbgAssertsAssert = 0x20,
    DbgAssertsAssert = 0x40,
    DbgWslAssertsAssert = 0x80,
    DbgPerfAssertsAssert = 0x100,
    DbgEnableExceptionHandler = 0x200,
    DbgEnableFloatingPointExceptions = 0x400,
    DbgPlaceLogsInAppDir = 0x800,
    DbgNoAutomaticStackTrace = 0x1000,
    DbgNeedToInitialize = 0x2000,
    DbgEnableMemoryExceptions = 0x4000
}

