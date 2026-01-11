namespace ACBindings.Internal;

public unsafe struct IntegerPropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public int m_value;

    // Methods

    /// <summary>Serializes the integer property's value into the provided archive.
    /// <code>Offset: 0x00424550
    /// void __thiscall IntegerPropertyValue::Serialize(IntegerPropertyValue*,Archive*,const unsigned int)</code>
    /// </summary>
    /// <param name="this">Pointer to the IntegerPropertyValue instance being serialized.</param>
    /// <param name="io_archive">Archive object used for reading or writing data.</param>
    /// <param name="i_eName">Identifier specifying the property’s serialization context (not used in this implementation).</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntegerPropertyValue, ACBindings.Internal.Archive*, uint, void>)0x00424550)(ref this, io_archive, i_eName);

    /// <summary>Sets the integer property from a generic base property value by delegating to the property's virtual extraction routine.
    /// <code>Offset: 0x00424650
    /// bool __thiscall IntegerPropertyValue::SetValue(IntegerPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">The source property value containing an integer representation.</param>
    /// <returns>True if the extraction and assignment succeeded; otherwise, false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntegerPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00424650)(ref this, value);

    /// <summary>Compares this object's value against the memory address of another property after validating type compatibility via a virtual method.
    /// <code>Offset: 0x00424670
    /// bool __thiscall IntegerPropertyValue::Compare(IntegerPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The base property value to compare against.</param>
    /// <returns>True if p is non‑null, its type matches (as verified by the virtual comparison), and this object's stored integer equals the address of p; otherwise false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntegerPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00424670)(ref this, p);

    /// <summary>Determines whether this integer property value is less than another property value.
    /// <code>Offset: 0x004246B0
    /// bool __thiscall IntegerPropertyValue::InqLessThan(IntegerPropertyValue*,const BasePropertyValue*,bool*)</code>
    /// </summary>
    /// <param name="i_pcRHS">The right‑hand side property to compare; must be an IntegerPropertyValue instance.</param>
    /// <param name="o_rbLessThan">Receives true when this.m_value is less than the RHS value, otherwise false.</param>
    /// <returns>True if the comparison succeeded; false if i_pcRHS could not be interpreted as an IntegerPropertyValue.</returns>
    public byte InqLessThan(ACBindings.Internal.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntegerPropertyValue, ACBindings.Internal.BasePropertyValue*, byte*, byte>)0x004246B0)(ref this, i_pcRHS, o_rbLessThan);

    /// <summary>Compares this IntegerPropertyValue's stored integer with the value of another property after verifying type compatibility.
    /// <code>Offset: 0x004247B0
    /// bool __thiscall IntegerPropertyValue::operator&gt;(IntegerPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="this">The IntegerPropertyValue instance performing the comparison.</param>
    /// <param name="i_rcRhs">A BasePropertyValue pointer expected to represent an IntegerPropertyValue; its type is checked before comparison.</param>
    /// <returns>True if this object's value exceeds the RHS property's integer value, otherwise false.</returns>
//     public byte operator>(ACBindings.Internal.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntegerPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004247B0)(ref this, i_rcRhs);

    /// <summary>Determines whether this IntegerPropertyValue’s m_value is less than that of a supplied BasePropertyValue when the latter supports comparison.
    /// <code>Offset: 0x00424810
    /// bool __thiscall IntegerPropertyValue::operator&lt;(IntegerPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="i_rcRhs">The property value to compare against.</param>
    /// <returns>True if the values are comparable and this.m_value is strictly smaller; otherwise false.</returns>
//     public byte operator__(ACBindings.Internal.BasePropertyValue* i_rcRhs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntegerPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00424810)(ref this, i_rcRhs);

    /// <summary>Creates a new BasePropertyValue instance that duplicates the integer value of this IntegerPropertyValue.
    /// <code>Offset: 0x004248D0
    /// BasePropertyValue* __thiscall IntegerPropertyValue::Copy(IntegerPropertyValue*)</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated BasePropertyValue containing the copied integer property value; returns null on allocation failure.</returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntegerPropertyValue, ACBindings.Internal.BasePropertyValue*>)0x004248D0)(ref this);

    /// <summary>Stores the integer property's value into the specified file node.
    /// <code>Offset: 0x00425DB0
    /// bool __thiscall IntegerPropertyValue::ToFileNode(IntegerPropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Property descriptor providing metadata for the property (currently not used).</param>
    /// <param name="node">File node where the value will be recorded.</param>
    /// <returns>True if the operation succeeded; false if no node was provided or the internal creation failed.</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntegerPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00425DB0)(ref this, desc, node);

    /// <summary>Parses an integer value from the given file node and stores it in this property.
    /// <code>Offset: 0x00426E60
    /// bool __thiscall IntegerPropertyValue::FromFileNode(IntegerPropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Property descriptor providing metadata (not used during parsing).</param>
    /// <param name="node">The file node to read; must contain a leaf with an integer value.</param>
    /// <returns>True if the node is valid and contains a parseable integer; otherwise, false.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntegerPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00426E60)(ref this, desc, node);

    /// <summary>Converts the stored integer value to its decimal string representation and writes it into the supplied buffer.
    /// <code>Offset: 0x00427710
    /// char __thiscall IntegerPropertyValue::GetValueAsString(_DWORD*,int,char**,int)</code>
    /// </summary>
    /// <param name="a3">Pointer to a char* that receives the formatted string.</param>
    /// <param name="a4">Size of the destination buffer (unused in this implementation).</param>
    /// <returns>Success indicator, always 1.</returns>
    public sbyte GetValueAsString(int a2, sbyte** a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.IntegerPropertyValue, int, sbyte**, int, sbyte>)0x00427710)(ref this, a2, a3, a4);
}

