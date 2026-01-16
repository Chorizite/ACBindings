namespace ACBindings.Internal;


/// <summary>
/// Encapsulates a 64‑bit bitfield property value and supplies methods for comparison, serialization, manipulation, and string conversion within the property management framework.
/// </summary>
public unsafe struct Bitfield64PropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public ulong m_value;

    // Methods

    /// <summary>Stores the supplied long double value into the object's 64‑bit field, converting as necessary.
    /// <code>Offset: 0x00423790
    /// bool __thiscall Bitfield64PropertyValue::SetBitfield64(TimeStampPropertyValue*,const long double)</code>
    /// </summary>
    /// <param name="value">The new value for the bitfield, provided as a long double.</param>
    /// <returns>True on success.</returns>
    public byte SetBitfield64(double value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield64PropertyValue, double, byte>)0x00423790)(ref this, value);

    /// <summary>Assigns a 64‑bit property value from the supplied BasePropertyValue instance.
    /// <code>Offset: 0x004237B0
    /// bool __thiscall Bitfield64PropertyValue::SetValue(Bitfield64PropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">The source property value providing the new data.</param>
    /// <returns>True if the assignment succeeded; otherwise false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield64PropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004237B0)(ref this, value);

    /// <summary>Determines whether the given BasePropertyValue represents the same 64‑bit bitfield as this instance.
    /// <code>Offset: 0x004237D0
    /// bool __thiscall Bitfield64PropertyValue::Compare(Bitfield64PropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The BasePropertyValue to compare against.</param>
    /// <returns>True when the value stored in p matches this Bitfield64PropertyValue; otherwise, false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield64PropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004237D0)(ref this, p);

    /// <summary>Compares this 64‑bit bitfield value with another property value and reports whether it is less than that value via an output flag. Returns true if the comparison succeeded; otherwise false.
    /// <code>Offset: 0x00423820
    /// bool __thiscall Bitfield64PropertyValue::InqLessThan(Bitfield64PropertyValue*,const BasePropertyValue*,bool*)</code>
    /// </summary>
    /// <param name="i_pcRHS">The property value to compare against.</param>
    /// <param name="o_rbLessThan">On success, set to true if this object's value is smaller than i_pcRHS's 64‑bit value; otherwise false.</param>
    /// <returns>True when the RHS value was successfully retrieved and compared; false on failure.</returns>
    public byte InqLessThan(ACBindings.Internal.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield64PropertyValue, ACBindings.Internal.BasePropertyValue*, byte*, byte>)0x00423820)(ref this, i_pcRHS, o_rbLessThan);

    /// <summary>Determines whether this 64‑bit bitfield contains all bits set in a given property value.
    /// <code>Offset: 0x004239A0
    /// bool __thiscall Bitfield64PropertyValue::contains(Bitfield64PropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="i_rcRhs">The property value whose bits are to be tested against the current bitfield.</param>
    /// <returns>True if every bit that is set in i_rcRhs appears in this->m_value; otherwise false.</returns>
    public byte contains(ACBindings.Internal.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield64PropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004239A0)(ref this, i_rcRhs);

    /// <summary>Clears the bits indicated by the supplied property mask from this 64‑bit value.
    /// <code>Offset: 0x00423A40
    /// void __thiscall Bitfield64PropertyValue::off(Bitfield64PropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="i_rcRhs">Property value containing a bitmask of bits to clear.</param>
    public void off(ACBindings.Internal.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield64PropertyValue, ACBindings.Internal.BasePropertyValue*, void>)0x00423A40)(ref this, i_rcRhs);

    /// <summary>Inverts every bit of the 64‑bit value stored in m_value.
    /// <code>Offset: 0x00423A80
    /// void __thiscall Bitfield64PropertyValue::toggle(Bitfield64PropertyValue*)</code>
    /// </summary>
    public void toggle() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield64PropertyValue, void>)0x00423A80)(ref this);

    /// <summary>Creates a new pair of BasePropertyValue objects that duplicate this Bitfield64PropertyValue’s data and metadata. The first element stores the object’s vtable pointer and a reference count of one, while the second element encodes the raw 64‑bit value as its vtable pointer and uses the high word of that value as an initial reference count.
    /// <code>Offset: 0x00423AA0
    /// BasePropertyValue* __thiscall Bitfield64PropertyValue::Copy(Bitfield64PropertyValue*)</code>
    /// </summary>
    /// <returns>A pointer to the allocated array of two BasePropertyValue structures, or nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield64PropertyValue, ACBindings.Internal.BasePropertyValue*>)0x00423AA0)(ref this);

    /// <summary>Parses a 64‑bit bitfield property value from the supplied file node according to the provided property description. Returns true when the value is successfully extracted or false if the node is null, the property type is unsupported, or an error occurs during parsing.
    /// <code>Offset: 0x0042B100
    /// bool __thiscall Bitfield64PropertyValue::FromFileNode(Bitfield64PropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Metadata describing the property, including its data ID and type.</param>
    /// <param name="node">File node that contains the bitfield value to be read.</param>
    /// <returns>True if the bitfield was parsed successfully; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield64PropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x0042B100)(ref this, desc, node);

    /// <summary>Converts the 64‑bit bitfield value into a file node using information from the property description, reporting an error if the type is unsupported or the input node is null.
    /// <code>Offset: 0x0042B1B0
    /// bool __thiscall Bitfield64PropertyValue::ToFileNode(Bitfield64PropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Metadata describing the property to be converted.</param>
    /// <param name="node">File node that will receive the serialized bitfield value; must not be null.</param>
    /// <returns>True when the conversion succeeds; otherwise false (e.g., unsupported type or null node).</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield64PropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x0042B1B0)(ref this, desc, node);

    /// <summary>Translates the 64‑bit bitfield value stored in this instance into a space‑separated list of enumeration names based on the data ID referenced by the property descriptor.
    /// <code>Offset: 0x0042B260
    /// char __thiscall Bitfield64PropertyValue::GetValueAsString(_QWORD*,int,int*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a property descriptor that provides the enumeration data ID at offset 24 and type information used for conversion.</param>
    /// <param name="a3">Output string buffer (wide character) that receives the resulting list of names.</param>
    /// <param name="a4">Maximum length or reserved parameter; currently unused by the implementation.</param>
    /// <returns>Non‑zero on success, zero if no enumeration mapping is available.</returns>
    public sbyte GetValueAsString(int a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Bitfield64PropertyValue, int, int*, int, sbyte>)0x0042B260)(ref this, a2, a3, a4);
}

