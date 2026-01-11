namespace ACBindings.Internal;

public unsafe struct PStringBaseIter_Const__sbyte
{
    // Base Classes
    public ACBindings.Internal.PStringBaseIter_Common__sbyte BaseClass_PStringBaseIter_Common; // ACBindings.Internal.PStringBaseIter_Common__sbyte

    // Child Types
    public unsafe struct PStringBaseIter_Const_vtbl__sbyte
    {
        // Members
        public System.IntPtr GetStrLen;
        public System.IntPtr IndexToConstPointer;
        public System.IntPtr IndexToChar;
        public System.IntPtr GetPStringPtr;

        // Methods
    }
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

    /// <summary>Retrieves a character from the underlying string at the specified zero‑based index, returning the last character when the index exceeds the string length.
    /// <code>Offset: 0x0040B360
    /// char __thiscall PStringBaseIter_Const&lt;char&gt;::IndexToChar(_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The desired position within the string.</param>
    /// <returns>The character located at that index or the final character if the index is out of range.</returns>
    // char __thiscall PStringBaseIter_Const<char>::IndexToChar(_DWORD**,unsigned int) (template type method)

    /// <summary>Converts an index into a constant pointer within the underlying string, clamping out‑of‑range indices to the last character.
    /// <code>Offset: 0x0040B380
    /// int __thiscall PStringBaseIter_Const&lt;char&gt;::IndexToConstPointer(_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Zero‑based position requested inside the string.</param>
    /// <returns>An integer value representing the address of the character at the specified position or the final character if the index exceeds the length.</returns>
    // int __thiscall PStringBaseIter_Const<char>::IndexToConstPointer(_DWORD**,unsigned int) (template type method)
}

public unsafe struct PStringBaseIter_Const__ushort
{
    // Base Classes
    public ACBindings.Internal.PStringBaseIter_Common__ushort BaseClass_PStringBaseIter_Common; // ACBindings.Internal.PStringBaseIter_Common__ushort

    // Members
    public System.IntPtr pstring_ptr;

    // Methods
}

