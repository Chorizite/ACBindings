namespace ACBindings;

// DeleteInternalTransactInfo
public unsafe struct DeleteInternalTransactInfo
{
    // Base Classes
    public ACBindings.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindings.DiskTransactInfo

    // Members
    public ACBindings.IDClass___tagDataID m_cTargetDID;
    public ACBindings.IDClass___tagDataID m_cDonorDID;
    public int m_nTargetOffset;
    public int m_nDonorOffset;
    public int m_nTargetIndex;
    public int m_nDonorIndex;

    // Generated Constructor
    public DeleteInternalTransactInfo() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall DeleteInternalTransactInfo::DeleteInternalTransactInfo(DeleteInternalTransactInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DeleteInternalTransactInfo, void>)0x00677400)(ref this);
    // void __thiscall DeleteInternalTransactInfo::Serialize(DeleteInternalTransactInfo*,Archive*)
    public void Serialize(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DeleteInternalTransactInfo, ACBindings.Archive*, void>)0x00677440)(ref this, io_rcArchive);
}

