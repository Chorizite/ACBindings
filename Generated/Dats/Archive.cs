namespace ACBindings;

// Archive
public unsafe struct Archive : System.IDisposable
{
    // Statics
    public static ACBindings.Archive.tagSetCurrentCoreVersion* SetCurrentCoreVersion = (ACBindings.Archive.tagSetCurrentCoreVersion*)0x008183B8;

    // Child Types
    // Archive_vtbl
    public unsafe struct Archive_vtbl
    {
        // Members
        public System.IntPtr InitForPacking; // function pointer
        public System.IntPtr InitForUnpacking; // function pointer
        public System.IntPtr SetCheckpointing; // function pointer
        public System.IntPtr InitVersionStack; // function pointer
        public System.IntPtr CreateVersionStack; // function pointer

        // Methods
    }
    // Archive::SetVersionRow_vtbl
    public unsafe struct SetVersionRow_vtbl
    {
        // Members
        public System.IntPtr InitializeArchive; // function pointer

        // Methods
    }
    // Archive::tagSetCurrentCoreVersion_vtbl
    public unsafe struct tagSetCurrentCoreVersion_vtbl
    {
        // Members
        public System.IntPtr InitializeArchive; // function pointer

        // Methods
    }
    // Archive::SetVersionRow
    public unsafe struct SetVersionRow
    {
        // Base Classes
        public ACBindings.ArchiveInitializer BaseClass_ArchiveInitializer; // ACBindings.ArchiveInitializer

        // Members
        public ACBindings.ArchiveVersionRow* m_rInitialData;

