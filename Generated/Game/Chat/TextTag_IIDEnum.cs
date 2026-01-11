namespace ACBindings.Internal;

public unsafe struct TextTag_IIDEnum
{
    // Base Classes
    public ACBindings.Internal.TextTag BaseClass_TextTag; // ACBindings.Internal.TextTag

    // Child Types
    public unsafe struct TextTag_IIDEnum_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag_IIDEnum*, void> TextTag_IIDEnum_dtor_0; // function pointer
        public System.IntPtr ParseEndTag;
        public System.IntPtr ParseStartTag;
        public System.IntPtr BuildEndTag;
        public System.IntPtr BuildStartTag;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.TextTag_IIDEnum*, uint, byte> HandleClick; // function pointer
        public System.IntPtr BuildStartTagData;

        // Methods
    }

    // Members
    public uint m_IID;
    public uint m_enum;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00478F90
    /// char __thiscall TextTag_IIDEnum::BuildStartTagData(_DWORD*,wchar_t**)</code>
    /// </summary>
    public sbyte BuildStartTagData(System.IntPtr a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag_IIDEnum, System.IntPtr, sbyte>)0x00478F90)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x00479030
    /// char __thiscall TextTag_IIDEnum::ParseStartTag(_DWORD*,int)</code>
    /// </summary>
    public sbyte ParseStartTag(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TextTag_IIDEnum, int, sbyte>)0x00479030)(ref this, a2);
}

