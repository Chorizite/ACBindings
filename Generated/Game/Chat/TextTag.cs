namespace ACBindings;

// TextTag
public unsafe struct TextTag
{
    // Base Classes
    public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

    // Child Types
    // TextTag_vtbl
    public unsafe struct TextTag_vtbl
    {
        // Members
        public System.IntPtr TextTag_dtor_0; // function pointer
        public System.IntPtr ParseEndTag;
        public System.IntPtr ParseStartTag;
        public System.IntPtr BuildEndTag;
        public System.IntPtr BuildStartTag;
        public System.IntPtr HandleClick; // function pointer
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
    // void __thiscall TextTag::TextTag(TextTag*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextTag, void>)0x00479380)(ref this);
    // char __stdcall TextTag::ParseStartTag(int)
    public static sbyte ParseStartTag(int a1) => ((delegate* unmanaged[Stdcall]<int, sbyte>)0x004793B0)(a1);
    // char __thiscall TextTag::BuildStartTag(int*,wchar_t**)
    public sbyte BuildStartTag(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextTag, System.IntPtr, sbyte>)0x004793E0)(ref this, a2);
    // char __thiscall TextTag::BuildEndTag(int*,wchar_t**)
    public sbyte BuildEndTag(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextTag, System.IntPtr, sbyte>)0x00479590)(ref this, a2);
    // bool __thiscall TextTag::ParseEndTag(_DWORD*,_WORD*)
    public byte ParseEndTag(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TextTag, System.IntPtr, byte>)0x00479630)(ref this, a2);
}

