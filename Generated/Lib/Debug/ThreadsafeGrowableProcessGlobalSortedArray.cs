namespace ACBindings.Internal;

public unsafe struct ThreadsafeGrowableProcessGlobalSortedArray___HResultDebugData
{
    // Child Types

    /// <summary>Facilitates concurrent access to a dynamically resizable, globally sorted collection of HResultDebugData entries by tracking allocation state, usage count, and providing a pointer to the underlying data buffer. Includes a memory format version for compatibility.</summary>
    public unsafe struct SharedData
    {
        // Members
        public uint nMemoryFormatVersion;
        public uint nElementsAllocated;
        public uint nElementsUsed;
        public ACBindings.Internal.HResultDebugData* aData;

        // Methods
    }

    // Members
    public byte m_bProcessGlobal;
    public System.IntPtr m_hLock;
    public System.IntPtr m_data;
    public System.IntPtr m_ppGlobalData;

    // Methods
}

public unsafe struct ThreadsafeGrowableProcessGlobalSortedArray__void_ptr
{
    // Child Types

    /// <summary>Stores metadata and a dynamically allocated array of function pointers used in a thread‑safe global sorted collection to process <c>HResultDebugData</c>. Tracks memory format version, allocation size, and element usage.</summary>
    public unsafe struct SharedData
    {
        // Members
        public uint nMemoryFormatVersion;
        public uint nElementsAllocated;
        public uint nElementsUsed;
        public static delegate* unmanaged[Cdecl]<ACBindings.Internal.HResultDebugData*, byte> aData; // function pointer

        // Methods
    }

    // Members
    public byte m_bProcessGlobal;
    public System.IntPtr m_hLock;
    public System.IntPtr m_data;
    public System.IntPtr m_ppGlobalData;

    // Methods
}

