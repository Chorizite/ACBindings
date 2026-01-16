namespace ACBindings.Internal;


/// <summary>Represents transactional information for a node split within a disk‑based index structure, containing parent context and allocation details used during persistence operations.</summary>
public unsafe struct SplitNodeTransactInfo
{
    // Base Classes
    public ACBindings.Internal.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindings.Internal.DiskTransactInfo

    // Members
    public int m_nParentOffset;
    public int m_nParentEntries;
    public int m_nSplitIndex;
    public int m_nFirstFreeBlock;

    // Generated Constructor
    public SplitNodeTransactInfo() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a SplitNodeTransactInfo instance for a split‑node transaction, setting the transaction type, magic number, and resetting all offset and counter fields to zero.
    /// <code>Offset: 0x00677270
    /// void __thiscall SplitNodeTransactInfo::SplitNodeTransactInfo(SplitNodeTransactInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SplitNodeTransactInfo, void>)0x00677270)(ref this);

    /// <summary>Serializes or deserializes the SplitNodeTransactInfo structure to or from an Archive, writing or reading its fields based on the archive's mode flags.
    /// <code>Offset: 0x006776E0
    /// void __thiscall SplitNodeTransactInfo::Serialize(SplitNodeTransactInfo*,Archive*)</code>
    /// </summary>
    /// <param name="io_rcArchive">The Archive used for serialization; when in write mode (flag set), fields are written, otherwise they are read into the structure.</param>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SplitNodeTransactInfo, ACBindings.Internal.Archive*, void>)0x006776E0)(ref this, io_rcArchive);
}

