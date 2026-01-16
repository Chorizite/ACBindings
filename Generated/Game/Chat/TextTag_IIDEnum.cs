namespace ACBindings.Internal;


/// <summary>
/// Combines a TextTag with an identifier and enumeration value for XML‑style tag handling,
/// enabling construction and parsing of start tags that include numeric IDs and mapped enum names.
/// </summary>
public unsafe struct TextTag_IIDEnum
{
    // Base Classes
    public ACBindings.Internal.TextTag BaseClass_TextTag; // ACBindings.Internal.TextTag

    // Child Types
    public unsafe struct TextTag_IIDEnum_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag_IIDEnum*, void> TextTag_IIDEnum_dtor_0; // function pointer
        public System.IntPtr ParseEndTag;
        public System.IntPtr ParseStartTag;
        public System.IntPtr BuildEndTag;
        public System.IntPtr BuildStartTag;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag_IIDEnum*, uint, byte> HandleClick; // function pointer
        public System.IntPtr BuildStartTagData;

        // Methods
    }

    // Members
    public uint m_IID;
    public uint m_enum;

    // Methods

    /// <summary>Builds a formatted start‑tag string for this TextTag_IIDEnum instance and stores it in an allocated wide‑character buffer.
    /// <code>Offset: 0x00478F90
    /// char __thiscall TextTag_IIDEnum::BuildStartTagData(_DWORD*,wchar_t**)</code>
    /// </summary>
    /// <param name="a2">Pointer to the wide‑string pointer that receives the newly constructed tag; the caller is responsible for freeing the memory when no longer needed.</param>
    /// <returns>Nonzero if a tag was successfully created, zero on failure (e.g., invalid IID or enum value).</returns>
    public sbyte BuildStartTagData(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag_IIDEnum, System.IntPtr, sbyte>)0x00478F90)(ref this, a2);

    /// <summary>Parses a colon‑separated start tag string, extracting a numeric IID and mapping the second part to an enum value stored in this instance.
    /// <code>Offset: 0x00479030
    /// char __thiscall TextTag_IIDEnum::ParseStartTag(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">The input string containing the start tag data.</param>
    /// <returns>Nonzero if parsing succeeded; zero otherwise.</returns>
    public sbyte ParseStartTag(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag_IIDEnum, int, sbyte>)0x00479030)(ref this, a2);
}

