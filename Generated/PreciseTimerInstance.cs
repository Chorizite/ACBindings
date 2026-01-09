namespace ACBindings;

// PreciseTimerInstance
public unsafe struct PreciseTimerInstance
{
    // Base Classes
    public ACBindings.TimerInstance__TimeSource_QueryPerformanceCounter BaseClass_TimerInstance; // ACBindings.TimerInstance__TimeSource_QueryPerformanceCounter

    // Child Types
    // PreciseTimerInstance_vtbl
    public unsafe struct PreciseTimerInstance_vtbl
    {
        // Members
        public System.IntPtr PreciseTimerInstance_dtor_0; // function pointer

        // Methods
    }

    // Generated Constructor
    public PreciseTimerInstance() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall PreciseTimerInstance::PreciseTimerInstance(PreciseTimerInstance*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.PreciseTimerInstance, void>)0x0040FC40)(ref this);
}

