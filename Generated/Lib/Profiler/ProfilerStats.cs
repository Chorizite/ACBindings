namespace ACBindings;

// ProfilerStats
public unsafe struct ProfilerStats
{
    // Members
    public ACBindings.ProfilerTypes.GlobalStatsType Global;
    public fixed byte Categories_Raw[680];
    public ACBindings.ProfilerTypes.FrameStatsType* Categories => (ACBindings.ProfilerTypes.FrameStatsType*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref Categories_Raw[0]);

    // Methods
}

