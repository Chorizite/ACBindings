namespace ACBindings.Internal;


/// <summary>
/// Represents an integer preference item within the UI system, holding a cached value and defined minimum and maximum bounds.
/// </summary>
/// <remarks>
/// Derived from UIPreferenceItem, it manages persistence through UserPreferences and tracks min/max limits for validation.
/// </remarks>
public unsafe struct UIPreferenceItemInt
{
    // Base Classes
    public ACBindings.Internal.UIPreferenceItem BaseClass_UIPreferenceItem; // ACBindings.Internal.UIPreferenceItem

    // Child Types
    public unsafe struct UIPreferenceItemInt_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, void> UIPreferenceItemInt_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, byte*, byte> InqBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, byte, byte> SetBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, int*, byte> InqInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, int, byte> SetInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, int*, int*, byte> InqIntegerRange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, int, int, byte> SetIntegerRange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, uint*, byte> InqEnum; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, uint, byte> SetEnum; // function pointer
        public System.IntPtr InqEnumChoices;
        public System.IntPtr SetEnumChoices;
        public System.IntPtr InqEnumValues;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, float*, byte> InqFloat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, float, byte> SetFloat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, float*, float*, byte> InqFloatRange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, float, float, byte> SetFloatRange; // function pointer
        public System.IntPtr InqString;
        public System.IntPtr SetString;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, byte*, byte> InqCachedBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, byte, byte> SetCachedBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, int*, byte> InqCachedInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, int, byte> SetCachedInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, uint*, byte> InqCachedEnum; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, uint, byte> SetCachedEnum; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, float*, byte> InqCachedFloat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemInt*, float, byte> SetCachedFloat; // function pointer
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

    /// <summary>Retrieves the minimum and maximum integer values associated with a preference item.
    /// <code>Offset: 0x005DE710
    /// bool __thiscall UIPreferenceItemInt::InqIntegerRange(UIPreferenceItemInt*,int*,int*)</code>
    /// </summary>
    /// <param name="o_nMin">Pointer to receive the item's minimum allowed value.</param>
    /// <param name="o_nMax">Pointer to receive the item's maximum allowed value.</param>
    /// <returns>Always true, indicating successful query.</returns>
    public byte InqIntegerRange(int* o_nMin, int* o_nMax) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemInt, int*, int*, byte>)0x005DE710)(ref this, o_nMin, o_nMax);

    /// <summary>Constructs a UIPreferenceItemInt instance, initializing its base class and setting the preference string buffer to a default name. Sets cache, minimum, and maximum values to 0, 0, and 1 respectively.
    /// <code>Offset: 0x005DE780
    /// void __thiscall UIPreferenceItemInt::UIPreferenceItemInt(UIPreferenceItemInt*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemInt, void>)0x005DE780)(ref this);

    /// <summary>Retrieves the current integer value for this preference item, storing it at the supplied pointer.
    /// <code>Offset: 0x005DE7C0
    /// bool __thiscall UIPreferenceItemInt::InqInteger(UIPreferenceItemInt*,int*)</code>
    /// </summary>
    /// <param name="o_value">Pointer to an integer where the retrieved value will be written.</param>
    /// <returns>True when a valid value is returned; otherwise false.</returns>
    public byte InqInteger(int* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemInt, int*, byte>)0x005DE7C0)(ref this, o_value);

    /// <summary>Assigns an integer value to the preference item and updates the underlying storage.
    /// <code>Offset: 0x005DE7E0
    /// bool __thiscall UIPreferenceItemInt::SetInteger(UIPreferenceItemInt*,const int)</code>
    /// </summary>
    /// <param name="i_value">The new integer value to be stored.</param>
    /// <returns>True if the update was successful; otherwise false.</returns>
    public byte SetInteger(int i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemInt, int, byte>)0x005DE7E0)(ref this, i_value);

    /// <summary>Retrieves the cached integer value stored in a UIPreferenceItemInt instance.
    /// <code>Offset: 0x005DE800
    /// bool __thiscall UIPreferenceItemInt::InqCachedInteger(UIPreferenceItemInt*,int*)</code>
    /// </summary>
    /// <param name="o_value">Pointer to receive the cached integer value.</param>
    /// <returns>True when the value is successfully copied into o_value.</returns>
    public byte InqCachedInteger(int* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemInt, int*, byte>)0x005DE800)(ref this, o_value);
}

