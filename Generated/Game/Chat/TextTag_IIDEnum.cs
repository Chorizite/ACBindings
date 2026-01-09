namespace ACBindings;

// TextTag_IIDEnum
public unsafe struct TextTag_IIDEnum
{
    // Base Classes
    public ACBindings.TextTag BaseClass_TextTag; // ACBindings.TextTag

    // Child Types
    // TextTag_IIDEnum_vtbl
    public unsafe struct TextTag_IIDEnum_vtbl
    {
        // Members
        public System.IntPtr TextTag_IIDEnum_dtor_0; // function pointer
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
    public uint m_enum;

    // Methods
    // char __thiscall TextTag_IIDEnum::BuildStartTagData(_DWORD*,wchar_t**)
    public sbyte BuildStartTagData(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextTag_IIDEnum, System.IntPtr, sbyte>)0x00478F90)(ref this, a2);
    // char __thiscall TextTag_IIDEnum::ParseStartTag(_DWORD*,int)
    public sbyte ParseStartTag(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextTag_IIDEnum, int, sbyte>)0x00479030)(ref this, a2);
}

