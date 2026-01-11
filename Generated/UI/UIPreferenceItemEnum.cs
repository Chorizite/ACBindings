namespace ACBindings.Internal;

public unsafe struct UIPreferenceItemEnum
{
    // Base Classes
    public ACBindings.Internal.UIPreferenceItem BaseClass_UIPreferenceItem; // ACBindings.Internal.UIPreferenceItem

    // Child Types
    public unsafe struct UIPreferenceItemEnum_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, void> UIPreferenceItemEnum_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, byte*, byte> InqBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, byte, byte> SetBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, int*, byte> InqInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, int, byte> SetInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, int*, int*, byte> InqIntegerRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, int, int, byte> SetIntegerRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, uint*, byte> InqEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, uint, byte> SetEnum; // function pointer
        public System.IntPtr InqEnumChoices;
        public System.IntPtr SetEnumChoices;
        public System.IntPtr InqEnumValues;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, float*, byte> InqFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, float, byte> SetFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, float*, float*, byte> InqFloatRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, float, float, byte> SetFloatRange; // function pointer
        public System.IntPtr InqString;
        public System.IntPtr SetString;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, byte*, byte> InqCachedBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, byte, byte> SetCachedBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, int*, byte> InqCachedInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, int, byte> SetCachedInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, uint*, byte> InqCachedEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, uint, byte> SetCachedEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, float*, byte> InqCachedFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, float, byte> SetCachedFloat; // function pointer
        public System.IntPtr InqCachedString;
        public System.IntPtr SetCachedString;

        // Methods
    }

    // Members
    public uint m_nCache;
    public ACBindings.Internal.SmartArray__uint m_arrayChoices;

    // Generated Constructor
    public UIPreferenceItemEnum() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005DE560
    /// void __thiscall UIPreferenceItemEnum::UIPreferenceItemEnum(UIPreferenceItemEnum*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemEnum, void>)0x005DE560)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DE5A0
    /// bool __thiscall UIPreferenceItemEnum::InqEnum(UIPreferenceItemEnum*,unsigned int*)</code>
    /// </summary>
    public byte InqEnum(uint* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemEnum, uint*, byte>)0x005DE5A0)(ref this, o_value);

    /// <summary>
    /// <code>Offset: 0x005DE5C0
    /// bool __thiscall UIPreferenceItemEnum::SetEnum(UIPreferenceItemEnum*,const unsigned int)</code>
    /// </summary>
    public byte SetEnum(uint i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemEnum, uint, byte>)0x005DE5C0)(ref this, i_value);

    /// <summary>
    /// <code>Offset: 0x005DE610
    /// char __thiscall UIPreferenceItemEnum::InqEnumChoices(void*,_DWORD*)</code>
    /// </summary>
    public sbyte InqEnumChoices(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemEnum, int*, sbyte>)0x005DE610)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005DE630
    /// char __thiscall UIPreferenceItemEnum::SetEnumChoices(_DWORD*,_DWORD*)</code>
    /// </summary>
    public sbyte SetEnumChoices(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemEnum, int*, sbyte>)0x005DE630)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005DF090
    /// char __thiscall UIPreferenceItemEnum::InqEnumValues(volatile LONG**,_DWORD*)</code>
    /// </summary>
    public sbyte InqEnumValues(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemEnum, int*, sbyte>)0x005DF090)(ref this, a2);
}

