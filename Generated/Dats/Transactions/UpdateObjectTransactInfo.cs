namespace ACBindings;

// UpdateObjectTransactInfo
public unsafe struct UpdateObjectTransactInfo
{
    // Base Classes
    public ACBindings.AddObjectTransactInfo BaseClass_AddObjectTransactInfo; // ACBindings.AddObjectTransactInfo

    // Members
    public int m_nEntryIndex;
    public int m_nOldOffset;

    // Methods
    // void __thiscall UpdateObjectTransactInfo::Serialize(UpdateObjectTransactInfo*,Archive*)
    public void Serialize(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.UpdateObjectTransactInfo, ACBindings.Archive*, void>)0x00677670)(ref this, io_rcArchive);
}

