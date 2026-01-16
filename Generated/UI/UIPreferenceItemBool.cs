namespace ACBindings.Internal;


/// <summary>Encapsulates a boolean user preference, storing its key name and providing cached access to its state for efficient retrieval.</summary>
public unsafe struct UIPreferenceItemBool
{
    // Base Classes
    public ACBindings.Internal.UIPreferenceItem BaseClass_UIPreferenceItem; // ACBindings.Internal.UIPreferenceItem

    // Child Types
    public unsafe struct UIPreferenceItemBool_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, void> UIPreferenceItemBool_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, byte*, byte> InqBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, byte, byte> SetBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, int*, byte> InqInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, int, byte> SetInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, int*, int*, byte> InqIntegerRange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, int, int, byte> SetIntegerRange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, uint*, byte> InqEnum; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, uint, byte> SetEnum; // function pointer
        public System.IntPtr InqEnumChoices;
        public System.IntPtr SetEnumChoices;
        public System.IntPtr InqEnumValues;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, float*, byte> InqFloat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, float, byte> SetFloat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, float*, float*, byte> InqFloatRange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, float, float, byte> SetFloatRange; // function pointer
        public System.IntPtr InqString;
        public System.IntPtr SetString;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, byte*, byte> InqCachedBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, byte, byte> SetCachedBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, int*, byte> InqCachedInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, int, byte> SetCachedInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, uint*, byte> InqCachedEnum; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, uint, byte> SetCachedEnum; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, float*, byte> InqCachedFloat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemBool*, float, byte> SetCachedFloat; // function pointer
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

    /// <summary>Initializes a new UIPreferenceItemBool instance, setting up its base preference item properties and disabling the internal cache flag.
    /// <code>Offset: 0x005DE490
    /// void __thiscall UIPreferenceItemBool::UIPreferenceItemBool(UIPreferenceItemBool*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemBool, void>)0x005DE490)(ref this);

    /// <summary>Retrieves the current boolean preference value.
    /// <code>Offset: 0x005DE4D0
    /// bool __thiscall UIPreferenceItemBool::InqBool(UIPreferenceItemBool*,bool*)</code>
    /// </summary>
    /// <param name="o_value">The variable to receive the retrieved boolean value.</param>
    /// <returns>True if the preference value was successfully queried; otherwise, false.</returns>
    public byte InqBool(byte* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemBool, byte*, byte>)0x005DE4D0)(ref this, o_value);

    /// <summary>Stores the supplied boolean value in the preference item and reports success.
    /// <code>Offset: 0x005DE4F0
    /// bool __thiscall UIPreferenceItemBool::SetBool(UIPreferenceItemBool*,const bool)</code>
    /// </summary>
    /// <param name="i_value">The boolean state to assign to the preference.</param>
    /// <returns>True if the value was stored successfully; otherwise false.</returns>
    public byte SetBool(byte i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemBool, byte, byte>)0x005DE4F0)(ref this, i_value);

    /// <summary>Retrieves the cached boolean preference value.
    /// <code>Offset: 0x005DE510
    /// bool __thiscall UIPreferenceItemBool::InqCachedBool(UIPreferenceItemBool*,bool*)</code>
    /// </summary>
    /// <param name="o_value">Receives the cached value of the preference item.</param>
    /// <returns>Always true, indicating that the retrieval succeeded.</returns>
    public byte InqCachedBool(byte* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemBool, byte*, byte>)0x005DE510)(ref this, o_value);

    /// <summary>Sets the cached boolean value for a UIPreferenceItemBool instance.
    /// <code>Offset: 0x005DE520
    /// bool __thiscall UIPreferenceItemBool::SetCachedBool(UIPreferenceItemBool*,const bool)</code>
    /// </summary>
    /// <param name="i_value">The desired boolean state to store in m_bCache.</param>
    /// <returns>True after setting the cache; always succeeds.</returns>
    public byte SetCachedBool(byte i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemBool, byte, byte>)0x005DE520)(ref this, i_value);
}

