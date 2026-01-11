namespace ACBindings.Internal;

public unsafe struct UIPreferenceItemString
{
    // Base Classes
    public ACBindings.Internal.UIPreferenceItem BaseClass_UIPreferenceItem; // ACBindings.Internal.UIPreferenceItem

    // Child Types
    public unsafe struct UIPreferenceItemString_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, void> UIPreferenceItemString_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, byte*, byte> InqBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, byte, byte> SetBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, int*, byte> InqInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, int, byte> SetInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, int*, int*, byte> InqIntegerRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, int, int, byte> SetIntegerRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, uint*, byte> InqEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, uint, byte> SetEnum; // function pointer
        public System.IntPtr InqEnumChoices;
        public System.IntPtr SetEnumChoices;
        public System.IntPtr InqEnumValues;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, float*, byte> InqFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, float, byte> SetFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, float*, float*, byte> InqFloatRange; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, float, float, byte> SetFloatRange; // function pointer
        public System.IntPtr InqString;
        public System.IntPtr SetString;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, byte*, byte> InqCachedBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, byte, byte> SetCachedBool; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, int*, byte> InqCachedInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, int, byte> SetCachedInteger; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, uint*, byte> InqCachedEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, uint, byte> SetCachedEnum; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, float*, byte> InqCachedFloat; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, float, byte> SetCachedFloat; // function pointer
        public System.IntPtr InqCachedString;
        public System.IntPtr SetCachedString;

        // Methods
    }

    // Members
    public ACBindings.Internal.PStringBase__sbyte m_strCache;

    // Generated Constructor
    public UIPreferenceItemString() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005DE850
    /// void __thiscall UIPreferenceItemString::UIPreferenceItemString(UIPreferenceItemString*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemString, void>)0x005DE850)(ref this);

    /// <summary>
    /// <code>Offset: 0x005DE890
    /// char __thiscall UIPreferenceItemString::InqString(volatile LONG**,int*)</code>
    /// </summary>
    public sbyte InqString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemString, int*, sbyte>)0x005DE890)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005DE8B0
    /// char __thiscall UIPreferenceItemString::SetString(volatile LONG**,int*)</code>
    /// </summary>
    public sbyte SetString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemString, int*, sbyte>)0x005DE8B0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005DE8D0
    /// char __thiscall UIPreferenceItemString::InqCachedString(LONG*,LONG*)</code>
    /// </summary>
    public sbyte InqCachedString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemString, int*, sbyte>)0x005DE8D0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x005DE8F0
    /// char __thiscall UIPreferenceItemString::SetCachedString(LONG*,LONG*)</code>
    /// </summary>
    public sbyte SetCachedString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemString, int*, sbyte>)0x005DE8F0)(ref this, a2);
}

