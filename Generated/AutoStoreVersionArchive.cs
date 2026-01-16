namespace ACBindings.Internal;


/// <summary>Encapsulates an archival record for auto‑store operations, including serialization metadata and state tracking of serialization completion.</summary>
public unsafe struct AutoStoreVersionArchive : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.Archive BaseClass_Archive; // ACBindings.Internal.Archive

    // Child Types
    public unsafe struct AutoStoreVersionArchive_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoStoreVersionArchive*, ACBindings.Internal.ArchiveInitializer*, ACBindings.Internal.SmartBuffer*, void> InitForPacking; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoStoreVersionArchive*, ACBindings.Internal.ArchiveInitializer*, ACBindings.Internal.SmartBuffer*, void> InitForUnpacking; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoStoreVersionArchive*, byte, void> SetCheckpointing; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoStoreVersionArchive*, void> InitVersionStack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoStoreVersionArchive*, void> CreateVersionStack; // function pointer
        public fixed byte gap14[8];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoStoreVersionArchive*, ACBindings.Internal.SmartBuffer*, void> InitForPacking_1c; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoStoreVersionArchive*, ACBindings.Internal.SmartBuffer*, void> InitForUnpacking_20; // function pointer

        // Methods
    }

    /// <summary>Links a serialization handle to its version row within the archive, storing initialization metadata and the initial data row for persistence.</summary>
    public unsafe struct tagSerializeVersionRow
    {
        // Base Classes
        public ACBindings.Internal.ArchiveInitializer BaseClass_ArchiveInitializer; // ACBindings.Internal.ArchiveInitializer

        // Child Types
        public unsafe struct tagSerializeVersionRow_vtbl
        {
            // Members
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoStoreVersionArchive.tagSerializeVersionRow*, ACBindings.Internal.Archive*, byte> InitializeArchive; // function pointer

            // Methods
        }

        // Members
        public uint m_hSerialize;
        public ACBindings.Internal.IDClass____tagVersionHandle m_hVersionRow;
        public ACBindings.Internal.ArchiveVersionRow m_rowInitialData;

        // Methods

        /// <summary>Initializes a version row in the supplied archive by pushing a new row, recording its handle, and serializing the header when valid.
        /// <code>Offset: 0x0065E7D0
        /// bool __thiscall AutoStoreVersionArchive::tagSerializeVersionRow::InitializeArchive(AutoStoreVersionArchive::tagSerializeVersionRow*,Archive*)</code>
        /// </summary>
        /// <param name="io_rcArchive">The archive into which the version row is added and serialized.</param>
        /// <returns>True if the archive permits serialization and the header was successfully written; otherwise false.</returns>
        public byte InitializeArchive(ACBindings.Internal.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive.tagSerializeVersionRow, ACBindings.Internal.Archive*, byte>)0x0065E7D0)(ref this, io_rcArchive);
    }

    // Members
    public ACBindings.Internal.AutoStoreVersionArchive.tagSerializeVersionRow m_SerializeVersionRow;
    public byte m_bOnSerializingDoneCalled;

    // Generated Constructor
    public AutoStoreVersionArchive(ACBindings.Internal.Archive.tagUnpacking formal, ACBindings.Internal.SmartBuffer* buff) {
        _ConstructorInternal(formal, buff);
    }
    public AutoStoreVersionArchive() {
        _ConstructorInternal();
    }
    public AutoStoreVersionArchive(ACBindings.Internal.Archive.tagUnpacking formal, System.IntPtr addr, uint size) {
        _ConstructorInternal(formal, addr, size);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys an AutoStoreVersionArchive instance, freeing any allocated version data and invoking the base Archive destructor.
    /// <code>Offset: 0x004466A0
    /// void __thiscall AutoStoreVersionArchive::~AutoStoreVersionArchive(AutoStoreVersionArchive*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, void>)0x004466A0)(ref this);

    /// <summary>Prepares the archive for packing by initializing the base class and resetting the serialization completion flag.
    /// <code>Offset: 0x004466D0
    /// void __thiscall AutoStoreVersionArchive::InitForPacking(AutoStoreVersionArchive*,const ArchiveInitializer*,const SmartBuffer*)</code>
    /// </summary>
    /// <param name="i_rInitializer">Initialization data used by the archive during setup.</param>
    /// <param name="i_buffer">Buffer that holds the data to be packed into the archive.</param>
    public void InitForPacking(ACBindings.Internal.ArchiveInitializer* i_rInitializer, ACBindings.Internal.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, ACBindings.Internal.ArchiveInitializer*, ACBindings.Internal.SmartBuffer*, void>)0x004466D0)(ref this, i_rInitializer, i_buffer);

    /// <summary>Initializes the archive for unpacking by resetting the serialization completion flag and delegating to the base Archive implementation.
    /// <code>Offset: 0x004466E0
    /// void __thiscall AutoStoreVersionArchive::InitForUnpacking(AutoStoreVersionArchive*,const ArchiveInitializer*,const SmartBuffer*)</code>
    /// </summary>
    /// <param name="i_rInitializer">Provides initialization data for the archive.</param>
    /// <param name="i_buffer">Specifies the buffer containing serialized data to be read.</param>
    public void InitForUnpacking(ACBindings.Internal.ArchiveInitializer* i_rInitializer, ACBindings.Internal.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, ACBindings.Internal.ArchiveInitializer*, ACBindings.Internal.SmartBuffer*, void>)0x004466E0)(ref this, i_rInitializer, i_buffer);

    /// <summary>Initializes the archive for packing by configuring versioning information and delegating to the base Archive initialization.
    /// <code>Offset: 0x004466F0
    /// void __thiscall AutoStoreVersionArchive::InitForPacking(AutoStoreVersionArchive*,const SmartBuffer*)</code>
    /// </summary>
    /// <param name="i_buffer">The SmartBuffer containing data to be packed into the archive.</param>
    public void InitForPacking(ACBindings.Internal.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, ACBindings.Internal.SmartBuffer*, void>)0x004466F0)(ref this, i_buffer);

    /// <summary>Prepares the archive for reading by initializing its internal state with data from the supplied buffer.
    /// <code>Offset: 0x00446770
    /// void __thiscall AutoStoreVersionArchive::InitForUnpacking(AutoStoreVersionArchive*,const SmartBuffer*)</code>
    /// </summary>
    /// <param name="i_buffer">The source buffer containing serialized archive data.</param>
    public void InitForUnpacking(ACBindings.Internal.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, ACBindings.Internal.SmartBuffer*, void>)0x00446770)(ref this, i_buffer);

    /// <summary>Prepares the archive for data packing by configuring its version information and initializing its base archive state with a supplied buffer.
    /// <code>Offset: 0x004467E0
    /// void __thiscall AutoStoreVersionArchive::InitForPacking(AutoStoreVersionArchive*,unsigned int,const SmartBuffer*)</code>
    /// </summary>
    /// <param name="i_iCoreVersion">The core version identifier used during serialization.</param>
    /// <param name="i_buffer">Buffer containing initial data to be packed into the archive.</param>
    public void InitForPacking(uint i_iCoreVersion, ACBindings.Internal.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, uint, ACBindings.Internal.SmartBuffer*, void>)0x004467E0)(ref this, i_iCoreVersion, i_buffer);

    /// <summary>Prepares the archive for packing by copying initial version data and initializing the base Archive with the provided buffer.
    /// <code>Offset: 0x00446860
    /// void __thiscall AutoStoreVersionArchive::InitForPacking(AutoStoreVersionArchive*,const ArchiveVersionRow*,const SmartBuffer*)</code>
    /// </summary>
    /// <param name="i_rowInitialData">Reference to a row containing initial version entries to serialize.</param>
    /// <param name="i_buffer">Buffer that will hold packed data during serialization.</param>
    public void InitForPacking(ACBindings.Internal.ArchiveVersionRow* i_rowInitialData, ACBindings.Internal.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, ACBindings.Internal.ArchiveVersionRow*, ACBindings.Internal.SmartBuffer*, void>)0x00446860)(ref this, i_rowInitialData, i_buffer);

    /// <summary>Initializes an AutoStoreVersionArchive in unpacking mode and prepares internal archive structures from the provided SmartBuffer.
    /// <code>Offset: 0x004468E0
    /// void __thiscall AutoStoreVersionArchive::AutoStoreVersionArchive(AutoStoreVersionArchive*,Archive::tagUnpacking,const SmartBuffer*)</code>
    /// </summary>
    /// <param name="formal">Specifies the unpacking operation tag for the Archive base class.</param>
    /// <param name="buff">Pointer to the SmartBuffer containing data to be unpacked into the archive.</param>
    public void _ConstructorInternal(ACBindings.Internal.Archive.tagUnpacking formal, ACBindings.Internal.SmartBuffer* buff) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, ACBindings.Internal.Archive.tagUnpacking, ACBindings.Internal.SmartBuffer*, void>)0x004468E0)(ref this, formal, buff);

    /// <summary>Initializes an AutoStoreVersionArchive instance by setting up the base Archive fields and preparing internal serialization structures for version rows.
    /// <code>Offset: 0x0044CE60
    /// void __thiscall AutoStoreVersionArchive::AutoStoreVersionArchive(AutoStoreVersionArchive*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, void>)0x0044CE60)(ref this);

    /// <summary>Initializes an AutoStoreVersionArchive for unpacking serialized data from the supplied memory buffer.
    /// <code>Offset: 0x005D62C0
    /// void __thiscall AutoStoreVersionArchive::AutoStoreVersionArchive(AutoStoreVersionArchive*,Archive::tagUnpacking,void*,unsigned int)</code>
    /// </summary>
    /// <param name="formal">Marker indicating unpacking operation; required by the constructor signature but not used directly.</param>
    /// <param name="addr">Pointer to the raw data buffer containing the serialized archive.</param>
    /// <param name="size">Size of the data buffer in bytes.</param>
    public void _ConstructorInternal(ACBindings.Internal.Archive.tagUnpacking formal, System.IntPtr addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, ACBindings.Internal.Archive.tagUnpacking, System.IntPtr, uint, void>)0x005D62C0)(ref this, formal, addr, size);

    /// <summary>Finalizes serialization of the archive by marking it complete and, when enabled by internal flags, writes a footer for the associated serialized version row.
    /// <code>Offset: 0x0065E850
    /// void __thiscall AutoStoreVersionArchive::OnSerializingDone(AutoStoreVersionArchive*)</code>
    /// </summary>
    public void OnSerializingDone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, void>)0x0065E850)(ref this);
}

