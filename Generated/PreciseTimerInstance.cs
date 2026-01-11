namespace ACBindings.Internal;

public unsafe struct PreciseTimerInstance
{
    // Base Classes
    public ACBindings.Internal.TimerInstance___TimeSource_QueryPerformanceCounter BaseClass_TimerInstance; // ACBindings.Internal.TimerInstance___TimeSource_QueryPerformanceCounter

    // Child Types
    public unsafe struct PreciseTimerInstance_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.PreciseTimerInstance*, void> PreciseTimerInstance_dtor_0; // function pointer

        // Methods
    }

    // Generated Constructor
    public PreciseTimerInstance() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a new PreciseTimerInstance with reference counting enabled, sets up the high‑resolution query performance counter as its time source, and zeroes all elapsed and external timing offsets.
    /// <code>Offset: 0x0040FC40
    /// void __thiscall PreciseTimerInstance::PreciseTimerInstance(PreciseTimerInstance*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PreciseTimerInstance, void>)0x0040FC40)(ref this);
}

