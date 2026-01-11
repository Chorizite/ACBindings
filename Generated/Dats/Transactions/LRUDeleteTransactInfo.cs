namespace ACBindings.Internal;

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

    /// <summary>
    /// <code>Offset: 0x006772A0
    /// void __thiscall LRUDeleteTransactInfo::LRUDeleteTransactInfo(LRUDeleteTransactInfo*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRUDeleteTransactInfo, void>)0x006772A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00677950
    /// void __thiscall LRUDeleteTransactInfo::Serialize(LRUDeleteTransactInfo*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LRUDeleteTransactInfo, ACBindings.Internal.Archive*, void>)0x00677950)(ref this, io_rcArchive);
}

