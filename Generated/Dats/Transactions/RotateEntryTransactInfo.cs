namespace ACBindings;

// RotateEntryTransactInfo
public unsafe struct RotateEntryTransactInfo
{
    // Base Classes
    public ACBindings.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindings.DiskTransactInfo

    // Members
    public int m_nParentOffset;
    public ACBindings.IDClass___tagDataID m_cEntryDID;
    public int m_nIndex;
    public int m_nNodeEntryCount;
    public int m_nSiblingEntryCount;
    public byte m_bLeftSibling;

    // Methods
    // void __thiscall RotateEntryTransactInfo::Serialize(RotateEntryTransactInfo*,Archive*)
    public void Serialize(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.RotateEntryTransactInfo, ACBindings.Archive*, void>)0x00677800)(ref this, io_rcArchive);
}

