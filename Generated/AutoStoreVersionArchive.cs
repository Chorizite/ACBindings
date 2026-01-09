namespace ACBindings;

// AutoStoreVersionArchive
public unsafe struct AutoStoreVersionArchive : System.IDisposable
{
    // Base Classes
    public ACBindings.Archive BaseClass_Archive; // ACBindings.Archive

    // Child Types
    // AutoStoreVersionArchive_vtbl
    public unsafe struct AutoStoreVersionArchive_vtbl
    {
        // Members
        public System.IntPtr InitForPacking; // function pointer
        public System.IntPtr InitForUnpacking; // function pointer
        public System.IntPtr SetCheckpointing; // function pointer
        public System.IntPtr InitVersionStack; // function pointer
        public System.IntPtr CreateVersionStack; // function pointer
        public fixed byte gap14[8];
        public System.IntPtr InitForPacking_1c; // function pointer
        public System.IntPtr InitForUnpacking_20; // function pointer

        // Methods
    }
    // AutoStoreVersionArchive::tagSerializeVersionRow_vtbl
    public unsafe struct tagSerializeVersionRow_vtbl
    {
        // Members
        public System.IntPtr InitializeArchive; // function pointer

        // Methods
    }
    // AutoStoreVersionArchive::tagSerializeVersionRow
    public unsafe struct tagSerializeVersionRow
    {
        // Base Classes
        public ACBindings.ArchiveInitializer BaseClass_ArchiveInitializer; // ACBindings.ArchiveInitializer

        // Members
        public uint m_hSerialize;
        public ACBindings.IDClass___tagVersionHandle m_hVersionRow;
        public ACBindings.ArchiveVersionRow m_rowInitialData;

        // Methods
        // bool __thiscall AutoStoreVersionArchive::tagSerializeVersionRow::InitializeArchive(AutoStoreVersionArchive::tagSerializeVersionRow*,Archive*)
        public byte InitializeArchive(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AutoStoreVersionArchive.tagSerializeVersionRow, ACBindings.Archive*, byte>)0x0065E7D0)(ref this, io_rcArchive);
    }

    // Members
    public ACBindings.AutoStoreVersionArchive.tagSerializeVersionRow m_SerializeVersionRow;
    public byte m_bOnSerializingDoneCalled;

    // Generated Constructor
    public AutoStoreVersionArchive(ACBindings.Archive.tagUnpacking formal, ACBindings.SmartBuffer* buff) {
        _ConstructorInternal(formal, buff);
    }
    public AutoStoreVersionArchive() {
        _ConstructorInternal();
    }
    public AutoStoreVersionArchive(ACBindings.Archive.tagUnpacking formal, System.IntPtr addr, uint size) {
        _ConstructorInternal(formal, addr, size);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall AutoStoreVersionArchive::~AutoStoreVersionArchive(AutoStoreVersionArchive*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AutoStoreVersionArchive, void>)0x004466A0)(ref this);
    // void __thiscall AutoStoreVersionArchive::InitForPacking(AutoStoreVersionArchive*,const ArchiveInitializer*,const SmartBuffer*)
    public void InitForPacking(ACBindings.ArchiveInitializer* i_rInitializer, ACBindings.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AutoStoreVersionArchive, ACBindings.ArchiveInitializer*, ACBindings.SmartBuffer*, void>)0x004466D0)(ref this, i_rInitializer, i_buffer);
    // void __thiscall AutoStoreVersionArchive::InitForUnpacking(AutoStoreVersionArchive*,const ArchiveInitializer*,const SmartBuffer*)
    public void InitForUnpacking(ACBindings.ArchiveInitializer* i_rInitializer, ACBindings.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AutoStoreVersionArchive, ACBindings.ArchiveInitializer*, ACBindings.SmartBuffer*, void>)0x004466E0)(ref this, i_rInitializer, i_buffer);
    // void __thiscall AutoStoreVersionArchive::InitForPacking(AutoStoreVersionArchive*,const SmartBuffer*)
    public void InitForPacking(ACBindings.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AutoStoreVersionArchive, ACBindings.SmartBuffer*, void>)0x004466F0)(ref this, i_buffer);
    // void __thiscall AutoStoreVersionArchive::InitForUnpacking(AutoStoreVersionArchive*,const SmartBuffer*)
    public void InitForUnpacking(ACBindings.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AutoStoreVersionArchive, ACBindings.SmartBuffer*, void>)0x00446770)(ref this, i_buffer);
    // void __thiscall AutoStoreVersionArchive::InitForPacking(AutoStoreVersionArchive*,unsigned int,const SmartBuffer*)
    public void InitForPacking(uint i_iCoreVersion, ACBindings.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AutoStoreVersionArchive, uint, ACBindings.SmartBuffer*, void>)0x004467E0)(ref this, i_iCoreVersion, i_buffer);
    // void __thiscall AutoStoreVersionArchive::InitForPacking(AutoStoreVersionArchive*,const ArchiveVersionRow*,const SmartBuffer*)
    public void InitForPacking(ACBindings.ArchiveVersionRow* i_rowInitialData, ACBindings.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AutoStoreVersionArchive, ACBindings.ArchiveVersionRow*, ACBindings.SmartBuffer*, void>)0x00446860)(ref this, i_rowInitialData, i_buffer);
    // void __thiscall AutoStoreVersionArchive::AutoStoreVersionArchive(AutoStoreVersionArchive*,Archive::tagUnpacking,const SmartBuffer*)
    public void _ConstructorInternal(ACBindings.Archive.tagUnpacking formal, ACBindings.SmartBuffer* buff) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AutoStoreVersionArchive, ACBindings.Archive.tagUnpacking, ACBindings.SmartBuffer*, void>)0x004468E0)(ref this, formal, buff);
    // void __thiscall AutoStoreVersionArchive::AutoStoreVersionArchive(AutoStoreVersionArchive*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AutoStoreVersionArchive, void>)0x0044CE60)(ref this);
    // void __thiscall AutoStoreVersionArchive::AutoStoreVersionArchive(AutoStoreVersionArchive*,Archive::tagUnpacking,void*,unsigned int)
    public void _ConstructorInternal(ACBindings.Archive.tagUnpacking formal, System.IntPtr addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AutoStoreVersionArchive, ACBindings.Archive.tagUnpacking, System.IntPtr, uint, void>)0x005D62C0)(ref this, formal, addr, size);
    // void __thiscall AutoStoreVersionArchive::OnSerializingDone(AutoStoreVersionArchive*)
    public void OnSerializingDone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AutoStoreVersionArchive, void>)0x0065E850)(ref this);
}

