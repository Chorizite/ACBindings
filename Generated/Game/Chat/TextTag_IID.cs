namespace ACBindings;

// TextTag_IID
public unsafe struct TextTag_IID
{
    // Base Classes
    public ACBindings.TextTag BaseClass_TextTag; // ACBindings.TextTag

    // Child Types
    // TextTag_IID_vtbl
    public unsafe struct TextTag_IID_vtbl
    {
        // Members
        public System.IntPtr TextTag_IID_dtor_0; // function pointer
        public System.IntPtr ParseEndTag;
        public System.IntPtr ParseStartTag;
        public System.IntPtr BuildEndTag;
        public System.IntPtr BuildStartTag;
        public System.IntPtr HandleClick; // function pointer
        public System.IntPtr BuildStartTagData;

        // Methods
    }

    // Members
    public uint m_IID;

    // Methods
    // char __thiscall TextTag_IID::BuildStartTagData(_DWORD*,wchar_t**)
    public sbyte BuildStartTagData(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextTag_IID, System.IntPtr, sbyte>)0x00479360)(ref this, a2);
}

