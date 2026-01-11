namespace ACBindings.Internal;

public unsafe struct DeleteInternalTransactInfo
{
    // Base Classes
    public ACBindings.Internal.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindings.Internal.DiskTransactInfo

    // Members
    public ACBindings.Internal.IDClass____tagDataID m_cTargetDID;
    public ACBindings.Internal.IDClass____tagDataID m_cDonorDID;
    public int m_nTargetOffset;
    public int m_nDonorOffset;
    public int m_nTargetIndex;
    public int m_nDonorIndex;

    // Generated Constructor
    public DeleteInternalTransactInfo() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00677400
    /// void __thiscall DeleteInternalTransactInfo::DeleteInternalTransactInfo(DeleteInternalTransactInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DeleteInternalTransactInfo, void>)0x00677400)(ref this);

    /// <summary>
    /// <code>Offset: 0x00677440
    /// void __thiscall DeleteInternalTransactInfo::Serialize(DeleteInternalTransactInfo*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DeleteInternalTransactInfo, ACBindings.Internal.Archive*, void>)0x00677440)(ref this, io_rcArchive);
}