        // Methods
        // bool __thiscall Archive::SetVersionRow::InitializeArchive(Archive::SetVersionRow*,Archive*)
        public byte InitializeArchive(ACBindings.Archive* io_rcArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive.SetVersionRow, ACBindings.Archive*, byte>)0x0040AC30)(ref this, io_rcArchive);
    }
    // Archive::tagPacking
    public enum tagPacking : byte
    {
        Packing = 0x0
    }
    // Archive::tagSetCurrentCoreVersion
    public unsafe struct tagSetCurrentCoreVersion
    {
        // Base Classes
        public ACBindings.ArchiveInitializer BaseClass_ArchiveInitializer; // ACBindings.ArchiveInitializer

        // Methods
    }
    // Archive::tagUnpacking
    public enum tagUnpacking : byte
    {
        Unpacking = 0x0
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public uint m_flags;
    public ACBindings.TResult m_hrError;
    public ACBindings.SmartBuffer m_buffer;
    public uint m_currOffset;
    public System.IntPtr m_pcUserDataHash;
    public ACBindings.IArchiveVersionStack* m_pVersionStack;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // unsigned int __thiscall Archive::GetSizeUsed(Archive*)
    public uint GetSizeUsed() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, uint>)0x0040A8D0)(ref this);
    // void __thiscall Archive::SetCurrentPosition(Archive*,unsigned int)
    public void SetCurrentPosition(uint i_position) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, uint, void>)0x0040A8E0)(ref this, i_position);
    // unsigned int __thiscall Archive::GetSizeLeft(Archive*)
    public uint GetSizeLeft() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, uint>)0x0040A8F0)(ref this);
    // SmartBuffer* __thiscall Archive::GetSerializedBuffer(Archive*,SmartBuffer*)
    public ACBindings.SmartBuffer* GetSerializedBuffer(ACBindings.SmartBuffer* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, ACBindings.SmartBuffer*, ACBindings.SmartBuffer*>)0x0040A900)(ref this, result);
    // SmartBuffer* __thiscall Archive::GetRemainingBuffer(Archive*,SmartBuffer*)
    public ACBindings.SmartBuffer* GetRemainingBuffer(ACBindings.SmartBuffer* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, ACBindings.SmartBuffer*, ACBindings.SmartBuffer*>)0x0040A920)(ref this, result);
    // void __thiscall Archive::InitVersionStack(Archive*)
    public void InitVersionStack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, void>)0x0040A940)(ref this);
    // unsigned int __thiscall Archive::GetVersionByToken(Archive*,unsigned int)
    public uint GetVersionByToken(uint i_tokVersion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, uint, uint>)0x0040A960)(ref this, i_tokVersion);
    // void __thiscall Archive::SetCheckpointing(Archive*,bool)
    public void SetCheckpointing(byte checkpointing) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, byte, void>)0x0040A9D0)(ref this, checkpointing);
    // bool __thiscall Archive::UsingDBLoader(Archive*)
    public byte UsingDBLoader() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, byte>)0x0040A9F0)(ref this);
    // void __thiscall Archive::SetDBLoader(Archive*,bool)
    public void SetDBLoader(byte using_DBLoader) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, byte, void>)0x0040AA10)(ref this, using_DBLoader);
    // void __thiscall Archive::SetWordAligned(Archive*,bool)
    public void SetWordAligned(byte aligned) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, byte, void>)0x0040AA30)(ref this, aligned);
    // void __thiscall Archive::RaiseError(Archive*)
    public void RaiseError() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, void>)0x0040AA50)(ref this);
    // bool __thiscall Archive::IsWordAligned(Archive*)
    public byte IsWordAligned() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, byte>)0x0040AA60)(ref this);
    // bool __thiscall Archive::SetVersionByToken(Archive*,unsigned int,unsigned int)
    public byte SetVersionByToken(uint i_tokVersion, uint i_iVersion) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, uint, uint, byte>)0x0040AA70)(ref this, i_tokVersion, i_iVersion);
    // IDClass<_tagVersionHandle,32,0>* __thiscall Archive::PushVersionRow(_DWORD*,IDClass<_tagVersionHandle,32,0>*)
    public ACBindings.IDClass___tagVersionHandle* PushVersionRow(ACBindings.IDClass___tagVersionHandle* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, ACBindings.IDClass___tagVersionHandle*, ACBindings.IDClass___tagVersionHandle*>)0x0040AAD0)(ref this, a2);
    // IDClass<_tagVersionHandle,32,0>* __thiscall Archive::PushVersionRow(_DWORD*,IDClass<_tagVersionHandle,32,0>*,int)
    public ACBindings.IDClass___tagVersionHandle* PushVersionRow(ACBindings.IDClass___tagVersionHandle* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, ACBindings.IDClass___tagVersionHandle*, int, ACBindings.IDClass___tagVersionHandle*>)0x0040AB30)(ref this, a2, a3);
    // char __thiscall Archive::GetVersionRowByHandle(_DWORD**,int,int)
    public sbyte GetVersionRowByHandle(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, int, int, sbyte>)0x0040AB90)(ref this, a2, a3);
    // unsigned __int8* __thiscall Archive::PeekBytes(Archive*,unsigned int,unsigned int)
    public byte* PeekBytes(uint i_position, uint i_size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, uint, uint, byte*>)0x0040AC70)(ref this, i_position, i_size);
    // unsigned __int8* __thiscall Archive::GetBytes(Archive*,unsigned int)
    public byte* GetBytes(uint i_size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, uint, byte*>)0x0040ACF0)(ref this, i_size);
    // void __thiscall Archive::CheckAlignment(Archive*,unsigned int)
    public void CheckAlignment(uint i_objectSize) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, uint, void>)0x0040AD10)(ref this, i_objectSize);
    // void __thiscall Archive::CreateVersionStack(Archive*)
    public void CreateVersionStack() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, void>)0x0040AEF0)(ref this);
    // void __thiscall Archive::ReleaseUserData(Archive*)
    public void ReleaseUserData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, void>)0x0040AF20)(ref this);
    // void __thiscall Archive::InitForPacking(Archive*,const ArchiveInitializer*,const SmartBuffer*)
    public void InitForPacking(ACBindings.ArchiveInitializer* i_rInitializer, ACBindings.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, ACBindings.ArchiveInitializer*, ACBindings.SmartBuffer*, void>)0x0040AFB0)(ref this, i_rInitializer, i_buffer);
    // void __thiscall Archive::InitForUnpacking(Archive*,const ArchiveInitializer*,const SmartBuffer*)
    public void InitForUnpacking(ACBindings.ArchiveInitializer* i_rInitializer, ACBindings.SmartBuffer* i_buffer) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, ACBindings.ArchiveInitializer*, ACBindings.SmartBuffer*, void>)0x0040B020)(ref this, i_rInitializer, i_buffer);
    // void __thiscall Archive::~Archive(Archive*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Archive, void>)0x0040B060)(ref this);
}

