namespace ACBindings.Internal;


/// <summary>Encapsulates a 64‑bit name value for a file node, providing cloning, parsing from string, conversion to string, and serialization capabilities.</summary>
public unsafe struct FileNodeName_Int64
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public long m_name;

    // Methods

    /// <summary>Retrieves the node type identifier for a FileNodeName_Int64 instance.
    /// <code>Offset: 0x0065B1F0
    /// NodeNameType __thiscall FileNodeName_Int64::GetType(FileNodeName_Int64*)</code>
    /// </summary>
    /// <returns>The NodeNameType enumeration value that identifies this file node name.</returns>
    public ACBindings.Internal.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Int64, ACBindings.Internal.NodeNameType>)0x0065B1F0)(ref this);

    /// <summary>Creates a duplicate of this FileNodeName_Int64 object, allocating a new IFileNodeName instance initialized with the same 64‑bit name value.
    /// <code>Offset: 0x0065B200
    /// IFileNodeName* __thiscall FileNodeName_Int64::Clone(FileNodeName_Int64*)</code>
    /// </summary>
    /// <returns>A pointer to the newly created IFileNodeName instance; null if memory allocation fails.</returns>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Int64, ACBindings.Internal.IFileNodeName*>)0x0065B200)(ref this);

    /// <summary>Serializes the InstanceID value held by this FileNodeName_Int64 into the given archive.
    /// <code>Offset: 0x0065B700
    /// void __thiscall FileNodeName_Int64::Serialize(FileNodeName_InstanceID*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The archive where the InstanceID will be written.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Int64, ACBindings.Internal.Archive*, void>)0x0065B700)(ref this, io_archive);

    /// <summary>Parses the referenced string as a 64‑bit integer and stores it into the object's name field if valid; otherwise fails.
    /// <code>Offset: 0x0065BA90
    /// char __thiscall FileNodeName_Int64::FromPString(_QWORD*,char**)</code>
    /// </summary>
    /// <param name="a2">Pointer to a reference‑counted C string containing the value to parse.</param>
    /// <returns>Nonzero on success, zero if the string is not a valid 64‑bit integer or parsing fails.</returns>
    public sbyte FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Int64, sbyte**, sbyte>)0x0065BA90)(ref this, a2);

    /// <summary>Converts the 64‑bit name stored in the object into its decimal string form and writes a pointer to the resulting buffer into the supplied parameter.
    /// <code>Offset: 0x0065C050
    /// int* __thiscall FileNodeName_Int64::ToPString(_QWORD*,int*)</code>
    /// </summary>
    /// <param name="a2">Receives the address of an integer that will be set to point at the formatted string.</param>
    /// <returns>The same pointer passed in, now pointing to the buffer holding the number as text.</returns>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Int64, int*, int*>)0x0065C050)(ref this, a2);
}

