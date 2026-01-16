namespace ACBindings.Internal;


/// <summary>Holds a property value that encapsulates string data through StringInfo and aggregates the base property functionality via BasePropertyValue composition.</summary>
/// <remarks>Supports copying, comparison with other properties, loading from and saving to file nodes, validity checks on table identifiers and token markers, and serialization into archives. The struct does not inherit from BasePropertyValue; instead it contains a BasePropertyValue instance that provides the common property interface.</remarks>
public unsafe struct StringInfoPropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public ACBindings.Internal.StringInfo m_value;

    // Methods

    /// <summary>Copies the supplied StringInfo object into this property value's internal string information.
    /// <code>Offset: 0x00424FE0
    /// bool __thiscall StringInfoPropertyValue::InqStringInfo(StringInfoPropertyValue*,StringInfo*)</code>
    /// </summary>
    /// <param name="value">The source StringInfo whose contents are copied into the property.</param>
    /// <returns>Always true, indicating the copy succeeded.</returns>
    public byte InqStringInfo(ACBindings.Internal.StringInfo* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfoPropertyValue, ACBindings.Internal.StringInfo*, byte>)0x00424FE0)(ref this, value);

    /// <summary>Assigns the supplied StringInfo to the property’s internal value and indicates success.
    /// <code>Offset: 0x00425000
    /// bool __thiscall StringInfoPropertyValue::SetStringInfo(StringInfoPropertyValue*,const StringInfo*)</code>
    /// </summary>
    /// <param name="value">The new string information to set.</param>
    /// <returns>True if the assignment succeeded; otherwise, false (currently always true).</returns>
    public byte SetStringInfo(ACBindings.Internal.StringInfo* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfoPropertyValue, ACBindings.Internal.StringInfo*, byte>)0x00425000)(ref this, value);

    /// <summary>Copies or converts the supplied BasePropertyValue into this StringInfoPropertyValue's internal string representation.
    /// <code>Offset: 0x00425020
    /// bool __thiscall StringInfoPropertyValue::SetValue(StringInfoPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">The source property value to copy from.</param>
    /// <returns>True if the conversion succeeded; otherwise false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfoPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00425020)(ref this, value);

    /// <summary>Creates a new StringInfoPropertyValue instance copying the underlying string value and returns it as a BasePropertyValue pointer.
    /// <code>Offset: 0x00425120
    /// BasePropertyValue* __thiscall StringInfoPropertyValue::Copy(StringInfoPropertyValue*)</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated copy of the property value; null if allocation fails.</returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfoPropertyValue, ACBindings.Internal.BasePropertyValue*>)0x00425120)(ref this);

    /// <summary>Saves the StringInfo value of this property into the specified archive.
    /// <code>Offset: 0x00425160
    /// void __thiscall StringInfoPropertyValue::Serialize(StringInfoPropertyValue*,Archive*,const unsigned int)</code>
    /// </summary>
    /// <param name="io_archive">The archive to write the string information into.</param>
    /// <param name="i_eName">Identifier or name for the serialized data, typically unused in this implementation.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfoPropertyValue, ACBindings.Internal.Archive*, uint, void>)0x00425160)(ref this, io_archive, i_eName);

    /// <summary>Validates that the StringInfoPropertyValue contains a string entry with a non‑INVALID table ID and whose preceding token marker is not set to 1.
    /// <code>Offset: 0x004261D0
    /// bool __thiscall StringInfoPropertyValue::HasValidData(StringInfoPropertyValue*)</code>
    /// </summary>
    /// <returns>True when both conditions are met; otherwise false.</returns>
    public byte HasValidData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfoPropertyValue, byte>)0x004261D0)(ref this);

    /// <summary>Compares this instance's stored string information with the string representation of another property value, returning true when they match.
    /// <code>Offset: 0x004261F0
    /// bool __thiscall StringInfoPropertyValue::Compare(StringInfoPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The other property value to compare against; if null, comparison fails.</param>
    /// <returns>True if both values are equivalent strings; otherwise false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfoPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004261F0)(ref this, p);

    /// <summary>Loads a string information property value from the specified file node, handling special "INVALID" names and reporting errors if loading fails.
    /// <code>Offset: 0x00427BB0
    /// bool __thiscall StringInfoPropertyValue::FromFileNode(StringInfoPropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Description of the property (unused in this implementation).</param>
    /// <param name="node">File node containing the string data to load.</param>
    /// <returns>True if the string information was successfully loaded; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfoPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00427BB0)(ref this, desc, node);

    /// <summary>Writes the string information value to the given file node, storing a timestamp if the value is valid or marking it as “INVALID” otherwise.
    /// <code>Offset: 0x00427CF0
    /// bool __thiscall StringInfoPropertyValue::ToFileNode(StringInfoPropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="this">The property value instance to serialize.</param>
    /// <param name="desc">Description of the property; unused in this implementation.</param>
    /// <param name="node">File node that will receive the serialized representation. Must not be null.</param>
    /// <returns>True if a non‑null node was supplied and the conversion performed; otherwise false.</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfoPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00427CF0)(ref this, desc, node);

    /// <summary>Retrieves the property value as a formatted string and writes it into the supplied buffer.
    /// <code>Offset: 0x00427D40
    /// char __thiscall StringInfoPropertyValue::GetValueAsString(int,int,char**,const char*)</code>
    /// </summary>
    /// <param name="a2">Unused parameter; reserved for future use or compatibility with other overloads.</param>
    /// <param name="a3">Pointer to a character buffer that receives the resulting string representation.</param>
    /// <param name="a4">Optional format flag; when non‑null, influences literal prefixing and output style.</param>
    /// <returns>Returns 1 on success.</returns>
    public sbyte GetValueAsString(int a2, sbyte** a3, sbyte* a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringInfoPropertyValue, int, sbyte**, sbyte*, sbyte>)0x00427D40)(ref this, a2, a3, a4);
}

