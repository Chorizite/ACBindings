namespace ACBindings;

// MergeNodesTransactInfo
public unsafe struct MergeNodesTransactInfo
{
    // Base Classes
    public ACBindings.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindings.DiskTransactInfo

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
    // void __thiscall MergeNodesTransactInfo::MergeNodesTransactInfo(MergeNodesTransactInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.MergeNodesTransactInfo, void>)0x00677240)(ref this);
    // void __thiscall MergeNodesTransactInfo::Serialize(MergeNodesTransactInfo*,Archive*)
    public void Serialize(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.MergeNodesTransactInfo, ACBindings.Archive*, void>)0x00677570)(ref this, io_rcArchive);
}

