namespace ACBindings.Internal;


/// <summary>Facilitates iteration over a character string by maintaining common iterator state and a reference to the underlying string data.</summary>
public unsafe struct PStringBaseIter__sbyte
{
    // Base Classes
    public ACBindings.Internal.PStringBaseIter_Common__sbyte BaseClass_PStringBaseIter_Common; // ACBindings.Internal.PStringBaseIter_Common__sbyte

    // Child Types
    public unsafe struct PStringBaseIter_vtbl__ushort
    {
        // Members
        public System.IntPtr GetStrLen;
        public System.IntPtr IndexToConstPointer;
        public System.IntPtr IndexToChar;
        public System.IntPtr GetPStringPtr;

        // Methods
    }
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

    /// <summary>Retrieves the length of the string referenced by this iterator.
    /// <code>Offset: 0x0040B3F0
    /// int __thiscall PStringBaseIter&lt;char&gt;::GetStrLen(_DWORD**)</code>
    /// </summary>
    /// <returns>The number of characters in that string (excluding any terminator).</returns>
    // int __thiscall PStringBaseIter<char>::GetStrLen(_DWORD**) (template type method)

    /// <summary>Truncates the associated string so that its content ends at the iterator's current position, handling reference counts and cleaning up unused buffers.
    /// <code>Offset: 0x0040C010
    /// char __thiscall PStringBaseIter&lt;char&gt;::Truncate(int)</code>
    /// </summary>
    /// <returns>Non‑zero if truncation succeeded; zero on failure.</returns>
    // char __thiscall PStringBaseIter<char>::Truncate(int) (template type method)

    /// <summary>Removes the leading portion of the associated string up to the iterator’s current position, resetting the iterator to the beginning and adjusting any mark positions.
    /// <code>Offset: 0x0040C0B0
    /// char __thiscall PStringBaseIter&lt;char&gt;::Behead(int)</code>
    /// </summary>
    /// <returns>Always returns 1 to indicate successful beheading.</returns>
    // char __thiscall PStringBaseIter<char>::Behead(int) (template type method)

    /// <summary>Inserts the characters from a null‑terminated string into the current position of the iterator, updating the underlying string and iterator state.
    /// <code>Offset: 0x0040C8A0
    /// char __thiscall PStringBaseIter&lt;char&gt;::Insert(int,char**)</code>
    /// </summary>
    /// <param name="a2">Pointer to the source string to insert; the string must be null‑terminated.</param>
    /// <returns>True (1) on successful insertion; this implementation always returns 1.</returns>
    // char __thiscall PStringBaseIter<char>::Insert(int,char**) (template type method)

    /// <summary>Replaces the text between the iterator’s current position and mark with the supplied string.
    /// <code>Offset: 0x0040C9A0
    /// char __thiscall PStringBaseIter&lt;char&gt;::Replace(int,char**)</code>
    /// </summary>
    /// <param name="a2">Pointer to a character buffer whose preceding word holds its length, used as the replacement text.</param>
    /// <returns>Always returns 1 to indicate successful replacement.</returns>
    // char __thiscall PStringBaseIter<char>::Replace(int,char**) (template type method)
}


/// <summary>Provides an iterator base for unsigned short string types, combining common iteration logic with a pointer to the underlying string data.</summary>
public unsafe struct PStringBaseIter__ushort
{
    // Base Classes
    public ACBindings.Internal.PStringBaseIter_Common__ushort BaseClass_PStringBaseIter_Common; // ACBindings.Internal.PStringBaseIter_Common__ushort

    // Members
    public System.IntPtr pstring_ptr;

    // Methods
}

