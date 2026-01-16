namespace ACBindings.Internal;


/// <summary>Maintains global profiler statistics and five category-specific frame metrics, enabling detailed performance analysis across various execution segments.</summary>
public unsafe struct ProfilerStats
{
    // Members
    public ACBindings.Internal.ProfilerTypes.GlobalStatsType Global;
    public fixed byte Categories_Raw[680];
    public ACBindings.Internal.ProfilerTypes.FrameStatsType* Categories => (ACBindings.Internal.ProfilerTypes.FrameStatsType*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref Categories_Raw[0]);

    // Methods
}

