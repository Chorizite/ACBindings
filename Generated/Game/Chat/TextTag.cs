namespace ACBindings.Internal;

public unsafe struct TextTag
{
    // Base Classes
    public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

    // Child Types
    public unsafe struct TextTag_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag*, void> TextTag_dtor_0; // function pointer
        public System.IntPtr ParseEndTag;
        public System.IntPtr ParseStartTag;
        public System.IntPtr BuildEndTag;
        public System.IntPtr BuildStartTag;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag*, uint, byte> HandleClick; // function pointer
        public System.IntPtr BuildStartTagData;

        // Methods
    }

    // Members
    public uint m_type;
    public uint m_format;

    // Generated Constructor
    public TextTag() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00479380
    /// void __thiscall TextTag::TextTag(TextTag*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag, void>)0x00479380)(ref this);

    /// <summary>
    /// <code>Offset: 0x004793B0
    /// char __stdcall TextTag::ParseStartTag(int)</code>
    /// </summary>
    public static sbyte ParseStartTag(int a1) => ((delegate* unmanaged[Stdcall]<int, sbyte>)0x004793B0)(a1);

    /// <summary>
    /// <code>Offset: 0x004793E0
    /// char __thiscall TextTag::BuildStartTag(int*,wchar_t**)</code>
    /// </summary>
    public sbyte BuildStartTag(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag, System.IntPtr, sbyte>)0x004793E0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00479590
    /// char __thiscall TextTag::BuildEndTag(int*,wchar_t**)</code>
    /// </summary>
    public sbyte BuildEndTag(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag, System.IntPtr, sbyte>)0x00479590)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00479630
    /// bool __thiscall TextTag::ParseEndTag(_DWORD*,_WORD*)</code>
    /// </summary>
    public byte ParseEndTag(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag, System.IntPtr, byte>)0x00479630)(ref this, a2);
}

