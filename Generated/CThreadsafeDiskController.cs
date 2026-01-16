namespace ACBindings.Internal;


/// <summary>Provides a thread‑synchronized wrapper around DiskController, exposing safe access to disk operations via an internal critical section and maintaining iteration state.</summary>
public unsafe struct CThreadsafeDiskController
{
    // Base Classes
    public ACBindings.Internal.DiskController BaseClass_DiskController; // ACBindings.Internal.DiskController

    // Child Types
    public unsafe struct CThreadsafeDiskController_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, void> CThreadsafeDiskController_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.DiskConInitInfo*, byte> InitFile; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, byte> Close; // function pointer
        public System.IntPtr LoadData;
        public System.IntPtr SaveData;
        public System.IntPtr DeleteData;
        public System.IntPtr DeleteDataByMask;
        public System.IntPtr IsMember;
        public System.IntPtr GetMembers;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, int> HowmuchFreeSpace; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.CMostlyConsecutiveIntSet*, byte> LoadIterationList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.CMostlyConsecutiveIntSet*, byte> SaveIterationList; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.DATFILE_TYPE> GetDataset; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, uint> GetSubset; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ulong> GetDatFileID; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, byte> IsInitialized; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, byte> IsReadOnly; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, byte> IsExpandable; // function pointer
        public System.IntPtr GetMasterMapDID;
        public System.IntPtr SetMasterMapDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.DatIDStamp*, void> SetDatIDStamp; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.DatIDStamp*, ACBindings.Internal.DatIDStamp*> GetDatIDStamp; // function pointer
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
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.BTEntry*, ACBindings.Internal.Cache_Pack_t*, uint, byte> SaveDataEx; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.Cache_Pack_t*, ACBindings.Internal.Cache_Pack_t*, byte> AttemptToCompress; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CThreadsafeDiskController*, ACBindings.Internal.Cache_Pack_t*, ACBindings.Internal.Cache_Pack_t*, byte> Decompress; // function pointer

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

    /// <summary>Loads data from disk into a cache package in a thread‑safe manner. The method acquires the controller’s critical section, delegates to DiskController::LoadDataEx, then releases the lock.
    /// <code>Offset: 0x004F8B00
    /// char __thiscall CThreadsafeDiskController::LoadDataEx(SharedCriticalSection*,int,Cache_Pack_t*,LONG*,char)</code>
    /// </summary>
    /// <param name="a2">Identifier or offset specifying which data to load.</param>
    /// <param name="nNumberOfBytesToRead">Buffer containing the cache pack into which the loaded data will be placed. Its internal buffer is filled by the underlying LoadDataEx call.</param>
    /// <param name="a4">Optional output parameter that receives the number of bytes actually read.</param>
    /// <param name="a5">Flag or mode controlling the load operation (e.g., whether to use caching).</param>
    /// <returns>Non‑zero if the data was loaded successfully; zero otherwise.</returns>
    public sbyte LoadDataEx(int a2, ACBindings.Internal.Cache_Pack_t* nNumberOfBytesToRead, int* a4, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CThreadsafeDiskController, int, ACBindings.Internal.Cache_Pack_t*, int*, sbyte, sbyte>)0x004F8B00)(ref this, a2, nNumberOfBytesToRead, a4, a5);

    /// <summary>Persists the specified BTree entry and its associated data pack to disk while protecting the operation with a critical section.
    /// <code>Offset: 0x004F8B50
    /// bool __thiscall CThreadsafeDiskController::SaveDataEx(CThreadsafeDiskController*,BTEntry*,Cache_Pack_t*,unsigned int)</code>
    /// </summary>
    /// <param name="io_entry">The BTree entry that identifies the location within the tree where the data should be stored.</param>
    /// <param name="buffer">A cache pack containing the offset, version, and buffer of data to write.</param>
    /// <param name="dwFlags">Bit flags controlling the save behavior (e.g., overwrite, append).</param>
    /// <returns>True if the data was written successfully; otherwise, false.</returns>
    public byte SaveDataEx(ACBindings.Internal.BTEntry* io_entry, ACBindings.Internal.Cache_Pack_t* buffer, uint dwFlags) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CThreadsafeDiskController, ACBindings.Internal.BTEntry*, ACBindings.Internal.Cache_Pack_t*, uint, byte>)0x004F8B50)(ref this, io_entry, buffer, dwFlags);

    /// <summary>Deletes data from the disk controller while ensuring thread safety via a critical section lock.
    /// <code>Offset: 0x004F8B90
    /// bool __thiscall CThreadsafeDiskController::DeleteData(SharedCriticalSection*,unsigned int,int)</code>
    /// </summary>
    /// <param name="a2">Identifier of the data to delete.</param>
    /// <param name="a3">Optional flag or mode that influences deletion behavior.</param>
    /// <returns>True if deletion succeeded; otherwise false.</returns>
    public byte DeleteData(uint a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CThreadsafeDiskController, uint, int, byte>)0x004F8B90)(ref this, a2, a3);

    /// <summary>Deletes records from the disk that match the specified mask in a thread‑safe manner.
    /// <code>Offset: 0x004F8BD0
    /// char __thiscall CThreadsafeDiskController::DeleteDataByMask(int,int,int)</code>
    /// </summary>
    /// <param name="a2">The first mask value used to identify target data segments.</param>
    /// <param name="a3">The second mask value used to refine the selection of data to delete.</param>
    /// <returns>Non‑zero if deletion succeeded, zero otherwise.</returns>
    public sbyte DeleteDataByMask(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CThreadsafeDiskController, int, int, sbyte>)0x004F8BD0)(ref this, a2, a3);

    /// <summary>Initializes a new threadsafe disk controller, setting up its base disk controller functionality, establishing a critical section for thread safety, and preparing an iterator set for use.
    /// <code>Offset: 0x004F8D60
    /// void __thiscall CThreadsafeDiskController::CThreadsafeDiskController(CThreadsafeDiskController*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CThreadsafeDiskController, void>)0x004F8D60)(ref this);

    /// <summary>Initializes a disk file within a thread‑safe controller by delegating to the base DiskController and loading iteration data.
    /// <code>Offset: 0x004F9260
    /// bool __thiscall CThreadsafeDiskController::InitFile(CThreadsafeDiskController*,DiskConInitInfo*)</code>
    /// </summary>
    /// <param name="info_r">Initialization parameters for the disk controller, including file name, path, dataset information, flags, and size settings.</param>
    /// <returns>True if the file was successfully initialized and ready for use; otherwise false, after displaying an error message and closing the file.></returns>
    public byte InitFile(ACBindings.Internal.DiskConInitInfo* info_r) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CThreadsafeDiskController, ACBindings.Internal.DiskConInitInfo*, byte>)0x004F9260)(ref this, info_r);
}

