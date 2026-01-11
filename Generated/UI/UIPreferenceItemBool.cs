namespace ACBindings.Internal;

public unsafe struct UIPreferenceItemBool
{
    // Base Classes
    public ACBindings.Internal.UIPreferenceItem BaseClass_UIPreferenceItem; // ACBindings.Internal.UIPreferenceItem

    // Child Types
    public unsafe struct UIPreferenceItemBool_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, void> UIPreferenceItemBool_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, byte*, byte> InqBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, byte, byte> SetBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, int*, byte> InqInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, int, byte> SetInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, int*, int*, byte> InqIntegerRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, int, int, byte> SetIntegerRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, uint*, byte> InqEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, uint, byte> SetEnum; // function pointer
        public System.IntPtr InqEnumChoices;
        public System.IntPtr SetEnumChoices;
        public System.IntPtr InqEnumValues;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, float*, byte> InqFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, float, byte> SetFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, float*, float*, byte> InqFloatRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, float, float, byte> SetFloatRange; // function pointer
        public System.IntPtr InqString;
        public System.IntPtr SetString;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, byte*, byte> InqCachedBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, byte, byte> SetCachedBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, int*, byte> InqCachedInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, int, byte> SetCachedInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, uint*, byte> InqCachedEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, uint, byte> SetCachedEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, float*, byte> InqCachedFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, float, byte> SetCachedFloat; // function pointer
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

    /// <summary>
    /// <code>Offset: 0x005DE490
    /// void __thiscall UIPreferenceItemBool::UIPreferenceItemBool(UIPreferenceItemBool*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemBool, void>)0x005DE490)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DE4D0
    /// bool __thiscall UIPreferenceItemBool::InqBool(UIPreferenceItemBool*,bool*)</code>
    /// </summary>
    public byte InqBool(byte* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemBool, byte*, byte>)0x005DE4D0)(ref this, o_value);

    /// <summary>
    /// <code>Offset: 0x005DE4F0
    /// bool __thiscall UIPreferenceItemBool::SetBool(UIPreferenceItemBool*,const bool)</code>
    /// </summary>
    public byte SetBool(byte i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemBool, byte, byte>)0x005DE4F0)(ref this, i_value);

    /// <summary>
    /// <code>Offset: 0x005DE510
    /// bool __thiscall UIPreferenceItemBool::InqCachedBool(UIPreferenceItemBool*,bool*)</code>
    /// </summary>
    public byte InqCachedBool(byte* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemBool, byte*, byte>)0x005DE510)(ref this, o_value);

    /// <summary>
    /// <code>Offset: 0x005DE520
    /// bool __thiscall UIPreferenceItemBool::SetCachedBool(UIPreferenceItemBool*,const bool)</code>
    /// </summary>
    public byte SetCachedBool(byte i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemBool, byte, byte>)0x005DE520)(ref this, i_value);
}

