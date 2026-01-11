namespace ACBindings.Internal;

public unsafe struct CThreadsafeDiskController
{
    // Base Classes
    public ACBindings.Internal.DiskController BaseClass_DiskController; // ACBindings.Internal.DiskController

    // Child Types
    public unsafe struct CThreadsafeDiskController_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, void> CThreadsafeDiskController_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.DiskConInitInfo*, byte> InitFile; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, byte> Close; // function pointer
        public System.IntPtr LoadData;
        public System.IntPtr SaveData;
        public System.IntPtr DeleteData;
        public System.IntPtr DeleteDataByMask;
        public System.IntPtr IsMember;
        public System.IntPtr GetMembers;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, int> HowmuchFreeSpace; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.CMostlyConsecutiveIntSet*, byte> LoadIterationList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.CMostlyConsecutiveIntSet*, byte> SaveIterationList; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.DATFILE_TYPE> GetDataset; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, uint> GetSubset; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ulong> GetDatFileID; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, byte> IsInitialized; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, byte> IsReadOnly; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, byte> IsExpandable; // function pointer
        public System.IntPtr GetMasterMapDID;
        public System.IntPtr SetMasterMapDID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.DatIDStamp*, void> SetDatIDStamp; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.DatIDStamp*, ACBindings.Internal.DatIDStamp*> GetDatIDStamp; // function pointer
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
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.BTEntry*, ACBindings.Internal.Cache_Pack_t*, uint, byte> SaveDataEx; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.Cache_Pack_t*, ACBindings.Internal.Cache_Pack_t*, byte> AttemptToCompress; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.Cache_Pack_t*, ACBindings.Internal.Cache_Pack_t*, byte> Decompress; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.SharedCriticalSection m_DiskLock;
    public ACBindings.Internal.CMostlyConsecutiveIntSet m_Iters;

    // Generated Constructor
    public CThreadsafeDiskController() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F8B00
    /// char __thiscall CThreadsafeDiskController::LoadDataEx(SharedCriticalSection*,int,Cache_Pack_t*,LONG*,char)</code>
    /// </summary>
    public sbyte LoadDataEx(int a2, ACBindings.Internal.Cache_Pack_t* nNumberOfBytesToRead, int* a4, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CThreadsafeDiskController, int, ACBindings.Internal.Cache_Pack_t*, int*, sbyte, sbyte>)0x004F8B00)(ref this, a2, nNumberOfBytesToRead, a4, a5);

    /// <summary>
    /// <code>Offset: 0x004F8B50
    /// bool __thiscall CThreadsafeDiskController::SaveDataEx(CThreadsafeDiskController*,BTEntry*,Cache_Pack_t*,unsigned int)</code>
    /// </summary>
    public byte SaveDataEx(ACBindings.Internal.BTEntry* io_entry, ACBindings.Internal.Cache_Pack_t* buffer, uint dwFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CThreadsafeDiskController, ACBindings.Internal.BTEntry*, ACBindings.Internal.Cache_Pack_t*, uint, byte>)0x004F8B50)(ref this, io_entry, buffer, dwFlags);

    /// <summary>
    /// <code>Offset: 0x004F8B90
    /// bool __thiscall CThreadsafeDiskController::DeleteData(SharedCriticalSection*,unsigned int,int)</code>
    /// </summary>
    public byte DeleteData(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CThreadsafeDiskController, uint, int, byte>)0x004F8B90)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004F8BD0
    /// char __thiscall CThreadsafeDiskController::DeleteDataByMask(int,int,int)</code>
    /// </summary>
    public sbyte DeleteDataByMask(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CThreadsafeDiskController, int, int, sbyte>)0x004F8BD0)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x004F8D60
    /// void __thiscall CThreadsafeDiskController::CThreadsafeDiskController(CThreadsafeDiskController*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CThreadsafeDiskController, void>)0x004F8D60)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F9260
    /// bool __thiscall CThreadsafeDiskController::InitFile(CThreadsafeDiskController*,DiskConInitInfo*)</code>
    /// </summary>
    public byte InitFile(ACBindings.Internal.DiskConInitInfo* info_r) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CThreadsafeDiskController, ACBindings.Internal.DiskConInitInfo*, byte>)0x004F9260)(ref this, info_r);
}

