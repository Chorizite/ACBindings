namespace ACBindings.AC1Legacy;

// AC1Legacy::PStringBaseIter_Const<char>
public unsafe struct PStringBaseIter_Const__sbyte
{
    // Base Classes
    public ACBindings.AC1Legacy.PStringBaseIter_Common__sbyte BaseClass_AC1Legacy_PStringBaseIter_Common; // ACBindings.AC1Legacy.PStringBaseIter_Common__sbyte

    // Child Types
    // AC1Legacy::PStringBaseIter_Const_vtbl<char>
    public unsafe struct PStringBaseIter_Const_vtbl__sbyte
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
    public System.IntPtr pstring_ptr;

    // Methods
}

