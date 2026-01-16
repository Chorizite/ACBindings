namespace ACBindings.Internal;


/// <summary>Stores a 3‑dimensional vector as a property value, providing mechanisms for copying, comparison, serialization, and conversion via the BasePropertyValue interface.</summary>
public unsafe struct VectorPropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public ACBindings.Internal.Vector3 m_value;

    // Methods

    /// <summary>Parses a vector value from the provided file node and stores it in this object's m_value.
    /// <code>Offset: 0x00425520
    /// bool __thiscall VectorPropertyValue::FromFileNode(VectorPropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Descriptor containing metadata about the property being parsed.</param>
    /// <param name="node">File node that holds the serialized vector data.</param>
    /// <returns>True if node is non‑null and the vector was successfully read; otherwise, false.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VectorPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00425520)(ref this, desc, node);

    /// <summary>Converts the vector property value into a file node representation when a valid node is supplied.
    /// <code>Offset: 0x00425540
    /// bool __thiscall VectorPropertyValue::ToFileNode(VectorPropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Descriptor of the property (unused in this conversion).</param>
    /// <param name="node">File node to populate with the vector data; must not be null for success.</param>
    /// <returns>True if the node was populated successfully; otherwise, false.</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VectorPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00425540)(ref this, desc, node);

    /// <summary>Copies the stored 3D vector into the supplied output variable.
    /// <code>Offset: 0x00425560
    /// bool __thiscall VectorPropertyValue::InqVector(VectorPropertyValue*,Vector3*)</code>
    /// </summary>
    /// <param name="value">A reference to a Vector3 object that receives the value of this property.</param>
    /// <returns>True upon successful retrieval (always).</returns>
    public byte InqVector(ACBindings.Internal.Vector3* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VectorPropertyValue, ACBindings.Internal.Vector3*, byte>)0x00425560)(ref this, value);

    /// <summary>Assigns the supplied vector to this property value.
    /// <code>Offset: 0x00425580
    /// bool __thiscall VectorPropertyValue::SetVector(VectorPropertyValue*,const Vector3*)</code>
    /// </summary>
    /// <param name="value">The vector whose components are copied into the property.</param>
    /// <returns>True (the operation always succeeds).</returns>
    public byte SetVector(ACBindings.Internal.Vector3* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VectorPropertyValue, ACBindings.Internal.Vector3*, byte>)0x00425580)(ref this, value);

    /// <summary>Sets the vector property’s value using data from the supplied BasePropertyValue via a virtual conversion method.
    /// <code>Offset: 0x004255A0
    /// bool __thiscall VectorPropertyValue::SetValue(VectorPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">BasePropertyValue containing data to assign to this VectorPropertyValue.</param>
    /// <returns>True if the value was successfully set; otherwise false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VectorPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004255A0)(ref this, value);

    /// <summary>Compares the vector stored in this instance to the vector represented by the supplied BasePropertyValue via its virtual interface, returning true if they match within a small tolerance.
    /// <code>Offset: 0x004255C0
    /// bool __thiscall VectorPropertyValue::Compare(VectorPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The base property value to compare against; may be null.</param>
    /// <returns>True when both vectors are equal within an epsilon of 0.0002, otherwise false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VectorPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004255C0)(ref this, p);

    /// <summary>Determines whether this vector property is considered less than another property value, storing the result in a boolean flag.
    /// <code>Offset: 0x00425610
    /// bool __thiscall VectorPropertyValue::InqLessThan(VectorPropertyValue*,const BasePropertyValue*,bool*)</code>
    /// </summary>
    /// <param name="i_pcRHS">The property value to compare against.</param>
    /// <param name="o_rbLessThan">Receives true if this value is less than i_pcRHS; otherwise false.</param>
    /// <returns>True when the comparison can be performed, false if i_pcRHS cannot provide a comparable float representation.</returns>
    public byte InqLessThan(ACBindings.Internal.BasePropertyValue* i_pcRHS, byte* o_rbLessThan) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VectorPropertyValue, ACBindings.Internal.BasePropertyValue*, byte*, byte>)0x00425610)(ref this, i_pcRHS, o_rbLessThan);

    /// <summary>Creates and returns a new BasePropertyValue instance that duplicates the Vector3 value of this VectorPropertyValue object.
    /// <code>Offset: 0x004256A0
    /// BasePropertyValue* __thiscall VectorPropertyValue::Copy(VectorPropertyValue*)</code>
    /// </summary>
    /// <returns>A pointer to a freshly allocated BasePropertyValue containing the copied vector data, or null if memory allocation fails.</returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VectorPropertyValue, ACBindings.Internal.BasePropertyValue*>)0x004256A0)(ref this);

    /// <summary>Serializes the VectorPropertyValue's m_value to or from an Archive, handling both write and read modes based on the archive's flags.
    /// <code>Offset: 0x00426830
    /// void __thiscall VectorPropertyValue::Serialize(VectorPropertyValue*,Archive*,const unsigned int)</code>
    /// </summary>
    /// <param name="io_archive">Archive instance used for serialization; its flags determine whether data is written or read.</param>
    /// <param name="i_eName">Identifier for the property value element (unused in this implementation but part of signature).</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VectorPropertyValue, ACBindings.Internal.Archive*, uint, void>)0x00426830)(ref this, io_archive, i_eName);

    /// <summary>Formats the vector value as a string with three decimal places and writes it to the supplied buffer.
    /// <code>Offset: 0x004281E0
    /// char __thiscall VectorPropertyValue::GetValueAsString(float*,int,char**,int)</code>
    /// </summary>
    /// <param name="a2">Unused parameter; retained for compatibility.</param>
    /// <param name="a3">Pointer to a character buffer that receives the formatted string.</param>
    /// <param name="a4">Maximum size of the output buffer (unused).</param>
    /// <returns>Always returns 1 indicating success.</returns>
    public sbyte GetValueAsString(int a2, sbyte** a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.VectorPropertyValue, int, sbyte**, int, sbyte>)0x004281E0)(ref this, a2, a3, a4);
}

