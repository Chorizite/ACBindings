namespace ACBindings;

// DeleteLeafTransactInfo
public unsafe struct DeleteLeafTransactInfo
{
    // Base Classes
    public ACBindings.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindings.DiskTransactInfo

    // Members
    public ACBindings.IDClass___tagDataID m_cObjectDID;
    public int m_nNodeOffset;
    public int m_nIndex;

    // Generated Constructor
    public DeleteLeafTransactInfo() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall DeleteLeafTransactInfo::DynamicCast_DeleteLeaf(DiskSpace*)
    public void DynamicCast_DeleteLeaf() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DeleteLeafTransactInfo, void>)0x0050A140)(ref this);
    // void __thiscall DeleteLeafTransactInfo::DeleteLeafTransactInfo(DeleteLeafTransactInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DeleteLeafTransactInfo, void>)0x006773D0)(ref this);
}

