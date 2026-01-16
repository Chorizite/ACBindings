namespace ACBindings.Internal;

public unsafe struct QTIsaac__uint
{
    // Child Types

    /// <summary>Maintains state for the ISAAC pseudorandom number generator, storing counters, result and memory buffers, and internal registers.</summary>
    /// <summary>Provides all data required to generate a sequence of 32‑bit pseudo‑random values within the application.</summary>
    public unsafe struct randctx
    {
        // Members
        public uint randcnt;
        public uint* randrsl;
        public uint* randmem;
        public uint randa;
        public uint randb;
        public uint randc;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.QTIsaac__uint.randctx m_rc;

    // Methods
}

