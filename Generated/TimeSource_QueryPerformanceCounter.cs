namespace ACBindings;

// TimeSource_QueryPerformanceCounter
public unsafe struct TimeSource_QueryPerformanceCounter
{
    // Child Types
    // TimeSource_QueryPerformanceCounter::StateData
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
    public ACBindings.TimeSource_QueryPerformanceCounter.StateData m_cVolatileState;
    public ACBindings.CSpinLock m_SpinLock;

    // Generated Constructor
    public TimeSource_QueryPerformanceCounter() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall TimeSource_QueryPerformanceCounter::TimeSource_QueryPerformanceCounter(TimeSource_QueryPerformanceCounter*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TimeSource_QueryPerformanceCounter, void>)0x00411190)(ref this);
    // void __thiscall TimeSource_QueryPerformanceCounter::Init(TimeSource_QueryPerformanceCounter*)
    public void Init() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TimeSource_QueryPerformanceCounter, void>)0x004111B0)(ref this);
    // long double __thiscall TimeSource_QueryPerformanceCounter::ComputeElapsedTime(TimeSource_QueryPerformanceCounter*,bool)
    public double ComputeElapsedTime(byte i_bUpdateInternalData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TimeSource_QueryPerformanceCounter, byte, double>)0x00411280)(ref this, i_bUpdateInternalData);
}

