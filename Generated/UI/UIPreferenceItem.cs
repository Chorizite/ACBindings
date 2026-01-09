namespace ACBindings;

// UIPreferenceItem
public unsafe struct UIPreferenceItem : System.IDisposable
{
    // Child Types
    // UIPreferenceItem_vtbl
    public unsafe struct UIPreferenceItem_vtbl
    {
        // Members
        public System.IntPtr UIPreferenceItem_dtor_0; // function pointer
        public System.IntPtr InqBool; // function pointer
        public System.IntPtr SetBool; // function pointer
        public System.IntPtr InqInteger; // function pointer
        public System.IntPtr SetInteger; // function pointer
        public System.IntPtr InqIntegerRange; // function pointer
        public System.IntPtr SetIntegerRange; // function pointer
        public System.IntPtr InqEnum; // function pointer
        public System.IntPtr SetEnum; // function pointer
        public System.IntPtr InqEnumChoices;
        public System.IntPtr SetEnumChoices;
        public System.IntPtr InqEnumValues;
        public System.IntPtr InqFloat; // function pointer
        public System.IntPtr SetFloat; // function pointer
        public System.IntPtr InqFloatRange; // function pointer
        public System.IntPtr SetFloatRange; // function pointer
        public System.IntPtr InqString;
        public System.IntPtr SetString;
        public System.IntPtr InqCachedBool; // function pointer
        public System.IntPtr SetCachedBool; // function pointer
        public System.IntPtr InqCachedInteger; // function pointer
        public System.IntPtr SetCachedInteger; // function pointer
        public System.IntPtr InqCachedEnum; // function pointer
        public System.IntPtr SetCachedEnum; // function pointer
        public System.IntPtr InqCachedFloat; // function pointer
        public System.IntPtr SetCachedFloat; // function pointer
        public System.IntPtr InqCachedString;
        public System.IntPtr SetCachedString;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.PStringBase__sbyte m_strPreference;
    public uint m_dataType;
    public uint m_eStringTable;
    public uint m_tokenPreference;
    public uint m_tokenTooltip;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall UIPreferenceItem::~UIPreferenceItem(UIPreferenceItem*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItem, void>)0x005DE410)(ref this);
    // char __thiscall UIPreferenceItem::Initialize(_DWORD*,volatile LONG**,int,int,int,int)
    public sbyte Initialize(int** m_charbuffer, int a3, int a4, int a5, int a6) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItem, int**, int, int, int, int, sbyte>)0x005DEFC0)(ref this, m_charbuffer, a3, a4, a5, a6);
}

