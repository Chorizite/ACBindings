namespace ACBindings;

// UIPreferenceItemEnum
public unsafe struct UIPreferenceItemEnum
{
    // Base Classes
    public ACBindings.UIPreferenceItem BaseClass_UIPreferenceItem; // ACBindings.UIPreferenceItem

    // Child Types
    // UIPreferenceItemEnum_vtbl
    public unsafe struct UIPreferenceItemEnum_vtbl
    {
        // Members
        public System.IntPtr UIPreferenceItemEnum_dtor_0; // function pointer
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
    public uint m_nCache;
    public ACBindings.SmartArray__uint m_arrayChoices;

    // Generated Constructor
    public UIPreferenceItemEnum() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall UIPreferenceItemEnum::UIPreferenceItemEnum(UIPreferenceItemEnum*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemEnum, void>)0x005DE560)(ref this);
    // bool __thiscall UIPreferenceItemEnum::InqEnum(UIPreferenceItemEnum*,unsigned int*)
    public byte InqEnum(uint* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemEnum, uint*, byte>)0x005DE5A0)(ref this, o_value);
    // bool __thiscall UIPreferenceItemEnum::SetEnum(UIPreferenceItemEnum*,const unsigned int)
    public byte SetEnum(uint i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemEnum, uint, byte>)0x005DE5C0)(ref this, i_value);
    // char __thiscall UIPreferenceItemEnum::InqEnumChoices(void*,_DWORD*)
    public sbyte InqEnumChoices(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemEnum, int*, sbyte>)0x005DE610)(ref this, a2);
    // char __thiscall UIPreferenceItemEnum::SetEnumChoices(_DWORD*,_DWORD*)
    public sbyte SetEnumChoices(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemEnum, int*, sbyte>)0x005DE630)(ref this, a2);
    // char __thiscall UIPreferenceItemEnum::InqEnumValues(volatile LONG**,_DWORD*)
    public sbyte InqEnumValues(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UIPreferenceItemEnum, int*, sbyte>)0x005DF090)(ref this, a2);
}

