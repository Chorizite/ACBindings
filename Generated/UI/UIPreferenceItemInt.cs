namespace ACBindings;

// UIPreferenceItemInt
public unsafe struct UIPreferenceItemInt
{
    // Base Classes
    public ACBindings.UIPreferenceItem BaseClass_UIPreferenceItem; // ACBindings.UIPreferenceItem

    // Child Types
    // UIPreferenceItemInt_vtbl
    public unsafe struct UIPreferenceItemInt_vtbl
    {
        // Members
        public System.IntPtr UIPreferenceItemInt_dtor_0; // function pointer
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
    public int m_nCache;
    public int m_nMin;
    public int m_nMax;

    // Generated Constructor
    public UIPreferenceItemInt() {
        _ConstructorInternal();
    }

    // Methods
    // bool __thiscall UIPreferenceItemInt::InqIntegerRange(UIPreferenceItemInt*,int*,int*)
    public byte InqIntegerRange(int* o_nMin, int* o_nMax) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemInt, int*, int*, byte>)0x005DE710)(ref this, o_nMin, o_nMax);
    // void __thiscall UIPreferenceItemInt::UIPreferenceItemInt(UIPreferenceItemInt*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemInt, void>)0x005DE780)(ref this);
    // bool __thiscall UIPreferenceItemInt::InqInteger(UIPreferenceItemInt*,int*)
    public byte InqInteger(int* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemInt, int*, byte>)0x005DE7C0)(ref this, o_value);
    // bool __thiscall UIPreferenceItemInt::SetInteger(UIPreferenceItemInt*,const int)
    public byte SetInteger(int i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemInt, int, byte>)0x005DE7E0)(ref this, i_value);
    // bool __thiscall UIPreferenceItemInt::InqCachedInteger(UIPreferenceItemInt*,int*)
    public byte InqCachedInteger(int* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemInt, int*, byte>)0x005DE800)(ref this, o_value);
}

