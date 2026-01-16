namespace ACBindings.Internal;


/// <summary>Facilitates OS‑specific configuration for the profiler’s user interface, enabling platform‑dependent customization and integration.</summary>
public unsafe struct OSSpecificProfilerUIInfo
{
    // Child Types
    public unsafe struct OSSpecificProfilerUIInfo_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OSSpecificProfilerUIInfo*, ACBindings.Internal.ProfilerUI*, void> FillInOSSpecificInfo; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OSSpecificProfilerUIInfo*, uint> GetSystemMemoryAllocated; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OSSpecificProfilerUIInfo*, uint> GetPeakSystemMemoryAllocated; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OSSpecificProfilerUIInfo*, uint> GetVirtualMemoryReserved; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.OSSpecificProfilerUIInfo*, uint> GetPeakVirtualMemoryReserved; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods
}

