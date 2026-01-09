namespace ACBindings;

// SplitNodeTransactInfo
public unsafe struct SplitNodeTransactInfo
{
    // Base Classes
    public ACBindings.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindings.DiskTransactInfo

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
    // void __thiscall SplitNodeTransactInfo::SplitNodeTransactInfo(SplitNodeTransactInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.SplitNodeTransactInfo, void>)0x00677270)(ref this);
    // void __thiscall SplitNodeTransactInfo::Serialize(SplitNodeTransactInfo*,Archive*)
    public void Serialize(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.SplitNodeTransactInfo, ACBindings.Archive*, void>)0x006776E0)(ref this, io_rcArchive);
}

