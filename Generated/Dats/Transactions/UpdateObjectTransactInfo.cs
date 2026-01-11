namespace ACBindings.Internal;

public unsafe struct UpdateObjectTransactInfo
{
    // Base Classes
    public ACBindings.Internal.AddObjectTransactInfo BaseClass_AddObjectTransactInfo; // ACBindings.Internal.AddObjectTransactInfo

    // Members
    public int m_nEntryIndex;
    public int m_nOldOffset;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00677670
    /// void __thiscall UpdateObjectTransactInfo::Serialize(UpdateObjectTransactInfo*,Archive*)</code>
    /// </summary>
    public void Serialize(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.UpdateObjectTransactInfo, ACBindings.Internal.Archive*, void>)0x00677670)(ref this, io_rcArchive);
}

