namespace ACBindings.Internal;

public unsafe struct StructPropertyValue
{
    // Base Classes
    public ACBindings.Internal.BasePropertyValue BaseClass_BasePropertyValue; // ACBindings.Internal.BasePropertyValue

    // Members
    public ACBindings.Internal.AutoGrowHashTable__uint___BaseProperty m_value;

    // Generated Constructor
    public StructPropertyValue(int* a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>Retrieves a pointer to the internal hash table stored within the struct.
    /// <code>Offset: 0x00426990
    /// char* __thiscall StructPropertyValue::GetHash(char*)</code>
    /// </summary>
    /// <returns>A character pointer referencing the beginning of the auto‑growing hash table used by the object.</returns>
    public sbyte* GetHash() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StructPropertyValue, sbyte*>)0x00426990)(ref this);

    /// <summary>Retrieves a named element from the struct property’s internal hash table, returning true if found.
    /// <code>Offset: 0x00429030
    /// bool __thiscall StructPropertyValue::InqStructElement(StructPropertyValue*,unsigned int,BaseProperty*)</code>
    /// </summary>
    /// <param name="name">Identifier of the element to retrieve.</param>
    /// <param name="value">Receives pointer to the matching BaseProperty; remains unchanged if not found.</param>
    /// <returns>True when an element with the specified name exists, otherwise false.</returns>
    public byte InqStructElement(uint name, ACBindings.Internal.BaseProperty* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StructPropertyValue, uint, ACBindings.Internal.BaseProperty*, byte>)0x00429030)(ref this, name, value);

    /// <summary>Retrieves a struct element by its identifier from this property value.
    /// <code>Offset: 0x004290D0
    /// const BaseProperty* __thiscall StructPropertyValue::GetStructElement(StructPropertyValue*,const unsigned int)</code>
    /// </summary>
    /// <param name="name">The identifier of the desired element.</param>
    /// <returns>A pointer to the corresponding BaseProperty, or null if not found.</returns>
    public ACBindings.Internal.BaseProperty* GetStructElement(uint name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StructPropertyValue, uint, ACBindings.Internal.BaseProperty*>)0x004290D0)(ref this, name);

    /// <summary>Inserts or updates a BaseProperty in the struct's internal hash table using the specified key.
    /// <code>Offset: 0x00429100
    /// bool __thiscall StructPropertyValue::SetStructElement(StructPropertyValue*,unsigned int,const BaseProperty*)</code>
    /// </summary>
    /// <param name="name">The key identifying the property within the struct.</param>
    /// <param name="value">The BaseProperty to associate with the given key.</param>
    /// <returns>True if the operation succeeded; otherwise, false.</returns>
    public byte SetStructElement(uint name, ACBindings.Internal.BaseProperty* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StructPropertyValue, uint, ACBindings.Internal.BaseProperty*, byte>)0x00429100)(ref this, name, value);

    /// <summary>Deletes the struct element associated with the specified identifier from the property value.
    /// <code>Offset: 0x004291C0
    /// bool __thiscall StructPropertyValue::RemoveStructElement(StructPropertyValue*,unsigned int)</code>
    /// </summary>
    /// <param name="name">The unsigned integer key identifying the element to remove.</param>
    /// <returns>True if an element was found and removed; otherwise, false.</returns>
    public byte RemoveStructElement(uint name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StructPropertyValue, uint, byte>)0x004291C0)(ref this, name);

    /// <summary>Copies the property values from the supplied BasePropertyValue into this StructPropertyValue's internal hash table, returning true on success.
    /// <code>Offset: 0x00429260
    /// bool __thiscall StructPropertyValue::SetValue(StructPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="value">The source of the new property values to be copied.</param>
    /// <returns>True if the value was successfully set; otherwise false.</returns>
    public byte SetValue(ACBindings.Internal.BasePropertyValue* value) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StructPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x00429260)(ref this, value);

    /// <summary>Initializes a new StructPropertyValue by setting up its base class and copying the hash table data from the supplied source.
    /// <code>Offset: 0x004296E0
    /// void*** __thiscall StructPropertyValue::StructPropertyValue(void***,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a structure containing initial values for the internal AutoGrowHashTable.</param>
    public void*** _ConstructorInternal(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StructPropertyValue, int*, void***>)0x004296E0)(ref this, a2);

    /// <summary>Serializes or deserializes the internal property hash table with the supplied archive, clearing existing entries when reading from an input stream.
    /// <code>Offset: 0x00429730
    /// void __thiscall StructPropertyValue::Serialize(StructPropertyValue*,Archive*,const unsigned int)</code>
    /// </summary>
    /// <param name="io_archive">Archive object that holds data and flags indicating read/write mode.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive, uint i_eName) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StructPropertyValue, ACBindings.Internal.Archive*, uint, void>)0x00429730)(ref this, io_archive, i_eName);

    /// <summary>Serializes every property stored in this struct into the supplied file node.
    /// <code>Offset: 0x0042C0A0
    /// bool __thiscall StructPropertyValue::ToFileNode(StructPropertyValue*,const BasePropertyDesc*,PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Metadata describing the property set; unused by this routine.</param>
    /// <param name="node">The target file node to receive serialized property data; must be non‑null for success.</param>
    /// <returns>True if all properties were written successfully and a valid node was provided; otherwise false.</returns>
    public byte ToFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StructPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x0042C0A0)(ref this, desc, node);

    /// <summary>Outputs the number of items contained in the struct to the supplied string buffer, optionally as an integer or descriptive text.
    /// <code>Offset: 0x0042C120
    /// char __thiscall StructPropertyValue::GetValueAsString(_DWORD*,int,char**,char)</code>
    /// </summary>
    /// <param name="a3">Pointer to a character pointer that will receive the formatted string.</param>
    /// <param name="a4">Non‑zero selects numeric format; zero selects descriptive format.</param>
    /// <returns>Always 1 to indicate success.</returns>
    public sbyte GetValueAsString(int a2, sbyte** a3, sbyte a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StructPropertyValue, int, sbyte**, sbyte, sbyte>)0x0042C120)(ref this, a2, a3, a4);

    /// <summary>Compares this StructPropertyValue with another BasePropertyValue for equality of all stored properties.
    /// <code>Offset: 0x0042C160
    /// bool __thiscall StructPropertyValue::Compare(StructPropertyValue*,const BasePropertyValue*)</code>
    /// </summary>
    /// <param name="p">The other property value to compare against.</param>
    /// <returns>True if the two values contain identical property sets and values; otherwise, false.</returns>
    public byte Compare(ACBindings.Internal.BasePropertyValue* p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StructPropertyValue, ACBindings.Internal.BasePropertyValue*, byte>)0x0042C160)(ref this, p);

    /// <summary>Populates the struct's property table from a file node, validating each sub-property against the descriptor and ensuring no duplicates or unavailable properties are added.
    /// <code>Offset: 0x0042C320
    /// bool __thiscall StructPropertyValue::FromFileNode(StructPropertyValue*,BasePropertyDesc*,const PFileNode*)</code>
    /// </summary>
    /// <param name="desc">Descriptor containing metadata about available properties for the struct.</param>
    /// <param name="node">File node that contains sub‑nodes representing individual property values to load.</param>
    /// <returns>True if all properties were successfully parsed and stored; otherwise, false.</returns>
    public byte FromFileNode(ACBindings.Internal.BasePropertyDesc* desc, ACBindings.Internal.PFileNode* node) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StructPropertyValue, ACBindings.Internal.BasePropertyDesc*, ACBindings.Internal.PFileNode*, byte>)0x0042C320)(ref this, desc, node);
}

