namespace ACBindings;

// UIPreferenceItemString
public unsafe struct UIPreferenceItemString
{
    // Base Classes
    public ACBindings.UIPreferenceItem BaseClass_UIPreferenceItem; // ACBindings.UIPreferenceItem

    // Child Types
    // UIPreferenceItemString_vtbl
    public unsafe struct UIPreferenceItemString_vtbl
    {
        // Members
        public System.IntPtr UIPreferenceItemString_dtor_0; // function pointer
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
    public ACBindings.PStringBase__sbyte m_strCache;

    // Generated Constructor
    public UIPreferenceItemString() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall UIPreferenceItemString::UIPreferenceItemString(UIPreferenceItemString*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemString, void>)0x005DE850)(ref this);
    // char __thiscall UIPreferenceItemString::InqString(volatile LONG**,int*)
    public sbyte InqString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemString, int*, sbyte>)0x005DE890)(ref this, a2);
    // char __thiscall UIPreferenceItemString::SetString(volatile LONG**,int*)
    public sbyte SetString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemString, int*, sbyte>)0x005DE8B0)(ref this, a2);
    // char __thiscall UIPreferenceItemString::InqCachedString(LONG*,LONG*)
    public sbyte InqCachedString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemString, int*, sbyte>)0x005DE8D0)(ref this, a2);
    // char __thiscall UIPreferenceItemString::SetCachedString(LONG*,LONG*)
    public sbyte SetCachedString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemString, int*, sbyte>)0x005DE8F0)(ref this, a2);
}

