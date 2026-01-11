namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x0065BC10
    /// int __thiscall FileNodeName_Bool::FromPString(_BYTE*,const char**)</code>
    /// </summary>
    public int FromPString(sbyte** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Bool, sbyte**, int>)0x0065BC10)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0065BC60
    /// volatile LONG** __thiscall FileNodeName_Bool::ToPString(_BYTE*,volatile LONG**)</code>
    /// </summary>
    public int** ToPString(int** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.FileNodeName_Bool, int**, int**>)0x0065BC60)(ref this, a2);
}

