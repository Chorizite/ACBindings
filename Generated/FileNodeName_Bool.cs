namespace ACBindings.Internal;


/// <summary>Boolean file node name used by the IFileNodeName interface, storing a true/false identifier for file nodes.</summary>
public unsafe struct FileNodeName_Bool
{
    // Base Classes
    public ACBindings.Internal.IFileNodeName BaseClass_IFileNodeName; // ACBindings.Internal.IFileNodeName

    // Members
    public byte m_name;

    // Methods

    /// <summary>Creates a duplicate of the current Boolean file node, allocating a fresh instance and copying its name value.
    /// <code>Offset: 0x00423D80
    /// IFileNodeName* __thiscall FileNodeName_Bool::Clone(FileNodeName_Bool*)</code>
    /// </summary>
    /// <returns>A pointer to the new IFileNodeName representing the clone, or nullptr if memory allocation failed.</returns>
    public ACBindings.Internal.IFileNodeName* Clone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Bool, ACBindings.Internal.IFileNodeName*>)0x00423D80)(ref this);

    /// <summary>Serializes the boolean member m_name to or from the provided Archive via Serializer::SerializeObject.
    /// <code>Offset: 0x00424530
    /// void __thiscall FileNodeName_Bool::Serialize(FileNodeName_Bool*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive used for serialization of the FileNodeName_Bool instance.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Bool, ACBindings.Internal.Archive*, void>)0x00424530)(ref this, io_archive);

    /// <summary>Parses the supplied string and stores the result as a boolean name field. Accepts case‑insensitive "TRUE" or "ONE" to set true; any other value sets false.
    /// <code>Offset: 0x0065BC10
    /// int __thiscall FileNodeName_Bool::FromPString(_BYTE*,const char**)</code>
    /// </summary>
    /// <param name="a2">Pointer to a C-style string containing the value to parse.</param>
    /// <returns>Integer status code (always 1) indicating that the operation succeeded.</returns>
    public int FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Bool, sbyte**, int>)0x0065BC10)(ref this, a2);

    /// <summary>Converts the boolean file node name to a PString by providing its character buffer and incrementing the reference count.
    /// <code>Offset: 0x0065BC60
    /// volatile LONG** __thiscall FileNodeName_Bool::ToPString(_BYTE*,volatile LONG**)</code>
    /// </summary>
    /// <param name="a2">Receives a pointer to the string's character buffer.</param>
    /// <returns>The same pointer passed in, now pointing to the referenced buffer.</returns>
    public int** ToPString(int** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Bool, int**, int**>)0x0065BC60)(ref this, a2);
}

