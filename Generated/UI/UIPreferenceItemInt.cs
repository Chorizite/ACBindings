namespace ACBindings.Internal;

public unsafe struct UIPreferenceItemInt
{
    // Base Classes
    public ACBindings.Internal.UIPreferenceItem BaseClass_UIPreferenceItem; // ACBindings.Internal.UIPreferenceItem

    // Child Types
    public unsafe struct UIPreferenceItemInt_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, void> UIPreferenceItemInt_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, byte*, byte> InqBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, byte, byte> SetBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, int*, byte> InqInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, int, byte> SetInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, int*, int*, byte> InqIntegerRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, int, int, byte> SetIntegerRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, uint*, byte> InqEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, uint, byte> SetEnum; // function pointer
        public System.IntPtr InqEnumChoices;
        public System.IntPtr SetEnumChoices;
        public System.IntPtr InqEnumValues;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, float*, byte> InqFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, float, byte> SetFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, float*, float*, byte> InqFloatRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, float, float, byte> SetFloatRange; // function pointer
        public System.IntPtr InqString;
        public System.IntPtr SetString;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, byte*, byte> InqCachedBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, byte, byte> SetCachedBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, int*, byte> InqCachedInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, int, byte> SetCachedInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, uint*, byte> InqCachedEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, uint, byte> SetCachedEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, float*, byte> InqCachedFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, float, byte> SetCachedFloat; // function pointer
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

    /// <summary>
    /// <code>Offset: 0x005DE710
    /// bool __thiscall UIPreferenceItemInt::InqIntegerRange(UIPreferenceItemInt*,int*,int*)</code>
    /// </summary>
    public byte InqIntegerRange(int* o_nMin, int* o_nMax) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemInt, int*, int*, byte>)0x005DE710)(ref this, o_nMin, o_nMax);

    /// <summary>
    /// <code>Offset: 0x005DE780
    /// void __thiscall UIPreferenceItemInt::UIPreferenceItemInt(UIPreferenceItemInt*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemInt, void>)0x005DE780)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DE7C0
    /// bool __thiscall UIPreferenceItemInt::InqInteger(UIPreferenceItemInt*,int*)</code>
    /// </summary>
    public byte InqInteger(int* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemInt, int*, byte>)0x005DE7C0)(ref this, o_value);

    /// <summary>
    /// <code>Offset: 0x005DE7E0
    /// bool __thiscall UIPreferenceItemInt::SetInteger(UIPreferenceItemInt*,const int)</code>
    /// </summary>
    public byte SetInteger(int i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemInt, int, byte>)0x005DE7E0)(ref this, i_value);

    /// <summary>
    /// <code>Offset: 0x005DE800
    /// bool __thiscall UIPreferenceItemInt::InqCachedInteger(UIPreferenceItemInt*,int*)</code>
    /// </summary>
    public byte InqCachedInteger(int* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemInt, int*, byte>)0x005DE800)(ref this, o_value);
}

