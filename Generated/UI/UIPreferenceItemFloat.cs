namespace ACBindings.Internal;

public unsafe struct UIPreferenceItemFloat
{
    // Base Classes
    public ACBindings.Internal.UIPreferenceItem BaseClass_UIPreferenceItem; // ACBindings.Internal.UIPreferenceItem

    // Child Types
    public unsafe struct UIPreferenceItemFloat_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, void> UIPreferenceItemFloat_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, byte*, byte> InqBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, byte, byte> SetBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, int*, byte> InqInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, int, byte> SetInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, int*, int*, byte> InqIntegerRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, int, int, byte> SetIntegerRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, uint*, byte> InqEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, uint, byte> SetEnum; // function pointer
        public System.IntPtr InqEnumChoices;
        public System.IntPtr SetEnumChoices;
        public System.IntPtr InqEnumValues;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, float*, byte> InqFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, float, byte> SetFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, float*, float*, byte> InqFloatRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, float, float, byte> SetFloatRange; // function pointer
        public System.IntPtr InqString;
        public System.IntPtr SetString;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, byte*, byte> InqCachedBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, byte, byte> SetCachedBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, int*, byte> InqCachedInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, int, byte> SetCachedInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, uint*, byte> InqCachedEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, uint, byte> SetCachedEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, float*, byte> InqCachedFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, float, byte> SetCachedFloat; // function pointer
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

    /// <summary>
    /// <code>Offset: 0x005DE690
    /// void __thiscall UIPreferenceItemFloat::UIPreferenceItemFloat(UIPreferenceItemFloat*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemFloat, void>)0x005DE690)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DE6D0
    /// bool __thiscall UIPreferenceItemFloat::InqFloat(UIPreferenceItemFloat*,float*)</code>
    /// </summary>
    public byte InqFloat(float* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemFloat, float*, byte>)0x005DE6D0)(ref this, o_value);

    /// <summary>
    /// <code>Offset: 0x005DE6F0
    /// bool __thiscall UIPreferenceItemFloat::SetFloat(UIPreferenceItemFloat*,const float)</code>
    /// </summary>
    public byte SetFloat(float i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemFloat, float, byte>)0x005DE6F0)(ref this, i_value);

    /// <summary>
    /// <code>Offset: 0x005DE730
    /// bool __thiscall UIPreferenceItemFloat::SetFloatRange(UIPreferenceItemInt*,const int,const int)</code>
    /// </summary>
    public byte SetFloatRange(int i_nMin, int i_nMax) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemFloat, int, int, byte>)0x005DE730)(ref this, i_nMin, i_nMax);

    /// <summary>
    /// <code>Offset: 0x005DE810
    /// bool __thiscall UIPreferenceItemFloat::SetCachedFloat(UIPreferenceItemInt*,const int)</code>
    /// </summary>
    public byte SetCachedFloat(int i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemFloat, int, byte>)0x005DE810)(ref this, i_value);
}

