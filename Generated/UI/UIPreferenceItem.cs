namespace ACBindings.Internal;

public unsafe struct UIPreferenceItem : System.IDisposable
{
    // Child Types
    public unsafe struct UIPreferenceItem_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, void> UIPreferenceItem_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, byte*, byte> InqBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, byte, byte> SetBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, int*, byte> InqInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, int, byte> SetInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, int*, int*, byte> InqIntegerRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, int, int, byte> SetIntegerRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, uint*, byte> InqEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, uint, byte> SetEnum; // function pointer
        public System.IntPtr InqEnumChoices;
        public System.IntPtr SetEnumChoices;
        public System.IntPtr InqEnumValues;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, float*, byte> InqFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, float, byte> SetFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, float*, float*, byte> InqFloatRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, float, float, byte> SetFloatRange; // function pointer
        public System.IntPtr InqString;
        public System.IntPtr SetString;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, byte*, byte> InqCachedBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, byte, byte> SetCachedBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, int*, byte> InqCachedInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, int, byte> SetCachedInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, uint*, byte> InqCachedEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, uint, byte> SetCachedEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, float*, byte> InqCachedFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItem*, float, byte> SetCachedFloat; // function pointer
        public System.IntPtr InqCachedString;
        public System.IntPtr SetCachedString;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.PStringBase__sbyte m_strPreference;
    public uint m_dataType;
    public uint m_eStringTable;
    public uint m_tokenPreference;
    public uint m_tokenTooltip;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005DE410
    /// void __thiscall UIPreferenceItem::~UIPreferenceItem(UIPreferenceItem*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItem, void>)0x005DE410)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DEFC0
    /// char __thiscall UIPreferenceItem::Initialize(_DWORD*,volatile LONG**,int,int,int,int)</code>
    /// </summary>
    public sbyte Initialize(int** m_charbuffer, int a3, int a4, int a5, int a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItem, int**, int, int, int, int, sbyte>)0x005DEFC0)(ref this, m_charbuffer, a3, a4, a5, a6);
}

