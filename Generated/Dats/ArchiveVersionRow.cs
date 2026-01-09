namespace ACBindings;

// ArchiveVersionRow
public unsafe struct ArchiveVersionRow
{
    // Child Types
    // ArchiveVersionRow_vtbl
    public unsafe struct ArchiveVersionRow_vtbl
    {
        // Members
        public System.IntPtr GetVersionByToken; // function pointer

        // Methods
    }
    // ArchiveVersionRow::VersionEntry
    public unsafe struct VersionEntry
    {
        // Members
        public uint tokVersion;
        public uint iVersion;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.PrimitiveInplaceArray__ArchiveVersionRow_VersionEntry m_aVersions;

    // Methods
    // bool __thiscall ArchiveVersionRow::SetVersion(ArchiveVersionRow*,unsigned int,unsigned int)
    public byte SetVersion(uint i_tokVersion, uint i_iVersion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArchiveVersionRow, uint, uint, byte>)0x00410500)(ref this, i_tokVersion, i_iVersion);
    // void __thiscall ArchiveVersionRow::SerializeRow(ArchiveVersionRow*,Archive*)
    public void SerializeRow(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArchiveVersionRow, ACBindings.Archive*, void>)0x00410590)(ref this, io_rcArchive);
    // unsigned int __thiscall ArchiveVersionRow::SerializeHeader(ArchiveVersionRow*,Archive*)
    public uint SerializeHeader(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArchiveVersionRow, ACBindings.Archive*, uint>)0x00410630)(ref this, io_rcArchive);
    // bool __thiscall ArchiveVersionRow::SerializeFooter(ArchiveVersionRow*,unsigned int,Archive*)
    public byte SerializeFooter(uint i_hSerialize, ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ArchiveVersionRow, uint, ACBindings.Archive*, byte>)0x004106F0)(ref this, i_hSerialize, io_rcArchive);
}

