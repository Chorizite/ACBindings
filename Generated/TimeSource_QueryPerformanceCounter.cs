namespace ACBindings.Internal;

public unsafe struct TimeSource_QueryPerformanceCounter
{
    // Child Types
    public unsafe struct StateData
    {
        // Members
        public double tLastTime;
        public uint dwFlags;
        public double tReference;
        public uint dwReferenceTGT;
        public ulong qwReferenceQPC;

        // Methods
    }
    // TimeSource_QueryPerformanceCounter::StateFlags
    public enum StateFlags : byte
    {
        sfInitialized = 0x0,
        sfDisableQPC = 0x1
    }

    // Members
    public double m_rPerfsPerSecond;
    public ulong m_qwPerfsPerMS;
    public ulong m_qwPerfCountTolerance;
    public ACBindings.Internal.TimeSource_QueryPerformanceCounter.StateData m_cVolatileState;
    public ACBindings.Internal.CSpinLock m_SpinLock;

    // Generated Constructor
    public TimeSource_QueryPerformanceCounter() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes the query performance counter time source, resetting its spin‑lock structure and volatile state flags to zero.
    /// <code>Offset: 0x00411190
    /// void __thiscall TimeSource_QueryPerformanceCounter::TimeSource_QueryPerformanceCounter(TimeSource_QueryPerformanceCounter*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimeSource_QueryPerformanceCounter, void>)0x00411190)(ref this);

    /// <summary>Initializes the time source by querying the system performance counter frequency, computing per‑second and per‑millisecond values, setting a tolerance threshold, establishing a reference point, and updating internal state flags in a thread‑safe manner.
    /// <code>Offset: 0x004111B0
    /// void __thiscall TimeSource_QueryPerformanceCounter::Init(TimeSource_QueryPerformanceCounter*)</code>
    /// </summary>
    /// <param name="this">The TimeSource_QueryPerformanceCounter instance to initialize.</param>
    public void Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimeSource_QueryPerformanceCounter, void>)0x004111B0)(ref this);

    /// <summary>Computes the current cumulative elapsed time, using a high‑resolution performance counter when available and falling back to the system timer if necessary.
    /// <code>Offset: 0x00411280
    /// long double __thiscall TimeSource_QueryPerformanceCounter::ComputeElapsedTime(TimeSource_QueryPerformanceCounter*,bool)</code>
    /// </summary>
    /// <param name="i_bUpdateInternalData">If true, writes the computed timing data back into the instance; otherwise only returns the value without modifying the stored state.</param>
    /// <returns>The elapsed time in seconds as a long double.</returns>
    public double ComputeElapsedTime(byte i_bUpdateInternalData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimeSource_QueryPerformanceCounter, byte, double>)0x00411280)(ref this, i_bUpdateInternalData);
}

