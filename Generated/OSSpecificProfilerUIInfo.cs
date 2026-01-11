namespace ACBindings.Internal;

public unsafe struct OSSpecificProfilerUIInfo
{
    // Child Types
    public unsafe struct OSSpecificProfilerUIInfo_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OSSpecificProfilerUIInfo*, ACBindings.Internal.ProfilerUI*, void> FillInOSSpecificInfo; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OSSpecificProfilerUIInfo*, uint> GetSystemMemoryAllocated; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OSSpecificProfilerUIInfo*, uint> GetPeakSystemMemoryAllocated; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OSSpecificProfilerUIInfo*, uint> GetVirtualMemoryReserved; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.OSSpecificProfilerUIInfo*, uint> GetPeakVirtualMemoryReserved; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

