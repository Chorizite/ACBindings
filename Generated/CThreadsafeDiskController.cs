namespace ACBindings;

// CThreadsafeDiskController
public unsafe struct CThreadsafeDiskController
{
    // Base Classes
    public ACBindings.DiskController BaseClass_DiskController; // ACBindings.DiskController

    // Child Types
    // CThreadsafeDiskController_vtbl
    public unsafe struct CThreadsafeDiskController_vtbl
    {
        // Members
        public System.IntPtr CThreadsafeDiskController_dtor_0; // function pointer
        public System.IntPtr InitFile; // function pointer
        public System.IntPtr Close; // function pointer
        public System.IntPtr LoadData;
        public System.IntPtr SaveData;
        public System.IntPtr DeleteData;
        public System.IntPtr DeleteDataByMask;
        public System.IntPtr IsMember;
        public System.IntPtr GetMembers;
        public System.IntPtr HowmuchFreeSpace; // function pointer
        public System.IntPtr LoadIterationList; // function pointer
        public System.IntPtr SaveIterationList; // function pointer
        public System.IntPtr GetDataset; // function pointer
        public System.IntPtr GetSubset; // function pointer
        public System.IntPtr GetDatFileID; // function pointer
        public System.IntPtr IsInitialized; // function pointer
        public System.IntPtr IsReadOnly; // function pointer
        public System.IntPtr IsExpandable; // function pointer
        public System.IntPtr GetMasterMapDID;
        public System.IntPtr SetMasterMapDID;
        public System.IntPtr SetDatIDStamp; // function pointer
        public System.IntPtr GetDatIDStamp; // function pointer
        public System.IntPtr GetFilename;
        public System.IntPtr GetDataSize;
        public System.IntPtr GetUncompressedDataSize;
        public System.IntPtr GetDatestamp;
        public System.IntPtr GetIteration;
        public System.IntPtr GetVersion;
        public System.IntPtr GetIsCompressed;
        public System.IntPtr LoadDataEx;
        public System.IntPtr SaveAndCompressData;
        public System.IntPtr SavePreCompressedData;
        public System.IntPtr SaveDataEx; // function pointer
        public System.IntPtr AttemptToCompress; // function pointer
        public System.IntPtr Decompress; // function pointer

        // Methods
    }

    // Members
    public ACBindings.SharedCriticalSection m_DiskLock;
    public ACBindings.CMostlyConsecutiveIntSet m_Iters;

    // Generated Constructor
    public CThreadsafeDiskController() {
        _ConstructorInternal();
    }

    // Methods
    // char __thiscall CThreadsafeDiskController::LoadDataEx(SharedCriticalSection*,int,Cache_Pack_t*,LONG*,char)
    public sbyte LoadDataEx(int a2, ACBindings.Cache_Pack_t* nNumberOfBytesToRead, int* a4, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CThreadsafeDiskController, int, ACBindings.Cache_Pack_t*, int*, sbyte, sbyte>)0x004F8B00)(ref this, a2, nNumberOfBytesToRead, a4, a5);
    // bool __thiscall CThreadsafeDiskController::SaveDataEx(CThreadsafeDiskController*,BTEntry*,Cache_Pack_t*,unsigned int)
    public byte SaveDataEx(ACBindings.BTEntry* io_entry, ACBindings.Cache_Pack_t* buffer, uint dwFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CThreadsafeDiskController, ACBindings.BTEntry*, ACBindings.Cache_Pack_t*, uint, byte>)0x004F8B50)(ref this, io_entry, buffer, dwFlags);
    // bool __thiscall CThreadsafeDiskController::DeleteData(SharedCriticalSection*,unsigned int,int)
    public byte DeleteData(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CThreadsafeDiskController, uint, int, byte>)0x004F8B90)(ref this, a2, a3);
    // char __thiscall CThreadsafeDiskController::DeleteDataByMask(int,int,int)
    public sbyte DeleteDataByMask(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CThreadsafeDiskController, int, int, sbyte>)0x004F8BD0)(ref this, a2, a3);
    // void __thiscall CThreadsafeDiskController::CThreadsafeDiskController(CThreadsafeDiskController*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CThreadsafeDiskController, void>)0x004F8D60)(ref this);
    // bool __thiscall CThreadsafeDiskController::InitFile(CThreadsafeDiskController*,DiskConInitInfo*)
    public byte InitFile(ACBindings.DiskConInitInfo* info_r) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CThreadsafeDiskController, ACBindings.DiskConInitInfo*, byte>)0x004F9260)(ref this, info_r);
}

