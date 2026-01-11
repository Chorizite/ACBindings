namespace ACBindings.Internal;

public unsafe struct Bitfield32PropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public uint m_value;

    // Methods

    /// <summary>Sets the internal 32‑bit field from the specified base property value.
    /// <code>Offset: 0x00423530
    /// bool __thiscall Bitfield32PropertyValue::SetValue(Bitfield32PropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">The source property value providing the bitfield data.</param>
    /// <returns>True if the conversion succeeded; otherwise false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield32PropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00423530)(ref this, value);

    /// <summary>
    /// Determines whether this Bitfield32PropertyValue matches another property value by verifying that the other value is non‑null, passes its own compatibility check via a virtual method, and that the stored 32‑bit field equals the address of the other property.
    /// 
    /// <code>Offset: 0x00423550
    /// bool __thiscall Bitfield32PropertyValue::Compare(Bitfield32PropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The BasePropertyValue to compare against.</param>
    /// <returns>True if p satisfies the checks and the values match; otherwise false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield32PropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00423550)(ref this, p);

    /// <summary>Determines whether this bitfield's value is strictly less than that of a supplied property and stores the result in an output flag.
    /// <code>Offset: 0x00423590
    /// bool __thiscall Bitfield32PropertyValue::InqLessThan(Bitfield32PropertyValue*,const BasePropertyValue*,bool*)</code>
    /// </summary>
    /// <param name="i_pcRHS">The property whose value is compared against this instance.</param>
    /// <param name="o_rbLessThan">Receives true if this value is less; otherwise false.</param>
    /// <returns>True when the comparison succeeds; false if the right‑hand side cannot provide a comparable value.</returns>
    public byte InqLessThan(ACBindings.Internal.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield32PropertyValue, ACBindings.Internal.BasePropertyValue*, byte*, byte>)0x00423590)(ref this, i_pcRHS, o_rbLessThan);

    /// <summary>Sets the bit represented by the supplied property value in this object's 32‑bit field when that value evaluates to true.
    /// <code>Offset: 0x00423600
    /// void __thiscall Bitfield32PropertyValue::on(Bitfield32PropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="i_rcRhs">The property value whose truthiness determines whether its corresponding bit is set in <c>m_value</c>.</param>
    public void on(ACBindings.Internal.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield32PropertyValue, ACBindings.Internal.BasePropertyValue*, void>)0x00423600)(ref this, i_rcRhs);

    /// <summary>Determines whether a given BasePropertyValue is represented by this Bitfield32PropertyValue instance by validating type compatibility and matching its identifier against the stored bitmask.
    /// <code>Offset: 0x004236C0
    /// bool __thiscall Bitfield32PropertyValue::contains(Bitfield32PropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="i_rcRhs">The property value to test for containment.</param>
    /// <returns>True if the property value matches the bitfield's criteria; otherwise, false.</returns>
    public byte contains(ACBindings.Internal.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield32PropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004236C0)(ref this, i_rcRhs);

    /// <summary>Clears bits in the 32‑bit value of this object according to the supplied property when that property approves the operation via its virtual validation method.
    /// <code>Offset: 0x00423700
    /// void __thiscall Bitfield32PropertyValue::off(Bitfield32PropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="i_rcRhs">The bitmask property to apply; it is validated before being used to clear corresponding bits.</param>
    public void off(ACBindings.Internal.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield32PropertyValue, ACBindings.Internal.BasePropertyValue*, void>)0x00423700)(ref this, i_rcRhs);

    /// <summary>Toggles all bits of the property's 32-bit unsigned integer value.
    /// <code>Offset: 0x00423730
    /// void __thiscall Bitfield32PropertyValue::toggle(Bitfield32PropertyValue*)</code>
    /// </summary>
    public void toggle() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield32PropertyValue, void>)0x00423730)(ref this);

    /// <summary>Creates a new <c>BasePropertyValue</c> instance containing a copy of the current <c>Bitfield32PropertyValue</c>'s data and initializes its reference count.
    /// <code>Offset: 0x00423740
    /// BasePropertyValue* __thiscall Bitfield32PropertyValue::Copy(Bitfield32PropertyValue*)</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated copy, or <c>nullptr</c> if memory allocation fails.</returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield32PropertyValue, ACBindings.Internal.BasePropertyValue*>)0x00423740)(ref this);

    /// <summary>Parses a bitfield property value from the supplied file node according to its type definition and stores the result in the instance. Handles enumerated bitfields, reports errors for unsupported types or parsing failures.
    /// <code>Offset: 0x0042ADB0
    /// bool __thiscall Bitfield32PropertyValue::FromFileNode(Bitfield32PropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Property descriptor containing type and data information used during parsing.</param>
    /// <param name="node">File node that holds the value to be read.</param>
    /// <returns>True if the property was successfully parsed; otherwise false after reporting an error.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield32PropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x0042ADB0)(ref this, desc, node);

    /// <summary>Converts the 32‑bit bitfield property value into a file node according to the supplied property descriptor. Returns true when the conversion succeeds, or false and reports an error if it fails.
    /// <code>Offset: 0x0042AE60
    /// bool __thiscall Bitfield32PropertyValue::ToFileNode(Bitfield32PropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Property descriptor containing type information and metadata for serialization.</param>
    /// <param name="node">File node that receives the serialized representation of the bitfield value.</param>
    /// <returns>True if the property was successfully written to the file node; otherwise, false.</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield32PropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x0042AE60)(ref this, desc, node);

    /// <summary>Retrieves the human‑readable names of all bits set in a 32‑bit enumerated bitfield and places them into the supplied string container.
    /// <code>Offset: 0x0042AFD0
    /// char __thiscall Bitfield32PropertyValue::GetValueAsString(_DWORD*,int,int*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a property data structure that contains type information and a data identifier for the bitfield.</param>
    /// <param name="a3">Output parameter that receives the space‑separated list of enabled bit names.</param>
    /// <param name="a4">Unused context value; ignored by this function.</param>
    /// <returns>Non‑zero if the string was successfully constructed, zero otherwise (e.g., unsupported type or initialization failure).</returns>
    public sbyte GetValueAsString(int a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield32PropertyValue, int, int*, int, sbyte>)0x0042AFD0)(ref this, a2, a3, a4);
}

