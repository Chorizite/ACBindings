namespace ACBindings.Internal.AC1Legacy;

public unsafe struct PStringBaseIter__sbyte
{
    // Base Classes
    public ACBindings.Internal.AC1Legacy.PStringBaseIter_Common__sbyte BaseClass_AC1Legacy_PStringBaseIter_Common; // ACBindings.Internal.AC1Legacy.PStringBaseIter_Common__sbyte

    // Child Types
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

    /// <summary>
    /// <code>Offset: 0x00684C30
    /// int __thiscall AC1Legacy::PStringBaseIter&lt;char&gt;::IndexToConstPointer(_DWORD**,unsigned int)</code>
    /// </summary>
    // int __thiscall AC1Legacy::PStringBaseIter<char>::IndexToConstPointer(_DWORD**,unsigned int) (template type method)

    /// <summary>
    /// <code>Offset: 0x00684C50
    /// char __thiscall AC1Legacy::PStringBaseIter&lt;char&gt;::IndexToChar(_DWORD**,unsigned int)</code>
    /// </summary>
    // char __thiscall AC1Legacy::PStringBaseIter<char>::IndexToChar(_DWORD**,unsigned int) (template type method)

    /// <summary>
    /// <code>Offset: 0x00684C70
    /// int __thiscall AC1Legacy::PStringBaseIter&lt;char&gt;::GetStrLen(_DWORD**)</code>
    /// </summary>
    // int __thiscall AC1Legacy::PStringBaseIter<char>::GetStrLen(_DWORD**) (template type method)

    /// <summary>
    /// <code>Offset: 0x00684C80
    /// int __thiscall AC1Legacy::PStringBaseIter&lt;char&gt;::Truncate(int)</code>
    /// </summary>
    // int __thiscall AC1Legacy::PStringBaseIter<char>::Truncate(int) (template type method)

    /// <summary>
    /// <code>Offset: 0x00684D20
    /// int __thiscall AC1Legacy::PStringBaseIter&lt;char&gt;::Split(void*,int,void**,int*)</code>
    /// </summary>
    // int __thiscall AC1Legacy::PStringBaseIter<char>::Split(void*,int,void**,int*) (template type method)

    /// <summary>
    /// <code>Offset: 0x00684ED0
    /// int __thiscall AC1Legacy::PStringBaseIter&lt;char&gt;::Split(void*,int*,int*)</code>
    /// </summary>
    // int __thiscall AC1Legacy::PStringBaseIter<char>::Split(void*,int*,int*) (template type method)
}

public unsafe struct PStringBaseIter__ushort
{
    // Base Classes
    public ACBindings.Internal.AC1Legacy.PStringBaseIter_Common__ushort BaseClass_AC1Legacy_PStringBaseIter_Common; // ACBindings.Internal.AC1Legacy.PStringBaseIter_Common__ushort

    // Members
    public System.IntPtr pstring_ptr;

    // Methods
}

