namespace ACBindings.Internal;

public unsafe struct TimeStampPropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public double m_value;

    // Methods

    /// <summary>Copies the timestamp stored in the object to a caller‑provided variable.
    /// <code>Offset: 0x00423770
    /// bool __thiscall TimeStampPropertyValue::InqTimeStamp(TimeStampPropertyValue*,long double*)</code>
    /// </summary>
    /// <param name="value">Pointer to <c>long double</c> that receives the timestamp value.</param>
    /// <returns>Always true, indicating successful retrieval.</returns>
    public byte InqTimeStamp(double* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimeStampPropertyValue, double*, byte>)0x00423770)(ref this, value);

    /// <summary>Verifies that the timestamp stored in TimeStampPropertyValue is valid by checking that its value differs from the sentinel -1.0.
    /// <code>Offset: 0x004252A0
    /// bool __thiscall TimeStampPropertyValue::HasValidData(TimeStampPropertyValue*)</code>
    /// </summary>
    /// <returns>True when a valid timestamp exists; false if the value equals -1.0.</returns>
    public byte HasValidData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimeStampPropertyValue, byte>)0x004252A0)(ref this);

    /// <summary>Sets the time stamp stored in this object from the supplied BasePropertyValue, returning true on success.
    /// <code>Offset: 0x004252C0
    /// bool __thiscall TimeStampPropertyValue::SetValue(TimeStampPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">The source property value providing the timestamp to set.</param>
    /// <returns>True if the assignment succeeded; otherwise false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimeStampPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004252C0)(ref this, value);

    /// <summary>Compares this time stamp to another property value, returning true when the other value is compatible and its numeric representation matches this instance.
    /// <code>Offset: 0x004252E0
    /// bool __thiscall TimeStampPropertyValue::Compare(TimeStampPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The property value to compare against; must provide a double representation.</param>
    /// <returns>true if p represents the same timestamp value; otherwise, false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimeStampPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004252E0)(ref this, p);

    /// <summary>
    /// Compares the timestamp stored in this object with that of another property value, indicating whether it is less.
    /// 
    /// <code>Offset: 0x00425330
    /// bool __thiscall TimeStampPropertyValue::InqLessThan(TimeStampPropertyValue*,const BasePropertyValue*,bool*)</code>
    /// </summary>
    /// <param name="i_pcRHS">The property value to compare against; must support numeric extraction via its virtual interface.</param>
    /// <param name="o_rbLessThan">Receives true if this object's timestamp is strictly less than the RHS value, false otherwise.</param>
    /// <returns>True if the comparison was performed successfully; false if the RHS does not provide a comparable value.</returns>
    public byte InqLessThan(ACBindings.Internal.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimeStampPropertyValue, ACBindings.Internal.BasePropertyValue*, byte*, byte>)0x00425330)(ref this, i_pcRHS, o_rbLessThan);

    /// <summary>Creates a deep copy of this TimeStampPropertyValue instance as a new BasePropertyValue object, initializing its reference count to one and duplicating the timestamp value.
    /// <code>Offset: 0x00425390
    /// BasePropertyValue* __thiscall TimeStampPropertyValue::Copy(TimeStampPropertyValue*)</code>
    /// </summary>
    /// <returns>Pointer to the newly allocated property value, or nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimeStampPropertyValue, ACBindings.Internal.BasePropertyValue*>)0x00425390)(ref this);

    /// <summary>Converts a timestamp value into a file node, storing it as a double.
    /// <code>Offset: 0x004253C0
    /// bool __thiscall TimeStampPropertyValue::ToFileNode(TimeStampPropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Property description; currently unused in this conversion.</param>
    /// <param name="node">The file node to populate; must not be null.</param>
    /// <returns>True if the node was successfully updated; otherwise false.</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimeStampPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x004253C0)(ref this, desc, node);

    /// <summary>Parses a time stamp value from the supplied file node and stores it in this object's m_value field.
    /// <code>Offset: 0x004280A0
    /// bool __thiscall TimeStampPropertyValue::FromFileNode(TimeStampPropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Property descriptor; currently ignored by this implementation.</param>
    /// <param name="node">File node expected to contain the time stamp value as a numeric leaf.</param>
    /// <returns>True when a leaf exists and contains a double that can be read; false if no node, no leaf, or parsing fails. An error is logged if the parsed value differs from -1.0.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimeStampPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x004280A0)(ref this, desc, node);

    /// <summary>Formats the timestamp into a string using “%.3g” and writes it to the supplied buffer.
    /// <code>Offset: 0x004281C0
    /// char __thiscall TimeStampPropertyValue::GetValueAsString(double*,int,char**,int)</code>
    /// </summary>
    /// <param name="a2">Unused parameter, retained for compatibility with base interface.</param>
    /// <param name="a3">Pointer to a character buffer that receives the formatted timestamp string.</param>
    /// <param name="a4">Size of the buffer (unused in this implementation).</param>
    /// <returns>Always 1, indicating success.</returns>
    public sbyte GetValueAsString(int a2, sbyte** a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimeStampPropertyValue, int, sbyte**, int, sbyte>)0x004281C0)(ref this, a2, a3, a4);

    /// <summary>Serializes a timestamp property value into the provided archive. It locates the property by its identifier, writes either an absolute or relative time representation depending on the property's configuration, and raises an error when the property cannot be found.
    /// <code>Offset: 0x00428790
    /// void __thiscall TimeStampPropertyValue::Serialize(TimeStampPropertyValue*,Archive*,const unsigned int)</code>
    /// </summary>
    /// <param name="io_archive">Archive to write the serialized data to.</param>
    /// <param name="i_eName">Identifier of the property to serialize.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TimeStampPropertyValue, ACBindings.Internal.Archive*, uint, void>)0x00428790)(ref this, io_archive, i_eName);
}

