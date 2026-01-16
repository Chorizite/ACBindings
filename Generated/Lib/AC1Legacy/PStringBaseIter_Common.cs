namespace ACBindings.Internal.AC1Legacy;


/// <summary>Provides an iterator context for character sequences in AC1Legacy, tracking the current position and optional mark while supporting polymorphic behavior via a vftable.</summary>
public unsafe struct PStringBaseIter_Common__sbyte
{
    // Child Types

    /// <summary>Provides virtual table entries for manipulating character-based string iterators in AC1Legacy, including length retrieval, split operation, and index-to-pointer conversions.</summary>
    public unsafe struct PStringBaseIter_Common_vtbl__sbyte
    {
        // Members
        public System.IntPtr GetStrLen;
        public fixed byte gap4[4];
        public System.IntPtr Split;
        public System.IntPtr IndexToConstPointer;
        public System.IntPtr IndexToChar;

        // Methods
    }

    /// <summary>Provides virtual function pointers for operations on a wide‑character string iterator, including length retrieval, splitting, and character access by index.</summary>
    public unsafe struct PStringBaseIter_Common_vtbl__ushort
    {
        // Members
        public System.IntPtr GetStrLen;
        public fixed byte gap4[4];
        public System.IntPtr Split;
        public System.IntPtr IndexToConstPointer;
        public System.IntPtr IndexToChar;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint curr;
    public uint mark;

    // Methods
}


/// <summary>Iterates through an AC1 legacy string of 16‑bit characters, maintaining the current index and a bookmark position for lookahead or backtracking.</summary>
public unsafe struct PStringBaseIter_Common__ushort
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint curr;
    public uint mark;

    // Methods
}

