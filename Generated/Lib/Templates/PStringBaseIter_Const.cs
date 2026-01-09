namespace ACBindings;

// PStringBaseIter_Const<char>
public unsafe struct PStringBaseIter_Const__sbyte
{
    // Base Classes
    public ACBindings.PStringBaseIter_Common__sbyte BaseClass_PStringBaseIter_Common; // ACBindings.PStringBaseIter_Common__sbyte

    // Child Types
    // PStringBaseIter_Const_vtbl<char>
    public unsafe struct PStringBaseIter_Const_vtbl__sbyte
    {
        // Members
        public System.IntPtr GetStrLen;
        public System.IntPtr IndexToConstPointer;
        public System.IntPtr IndexToChar;
        public System.IntPtr GetPStringPtr;

        // Methods
    }
    // PStringBaseIter_Const_vtbl<unsigned short>
    public unsafe struct PStringBaseIter_Const_vtbl__ushort
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
    // PStringBaseIter_Const<char>::IndexToChar (template type method)
    // PStringBaseIter_Const<char>::IndexToConstPointer (template type method)
}

// PStringBaseIter_Const<unsigned short>
public unsafe struct PStringBaseIter_Const__ushort
{
    // Base Classes
    public ACBindings.PStringBaseIter_Common__ushort BaseClass_PStringBaseIter_Common; // ACBindings.PStringBaseIter_Common__ushort

    // Members
    public System.IntPtr pstring_ptr;

    // Methods
}

