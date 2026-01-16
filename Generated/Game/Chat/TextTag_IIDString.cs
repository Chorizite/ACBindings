namespace ACBindings.Internal;


/// <summary>Represents an XML tag that stores a 32‑bit interface identifier (IID) together with an associated string, enabling the construction and parsing of formatted start and end tag representations.</summary>
public unsafe struct TextTag_IIDString
{
    // Base Classes
    public ACBindings.Internal.TextTag BaseClass_TextTag; // ACBindings.Internal.TextTag

    // Child Types
    public unsafe struct TextTag_IIDString_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag_IIDString*, void> TextTag_IIDString_dtor_0; // function pointer
        public System.IntPtr ParseEndTag;
        public System.IntPtr ParseStartTag;
        public System.IntPtr BuildEndTag;
        public System.IntPtr BuildStartTag;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag_IIDString*, uint, byte> HandleClick; // function pointer
        public System.IntPtr BuildStartTagData;

        // Methods
    }

    // Members
    public uint m_IID;
    public ACBindings.Internal.PStringBase__ushort m_string;

    // Methods

    /// <summary>Creates a formatted start‑tag representation of an IID and its associated string into the supplied buffer unless the string component is empty.
    /// <code>Offset: 0x00478CE0
    /// char __thiscall TextTag_IIDString::BuildStartTagData(_DWORD*,wchar_t**)</code>
    /// </summary>
    /// <param name="a2">Pointer to a wchar_t* that receives the newly allocated or overwritten string containing the formatted tag data.</param>
    /// <returns>Non‑zero if the tag data was successfully written; zero when no output is produced because the string component is empty.</returns>
    public sbyte BuildStartTagData(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag_IIDString, System.IntPtr, sbyte>)0x00478CE0)(ref this, a2);

    /// <summary>Parses the start tag from the supplied wide‑character string, extracts an IID and a following string, and stores them in the TextTag_IIDString object. Returns true on successful parsing.
    /// <code>Offset: 0x00478D10
    /// char __thiscall TextTag_IIDString::ParseStartTag(int*,int)</code>
    /// </summary>
    /// <param name="a2">The wide‑string containing the tag to parse.</param>
    /// <returns>Non‑zero if the tag was parsed successfully; zero otherwise.</returns>
    public sbyte ParseStartTag(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag_IIDString, int, sbyte>)0x00478D10)(ref this, a2);
}

