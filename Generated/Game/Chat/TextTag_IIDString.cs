namespace ACBindings.Internal;

public unsafe struct TextTag_IIDString
{
    // Base Classes
    public ACBindings.Internal.TextTag BaseClass_TextTag; // ACBindings.Internal.TextTag

    // Child Types
    public unsafe struct TextTag_IIDString_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag_IIDString*, void> TextTag_IIDString_dtor_0; // function pointer
        public System.IntPtr ParseEndTag;
        public System.IntPtr ParseStartTag;
        public System.IntPtr BuildEndTag;
        public System.IntPtr BuildStartTag;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag_IIDString*, uint, byte> HandleClick; // function pointer
        public System.IntPtr BuildStartTagData;

        // Methods
    }

    // Members
    public uint m_IID;
    public ACBindings.Internal.PStringBase__ushort m_string;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00478CE0
    /// char __thiscall TextTag_IIDString::BuildStartTagData(_DWORD*,wchar_t**)</code>
    /// </summary>
    public sbyte BuildStartTagData(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag_IIDString, System.IntPtr, sbyte>)0x00478CE0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00478D10
    /// char __thiscall TextTag_IIDString::ParseStartTag(int*,int)</code>
    /// </summary>
    public sbyte ParseStartTag(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag_IIDString, int, sbyte>)0x00478D10)(ref this, a2);
}

