namespace ACBindings.Internal;


/// <summary>Represents a collection mapping unique identifiers to their corresponding AvailableProperty objects, facilitating efficient lookup and management of available properties within the system.</summary>
public unsafe struct AvailablePropertySet
{
    // Members
    public ACBindings.Internal.HashTable__uint___AvailableProperty m_reqHash;

    // Methods

    /// <summary>Generates an iterator representing the end position of this AvailablePropertySet and writes it into a supplied buffer.
    /// <code>Offset: 0x0042BCF0
    /// _DWORD* __thiscall AvailablePropertySet::end(char*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an array where the iterator data will be stored. The array must have space for at least three DWORDs.</param>
    /// <returns>Pointer to the same buffer that was passed in, now containing the end iterator.</returns>
    public int* end(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AvailablePropertySet, int*, int*>)0x0042BCF0)(ref this, a2);

    /// <summary>Determines whether the property set contains an entry with the specified key.
    /// <code>Offset: 0x0042BD10
    /// bool __thiscall AvailablePropertySet::contains(AvailablePropertySet*,unsigned int)</code>
    /// </summary>
    /// <param name="name">The unique identifier of the property to search for.</param>
    /// <returns>True if the property is present; otherwise, false.</returns>
    public byte contains(uint name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AvailablePropertySet, uint, byte>)0x0042BD10)(ref this, name);

    /// <summary>Adds a property identified by the specified name to the set.
    /// <code>Offset: 0x0042BE30
    /// bool __thiscall AvailablePropertySet::AddProperty(AvailablePropertySet*,unsigned int)</code>
    /// </summary>
    /// <param name="name">The unique identifier of the property to add.</param>
    /// <returns>True if the property was added or updated successfully; otherwise, false.</returns>
    public byte AddProperty(uint name) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AvailablePropertySet, uint, byte>)0x0042BE30)(ref this, name);

    /// <summary>Serializes the set of available properties into the given archive, clearing existing entries when deserializing based on archive flags.
    /// <code>Offset: 0x0042C070
    /// void __thiscall AvailablePropertySet::Serialize(AvailablePropertySet*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for serialization or deserialization.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AvailablePropertySet, ACBindings.Internal.Archive*, void>)0x0042C070)(ref this, io_archive);
}

