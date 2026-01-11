namespace ACBindings.Internal;

public unsafe struct WaveformPropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public ACBindings.Internal.Waveform m_value;

    // Methods

    /// <summary>Parses a waveform definition from an XML file node and stores it in the property value.
    /// <code>Offset: 0x00425710
    /// bool __thiscall WaveformPropertyValue::FromFileNode(WaveformPropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Property descriptor containing metadata; not used during parsing.</param>
    /// <param name="node">File node that holds the waveform data to parse.</param>
    /// <returns>True if parsing succeeds; false if the node is null or parsing fails.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveformPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00425710)(ref this, desc, node);

    /// <summary>Writes the waveform property value into a file node.
    /// <code>Offset: 0x00425740
    /// bool __thiscall WaveformPropertyValue::ToFileNode(WaveformPropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Property description providing context for the conversion (unused in this implementation).</param>
    /// <param name="node">Target file node to receive the waveform data; must not be null.</param>
    /// <returns>True if the node was successfully updated; false if the node pointer is null.</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveformPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00425740)(ref this, desc, node);

    /// <summary>Copies the waveform stored in this property into the supplied Waveform structure.
    /// <code>Offset: 0x00425760
    /// bool __thiscall WaveformPropertyValue::InqWaveform(WaveformPropertyValue*,Waveform*)</code>
    /// </summary>
    /// <param name="value">Receives a copy of the current waveform value.</param>
    /// <returns>True to indicate successful retrieval.</returns>
    public byte InqWaveform(ACBindings.Internal.Waveform* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveformPropertyValue, ACBindings.Internal.Waveform*, byte>)0x00425760)(ref this, value);

    /// <summary>Assigns the provided waveform data to this property value.
    /// <code>Offset: 0x004257D0
    /// bool __thiscall WaveformPropertyValue::SetWaveform(WaveformPropertyValue*,const Waveform*)</code>
    /// </summary>
    /// <param name="value">Waveform to assign.</param>
    /// <returns>True if assignment succeeded; always true for this implementation.</returns>
    public byte SetWaveform(ACBindings.Internal.Waveform* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveformPropertyValue, ACBindings.Internal.Waveform*, byte>)0x004257D0)(ref this, value);

    /// <summary>Updates this object's waveform value using data supplied by the specified BasePropertyValue instance.
    /// <code>Offset: 0x00425820
    /// bool __thiscall WaveformPropertyValue::SetValue(WaveformPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">BasePropertyValue containing new waveform data.</param>
    /// <returns>True if the operation succeeded; otherwise, false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveformPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00425820)(ref this, value);

    /// <summary>Compares this waveform property value against another property value for equality.
    /// <code>Offset: 0x00425840
    /// bool __thiscall WaveformPropertyValue::Compare(WaveformPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The property value to compare with, expected to be of a compatible type.</param>
    /// <returns>True if the other property is non‑null and represents the same waveform value; otherwise false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveformPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00425840)(ref this, p);

    /// <summary>Compares the base component of this object's waveform to that of another property value and reports whether it is less than.
    /// <code>Offset: 0x00425990
    /// bool __thiscall WaveformPropertyValue::InqLessThan(WaveformPropertyValue*,const BasePropertyValue*,bool*)</code>
    /// </summary>
    /// <param name="i_pcRHS">The right‑hand side property value from which a waveform representation is obtained via virtual dispatch.</param>
    /// <param name="o_rbLessThan">If the comparison succeeds, receives true when this object's base value is strictly less than the RHS's base; otherwise false. The output pointer remains unchanged if the function fails.</param>
    /// <returns>True if the comparison was performed successfully (i.e., the RHS provided a valid waveform); otherwise false and o_rbLessThan is left untouched.</returns>
    public byte InqLessThan(ACBindings.Internal.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveformPropertyValue, ACBindings.Internal.BasePropertyValue*, byte*, byte>)0x00425990)(ref this, i_pcRHS, o_rbLessThan);

    /// <summary>Creates a new BasePropertyValue containing a deep copy of this instance’s waveform data.
    /// <code>Offset: 0x004259F0
    /// BasePropertyValue* __thiscall WaveformPropertyValue::Copy(WaveformPropertyValue*)</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed BasePropertyValue with its reference count set to one; returns null if memory allocation fails.</returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveformPropertyValue, ACBindings.Internal.BasePropertyValue*>)0x004259F0)(ref this);

    /// <summary>Serializes the waveform value stored within this property into the provided archive.
    /// <code>Offset: 0x00425A30
    /// void __thiscall WaveformPropertyValue::Serialize(WaveformPropertyValue*,Archive*,const unsigned int)</code>
    /// </summary>
    /// <param name="io_archive">Archive instance receiving serialized waveform data.</param>
    /// <param name="i_eName">Identifier for the property; currently unused during serialization.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveformPropertyValue, ACBindings.Internal.Archive*, uint, void>)0x00425A30)(ref this, io_archive, i_eName);

    /// <summary>Converts the waveform value stored in this object into its textual representation and writes it into the buffer pointed to by a3.
    /// <code>Offset: 0x00426880
    /// char __thiscall WaveformPropertyValue::GetValueAsString(void*,int,LONG*,int)</code>
    /// </summary>
    /// <param name="a2">Unused parameter.</param>
    /// <param name="a3">Pointer to a string buffer that will receive the waveform's text form.</param>
    /// <param name="a4">Unused parameter.</param>
    /// <returns>Always returns 1, indicating success.</returns>
    public sbyte GetValueAsString(int a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.WaveformPropertyValue, int, int*, int, sbyte>)0x00426880)(ref this, a2, a3, a4);
}

