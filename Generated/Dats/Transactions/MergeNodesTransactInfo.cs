namespace ACBindings.Internal;


/// <summary>Holds transaction details required when merging nodes within a disk‑based data structure, tracking node offsets, child positions, and entry counts.</summary>
public unsafe struct MergeNodesTransactInfo
{
    // Base Classes
    public ACBindings.Internal.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindings.Internal.DiskTransactInfo

    // Members
    public int m_nNodeOffset;
    public int m_nLeftOffset;
    public int m_nRightOffset;
    public int m_nIndex;
    public int m_nNodeEntries;

    // Generated Constructor
    public MergeNodesTransactInfo() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a MergeNodesTransactInfo instance with default values for node merge transactions, setting transaction type, magic number, and resetting all offsets, indices, and entry counts.
    /// <code>Offset: 0x00677240
    /// void __thiscall MergeNodesTransactInfo::MergeNodesTransactInfo(MergeNodesTransactInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MergeNodesTransactInfo, void>)0x00677240)(ref this);

    /// <summary>Serializes or deserializes MergeNodesTransactInfo fields to/from an Archive based on the archive's flags.
    /// <code>Offset: 0x00677570
    /// void __thiscall MergeNodesTransactInfo::Serialize(MergeNodesTransactInfo*,Archive*)</code>
    /// </summary>
    /// <param name="io_rcArchive">The Archive instance that holds serialized data. When its m_flags include bit 0, the method writes this object's fields into the archive; otherwise it reads values from the archive into the object.</param>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MergeNodesTransactInfo, ACBindings.Internal.Archive*, void>)0x00677570)(ref this, io_rcArchive);
}

