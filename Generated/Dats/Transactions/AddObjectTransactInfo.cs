namespace ACBindings.Internal;


/// <summary>Represents metadata for adding an object to a disk‑based B‑tree, including base transaction information, the specific tree entry, and bookkeeping indices for free blocks and node entries.</summary>
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

    /// <summary>Serializes or deserializes the transaction information of an AddObjectTransactInfo instance to or from an Archive.
    /// <code>Offset: 0x00677310
    /// void __thiscall AddObjectTransactInfo::Serialize(AddObjectTransactInfo*,Archive*)</code>
    /// </summary>
    /// <param name="io_rcArchive">The archive used for reading or writing the object's state, including its magic number, BTEntry data, first free block index, and node entry count.</param>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AddObjectTransactInfo, ACBindings.Internal.Archive*, void>)0x00677310)(ref this, io_rcArchive);

    /// <summary>Initializes an AddObjectTransactInfo object by configuring the transaction type to ADD_OBJ_TRANS, assigning a magic number, setting up the virtual table pointer, and clearing all entry fields and counters.
    /// <code>Offset: 0x00677A10
    /// void __thiscall AddObjectTransactInfo::AddObjectTransactInfo(AddObjectTransactInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AddObjectTransactInfo, void>)0x00677A10)(ref this);
}

