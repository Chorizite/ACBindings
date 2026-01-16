namespace ACBindings.Internal;


/// <summary>PStringBaseIter_Common offers an iterator interface for string processing, tracking the current position and mark within the underlying character sequence while supporting virtual dispatch through its vftable pointer.</summary>
public unsafe struct PStringBaseIter_Common__sbyte
{
    // Child Types
    public unsafe struct PStringBaseIter_Common_vtbl__sbyte
    {
        // Members
        public System.IntPtr GetStrLen;
        public System.IntPtr IndexToConstPointer;
        public System.IntPtr IndexToChar;
        public System.IntPtr GetPStringPtr;

        // Methods
    }
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

    /// <summary>Advances or rewinds an iterator by a given offset, clamping the position within the string boundaries.
    /// <code>Offset: 0x0040B0F0
    /// char __thiscall PStringBaseIter_Common&lt;char&gt;::Next(int (__thiscall***this)(void*),int)</code>
    /// </summary>
    /// <param name="a2">Number of characters to move; negative values retreat the iterator, positive values advance it.</param>
    /// <returns>1 if the new position is within bounds after adjustment; 0 when the requested movement exceeds the string limits, in which case the iterator is positioned at the end of the string.</returns>
    // char __thiscall PStringBaseIter_Common<char>::Next(int (__thiscall***this)(void*),int) (template type method)

    /// <summary>Moves the iterator until it points to the specified character, searching forward or backward based on direction flag.
    /// <code>Offset: 0x0040B580
    /// char __thiscall PStringBaseIter_Common&lt;char&gt;::FindChar(_DWORD*,char,char)</code>
    /// </summary>
    /// <param name="a2">Character to search for.</param>
    /// <param name="a3">Direction: non‑zero to search backwards; zero to search forwards.</param>
    /// <returns>Non‑zero if the iterator stops at a matching character; otherwise zero when no match is found within bounds.</returns>
    // char __thiscall PStringBaseIter_Common<char>::FindChar(_DWORD*,char,char) (template type method)

    /// <summary>Searches the string referenced by this iterator for a specified character or checks for the presence of any character based on the supplied flag. Returns non‑zero when the search succeeds and zero otherwise.
    /// <code>Offset: 0x0040B790
    /// char __thiscall PStringBaseIter_Common&lt;char&gt;::FindChar(_DWORD*,int,char)</code>
    /// </summary>
    /// <param name="this">Pointer to the iterator object that manages the current position within the underlying string.</param>
    /// <param name="a2">Optional parameter (currently unused) that may indicate a starting index or other context for the search.</param>
    /// <param name="a3">Target character to locate; when zero, the function checks whether any character exists at the iterator's current position.</param>
    /// <returns>Non‑zero if the target character is found (or any character exists in the zero‑flag case); otherwise returns 0.</returns>
    // char __thiscall PStringBaseIter_Common<char>::FindChar(_DWORD*,int,char) (template type method)

    /// <summary>
    /// Extracts the characters between the iterator’s range into a newly allocated string buffer, handling reference counts internally.
    /// 
    /// <code>Offset: 0x0040BF30
    /// char __thiscall PStringBaseIter_Common&lt;char&gt;::GetSubString(_DWORD*,char**)</code>
    /// </summary>
    /// <param name="a2">Receives a pointer to the newly created string that contains the extracted substring; the caller must release this buffer when no longer needed.</param>
    /// <returns>Always returns 1 to indicate successful extraction.</returns>
    // char __thiscall PStringBaseIter_Common<char>::GetSubString(_DWORD*,char**) (template type method)

    /// <summary>Retrieves the current substring represented by this iterator and writes the resulting character array into the caller‑supplied pointer.
    /// <code>Offset: 0x0040BFB0
    /// _DWORD* __thiscall PStringBaseIter_Common&lt;char&gt;::GetSubString(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer that will receive the address of the reference‑counted buffer containing the substring.</param>
    /// <returns>The same pointer passed as a2, now pointing to the retrieved substring.</returns>
    // _DWORD* __thiscall PStringBaseIter_Common<char>::GetSubString(_DWORD*,_DWORD*) (template type method)

    /// <summary>Splits the string represented by this iterator into one or three substrings according to the current and mark positions, storing the resulting parts in the provided output parameters.
    /// <code>Offset: 0x0040C4C0
    /// char __thiscall PStringBaseIter_Common&lt;char&gt;::Split(unsigned int*,int*,void**,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to receive the substring preceding any split points (or the entire string when curr equals mark).</param>
    /// <param name="a3">Pointer to receive the middle substring between curr and mark; cleared if curr equals mark.</param>
    /// <param name="a4">Pointer to receive the substring following the split point(s).</param>
    /// <returns>Nonzero on success; zero if the underlying string is null.</returns>
    // char __thiscall PStringBaseIter_Common<char>::Split(unsigned int*,int*,void**,int*) (template type method)

    /// <summary>Determines whether the string starting at the provided position begins with a specified substring, performing a case‑insensitive comparison.
    /// <code>Offset: 0x0056F510
    /// bool __cdecl PStringBaseIter_Common&lt;char&gt;::FindSubStringIter(const char*,const char*)</code>
    /// </summary>
    /// <param name="my_curr">Pointer to the current position in the source string from which the search starts.</param>
    /// <param name="substring_curr">Pointer to the null‑terminated substring to match against the source string.</param>
    /// <returns>True if the substring matches the sequence at the given position; otherwise, false.</returns>
    // bool __cdecl PStringBaseIter_Common<char>::FindSubStringIter(const char*,const char*) (template type method)

    /// <summary>Searches the current position in the iterator for the substring specified by a2 and updates internal markers if found.
    /// <code>Offset: 0x0056F710
    /// char __thiscall PStringBaseIter_Common&lt;char&gt;::FindSubString(int,const char**,char)</code>
    /// </summary>
    /// <param name="this">The string iterator instance.</param>
    /// <param name="a2">Pointer to the C-style string pattern to locate.</param>
    /// <param name="a3">Flag that selects an alternate search path when non-zero.</param>
    /// <returns>Returns 1 if the substring is located; otherwise, returns 0.</returns>
    // char __thiscall PStringBaseIter_Common<char>::FindSubString(int,const char**,char) (template type method)
}


/// <summary>Iterates over a sequence of unsigned short elements, tracking the current index and a mark to allow resetting or rewinding during traversal.</summary>
public unsafe struct PStringBaseIter_Common__ushort
{
    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint curr;
    public uint mark;

    // Methods
}

