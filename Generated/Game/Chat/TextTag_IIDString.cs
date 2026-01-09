namespace ACBindings;

// TextTag_IIDString
public unsafe struct TextTag_IIDString
{
    // Base Classes
    public ACBindings.TextTag BaseClass_TextTag; // ACBindings.TextTag

    // Child Types
    // TextTag_IIDString_vtbl
    public unsafe struct TextTag_IIDString_vtbl
    {
        // Members
        public System.IntPtr TextTag_IIDString_dtor_0; // function pointer
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
    public ACBindings.PStringBase__ushort m_string;

    // Methods
    // char __thiscall TextTag_IIDString::BuildStartTagData(_DWORD*,wchar_t**)
    public sbyte BuildStartTagData(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextTag_IIDString, System.IntPtr, sbyte>)0x00478CE0)(ref this, a2);
    // char __thiscall TextTag_IIDString::ParseStartTag(int*,int)
    public sbyte ParseStartTag(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextTag_IIDString, int, sbyte>)0x00478D10)(ref this, a2);
}

