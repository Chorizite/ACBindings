namespace ACBindings;

// PStringBaseIter<char>
public unsafe struct PStringBaseIter__sbyte
{
    // Base Classes
    public ACBindings.PStringBaseIter_Common__sbyte BaseClass_PStringBaseIter_Common; // ACBindings.PStringBaseIter_Common__sbyte

    // Child Types
    // PStringBaseIter_vtbl<unsigned short>
    public unsafe struct PStringBaseIter_vtbl__ushort
    {
        // Members
        public System.IntPtr GetStrLen;
        public System.IntPtr IndexToConstPointer;
        public System.IntPtr IndexToChar;
        public System.IntPtr GetPStringPtr;

        // Methods
    }
    // PStringBaseIter_vtbl<char>
    public unsafe struct PStringBaseIter_vtbl__sbyte
    {
        // Members
        public System.IntPtr GetStrLen;
        public System.IntPtr IndexToConstPointer;
        public System.IntPtr IndexToChar;
        public System.IntPtr GetPStringPtr;

        // Methods
    }

    // Members
    public System.IntPtr pstring_ptr;

    // Methods
    // PStringBaseIter<char>::GetStrLen (template type method)
    // PStringBaseIter<char>::Truncate (template type method)
    // PStringBaseIter<char>::Behead (template type method)
    // PStringBaseIter<char>::Insert (template type method)
    // PStringBaseIter<char>::Replace (template type method)
}

// PStringBaseIter<unsigned short>
public unsafe struct PStringBaseIter__ushort
{
    // Base Classes
    public ACBindings.PStringBaseIter_Common__ushort BaseClass_PStringBaseIter_Common; // ACBindings.PStringBaseIter_Common__ushort

    // Members
    public System.IntPtr pstring_ptr;

    // Methods
}

