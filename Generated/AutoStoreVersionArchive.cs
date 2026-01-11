namespace ACBindings.Internal;

public unsafe struct AutoStoreVersionArchive : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.Archive BaseClass_Archive; // ACBindings.Internal.Archive

    // Child Types
    public unsafe struct AutoStoreVersionArchive_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoStoreVersionArchive*, ACBindings.Internal.ArchiveInitializer*, ACBindings.Internal.SmartBuffer*, void> InitForPacking; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoStoreVersionArchive*, ACBindings.Internal.ArchiveInitializer*, ACBindings.Internal.SmartBuffer*, void> InitForUnpacking; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoStoreVersionArchive*, byte, void> SetCheckpointing; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoStoreVersionArchive*, void> InitVersionStack; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoStoreVersionArchive*, void> CreateVersionStack; // function pointer
        public fixed byte gap14[8];
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoStoreVersionArchive*, ACBindings.Internal.SmartBuffer*, void> InitForPacking_1c; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoStoreVersionArchive*, ACBindings.Internal.SmartBuffer*, void> InitForUnpacking_20; // function pointer

        // Methods
    }
    public unsafe struct tagSerializeVersionRow
    {
        // Base Classes
        public ACBindings.Internal.ArchiveInitializer BaseClass_ArchiveInitializer; // ACBindings.Internal.ArchiveInitializer

        // Child Types
        public unsafe struct tagSerializeVersionRow_vtbl
        {
            // Members
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.AutoStoreVersionArchive.tagSerializeVersionRow*, ACBindings.Internal.Archive*, byte> InitializeArchive; // function pointer

            // Methods
        }

        // Members
        public uint m_hSerialize;
        public ACBindings.Internal.IDClass____tagVersionHandle m_hVersionRow;
        public ACBindings.Internal.ArchiveVersionRow m_rowInitialData;

        // Methods

        /// <summary>
        /// <code>Offset: 0x0065E7D0
        /// bool __thiscall AutoStoreVersionArchive::tagSerializeVersionRow::InitializeArchive(AutoStoreVersionArchive::tagSerializeVersionRow*,Archive*)</code>
        /// </summary>
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

    /// <summary>
    /// <code>Offset: 0x004466A0
    /// void __thiscall AutoStoreVersionArchive::~AutoStoreVersionArchive(AutoStoreVersionArchive*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, void>)0x004466A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004466D0
    /// void __thiscall AutoStoreVersionArchive::InitForPacking(AutoStoreVersionArchive*,const ArchiveInitializer*,const SmartBuffer*)</code>
    /// </summary>
    public void InitForPacking(ACBindings.Internal.ArchiveInitializer* i_rInitializer, ACBindings.Internal.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, ACBindings.Internal.ArchiveInitializer*, ACBindings.Internal.SmartBuffer*, void>)0x004466D0)(ref this, i_rInitializer, i_buffer);

    /// <summary>
    /// <code>Offset: 0x004466E0
    /// void __thiscall AutoStoreVersionArchive::InitForUnpacking(AutoStoreVersionArchive*,const ArchiveInitializer*,const SmartBuffer*)</code>
    /// </summary>
    public void InitForUnpacking(ACBindings.Internal.ArchiveInitializer* i_rInitializer, ACBindings.Internal.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, ACBindings.Internal.ArchiveInitializer*, ACBindings.Internal.SmartBuffer*, void>)0x004466E0)(ref this, i_rInitializer, i_buffer);

    /// <summary>
    /// <code>Offset: 0x004466F0
    /// void __thiscall AutoStoreVersionArchive::InitForPacking(AutoStoreVersionArchive*,const SmartBuffer*)</code>
    /// </summary>
    public void InitForPacking(ACBindings.Internal.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, ACBindings.Internal.SmartBuffer*, void>)0x004466F0)(ref this, i_buffer);

    /// <summary>
    /// <code>Offset: 0x00446770
    /// void __thiscall AutoStoreVersionArchive::InitForUnpacking(AutoStoreVersionArchive*,const SmartBuffer*)</code>
    /// </summary>
    public void InitForUnpacking(ACBindings.Internal.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, ACBindings.Internal.SmartBuffer*, void>)0x00446770)(ref this, i_buffer);

    /// <summary>
    /// <code>Offset: 0x004467E0
    /// void __thiscall AutoStoreVersionArchive::InitForPacking(AutoStoreVersionArchive*,unsigned int,const SmartBuffer*)</code>
    /// </summary>
    public void InitForPacking(uint i_iCoreVersion, ACBindings.Internal.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, uint, ACBindings.Internal.SmartBuffer*, void>)0x004467E0)(ref this, i_iCoreVersion, i_buffer);

    /// <summary>
    /// <code>Offset: 0x00446860
    /// void __thiscall AutoStoreVersionArchive::InitForPacking(AutoStoreVersionArchive*,const ArchiveVersionRow*,const SmartBuffer*)</code>
    /// </summary>
    public void InitForPacking(ACBindings.Internal.ArchiveVersionRow* i_rowInitialData, ACBindings.Internal.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, ACBindings.Internal.ArchiveVersionRow*, ACBindings.Internal.SmartBuffer*, void>)0x00446860)(ref this, i_rowInitialData, i_buffer);

    /// <summary>
    /// <code>Offset: 0x004468E0
    /// void __thiscall AutoStoreVersionArchive::AutoStoreVersionArchive(AutoStoreVersionArchive*,Archive::tagUnpacking,const SmartBuffer*)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.Archive.tagUnpacking formal, ACBindings.Internal.SmartBuffer* buff) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, ACBindings.Internal.Archive.tagUnpacking, ACBindings.Internal.SmartBuffer*, void>)0x004468E0)(ref this, formal, buff);

    /// <summary>
    /// <code>Offset: 0x0044CE60
    /// void __thiscall AutoStoreVersionArchive::AutoStoreVersionArchive(AutoStoreVersionArchive*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, void>)0x0044CE60)(ref this);

    /// <summary>
    /// <code>Offset: 0x005D62C0
    /// void __thiscall AutoStoreVersionArchive::AutoStoreVersionArchive(AutoStoreVersionArchive*,Archive::tagUnpacking,void*,unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(ACBindings.Internal.Archive.tagUnpacking formal, System.IntPtr addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, ACBindings.Internal.Archive.tagUnpacking, System.IntPtr, uint, void>)0x005D62C0)(ref this, formal, addr, size);

    /// <summary>
    /// <code>Offset: 0x0065E850
    /// void __thiscall AutoStoreVersionArchive::OnSerializingDone(AutoStoreVersionArchive*)</code>
    /// </summary>
    public void OnSerializingDone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AutoStoreVersionArchive, void>)0x0065E850)(ref this);
}

