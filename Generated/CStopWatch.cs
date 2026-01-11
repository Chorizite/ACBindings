namespace ACBindings.Internal;

public unsafe struct CStopWatch
{
    // Child Types
    public unsafe struct CStopWatch_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CStopWatch*, void> CStopWatch_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CStopWatch*, void> Start; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CStopWatch*, double> Stop; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public double m_startTime;

    // Methods
}

