namespace ACBindings.Internal;

public unsafe struct ProfilerStats
{
    // Members
    public ACBindings.Internal.ProfilerTypes.GlobalStatsType Global;
    public fixed byte Categories_Raw[680];
    public ACBindings.Internal.ProfilerTypes.FrameStatsType* Categories => (ACBindings.Internal.ProfilerTypes.FrameStatsType*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref Categories_Raw[0]);

    // Methods
}

