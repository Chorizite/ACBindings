namespace ACBindings.Internal;

public unsafe struct RotateEntryTransactInfo
{
    // Base Classes
    public ACBindings.Internal.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindings.Internal.DiskTransactInfo

    // Members
    public int m_nParentOffset;
    public ACBindings.Internal.IDClass____tagDataID m_cEntryDID;
    public int m_nIndex;
    public int m_nNodeEntryCount;
    public int m_nSiblingEntryCount;
    public byte m_bLeftSibling;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00677800
    /// void __thiscall RotateEntryTransactInfo::Serialize(RotateEntryTransactInfo*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.RotateEntryTransactInfo, ACBindings.Internal.Archive*, void>)0x00677800)(ref this, io_rcArchive);
}

