namespace ACBindings;

// LRUDeleteTransactInfo
public unsafe struct LRUDeleteTransactInfo
{
    // Base Classes
    public ACBindings.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindings.DiskTransactInfo

    // Members
    public int m_nBlockOffset;
    public int m_nOldOffset;
    public int m_nYoungOffset;

    // Generated Constructor
    public LRUDeleteTransactInfo() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall LRUDeleteTransactInfo::LRUDeleteTransactInfo(LRUDeleteTransactInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LRUDeleteTransactInfo, void>)0x006772A0)(ref this);
    // void __thiscall LRUDeleteTransactInfo::Serialize(LRUDeleteTransactInfo*,Archive*)
    public void Serialize(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LRUDeleteTransactInfo, ACBindings.Archive*, void>)0x00677950)(ref this, io_rcArchive);
}

