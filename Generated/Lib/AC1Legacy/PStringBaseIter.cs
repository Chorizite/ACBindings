namespace ACBindings.Internal.AC1Legacy;


/// <summary>Provides iteration capabilities over character-based PString objects, encapsulating base iterator functionality and a pointer to the underlying string data.</summary>
public unsafe struct PStringBaseIter__sbyte
{
    // Base Classes
    public ACBindings.Internal.AC1Legacy.PStringBaseIter_Common__sbyte BaseClass_AC1Legacy_PStringBaseIter_Common; // ACBindings.Internal.AC1Legacy.PStringBaseIter_Common__sbyte

    // Child Types

    /// <summary>Provides the virtual function table for legacy string iterators, exposing operations such as length retrieval, split, and indexed access to characters or constant pointers.</summary>
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

    /// <summary>Defines a vtable of function pointers for operations on unsigned‑short string iterators, enabling length queries, split operations, and indexed character access.</summary>
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

    /// <summary>Converts an index into a pointer to the corresponding character within the string handled by the iterator, clamping out‑of‑range indices to the last valid position.
    /// <code>Offset: 0x00684C30
    /// int __thiscall AC1Legacy::PStringBaseIter&lt;char&gt;::IndexToConstPointer(_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Zero‑based index of the desired character.</param>
    /// <returns>An integer representing the address of the requested character; if the index exceeds the string length, returns a pointer to the final character.</returns>
    // int __thiscall AC1Legacy::PStringBaseIter<char>::IndexToConstPointer(_DWORD**,unsigned int) (template type method)

    /// <summary>Returns the character at the specified index of an AC1Legacy string, falling back to the last character when the index is beyond the string length.
    /// <code>Offset: 0x00684C50
    /// char __thiscall AC1Legacy::PStringBaseIter&lt;char&gt;::IndexToChar(_DWORD**,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Zero‑based index into the string.</param>
    /// <returns>The character at that position or the final character if out of range.</returns>
    // char __thiscall AC1Legacy::PStringBaseIter<char>::IndexToChar(_DWORD**,unsigned int) (template type method)

    /// <summary>Retrieves the length of the string referenced by this iterator.
    /// <code>Offset: 0x00684C70
    /// int __thiscall AC1Legacy::PStringBaseIter&lt;char&gt;::GetStrLen(_DWORD**)</code>
    /// </summary>
    /// <returns>The number of characters in the string, excluding the terminating null byte.</returns>
    // int __thiscall AC1Legacy::PStringBaseIter<char>::GetStrLen(_DWORD**) (template type method)

    /// <summary>Truncates the iterator’s associated string to its current position and adjusts internal markers so they do not exceed the new length.
    /// <code>Offset: 0x00684C80
    /// int __thiscall AC1Legacy::PStringBaseIter&lt;char&gt;::Truncate(int)</code>
    /// </summary>
    /// <returns>Returns 1 to signal successful truncation.</returns>
    // int __thiscall AC1Legacy::PStringBaseIter<char>::Truncate(int) (template type method)

    /// <summary>Splits the string associated with this iterator into up to three parts based on its current and mark positions, storing each part in the supplied output parameters.
    /// <code>Offset: 0x00684D20
    /// int __thiscall AC1Legacy::PStringBaseIter&lt;char&gt;::Split(void*,int,void**,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a string that receives the substring preceding the first split position; updated with reference‑count handling.</param>
    /// <param name="a3">Pointer to a string that receives the substring between the two split positions; set to the null string if no middle part exists.</param>
    /// <param name="a4">Pointer to a string that receives the substring following the second split position; updated with reference‑count handling.</param>
    /// <returns>Always returns 1, indicating successful completion of the split operation.</returns>
    // int __thiscall AC1Legacy::PStringBaseIter<char>::Split(void*,int,void**,int*) (template type method)

    /// <summary>Splits the string referenced by this iterator into two substrings at the current position, assigning them to the provided output parameters.
    /// <code>Offset: 0x00684ED0
    /// int __thiscall AC1Legacy::PStringBaseIter&lt;char&gt;::Split(void*,int*,int*)</code>
    /// </summary>
    /// <param name="a2">Receives a pointer to the substring from the beginning of the string up to (but not including) the current position.</param>
    /// <param name="a3">Receives a pointer to the substring from the current position to the end of the string.</param>
    /// <returns>Always returns 1, indicating that the split operation succeeded.</returns>
    // int __thiscall AC1Legacy::PStringBaseIter<char>::Split(void*,int*,int*) (template type method)
}


/// <summary>Iterates through a PStringBase of unsigned short elements, exposing the underlying string data through an internal pointer.</summary>
public unsafe struct PStringBaseIter__ushort
{
    // Base Classes
    public ACBindings.Internal.AC1Legacy.PStringBaseIter_Common__ushort BaseClass_AC1Legacy_PStringBaseIter_Common; // ACBindings.Internal.AC1Legacy.PStringBaseIter_Common__ushort

    // Members
    public System.IntPtr pstring_ptr;

    // Methods
}

