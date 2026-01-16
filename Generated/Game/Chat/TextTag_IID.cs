namespace ACBindings.Internal;


/// <summary>Represents a specialized text tag that stores a 32‑bit identifier and extends base TextTag behavior for interface ID handling.</summary>
/// <remarks>The m_IID field holds the numeric value used when building start tags in hexadecimal form.</remarks>
public unsafe struct TextTag_IID
{
    // Base Classes
    public ACBindings.Internal.TextTag BaseClass_TextTag; // ACBindings.Internal.TextTag

    // Child Types
    public unsafe struct TextTag_IID_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag_IID*, void> TextTag_IID_dtor_0; // function pointer
        public System.IntPtr ParseEndTag;
        public System.IntPtr ParseStartTag;
        public System.IntPtr BuildEndTag;
        public System.IntPtr BuildStartTag;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag_IID*, uint, byte> HandleClick; // function pointer
        public System.IntPtr BuildStartTagData;

        // Methods
    }

    // Members
    public uint m_IID;

    // Methods

    /// <summary>Formats the object's IID into an eight‑digit hexadecimal string and stores it via the supplied pointer.
    /// <code>Offset: 0x00479360
    /// char __thiscall TextTag_IID::BuildStartTagData(_DWORD*,wchar_t**)</code>
    /// </summary>
    /// <param name="a2">Pointer to receive the formatted string.</param>
    /// <returns>Always returns 1 to indicate success.</returns>
    public sbyte BuildStartTagData(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag_IID, System.IntPtr, sbyte>)0x00479360)(ref this, a2);
}

