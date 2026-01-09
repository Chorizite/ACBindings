namespace ACBindings;

// PStringBaseIter_Common<char>
public unsafe struct PStringBaseIter_Common__sbyte
{
    // Child Types
    // PStringBaseIter_Common_vtbl<char>
    public unsafe struct PStringBaseIter_Common_vtbl__sbyte
    {
        // Members
        public System.IntPtr GetStrLen;
        public System.IntPtr IndexToConstPointer;
        public System.IntPtr IndexToChar;
        public System.IntPtr GetPStringPtr;

        // Methods
    }
    // PStringBaseIter_Common_vtbl<unsigned short>
    public unsafe struct PStringBaseIter_Common_vtbl__ushort
    {
        // Members
        public System.IntPtr GetStrLen;
        public System.IntPtr IndexToConstPointer;
        public System.IntPtr IndexToChar;
        public System.IntPtr GetPStringPtr;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint curr;
    public uint mark;

    // Methods
    // PStringBaseIter_Common<char>::Next (template type method)
    // PStringBaseIter_Common<char>::FindChar (template type method)
    // PStringBaseIter_Common<char>::FindChar (template type method)
    // PStringBaseIter_Common<char>::GetSubString (template type method)
    // PStringBaseIter_Common<char>::GetSubString (template type method)
    // PStringBaseIter_Common<char>::Split (template type method)
    // PStringBaseIter_Common<char>::FindSubStringIter (template type method)
    // PStringBaseIter_Common<char>::FindSubString (template type method)
}

// PStringBaseIter_Common<unsigned short>
public unsafe struct PStringBaseIter_Common__ushort
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint curr;
    public uint mark;

    // Methods
}

