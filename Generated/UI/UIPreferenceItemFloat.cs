namespace ACBindings.Internal;


/// <summary>Floating‑point preference item used by the UI system to store a configurable value along with its minimum and maximum bounds, enabling retrieval and modification of user preferences.</summary>
public unsafe struct UIPreferenceItemFloat
{
    // Base Classes
    public ACBindings.Internal.UIPreferenceItem BaseClass_UIPreferenceItem; // ACBindings.Internal.UIPreferenceItem

    // Child Types
    public unsafe struct UIPreferenceItemFloat_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, void> UIPreferenceItemFloat_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, byte*, byte> InqBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, byte, byte> SetBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, int*, byte> InqInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, int, byte> SetInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, int*, int*, byte> InqIntegerRange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, int, int, byte> SetIntegerRange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, uint*, byte> InqEnum; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, uint, byte> SetEnum; // function pointer
        public System.IntPtr InqEnumChoices;
        public System.IntPtr SetEnumChoices;
        public System.IntPtr InqEnumValues;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, float*, byte> InqFloat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, float, byte> SetFloat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, float*, float*, byte> InqFloatRange; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, float, float, byte> SetFloatRange; // function pointer
        public System.IntPtr InqString;
        public System.IntPtr SetString;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, byte*, byte> InqCachedBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, byte, byte> SetCachedBool; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, int*, byte> InqCachedInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, int, byte> SetCachedInteger; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, uint*, byte> InqCachedEnum; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, uint, byte> SetCachedEnum; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, float*, byte> InqCachedFloat; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.UIPreferenceItemFloat*, float, byte> SetCachedFloat; // function pointer
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

    /// <summary>Initializes a UIPreferenceItemFloat instance, setting up its base class properties and establishing a default float preference range of 0 to 1.
    /// <code>Offset: 0x005DE690
    /// void __thiscall UIPreferenceItemFloat::UIPreferenceItemFloat(UIPreferenceItemFloat*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemFloat, void>)0x005DE690)(ref this);

    /// <summary>Retrieves the current value of the preference item and writes it to the provided output pointer.
    /// <code>Offset: 0x005DE6D0
    /// bool __thiscall UIPreferenceItemFloat::InqFloat(UIPreferenceItemFloat*,float*)</code>
    /// </summary>
    /// <param name="o_value">Pointer to store the retrieved float value.</param>
    /// <returns>True if the value was successfully queried; otherwise, false.</returns>
    public byte InqFloat(float* o_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemFloat, float*, byte>)0x005DE6D0)(ref this, o_value);

    /// <summary>Assigns a new float value to this preference item and stores it in the underlying preference system.
    /// <code>Offset: 0x005DE6F0
    /// bool __thiscall UIPreferenceItemFloat::SetFloat(UIPreferenceItemFloat*,const float)</code>
    /// </summary>
    /// <param name="i_value">The float value to set for the preference.</param>
    /// <returns>True if the operation succeeded; otherwise false.</returns>
    public byte SetFloat(float i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemFloat, float, byte>)0x005DE6F0)(ref this, i_value);

    /// <summary>Defines the allowable range for this float preference by setting its minimum and maximum values.
    /// <code>Offset: 0x005DE730
    /// bool __thiscall UIPreferenceItemFloat::SetFloatRange(UIPreferenceItemInt*,const int,const int)</code>
    /// </summary>
    /// <param name="i_nMin">The lower bound of the range.</param>
    /// <param name="i_nMax">The upper bound of the range.</param>
    /// <returns>Always returns true to indicate success.</returns>
    public byte SetFloatRange(int i_nMin, int i_nMax) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemFloat, int, int, byte>)0x005DE730)(ref this, i_nMin, i_nMax);

    /// <summary>Sets the cached float value from an integer input and returns success.
    /// <code>Offset: 0x005DE810
    /// bool __thiscall UIPreferenceItemFloat::SetCachedFloat(UIPreferenceItemInt*,const int)</code>
    /// </summary>
    /// <param name="i_value">The integer value to store in the item's cache.</param>
    /// <returns>Always true after setting the cache.</returns>
    public byte SetCachedFloat(int i_value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UIPreferenceItemFloat, int, byte>)0x005DE810)(ref this, i_value);
}

