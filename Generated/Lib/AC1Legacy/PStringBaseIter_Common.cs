namespace ACBindings.AC1Legacy;

// AC1Legacy::PStringBaseIter_Common<char>
public unsafe struct PStringBaseIter_Common__sbyte
{
    // Child Types
    // AC1Legacy::PStringBaseIter_Common_vtbl<char>
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
    // AC1Legacy::PStringBaseIter_Common_vtbl<unsigned short>
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

// AC1Legacy::PStringBaseIter_Common<unsigned short>
public unsafe struct PStringBaseIter_Common__ushort
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint curr;
    public uint mark;

    // Methods
}

