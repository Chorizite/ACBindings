namespace ACBindings.Internal;


/// <summary>Encapsulates a spatial position within the property framework, enabling storage, retrieval, comparison, parsing from files, and serialization to archives.</summary>
public unsafe struct PositionPropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public ACBindings.Internal.Position m_value;

    // Methods

    /// <summary>Determines whether this instance's position holds valid data.
    /// <code>Offset: 0x00424D90
    /// bool __thiscall PositionPropertyValue::HasValidData(PositionPropertyValue*)</code>
    /// </summary>
    /// <returns>True if the stored position value is considered valid, otherwise false.</returns>
    public byte HasValidData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionPropertyValue, byte>)0x00424D90)(ref this);

    /// <summary>Assigns this instance's position from the supplied base property value.
    /// <code>Offset: 0x00424DA0
    /// bool __thiscall PositionPropertyValue::SetValue(PositionPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">The source property value containing new position data.</param>
    /// <returns>True if the value was successfully applied; otherwise false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00424DA0)(ref this, value);

    /// <summary>Writes the internal position value into the supplied archive for persistence or transmission.
    /// <code>Offset: 0x00424DC0
    /// void __thiscall PositionPropertyValue::Serialize(PositionPropertyValue*,Archive*,const unsigned int)</code>
    /// </summary>
    /// <param name="io_archive">Archive to receive the serialized position data.</param>
    /// <param name="i_eName">Identifier of the element being serialized (unused in this implementation).</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionPropertyValue, ACBindings.Internal.Archive*, uint, void>)0x00424DC0)(ref this, io_archive, i_eName);

    /// <summary>Returns true when the supplied BasePropertyValue can be interpreted as a Position and this object's objcell_id equals zero while its frame matches the identity Frame; otherwise returns false.
    /// <code>Offset: 0x00424DD0
    /// bool __thiscall PositionPropertyValue::Compare(PositionPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="this">The PositionPropertyValue instance whose position is being evaluated.</param>
    /// <param name="p">A BasePropertyValue that may reference a Position value.</param>
    /// <returns>True if p is convertible to a Position and this object's objcell_id is zero with a frame equal to the identity Frame; otherwise false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00424DD0)(ref this, p);

    /// <summary>Create a duplicate of this PositionPropertyValue instance and return it as a BasePropertyValue pointer.
    /// <code>Offset: 0x00425EA0
    /// BasePropertyValue* __thiscall PositionPropertyValue::Copy(PositionPropertyValue*)</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated BasePropertyValue containing the copied value, or nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionPropertyValue, ACBindings.Internal.BasePropertyValue*>)0x00425EA0)(ref this);

    /// <summary>Parses a Position from the specified file node and assigns it to the property value, returning true on success.
    /// <code>Offset: 0x00425F80
    /// bool __thiscall PositionPropertyValue::FromFileNode(PositionPropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Descriptor of the property; currently unused by this function but provided for consistency with other FromFileNode implementations.</param>
    /// <param name="node">The file node containing the position data.</param>
    /// <returns>True if parsing succeeded and the value was set; otherwise, false.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00425F80)(ref this, desc, node);

    /// <summary>Retrieves the current position stored in a PositionPropertyValue instance into the supplied Position structure.
    /// <code>Offset: 0x00426190
    /// bool __thiscall PositionPropertyValue::InqPosition(PositionPropertyValue*,Position*)</code>
    /// </summary>
    /// <param name="value">Receives the position data from the object.</param>
    /// <returns>True if the position was successfully copied.</returns>
    public byte InqPosition(ACBindings.Internal.Position* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionPropertyValue, ACBindings.Internal.Position*, byte>)0x00426190)(ref this, value);

    /// <summary>Updates the property’s position by copying the cell ID and frame data from a supplied Position structure.
    /// <code>Offset: 0x004261B0
    /// bool __thiscall PositionPropertyValue::SetPosition(PositionPropertyValue*,const Position*)</code>
    /// </summary>
    /// <param name="value">The Position object whose values will replace the current ones.</param>
    /// <returns>True when the assignment succeeds (always true in this implementation).</returns>
    public byte SetPosition(ACBindings.Internal.Position* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionPropertyValue, ACBindings.Internal.Position*, byte>)0x004261B0)(ref this, value);

    /// <summary>Converts the stored position into a string and stores it as a sub‑node of the supplied file node.
    /// <code>Offset: 0x00427B20
    /// bool __thiscall PositionPropertyValue::ToFileNode(PositionPropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Property descriptor for the value being serialized.</param>
    /// <param name="node">File node under which to create the new sub‑node.</param>
    /// <returns>True if serialization succeeds; otherwise false.</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00427B20)(ref this, desc, node);

    /// <summary>Converts the Position stored within this object to a string representation and assigns it to the supplied output buffer.
    /// <code>Offset: 0x00427B70
    /// char __thiscall PositionPropertyValue::GetValueAsString(int,int,void**,int)</code>
    /// </summary>
    /// <param name="a3">Pointer to a string container that receives the formatted position.</param>
    /// <returns>1 to indicate successful conversion.</returns>
    public sbyte GetValueAsString(int a2, void** a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PositionPropertyValue, int, void**, int, sbyte>)0x00427B70)(ref this, a2, a3, a4);
}

