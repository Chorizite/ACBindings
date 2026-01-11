namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x00677270
    /// void __thiscall SplitNodeTransactInfo::SplitNodeTransactInfo(SplitNodeTransactInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SplitNodeTransactInfo, void>)0x00677270)(ref this);

    /// <summary>
    /// <code>Offset: 0x006776E0
    /// void __thiscall SplitNodeTransactInfo::Serialize(SplitNodeTransactInfo*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SplitNodeTransactInfo, ACBindings.Internal.Archive*, void>)0x006776E0)(ref this, io_rcArchive);
}

