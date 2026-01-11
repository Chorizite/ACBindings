namespace ACBindings.Internal;

public unsafe struct ThreadsafeGrowableProcessGlobalSortedArray___HResultDebugData
{
    // Child Types
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
    public unsafe struct SharedData
    {
        // Members
        public uint nMemoryFormatVersion;
        public uint nElementsAllocated;
        public uint nElementsUsed;
        public delegate* unmanaged[Cdecl]<ACBindings.Internal.HResultDebugData*, byte> aData; // function pointer

        // Methods
    }

    // Members
    public byte m_bProcessGlobal;
    public System.IntPtr m_hLock;
    public System.IntPtr m_data;
    public System.IntPtr m_ppGlobalData;

    // Methods
}

