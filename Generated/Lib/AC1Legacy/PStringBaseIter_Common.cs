namespace ACBindings.Internal.AC1Legacy;

public unsafe struct PStringBaseIter_Common__sbyte
{
    // Child Types
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

public unsafe struct PStringBaseIter_Common__ushort
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint curr;
    public uint mark;

    // Methods
}

