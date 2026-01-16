namespace ACBindings.Internal;


/// <summary>Represents a property value that stores a string used in file node structures and archives. Provides mechanisms for copying, comparison, validation, and serialization within the system.</summary>
public unsafe struct StringPropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public ACBindings.Internal.PStringBase__sbyte m_value;

    // Methods

    /// <summary>Assigns the string represented by the supplied BasePropertyValue to this StringPropertyValue instance, returning true on success.
    /// <code>Offset: 0x004262E0
    /// bool __thiscall StringPropertyValue::SetValue(StringPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">The source property value from which to extract the string.</param>
    /// <returns>True if the value was successfully applied; otherwise false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004262E0)(ref this, value);

    /// <summary>Checks whether the stored string contains valid data.
    /// <code>Offset: 0x00426300
    /// bool __thiscall StringPropertyValue::HasValidData(StringPropertyValue*)</code>
    /// </summary>
    /// <returns>True when the internal buffer header is not equal to one, indicating a non‑sentinel value; otherwise false.</returns>
    public byte HasValidData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringPropertyValue, byte>)0x00426300)(ref this);

    /// <summary>Creates a deep copy of the current StringPropertyValue by allocating a new object and duplicating its string data.
    /// <code>Offset: 0x00426320
    /// BasePropertyValue* __thiscall StringPropertyValue::Copy(StringPropertyValue*)</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated BasePropertyValue instance that contains the copied string.</returns>
    public ACBindings.Internal.BasePropertyValue* Copy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringPropertyValue, ACBindings.Internal.BasePropertyValue*>)0x00426320)(ref this);

    /// <summary>Extracts the string value from a file node leaf and assigns it to this property instance.
    /// <code>Offset: 0x00426360
    /// bool __thiscall StringPropertyValue::FromFileNode(StringPropertyValue*,const BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="this">The StringPropertyValue object being initialized.</param>
    /// <param name="desc">Metadata describing the property (unused by this method).</param>
    /// <param name="node">The file node whose leaf name supplies the string value.</param>
    /// <returns>True if a valid leaf was found and its name assigned; otherwise false.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00426360)(ref this, desc, node);

    /// <summary>Copies the property’s stored string value into the supplied LONG* buffer and returns a status flag.
    /// <code>Offset: 0x00426390
    /// char __thiscall StringPropertyValue::InqString(LONG*,LONG*)</code>
    /// </summary>
    /// <param name="a2">Pointer to buffer where the string will be written.</param>
    /// <returns>A non‑zero char indicating success (1).</returns>
    public sbyte InqString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringPropertyValue, int*, sbyte>)0x00426390)(ref this, a2);

    /// <summary>Sets the internal string representation from the supplied source data.
    /// <code>Offset: 0x004263B0
    /// char __thiscall StringPropertyValue::SetString(LONG*,LONG*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the data used to initialize the property’s string value.</param>
    /// <returns>Always 1, indicating successful assignment.</returns>
    public sbyte SetString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringPropertyValue, int*, sbyte>)0x004263B0)(ref this, a2);

    /// <summary>Retrieves this property's string value and writes it into the supplied buffer.
    /// <code>Offset: 0x004263D0
    /// char __thiscall StringPropertyValue::GetValueAsString(LONG*,int,LONG*,int)</code>
    /// </summary>
    /// <param name="a2">Optional parameter, not used in this implementation.</param>
    /// <param name="a3">Pointer to a buffer where the string will be stored.</param>
    /// <param name="a4">Optional parameter, not used in this implementation.</param>
    /// <returns>Always returns true (1) indicating success.</returns>
    public sbyte GetValueAsString(int a2, int* a3, int a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringPropertyValue, int, int*, int, sbyte>)0x004263D0)(ref this, a2, a3, a4);

    /// <summary>Compares the string value of this property to that of another property, returning true if they match.
    /// <code>Offset: 0x004263F0
    /// bool __thiscall StringPropertyValue::Compare(StringPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The other property value to compare against.</param>
    /// <returns>True when both properties contain identical strings; otherwise false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x004263F0)(ref this, p);

    /// <summary>Adds a subnode to the specified file node using the stored string value as the subnode name.
    /// <code>Offset: 0x00426F50
    /// bool __thiscall StringPropertyValue::ToFileNode(StringPropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Metadata describing the property; not used in this implementation.</param>
    /// <param name="node">The parent file node that will receive the new subnode.</param>
    /// <returns>True if a subnode was successfully created; false when the supplied node is null or creation fails.</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x00426F50)(ref this, desc, node);

    /// <summary>Serializes the string value of a property to or from the given archive.
    /// <code>Offset: 0x00427F40
    /// void __thiscall StringPropertyValue::Serialize(StringPropertyValue*,Archive*,const unsigned int)</code>
    /// </summary>
    /// <param name="io_archive">Archive instance used for reading or writing the string data.</param>
    /// <param name="i_eName">Identifier for the property, typically an enumeration value.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringPropertyValue, ACBindings.Internal.Archive*, uint, void>)0x00427F40)(ref this, io_archive, i_eName);
}

