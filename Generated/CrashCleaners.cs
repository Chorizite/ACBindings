namespace ACBindings.Internal;

public unsafe struct CrashCleaners
{
    // Base Classes
    public ACBindings.Internal.CPluginManagerTemplate___CrashCleaner BaseClass_CPluginManagerTemplate; // ACBindings.Internal.CPluginManagerTemplate___CrashCleaner

    // Methods

    /// <summary>Runs the cleanup routines of all registered crash‑cleaner plugins exactly once, destroying each plugin instance and preventing repeated calls.
    /// <code>Offset: 0x0040E3A0
    /// void __cdecl CrashCleaners::CallCrashCleaners()</code>
    /// </summary>
    public static void CallCrashCleaners() => ((delegate* unmanaged[Cdecl]<void>)0x0040E3A0)();
}

