namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x00677240
    /// void __thiscall MergeNodesTransactInfo::MergeNodesTransactInfo(MergeNodesTransactInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MergeNodesTransactInfo, void>)0x00677240)(ref this);

    /// <summary>
    /// <code>Offset: 0x00677570
    /// void __thiscall MergeNodesTransactInfo::Serialize(MergeNodesTransactInfo*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MergeNodesTransactInfo, ACBindings.Internal.Archive*, void>)0x00677570)(ref this, io_rcArchive);
}

