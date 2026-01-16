namespace ACBindings.Internal;


/// <summary>Contains transaction deletion metadata for LRU cache management, storing base disk transaction data along with block offsets that track the position of old and young blocks relative to the target block.</summary>
public unsafe struct LRUDeleteTransactInfo
{
    // Base Classes
    public ACBindings.Internal.DiskTransactInfo BaseClass_DiskTransactInfo; // ACBindings.Internal.DiskTransactInfo

    // Members
    public int m_nBlockOffset;
    public int m_nOldOffset;
    public int m_nYoungOffset;

    // Generated Constructor
    public LRUDeleteTransactInfo() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Creates an LRU delete transaction record, initializing the base DiskTransactInfo with type LRU_DELETE_TRANS, setting its magic number to 19536, and zeroing block and offset counters.
    /// <code>Offset: 0x006772A0
    /// void __thiscall LRUDeleteTransactInfo::LRUDeleteTransactInfo(LRUDeleteTransactInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRUDeleteTransactInfo, void>)0x006772A0)(ref this);

    /// <summary>Serializes or deserializes the delete transaction information to or from an archive, writing or reading the magic number and block offsets depending on the archive's mode.
    /// <code>Offset: 0x00677950
    /// void __thiscall LRUDeleteTransactInfo::Serialize(LRUDeleteTransactInfo*,Archive*)</code>
    /// </summary>
    /// <param name="io_rcArchive">The archive used for input or output of the transaction data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRUDeleteTransactInfo, ACBindings.Internal.Archive*, void>)0x00677950)(ref this, io_rcArchive);
}

