namespace ACBindings.Internal;

public unsafe struct TextTag_IID
{
    // Base Classes
    public ACBindings.Internal.TextTag BaseClass_TextTag; // ACBindings.Internal.TextTag

    // Child Types
    public unsafe struct TextTag_IID_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag_IID*, void> TextTag_IID_dtor_0; // function pointer
        public System.IntPtr ParseEndTag;
        public System.IntPtr ParseStartTag;
        public System.IntPtr BuildEndTag;
        public System.IntPtr BuildStartTag;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag_IID*, uint, byte> HandleClick; // function pointer
        public System.IntPtr BuildStartTagData;

        // Methods
    }

    // Members
    public uint m_IID;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00479360
    /// char __thiscall TextTag_IID::BuildStartTagData(_DWORD*,wchar_t**)</code>
    /// </summary>
    public sbyte BuildStartTagData(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag_IID, System.IntPtr, sbyte>)0x00479360)(ref this, a2);
}

