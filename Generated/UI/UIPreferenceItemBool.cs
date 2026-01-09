namespace ACBindings;

// UIPreferenceItemBool
public unsafe struct UIPreferenceItemBool
{
    // Base Classes
    public ACBindings.UIPreferenceItem BaseClass_UIPreferenceItem; // ACBindings.UIPreferenceItem

    // Child Types
    // UIPreferenceItemBool_vtbl
    public unsafe struct UIPreferenceItemBool_vtbl
    {
        // Members
        public System.IntPtr UIPreferenceItemBool_dtor_0; // function pointer
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
    public byte m_bCache;

    // Generated Constructor
    public UIPreferenceItemBool() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall UIPreferenceItemBool::UIPreferenceItemBool(UIPreferenceItemBool*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemBool, void>)0x005DE490)(ref this);
    // bool __thiscall UIPreferenceItemBool::InqBool(UIPreferenceItemBool*,bool*)
    public byte InqBool(byte* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemBool, byte*, byte>)0x005DE4D0)(ref this, o_value);
    // bool __thiscall UIPreferenceItemBool::SetBool(UIPreferenceItemBool*,const bool)
    public byte SetBool(byte i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemBool, byte, byte>)0x005DE4F0)(ref this, i_value);
    // bool __thiscall UIPreferenceItemBool::InqCachedBool(UIPreferenceItemBool*,bool*)
    public byte InqCachedBool(byte* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemBool, byte*, byte>)0x005DE510)(ref this, o_value);
    // bool __thiscall UIPreferenceItemBool::SetCachedBool(UIPreferenceItemBool*,const bool)
    public byte SetCachedBool(byte i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemBool, byte, byte>)0x005DE520)(ref this, i_value);
}

