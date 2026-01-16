namespace ACBindings.Internal;


/// <summary>Represents a preference item that handles string values, integrating with the user preferences system and providing caching for efficient access.</summary>
/// <remarks>Used to store and retrieve user-configurable string settings within the application’s UI preferences framework.</remarks>
public unsafe struct UIPreferenceItemString
{
    // Base Classes
    public ACBindings.Internal.UIPreferenceItem BaseClass_UIPreferenceItem; // ACBindings.Internal.UIPreferenceItem

    // Child Types
    public unsafe struct UIPreferenceItemString_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, void> UIPreferenceItemString_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, byte*, byte> InqBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, byte, byte> SetBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, int*, byte> InqInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, int, byte> SetInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, int*, int*, byte> InqIntegerRange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, int, int, byte> SetIntegerRange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, uint*, byte> InqEnum; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, uint, byte> SetEnum; // function pointer
        public System.IntPtr InqEnumChoices;
        public System.IntPtr SetEnumChoices;
        public System.IntPtr InqEnumValues;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, float*, byte> InqFloat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, float, byte> SetFloat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, float*, float*, byte> InqFloatRange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, float, float, byte> SetFloatRange; // function pointer
        public System.IntPtr InqString;
        public System.IntPtr SetString;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, byte*, byte> InqCachedBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, byte, byte> SetCachedBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, int*, byte> InqCachedInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, int, byte> SetCachedInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, uint*, byte> InqCachedEnum; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, uint, byte> SetCachedEnum; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, float*, byte> InqCachedFloat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemString*, float, byte> SetCachedFloat; // function pointer
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

    /// <summary>Initializes a UIPreferenceItemString instance, setting up the base preference item with default values and preparing an empty string cache.
    /// <code>Offset: 0x005DE850
    /// void __thiscall UIPreferenceItemString::UIPreferenceItemString(UIPreferenceItemString*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemString, void>)0x005DE850)(ref this);

    /// <summary>Retrieves the string preference value for this item through UserPreferences::InqValue.
    /// <code>Offset: 0x005DE890
    /// char __thiscall UIPreferenceItemString::InqString(volatile LONG**,int*)</code>
    /// </summary>
    /// <param name="a2">Output parameter that receives additional information related to the retrieved string (e.g., status or metadata).</param>
    /// <returns>A character indicating success (non‑zero) or failure (zero).</returns>
    public sbyte InqString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemString, int*, sbyte>)0x005DE890)(ref this, a2);

    /// <summary>Updates the underlying user preference with a new string value.
    /// <code>Offset: 0x005DE8B0
    /// char __thiscall UIPreferenceItemString::SetString(volatile LONG**,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the string data that will replace the current preference value.</param>
    /// <returns>A status flag (non‑zero on success, zero on failure) indicating whether the update succeeded.</returns>
    public sbyte SetString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemString, int*, sbyte>)0x005DE8B0)(ref this, a2);

    /// <summary>Retrieves the cached preference string and stores it in the supplied buffer.
    /// <code>Offset: 0x005DE8D0
    /// char __thiscall UIPreferenceItemString::InqCachedString(LONG*,LONG*)</code>
    /// </summary>
    /// <param name="a2">Reference to a string object where the cached value will be copied.</param>
    /// <returns>Non‑zero if the operation succeeded; zero otherwise.</returns>
    public sbyte InqCachedString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemString, int*, sbyte>)0x005DE8D0)(ref this, a2);

    /// <summary>Sets the cached string for this preference item.
    /// <code>Offset: 0x005DE8F0
    /// char __thiscall UIPreferenceItemString::SetCachedString(LONG*,LONG*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the new string value to store in the cache.</param>
    /// <returns>Always 1 (true) indicating successful caching.</returns>
    public sbyte SetCachedString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemString, int*, sbyte>)0x005DE8F0)(ref this, a2);
}

