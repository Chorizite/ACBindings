namespace ACBindings;

// Profiler
public unsafe struct Profiler
{
    // Statics
    public static ACBindings.ProfilerTypes.CategoryType* ActiveCategories = (ACBindings.ProfilerTypes.CategoryType*)0x008F20D0;
    public static uint* NumActiveCategories = (uint*)0x008F20E4;
    public static ACBindings.ProfilerStats* Stats = (ACBindings.ProfilerStats*)0x008F20E8;
    public static ACBindings.ProfilerStats* CapturedStats = (ACBindings.ProfilerStats*)0x008F23F0;

    // Methods
    // void __cdecl Profiler::ResetFrameStats()
    public static void ResetFrameStats() => ((delegate* unmanaged[Cdecl]<void>)0x005DE390)();
}

