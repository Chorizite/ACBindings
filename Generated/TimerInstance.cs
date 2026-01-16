namespace ACBindings.Internal;


/// <summary>
///   Represents a high‑resolution timer instance based on the Windows QueryPerformanceCounter source. Provides accurate elapsed time calculation, optional external offsets, and tracks initialization state.
/// </summary>
public unsafe struct TimerInstance___TimeSource_QueryPerformanceCounter
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Members
    public ACBindings.Internal.TimeSource_QueryPerformanceCounter m_cTimeSource;
    public double m_rExternalOffset;
    public double m_tElapsedTime;
    public double m_tExternalTime;
    public byte m_bInitialized;

    // Methods
}

