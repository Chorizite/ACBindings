namespace ACBindings.Internal;


/// <summary>Encapsulates an enumerated preference item, maintaining its current cached value and available choice list for user interface settings.</summary>
public unsafe struct UIPreferenceItemEnum
{
    // Base Classes
    public ACBindings.Internal.UIPreferenceItem BaseClass_UIPreferenceItem; // ACBindings.Internal.UIPreferenceItem

    // Child Types
    public unsafe struct UIPreferenceItemEnum_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, void> UIPreferenceItemEnum_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, byte*, byte> InqBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, byte, byte> SetBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, int*, byte> InqInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, int, byte> SetInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, int*, int*, byte> InqIntegerRange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, int, int, byte> SetIntegerRange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, uint*, byte> InqEnum; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, uint, byte> SetEnum; // function pointer
        public System.IntPtr InqEnumChoices;
        public System.IntPtr SetEnumChoices;
        public System.IntPtr InqEnumValues;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, float*, byte> InqFloat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, float, byte> SetFloat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, float*, float*, byte> InqFloatRange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, float, float, byte> SetFloatRange; // function pointer
        public System.IntPtr InqString;
        public System.IntPtr SetString;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, byte*, byte> InqCachedBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, byte, byte> SetCachedBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, int*, byte> InqCachedInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, int, byte> SetCachedInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, uint*, byte> InqCachedEnum; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, uint, byte> SetCachedEnum; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, float*, byte> InqCachedFloat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemEnum*, float, byte> SetCachedFloat; // function pointer
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

    /// <summary>Constructs a new UIPreferenceItemEnum instance, initializing its base preference item fields, cache value, and choice array to default states.
    /// <code>Offset: 0x005DE560
    /// void __thiscall UIPreferenceItemEnum::UIPreferenceItemEnum(UIPreferenceItemEnum*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemEnum, void>)0x005DE560)(ref this);

    /// <summary>Retrieves the current value of this enum preference item and stores it in the provided output pointer.
    /// <code>Offset: 0x005DE5A0
    /// bool __thiscall UIPreferenceItemEnum::InqEnum(UIPreferenceItemEnum*,unsigned int*)</code>
    /// </summary>
    /// <param name="o_value">Pointer to receive the enumerated preference value.</param>
    /// <returns>True if the value was successfully retrieved; otherwise, false.</returns>
    public byte InqEnum(uint* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemEnum, uint*, byte>)0x005DE5A0)(ref this, o_value);

    /// <summary>Assigns a new enumeration value to the preference item and updates its internal representation.
    /// <code>Offset: 0x005DE5C0
    /// bool __thiscall UIPreferenceItemEnum::SetEnum(UIPreferenceItemEnum*,const unsigned int)</code>
    /// </summary>
    /// <param name="i_value">The integer value representing the desired enum choice.</param>
    /// <returns>True if the operation succeeded; otherwise, false.</returns>
    public byte SetEnum(uint i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemEnum, uint, byte>)0x005DE5C0)(ref this, i_value);

    /// <summary>Populates the supplied array with enumeration choice identifiers for this preference item.
    /// <code>Offset: 0x005DE610
    /// char __thiscall UIPreferenceItemEnum::InqEnumChoices(void*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an array that receives the choice IDs; the method copies the internal choices into it.</param>
    /// <returns>Nonzero if the operation succeeded; zero otherwise.</returns>
    public sbyte InqEnumChoices(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemEnum, int*, sbyte>)0x005DE610)(ref this, a2);

    /// <summary>Appends a new enumeration choice value to this preference item's internal list.
    /// <code>Offset: 0x005DE630
    /// char __thiscall UIPreferenceItemEnum::SetEnumChoices(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the unsigned long value representing the enum choice to add.</param>
    /// <returns>Non‑zero if the choice was added successfully; zero otherwise.</returns>
    public sbyte SetEnumChoices(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemEnum, int*, sbyte>)0x005DE630)(ref this, a2);

    /// <summary>Retrieves the enumeration values associated with this preference item and appends them to the supplied array.
    /// <code>Offset: 0x005DF090
    /// char __thiscall UIPreferenceItemEnum::InqEnumValues(volatile LONG**,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Array receiving the enumeration values returned by the query.</param>
    /// <returns>Non‑zero if the retrieval succeeded; zero otherwise.</returns>
    public sbyte InqEnumValues(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemEnum, int*, sbyte>)0x005DF090)(ref this, a2);
}

