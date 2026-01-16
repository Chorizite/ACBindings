namespace ACBindings.Internal;


/// <summary>Represents a file node name that is uniquely identified by a GUID, providing cloning, type identification, string conversion, and binary serialization capabilities.</summary>
public unsafe struct FileNodeName_Guid
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public ACBindings.Internal.Turbine_GUID m_name;

    // Methods

    /// <summary>Identifies this file node name as a GUID-based type.
    /// <code>Offset: 0x0065B2B0
    /// NodeNameType __thiscall FileNodeName_Guid::GetType(FileNodeName_Guid*)</code>
    /// </summary>
    /// <returns>The NodeNameType enum value corresponding to a GUID node (value 14).</returns>
    public ACBindings.Internal.NodeNameType GetType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Guid, ACBindings.Internal.NodeNameType>)0x0065B2B0)(ref this);

    /// <summary>Creates a new IFileNodeName instance that duplicates the GUID contained in this FileNodeName_Guid object.
    /// <code>Offset: 0x0065B2C0
    /// IFileNodeName* __thiscall FileNodeName_Guid::Clone(FileNodeName_Guid*)</code>
    /// </summary>
    /// <returns>The cloned node, or null if memory allocation fails.</returns>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Guid, ACBindings.Internal.IFileNodeName*>)0x0065B2C0)(ref this);

    /// <summary>Converts a string into a GUID and stores it in the object.
    /// <code>Offset: 0x0065B470
    /// bool __thiscall FileNodeName_Guid::FromPString(int,char*)</code>
    /// </summary>
    /// <param name="Buffer">Null‑terminated character buffer holding the GUID representation.</param>
    /// <returns>True if conversion succeeds; otherwise false.</returns>
    public byte FromPString(sbyte* Buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Guid, sbyte*, byte>)0x0065B470)(ref this, Buffer);

    /// <summary>Serializes the file node's GUID to or from an archive buffer, ensuring proper alignment and honoring the archive's read/write flag.
    /// <code>Offset: 0x0065B760
    /// void __thiscall FileNodeName_Guid::Serialize(FileNodeName_Guid*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive instance used for reading or writing the GUID data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Guid, ACBindings.Internal.Archive*, void>)0x0065B760)(ref this, io_archive);

    /// <summary>Converts the internal GUID of the file node name into its string representation and stores it in the provided buffer.
    /// <code>Offset: 0x0065BD70
    /// int* __thiscall FileNodeName_Guid::ToPString(unsigned __int16*,int*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an integer buffer where the resulting string will be written.</param>
    /// <returns>The same buffer pointer passed as a2, now containing the stringified GUID.</returns>
    public int* ToPString(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Guid, int*, int*>)0x0065BD70)(ref this, a2);
}

