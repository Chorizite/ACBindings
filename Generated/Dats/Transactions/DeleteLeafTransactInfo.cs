namespace ACBindings.Internal;

public unsafe struct DeleteLeafTransactInfo
{
    // Base Classes
    public ACBindings.Internal.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindings.Internal.DiskTransactInfo

    // Members
    public ACBindings.Internal.IDClass____tagDataID m_cObjectDID;
    public int m_nNodeOffset;
    public int m_nIndex;

    // Generated Constructor
    public DeleteLeafTransactInfo() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0050A140
    /// void __thiscall DeleteLeafTransactInfo::DynamicCast_DeleteLeaf(DiskSpace*)</code>
    /// </summary>
    public void DynamicCast_DeleteLeaf() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DeleteLeafTransactInfo, void>)0x0050A140)(ref this);

    /// <summary>
    /// <code>Offset: 0x006773D0
    /// void __thiscall DeleteLeafTransactInfo::DeleteLeafTransactInfo(DeleteLeafTransactInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DeleteLeafTransactInfo, void>)0x006773D0)(ref this);
}

