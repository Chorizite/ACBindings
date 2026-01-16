namespace ACBindings.Internal;


/// <summary>Holds a 64‑bit integer for use as a property value, providing operations for copying, comparison, string conversion, and binary serialization.</summary>
public unsafe struct LongIntegerPropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public long m_value;

    // Methods

    /// <summary>Serializes the 64‑bit integer value of a LongIntegerPropertyValue instance into the specified Archive.
    /// <code>Offset: 0x00423AD0
    /// void __thiscall LongIntegerPropertyValue::Serialize(LongIntegerPropertyValue*,Archive*,const unsigned int)</code>
    /// </summary>
    /// <param name="io_archive">Archive to write the value to.</param>
    /// <param name="i_eName">Identifier for the property (unused in this implementation).</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LongIntegerPropertyValue, ACBindings.Internal.Archive*, uint, void>)0x00423AD0)(ref this, io_archive, i_eName);

    /// <summary>Sets this object's internal 64‑bit value from the supplied BasePropertyValue using its virtual extractor; returns whether the operation succeeded.
    /// <code>Offset: 0x00424900
    /// bool __thiscall LongIntegerPropertyValue::SetValue(LongIntegerPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">The source property value providing the long integer to assign.</param>
    /// <returns>True if extraction and assignment were successful; otherwise false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LongIntegerPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00424900)(ref this, value);

    /// <summary>Compares the 64‑bit integer value held by this instance to the integer represented by another property value.
    /// <code>Offset: 0x00424920
    /// bool __thiscall LongIntegerPropertyValue::Compare(LongIntegerPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">Property value to compare against; must be non‑null and convertible to a 64‑bit integer via its virtual conversion method.</param>
    /// <returns>true if both values are equal; otherwise false (including when p is null or cannot provide an integer).</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LongIntegerPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00424920)(ref this, p);

    /// <summary>Determines whether this long integer property's value is less than the value represented by another property.
    /// <code>Offset: 0x00424970
    /// bool __thiscall LongIntegerPropertyValue::InqLessThan(LongIntegerPropertyValue*,const BasePropertyValue*,bool*)</code>
    /// </summary>
    /// <param name="i_pcRHS">Property to compare against, expected to supply a 64‑bit integer value.</param>
    /// <param name="o_rbLessThan">Receives true if this value is strictly less; otherwise false.</param>
    /// <returns>True if the comparison was successfully performed; false if the RHS property cannot provide an int64 value.</returns>
    public byte InqLessThan(ACBindings.Internal.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LongIntegerPropertyValue, ACBindings.Internal.BasePropertyValue*, byte*, byte>)0x00424970)(ref this, i_pcRHS, o_rbLessThan);

    /// <summary>Compares this LongIntegerPropertyValue’s integer value with that of another BasePropertyValue, returning true if the former is greater.
    /// <code>Offset: 0x00424AD0
    /// bool __thiscall LongIntegerPropertyValue::operator&gt;(LongIntegerPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="i_rcRhs">The right‑hand side property value to compare against.</param>
    /// <returns>True when this object's m_value exceeds the rhs property's value; otherwise false.</returns>
//     public byte operator>(ACBindings.Internal.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LongIntegerPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00424AD0)(ref this, i_rcRhs);

    /// <summary>Determines whether the integer stored in this LongIntegerPropertyValue is less than that of another BasePropertyValue.
    /// <code>Offset: 0x00424B70
    /// bool __thiscall LongIntegerPropertyValue::operator&lt;(LongIntegerPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="i_rcRhs">The property value to compare against.</param>
    /// <returns>True if this object's value is strictly smaller; otherwise false.</returns>
//     public byte operator__(ACBindings.Internal.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LongIntegerPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00424B70)(ref this, i_rcRhs);

    /// <summary>Creates a duplicate of this LongIntegerPropertyValue, allocating a new BasePropertyValue that stores the same 64‑bit value.
    /// <code>Offset: 0x00424CB0
    /// BasePropertyValue* __thiscall LongIntegerPropertyValue::Copy(LongIntegerPropertyValue*)</code>
    /// </summary>
    /// <returns>A pointer to the newly created BasePropertyValue representing the copied value; returns nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LongIntegerPropertyValue, ACBindings.Internal.BasePropertyValue*>)0x00424CB0)(ref this);

    /// <summary>Extracts a 64‑bit integer from a file node's leaf text and stores it in the property value.
    /// <code>Offset: 0x00427730
    /// bool __thiscall LongIntegerPropertyValue::FromFileNode(LongIntegerPropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Property descriptor providing metadata; unused by this routine.</param>
    /// <param name="node">File node expected to contain an int64 value as its leaf string.</param>
    /// <returns>True when parsing succeeds and the value is stored; otherwise false, with an error reported.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LongIntegerPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00427730)(ref this, desc, node);

    /// <summary>Serializes this property’s 64‑bit integer value into a string and adds it as a sub‑node to the supplied file node, indicating success of the operation.
    /// <code>Offset: 0x004278D0
    /// bool __thiscall LongIntegerPropertyValue::ToFileNode(LongIntegerPropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="this">The LongIntegerPropertyValue instance whose value is serialized.</param>
    /// <param name="desc">Description of the property; not referenced in this implementation.</param>
    /// <param name="node">File node that receives the new sub‑node containing the formatted integer string.</param>
    /// <returns>True if the sub‑node was successfully appended to the file node; otherwise, false (e.g., when the input node is null or allocation fails).</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LongIntegerPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x004278D0)(ref this, desc, node);

    /// <summary>Converts the 64‑bit integer stored in this LongIntegerPropertyValue to text and appends it to the string supplied via a3. If a4 is non‑zero, writes decimal; otherwise writes hexadecimal followed by the decimal value in parentheses.
    /// <code>Offset: 0x004279C0
    /// char __thiscall LongIntegerPropertyValue::GetValueAsString(_DWORD*,int,void**,int)</code>
    /// </summary>
    /// <param name="a2">Additional parameter (unused) that may carry context for formatting.</param>
    /// <param name="a3">Reference to a string object where the formatted value will be appended.</param>
    /// <param name="a4">Flag determining numeric base: non‑zero for decimal, zero for hexadecimal with parenthesized decimal.</param>
    /// <returns>Non‑zero on success (always 1).</returns>
    public sbyte GetValueAsString(int a2, void** a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LongIntegerPropertyValue, int, void**, int, sbyte>)0x004279C0)(ref this, a2, a3, a4);
}

