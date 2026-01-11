namespace ACBindings.Internal;

public unsafe struct AddObjectTransactInfo
{
    // Base Classes
    public ACBindings.Internal.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindings.Internal.DiskTransactInfo

    // Members
    public ACBindings.Internal.BTEntry m_entry;
    public int m_nFirstFreeBlock;
    public int m_nNodeEntries;

    // Generated Constructor
    public AddObjectTransactInfo() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00677310
    /// void __thiscall AddObjectTransactInfo::Serialize(AddObjectTransactInfo*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AddObjectTransactInfo, ACBindings.Internal.Archive*, void>)0x00677310)(ref this, io_rcArchive);

    /// <summary>
    /// <code>Offset: 0x00677A10
    /// void __thiscall AddObjectTransactInfo::AddObjectTransactInfo(AddObjectTransactInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AddObjectTransactInfo, void>)0x00677A10)(ref this);
}

