namespace ACBindings.Internal;

public unsafe struct ArchiveVersionRow
{
    // Child Types
    public unsafe struct ArchiveVersionRow_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ArchiveVersionRow*, uint, uint> GetVersionByToken; // function pointer

        // Methods
    }
    public unsafe struct VersionEntry
    {
        // Members
        public uint tokVersion;
        public uint iVersion;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.PrimitiveInplaceArray___ArchiveVersionRow_VersionEntry m_aVersions;

    // Methods

    /// <summary>Stores a version mapping for a specified token in the archive row and verifies consistency when the token already exists.
    /// <code>Offset: 0x00410500
    /// bool __thiscall ArchiveVersionRow::SetVersion(ArchiveVersionRow*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_tokVersion">The token identifying the specific version entry.</param>
    /// <param name="i_iVersion">The version number to associate with the token.</param>
    /// <returns>True if the token was not previously present (new entry added) or if an existing entry’s iVersion matches the supplied value; otherwise false.</returns>
    public byte SetVersion(uint i_tokVersion, uint i_iVersion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArchiveVersionRow, uint, uint, byte>)0x00410500)(ref this, i_tokVersion, i_iVersion);

    /// <summary>Serializes or deserializes the row's version entries to or from the provided archive, handling the count and each entry according to the archive’s mode.
    /// <code>Offset: 0x00410590
    /// void __thiscall ArchiveVersionRow::SerializeRow(ArchiveVersionRow*,Archive*)</code>
    /// </summary>
    /// <param name="this">The ArchiveVersionRow instance containing the versions.</param>
    /// <param name="io_rcArchive">The archive used for reading or writing; its flags determine whether data is written or read.</param>
    public void SerializeRow(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArchiveVersionRow, ACBindings.Internal.Archive*, void>)0x00410590)(ref this, io_rcArchive);

    /// <summary>Serializes the header of an ArchiveVersionRow into or from a given archive, writing a magic identifier and handling row data offset based on archive flags.
    /// <code>Offset: 0x00410630
    /// unsigned int __thiscall ArchiveVersionRow::SerializeHeader(ArchiveVersionRow*,Archive*)</code>
    /// </summary>
    /// <param name="io_rcArchive">The archive buffer used for reading or writing.</param>
    /// <returns>On success returns the size used before header serialization; if the archive is in read‑only mode (flag 4 set), returns 0xFFFFFFFF to indicate failure.</returns>
    public uint SerializeHeader(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArchiveVersionRow, ACBindings.Internal.Archive*, uint>)0x00410630)(ref this, io_rcArchive);

    /// <summary>Serializes or validates the footer of an ArchiveVersionRow within an archive.
    /// <code>Offset: 0x004106F0
    /// bool __thiscall ArchiveVersionRow::SerializeFooter(ArchiveVersionRow*,unsigned int,Archive*)</code>
    /// </summary>
    /// <param name="this">The ArchiveVersionRow instance whose versions are being processed.</param>
    /// <param name="i_hSerialize">Offset in the archive where the footer data is written or read; a value of –1 indicates no specific offset.</param>
    /// <param name="io_rcArchive">Archive object used for input/output during the operation.</param>
    /// <returns>True if the footer was serialized or validated successfully without setting an error flag; otherwise, false.</returns>
    public byte SerializeFooter(uint i_hSerialize, ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ArchiveVersionRow, uint, ACBindings.Internal.Archive*, byte>)0x004106F0)(ref this, i_hSerialize, io_rcArchive);
}

