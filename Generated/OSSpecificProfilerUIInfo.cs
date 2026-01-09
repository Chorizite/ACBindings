namespace ACBindings;

// OSSpecificProfilerUIInfo
public unsafe struct OSSpecificProfilerUIInfo
{
    // Child Types
    // OSSpecificProfilerUIInfo_vtbl
    public unsafe struct OSSpecificProfilerUIInfo_vtbl
    {
        // Members
        public System.IntPtr FillInOSSpecificInfo; // function pointer
        public System.IntPtr GetSystemMemoryAllocated; // function pointer
        public System.IntPtr GetPeakSystemMemoryAllocated; // function pointer
        public System.IntPtr GetVirtualMemoryReserved; // function pointer
        public System.IntPtr GetPeakVirtualMemoryReserved; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

