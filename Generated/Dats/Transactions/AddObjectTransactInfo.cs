namespace ACBindings;

// AddObjectTransactInfo
public unsafe struct AddObjectTransactInfo
{
    // Base Classes
    public ACBindings.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindings.DiskTransactInfo

    // Members
    public ACBindings.BTEntry m_entry;
    public int m_nFirstFreeBlock;
    public int m_nNodeEntries;

    // Generated Constructor
    public AddObjectTransactInfo() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall AddObjectTransactInfo::Serialize(AddObjectTransactInfo*,Archive*)
    public void Serialize(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AddObjectTransactInfo, ACBindings.Archive*, void>)0x00677310)(ref this, io_rcArchive);
    // void __thiscall AddObjectTransactInfo::AddObjectTransactInfo(AddObjectTransactInfo*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AddObjectTransactInfo, void>)0x00677A10)(ref this);
}

