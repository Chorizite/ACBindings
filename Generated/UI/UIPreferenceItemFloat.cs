namespace ACBindings;

// UIPreferenceItemFloat
public unsafe struct UIPreferenceItemFloat
{
    // Base Classes
    public ACBindings.UIPreferenceItem BaseClass_UIPreferenceItem; // ACBindings.UIPreferenceItem

    // Child Types
    // UIPreferenceItemFloat_vtbl
    public unsafe struct UIPreferenceItemFloat_vtbl
    {
        // Members
        public System.IntPtr UIPreferenceItemFloat_dtor_0; // function pointer
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
    public float m_nCache;
    public float m_nMin;
    public float m_nMax;

    // Generated Constructor
    public UIPreferenceItemFloat() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall UIPreferenceItemFloat::UIPreferenceItemFloat(UIPreferenceItemFloat*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemFloat, void>)0x005DE690)(ref this);
    // bool __thiscall UIPreferenceItemFloat::InqFloat(UIPreferenceItemFloat*,float*)
    public byte InqFloat(float* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemFloat, float*, byte>)0x005DE6D0)(ref this, o_value);
    // bool __thiscall UIPreferenceItemFloat::SetFloat(UIPreferenceItemFloat*,const float)
    public byte SetFloat(float i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemFloat, float, byte>)0x005DE6F0)(ref this, i_value);
    // bool __thiscall UIPreferenceItemFloat::SetFloatRange(UIPreferenceItemInt*,const int,const int)
    public byte SetFloatRange(int i_nMin, int i_nMax) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemFloat, int, int, byte>)0x005DE730)(ref this, i_nMin, i_nMax);
    // bool __thiscall UIPreferenceItemFloat::SetCachedFloat(UIPreferenceItemInt*,const int)
    public byte SetCachedFloat(int i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemFloat, int, byte>)0x005DE810)(ref this, i_value);
}

