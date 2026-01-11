namespace ACBindings.Internal;

public unsafe struct TextTag_DID
{
    // Base Classes
    public ACBindings.Internal.TextTag BaseClass_TextTag; // ACBindings.Internal.TextTag

    // Child Types
    public unsafe struct TextTag_DID_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag_DID*, void> TextTag_DID_dtor_0; // function pointer
        public System.IntPtr ParseEndTag;
        public System.IntPtr ParseStartTag;
        public System.IntPtr BuildEndTag;
        public System.IntPtr BuildStartTag;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag_DID*, uint, byte> HandleClick; // function pointer
        public System.IntPtr BuildStartTagData;

        // Methods
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID m_DID;

    // Generated Constructor
    public TextTag_DID() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00478B40
    /// bool __thiscall TextTag_DID::HandleClick(TextTag_DID*,unsigned int)</code>
    /// </summary>
    public byte HandleClick(uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag_DID, uint, byte>)0x00478B40)(ref this, button);

    /// <summary>
    /// <code>Offset: 0x00478B60
    /// void __thiscall TextTag_DID::TextTag_DID(TextTag_DID*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag_DID, void>)0x00478B60)(ref this);

    /// <summary>
    /// <code>Offset: 0x004792D0
    /// char __thiscall TextTag_DID::ParseStartTag(wchar_t*,wchar_t*)</code>
    /// </summary>
    public sbyte ParseStartTag(System.IntPtr Stringa) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag_DID, System.IntPtr, sbyte>)0x004792D0)(ref this, Stringa);
}

