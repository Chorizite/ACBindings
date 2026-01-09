namespace ACBindings;

// CStopWatch
public unsafe struct CStopWatch
{
    // Child Types
    // CStopWatch_vtbl
    public unsafe struct CStopWatch_vtbl
    {
        // Members
        public System.IntPtr CStopWatch_dtor_0; // function pointer
        public System.IntPtr Start; // function pointer
        public System.IntPtr Stop; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public double m_startTime;

    // Methods
}

