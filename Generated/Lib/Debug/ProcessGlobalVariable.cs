namespace ACBindings.Internal;

public unsafe struct ProcessGlobalVariable___ThreadsafeGrowableProcessGlobalSortedArray___HResultDebugData_SharedData___DefaultFactory___ThreadsafeGrowableProcessGlobalSortedArray___HResultDebugData_SharedData___EnvVarTable
{
    // Child Types

    /// <summary>Container encapsulating a process‑global variable instance, preserving its data buffer, reference count, ownership flag, and name for lookup in environment tables.</summary>
    public unsafe struct Container
    {
        // Members
        public fixed int m_buffer[4];
        public uint m_refcount;
        public System.IntPtr m_object;
        public byte m_allocated;
        public fixed sbyte m_variableName[100];

        // Methods
    }

    // Members
    public System.IntPtr m_globalContainer;

    // Methods
}

public unsafe struct ProcessGlobalVariable___ThreadsafeGrowableProcessGlobalSortedArray__void_ptr_SharedData___DefaultFactory___ThreadsafeGrowableProcessGlobalSortedArray__void_ptr_SharedData___EnvVarTable
{
    // Child Types

    /// <summary>Represents a container that holds metadata for a process‑wide global variable, including its reference count, allocation state, associated object, and a human‑readable name.</summary>
    public unsafe struct Container
    {
        // Members
        public fixed int m_buffer[4];
        public uint m_refcount;
        public System.IntPtr m_object;
        public byte m_allocated;
        public fixed sbyte m_variableName[100];

        // Methods
    }

    // Members
    public System.IntPtr m_globalContainer;

    // Methods
}

