namespace ACBindings.Internal;

public unsafe struct Profiler
{
    // Statics
    public static ACBindings.Internal.ProfilerTypes.CategoryType* ActiveCategories = (ACBindings.Internal.ProfilerTypes.CategoryType*)0x008F20D0;
    public static uint* NumActiveCategories = (uint*)0x008F20E4;
    public static ACBindings.Internal.ProfilerStats* CapturedStats = (ACBindings.Internal.ProfilerStats*)0x008F23F0;

    // Methods

    /// <summary>
    /// <code>Offset: 0x005DE390
    /// void __cdecl Profiler::ResetFrameStats()</code>
    /// </summary>
    public static void ResetFrameStats() => ((delegate* unmanaged[Cdecl]<void>)0x005DE390)();
}

