namespace ACBindings.Internal;


/// <summary>Encapsulates transaction information for updating an object, including base transaction data, entry index, and previous offset.</summary>
public unsafe struct UpdateObjectTransactInfo
{
    // Base Classes
    public ACBindings.Internal.AddObjectTransactInfo BaseClass_AddObjectTransactInfo; // ACBindings.Internal.AddObjectTransactInfo

    // Members
    public int m_nEntryIndex;
    public int m_nOldOffset;

    // Methods

    /// <summary>Serializes UpdateObjectTransactInfo to or from an Archive, writing or reading the entry index and old offset while delegating base class serialization.
    /// <code>Offset: 0x00677670
    /// void __thiscall UpdateObjectTransactInfo::Serialize(UpdateObjectTransactInfo*,Archive*)</code>
    /// </summary>
    /// <param name="this">The UpdateObjectTransactInfo instance being serialized.</param>
    /// <param name="io_rcArchive">Archive used for reading or writing transaction data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UpdateObjectTransactInfo, ACBindings.Internal.Archive*, void>)0x00677670)(ref this, io_rcArchive);
}

