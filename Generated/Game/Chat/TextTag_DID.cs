namespace ACBindings;

// TextTag_DID
public unsafe struct TextTag_DID
{
    // Base Classes
    public ACBindings.TextTag BaseClass_TextTag; // ACBindings.TextTag

    // Child Types
    // TextTag_DID_vtbl
    public unsafe struct TextTag_DID_vtbl
    {
        // Members
        public System.IntPtr TextTag_DID_dtor_0; // function pointer
        public System.IntPtr ParseEndTag;
        public System.IntPtr ParseStartTag;
        public System.IntPtr BuildEndTag;
        public System.IntPtr BuildStartTag;
        public System.IntPtr HandleClick; // function pointer
        public System.IntPtr BuildStartTagData;

        // Methods
    }

    // Members
    public ACBindings.IDClass___tagDataID m_DID;

    // Generated Constructor
    public TextTag_DID() {
        _ConstructorInternal();
    }

    // Methods
    // bool __thiscall TextTag_DID::HandleClick(TextTag_DID*,unsigned int)
    public byte HandleClick(uint button) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextTag_DID, uint, byte>)0x00478B40)(ref this, button);
    // void __thiscall TextTag_DID::TextTag_DID(TextTag_DID*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextTag_DID, void>)0x00478B60)(ref this);
    // char __thiscall TextTag_DID::ParseStartTag(wchar_t*,wchar_t*)
    public sbyte ParseStartTag(System.IntPtr Stringa) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextTag_DID, System.IntPtr, sbyte>)0x004792D0)(ref this, Stringa);
}

