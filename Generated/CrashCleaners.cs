namespace ACBindings;

// CrashCleaners
public unsafe struct CrashCleaners
{
    // Base Classes
    public ACBindings.CPluginManagerTemplate__CrashCleaner BaseClass_CPluginManagerTemplate; // ACBindings.CPluginManagerTemplate__CrashCleaner

    // Methods
    // void __cdecl CrashCleaners::CallCrashCleaners()
    public static void CallCrashCleaners() => ((delegate* unmanaged[Cdecl]<void>)0x0040E3A0)();
}

