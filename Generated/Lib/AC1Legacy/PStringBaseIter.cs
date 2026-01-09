namespace ACBindings.AC1Legacy;

// AC1Legacy::PStringBaseIter<char>
public unsafe struct PStringBaseIter__sbyte
{
    // Base Classes
    public ACBindings.AC1Legacy.PStringBaseIter_Common__sbyte BaseClass_AC1Legacy_PStringBaseIter_Common; // ACBindings.AC1Legacy.PStringBaseIter_Common__sbyte

    // Child Types
    // AC1Legacy::PStringBaseIter_vtbl<char>
    public unsafe struct PStringBaseIter_vtbl__sbyte
    {
        // Members
        public System.IntPtr GetStrLen;
        public fixed byte gap4[4];
        public System.IntPtr Split;
        public System.IntPtr IndexToConstPointer;
        public System.IntPtr IndexToChar;

        // Methods
    }
    // AC1Legacy::PStringBaseIter_vtbl<unsigned short>
    public unsafe struct PStringBaseIter_vtbl__ushort
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
    // AC1Legacy::PStringBaseIter<char>::IndexToConstPointer (template type method)
    // AC1Legacy::PStringBaseIter<char>::IndexToChar (template type method)
    // AC1Legacy::PStringBaseIter<char>::GetStrLen (template type method)
    // AC1Legacy::PStringBaseIter<char>::Truncate (template type method)
    // AC1Legacy::PStringBaseIter<char>::Split (template type method)
    // AC1Legacy::PStringBaseIter<char>::Split (template type method)
}

// AC1Legacy::PStringBaseIter<unsigned short>
public unsafe struct PStringBaseIter__ushort
{
    // Base Classes
    public ACBindings.AC1Legacy.PStringBaseIter_Common__ushort BaseClass_AC1Legacy_PStringBaseIter_Common; // ACBindings.AC1Legacy.PStringBaseIter_Common__ushort

    // Members
    public System.IntPtr pstring_ptr;

    // Methods
}

