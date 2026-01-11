namespace ACBindings.Internal;

public unsafe struct CLCache : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.ThreadedCache BaseClass_ThreadedCache; // ACBindings.Internal.ThreadedCache
    public ACBindings.Internal.CPluginManagerTemplate___CDDDStatusPlugin BaseClass_CPluginManagerTemplate; // ACBindings.Internal.CPluginManagerTemplate___CDDDStatusPlugin

    // Child Types
    public unsafe struct CLCache_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> DBCache_dtor_18; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.DBCache.Enum3> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> ResetCache; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, int, int, uint, ACBindings.Internal.DBObj*> GetFromEnum; // function pointer
        public System.IntPtr GetDIDFromEnum;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.CACHE_OBJECT_CODES> PreFetch; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.DatIDStamp*, byte> InqDatIDStamp; // function pointer
        public System.IntPtr ReloadObject;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte, byte> SetShutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte> IsLoader; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, uint, byte> SetRegion; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte> UnloadCellData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> AskForLastWords; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, uint, byte, byte> SetLanguageInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> DestroyObjectCaches; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, void> StopThread; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.AsyncCache.CAsyncRequest*, void> WorkerExecuteRequest; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.CAsyncGetRequest*, void> WorkerExecuteGetRequest; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.CAsyncSaveRequest*, void> WorkerExecuteSaveRequest; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.CAsyncPurgeRequest*, void> WorkerExecutePurgeRequest; // function pointer
        public System.IntPtr Init;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache*, void> Init_Internal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache*, ACBindings.Internal.AsyncContext*, ACBindings.Internal.DDD_DataMessage*, ACBindings.Internal.AsyncContext*> AsyncSaveDDDMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache*, ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, void> WorkerExecuteBeginDDDRequest; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache*, ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, void> OnBeginDDDRequestFinished; // function pointer

        // Methods
    }
    public unsafe struct CAsyncBeginDDDRequest
    {
        // Base Classes
        public ACBindings.Internal.AsyncCache.CAsyncRequest BaseClass_AsyncCache_CAsyncRequest; // ACBindings.Internal.AsyncCache.CAsyncRequest

        // Child Types
        public unsafe struct CAsyncBeginDDDRequest_vtbl
        {
            // Members
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, void> CLCache; // function pointer
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, byte> bAllDependanciesDone; // function pointer
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, byte> ReadyToUnhash; // function pointer
            public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, void> ReleaseDBObj; // function pointer

            // Methods
        }

        // Methods
    }
    // CLCache::CCLCacheAsyncOperation
    public enum CCLCacheAsyncOperation : byte
    {
        MM_3h = 0x3,
        opAsyncBeginDDD = 0x3,
        opCLCacheNextAsyncOperation = 0x4
    }
    // CLCache::DatFileIndex
    public enum DatFileIndex : byte
    {
        PortalDatIndex = 0x0,
        LocalDatIndex = 0x1,
        CellDatIndex = 0x2,
        HighResDatIndex = 0x3,
        nDatFiles = 0x4
    }

    // Members
    public ACBindings.Internal.SmartArray___DiskController_ptr m_DatFiles;
    public byte m_fReadOnly;
    public byte m_fEngineOnly;
    public uint m_ridDDDRegion;
    public ACBindings.Internal._F43682D933327F9F3CA6C70AFCFC5243 m_DDDState;
    public ACBindings.Internal.SmartArray___MissingIteration m_MissingIters;
    public ACBindings.Internal.AutoGrowHashTable___QualifiedDataID___MissingIteration_ptr m_PendingDownloads;
    public ACBindings.Internal.HashTable__ulong___DiskController_ptr m_DatFileByIDTable;
    public ACBindings.Internal.SmartArray___QualifiedDataID m_EarlySaves;
    public uint m_cbEarlySaves;
    public uint m_eNameRuleLanguage;
    public System.IntPtr m_pNetQueue;
    public ACBindings.Internal.PStringBase__ushort m_strDatFilePath;

    // Generated Constructor
    public CLCache() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004F7F40
    /// void __thiscall CLCache::ResetCache(CLCache*)</code>
    /// </summary>
    public void ResetCache() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, void>)0x004F7F40)(ref this);

    /// <summary>
    /// <code>Offset: 0x004F7F70
    /// int __thiscall CLCache::SetNetQueue(_DWORD*,int)</code>
    /// </summary>
    public int SetNetQueue(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, int, int>)0x004F7F70)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x004F7F80
    /// void __thiscall CLCache::WorkerExecuteRequest(CLCache*,AsyncCache::CAsyncRequest*)</code>
    /// </summary>
    public void WorkerExecuteRequest(ACBindings.Internal.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.AsyncCache.CAsyncRequest*, void>)0x004F7F80)(ref this, pReq);

    /// <summary>
    /// <code>Offset: 0x004F7FA0
    /// void __thiscall CLCache::OnRequestFinished(CLCache*,AsyncCache::CAsyncRequest*)</code>
    /// </summary>
    public void OnRequestFinished(ACBindings.Internal.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.AsyncCache.CAsyncRequest*, void>)0x004F7FA0)(ref this, pReq);

    /// <summary>
    /// <code>Offset: 0x004F8380
    /// TResult* __thiscall CLCache::QueryInterface(CLCache*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rInterfaceType, void** o_ppOutInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x004F8380)(ref this, result, i_rInterfaceType, o_ppOutInterface);

    /// <summary>
    /// <code>Offset: 0x004F8430
    /// void __thiscall CLCache::WorkerExecuteBeginDDDRequest(CLCache*,CLCache::CAsyncBeginDDDRequest*)</code>
    /// </summary>
    public void WorkerExecuteBeginDDDRequest(ACBindings.Internal.CLCache.CAsyncBeginDDDRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, void>)0x004F8430)(ref this, pReq);

    /// <summary>
    /// <code>Offset: 0x004F8570
    /// bool __thiscall CLCache::InqDatIDStamp(CLCache*,DatIDStamp*)</code>
    /// </summary>
    public byte InqDatIDStamp(ACBindings.Internal.DatIDStamp* id_vstamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.DatIDStamp*, byte>)0x004F8570)(ref this, id_vstamp);

    /// <summary>
    /// <code>Offset: 0x004F85B0
    /// TResult* __thiscall CLCache::AdoptAndDeliverMessage(CLCache*,TResult*,FakeMessageData*)</code>
    /// </summary>
    public ACBindings.Internal.TResult* AdoptAndDeliverMessage(ACBindings.Internal.TResult* result, ACBindings.Internal.FakeMessageData* i_FMD) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.TResult*, ACBindings.Internal.FakeMessageData*, ACBindings.Internal.TResult*>)0x004F85B0)(ref this, result, i_FMD);

    /// <summary>
    /// <code>Offset: 0x004F8C50
    /// bool __thiscall CLCache::AsyncGetFromOtherSources(CLCache*,const QualifiedDataID*,DBOCache*)</code>
    /// </summary>
    public byte AsyncGetFromOtherSources(ACBindings.Internal.QualifiedDataID* qdid, ACBindings.Internal.DBOCache* pObjCache) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.DBOCache*, byte>)0x004F8C50)(ref this, qdid, pObjCache);

    /// <summary>
    /// <code>Offset: 0x004F8CB0
    /// void __thiscall CLCache::NotifyDDDEvent(CLCache*,DDDEvent,unsigned int)</code>
    /// </summary>
    public void NotifyDDDEvent(ACBindings.Internal.DDDEvent EventNum, uint nBytes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.DDDEvent, uint, void>)0x004F8CB0)(ref this, EventNum, nBytes);

    /// <summary>
    /// <code>Offset: 0x004F8E90
    /// AsyncContext* __thiscall CLCache::AsyncSaveDDDMessage(CLCache*,AsyncContext*,const DDD_DataMessage*)</code>
    /// </summary>
    public ACBindings.Internal.AsyncContext* AsyncSaveDDDMessage(ACBindings.Internal.AsyncContext* result, ACBindings.Internal.DDD_DataMessage* pEvent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.AsyncContext*, ACBindings.Internal.DDD_DataMessage*, ACBindings.Internal.AsyncContext*>)0x004F8E90)(ref this, result, pEvent);

    /// <summary>
    /// <code>Offset: 0x004F92D0
    /// bool __thiscall CLCache::SetRegion(CLCache*,unsigned int)</code>
    /// </summary>
    public byte SetRegion(uint rid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, uint, byte>)0x004F92D0)(ref this, rid);

    /// <summary>
    /// <code>Offset: 0x004F95F0
    /// bool __thiscall CLCache::SetLanguageInternal(CLCache*,unsigned int,bool)</code>
    /// </summary>
    public byte SetLanguageInternal(uint language_l, byte engine_only) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, uint, byte, byte>)0x004F95F0)(ref this, language_l, engine_only);

    /// <summary>
    /// <code>Offset: 0x004F9B40
    /// DiskController* __thiscall CLCache::GetDiskController(CLCache*,const QualifiedDataID*,unsigned __int64)</code>
    /// </summary>
    public ACBindings.Internal.DiskController* GetDiskController(ACBindings.Internal.QualifiedDataID* qdid, ulong idRequestedDatFile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.QualifiedDataID*, ulong, ACBindings.Internal.DiskController*>)0x004F9B40)(ref this, qdid, idRequestedDatFile);

    /// <summary>
    /// <code>Offset: 0x004F9C30
    /// bool __thiscall CLCache::IsDatFileLoaded(CLCache*,unsigned __int64)</code>
    /// </summary>
    public byte IsDatFileLoaded(ulong idDatFile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ulong, byte>)0x004F9C30)(ref this, idDatFile);

    /// <summary>
    /// <code>Offset: 0x004FA660
    /// void __thiscall CLCache::OnBeginDDD(CLCache*,const DDD_BeginDDDMessage*)</code>
    /// </summary>
    public void OnBeginDDD(ACBindings.Internal.DDD_BeginDDDMessage* pEvent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.DDD_BeginDDDMessage*, void>)0x004FA660)(ref this, pEvent);

    /// <summary>
    /// <code>Offset: 0x004FA8B0
    /// char __thiscall CLCache::Init(int,int*,char,int,char,int,int,int)</code>
    /// </summary>
    public sbyte Init(int* a2, sbyte a3, int a4, sbyte a5, int a6, int a7, int a8) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, int*, sbyte, int, sbyte, int, int, int, sbyte>)0x004FA8B0)(ref this, a2, a3, a4, a5, a6, a7, a8);

    /// <summary>
    /// <code>Offset: 0x004FADF0
    /// void __thiscall CLCache::LoadHighResDat(CLCache*)</code>
    /// </summary>
    public void LoadHighResDat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, void>)0x004FADF0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FAF80
    /// void __thiscall CLCache::OnServerInterrogation(CLCache*,const DDD_InterrogationMessage*)</code>
    /// </summary>
    public void OnServerInterrogation(ACBindings.Internal.DDD_InterrogationMessage* pEvent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.DDD_InterrogationMessage*, void>)0x004FAF80)(ref this, pEvent);

    /// <summary>
    /// <code>Offset: 0x004FB290
    /// bool __thiscall CLCache::RemovePendingDownload(CLCache*,const QualifiedDataID*)</code>
    /// </summary>
    public byte RemovePendingDownload(ACBindings.Internal.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.QualifiedDataID*, byte>)0x004FB290)(ref this, qdid);

    /// <summary>
    /// <code>Offset: 0x004FB450
    /// void __thiscall CLCache::OnEndDDD(CLCache*)</code>
    /// </summary>
    public void OnEndDDD() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, void>)0x004FB450)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FB4E0
    /// void __thiscall CLCache::OnBeginDDDRequestFinished(CLCache*,CLCache::CAsyncBeginDDDRequest*)</code>
    /// </summary>
    public void OnBeginDDDRequestFinished(ACBindings.Internal.CLCache.CAsyncBeginDDDRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, void>)0x004FB4E0)(ref this, pReq);

    /// <summary>
    /// <code>Offset: 0x004FB850
    /// void __thiscall CLCache::Init_Internal(CLCache*)</code>
    /// </summary>
    public void Init_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, void>)0x004FB850)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FC9D0
    /// void __thiscall CLCache::~CLCache(CLCache*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, void>)0x004FC9D0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FCBE0
    /// void __thiscall CLCache::UseTime(CLCache*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, void>)0x004FCBE0)(ref this);

    /// <summary>
    /// <code>Offset: 0x004FCEB0
    /// void __thiscall CLCache::OnSaveRequestFinished(CLCache*,CAsyncSaveRequest*)</code>
    /// </summary>
    public void OnSaveRequestFinished(ACBindings.Internal.CAsyncSaveRequest* pSaveReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, ACBindings.Internal.CAsyncSaveRequest*, void>)0x004FCEB0)(ref this, pSaveReq);

    /// <summary>
    /// <code>Offset: 0x004FCF90
    /// void __thiscall CLCache::CLCache(CLCache*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLCache, void>)0x004FCF90)(ref this);
}

public unsafe struct CLBlockAllocator : System.IDisposable
{
    // Members
    public ACBindings.Internal.DiskFileInfo_t* file_info_mp;
    public ACBindings.Internal.DiskDev file_man_m;
    public byte expandable_mf;

    // Generated Constructor
    public CLBlockAllocator() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00674E20
    /// void __thiscall CLBlockAllocator::CLBlockAllocator(CLBlockAllocator*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, void>)0x00674E20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00674E40
    /// void __thiscall CLBlockAllocator::~CLBlockAllocator(CLBlockAllocator*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, void>)0x00674E40)(ref this);

    /// <summary>
    /// <code>Offset: 0x00674E50
    /// int __thiscall CLBlockAllocator::Close_Data_File(CLBlockAllocator*)</code>
    /// </summary>
    public int Close_Data_File() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, int>)0x00674E50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00674E70
    /// int __thiscall CLBlockAllocator::SaveFileInfo(CLBlockAllocator*)</code>
    /// </summary>
    public int SaveFileInfo() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, int>)0x00674E70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00674E90
    /// int __thiscall CLBlockAllocator::StoreDataRollback(CLBlockAllocator*,unsigned int,int)</code>
    /// </summary>
    public int StoreDataRollback(uint dataSize, int startOffset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, uint, int, int>)0x00674E90)(ref this, dataSize, startOffset);

    /// <summary>
    /// <code>Offset: 0x00674F50
    /// int __thiscall CLBlockAllocator::DeleteBlocks(CLBlockAllocator*,int,int,int,bool)</code>
    /// </summary>
    public int DeleteBlocks(int startOffset, int finalOffset, int oldFreeCount, byte fRefree) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, int, int, int, byte, int>)0x00674F50)(ref this, startOffset, finalOffset, oldFreeCount, fRefree);

    /// <summary>
    /// <code>Offset: 0x00675040
    /// int __thiscall CLBlockAllocator::ExpandFile(CLBlockAllocator*,int)</code>
    /// </summary>
    public int ExpandFile(int size_l) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, int, int>)0x00675040)(ref this, size_l);

    /// <summary>
    /// <code>Offset: 0x00675150
    /// int __thiscall CLBlockAllocator::Store_Data(CLBlockAllocator*,Cache_Pack_t*,int)</code>
    /// </summary>
    public int Store_Data(ACBindings.Internal.Cache_Pack_t* pack_buf, int startOffset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, ACBindings.Internal.Cache_Pack_t*, int, int>)0x00675150)(ref this, pack_buf, startOffset);

    /// <summary>
    /// <code>Offset: 0x006752A0
    /// int __thiscall CLBlockAllocator::Update(CLBlockAllocator*,Cache_Pack_t*,int)</code>
    /// </summary>
    public int Update(ACBindings.Internal.Cache_Pack_t* pack_buf, int inOffset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, ACBindings.Internal.Cache_Pack_t*, int, int>)0x006752A0)(ref this, pack_buf, inOffset);

    /// <summary>
    /// <code>Offset: 0x00675480
    /// bool __thiscall CLBlockAllocator::Load_Data(CLBlockAllocator*,Cache_Pack_t*,int,bool)</code>
    /// </summary>
    public byte Load_Data(ACBindings.Internal.Cache_Pack_t* buf_out, int offset, byte bShortRead) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, ACBindings.Internal.Cache_Pack_t*, int, byte, byte>)0x00675480)(ref this, buf_out, offset, bShortRead);

    /// <summary>
    /// <code>Offset: 0x006755E0
    /// int __thiscall CLBlockAllocator::SaveTransaction(CLBlockAllocator*,DiskTransactInfo*)</code>
    /// </summary>
    public int SaveTransaction(ACBindings.Internal.DiskTransactInfo* pTransInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, ACBindings.Internal.DiskTransactInfo*, int>)0x006755E0)(ref this, pTransInfo);

    /// <summary>
    /// <code>Offset: 0x00675680
    /// int __thiscall CLBlockAllocator::ClearTransaction(CLBlockAllocator*)</code>
    /// </summary>
    public int ClearTransaction() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, int>)0x00675680)(ref this);

    /// <summary>
    /// <code>Offset: 0x006756A0
    /// int __thiscall CLBlockAllocator::ReadTransaction(CLBlockAllocator*,DiskTransactInfo**)</code>
    /// </summary>
    public int ReadTransaction(ACBindings.Internal.DiskTransactInfo** pTranInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, ACBindings.Internal.DiskTransactInfo**, int>)0x006756A0)(ref this, pTranInfo);

    /// <summary>
    /// <code>Offset: 0x00675780
    /// int __thiscall CLBlockAllocator::CreateDataFile(CLBlockAllocator*,DiskFileInfo_t*,int,int,int)</code>
    /// </summary>
    public int CreateDataFile(ACBindings.Internal.DiskFileInfo_t* a2, int a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, ACBindings.Internal.DiskFileInfo_t*, int, int, int, int>)0x00675780)(ref this, a2, a3, a4, a5);

    /// <summary>
    /// <code>Offset: 0x00675920
    /// int __thiscall CLBlockAllocator::OpenDataFile(CLBlockAllocator*,volatile LONG*,int,int*,int,DiskTransactInfo**)</code>
    /// </summary>
    public int OpenDataFile(int* lpBuffer, int a3, int* a4, int a5, ACBindings.Internal.DiskTransactInfo** pTranInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLBlockAllocator, int*, int, int*, int, ACBindings.Internal.DiskTransactInfo**, int>)0x00675920)(ref this, lpBuffer, a3, a4, a5, pTranInfo);
}

public unsafe struct gmCLCache
{
    // Base Classes
    public ACBindings.Internal.CLCache BaseClass_CLCache; // ACBindings.Internal.CLCache

    // Child Types
    public unsafe struct gmCLCache_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> DBCache_dtor_18; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.DBCache.Enum3> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> ResetCache; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, int, int, uint, ACBindings.Internal.DBObj*> GetFromEnum; // function pointer
        public System.IntPtr GetDIDFromEnum;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.CACHE_OBJECT_CODES> PreFetch; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.DatIDStamp*, byte> InqDatIDStamp; // function pointer
        public System.IntPtr ReloadObject;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte, byte> SetShutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte> IsLoader; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, uint, byte> SetRegion; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte> UnloadCellData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> AskForLastWords; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, uint, byte, byte> SetLanguageInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> DestroyObjectCaches; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, void> StopThread; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.AsyncCache.CAsyncRequest*, void> WorkerExecuteRequest; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.CAsyncGetRequest*, void> WorkerExecuteGetRequest; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.CAsyncSaveRequest*, void> WorkerExecuteSaveRequest; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.CAsyncPurgeRequest*, void> WorkerExecutePurgeRequest; // function pointer
        public System.IntPtr Init;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache*, void> Init_Internal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache*, ACBindings.Internal.AsyncContext*, ACBindings.Internal.DDD_DataMessage*, ACBindings.Internal.AsyncContext*> AsyncSaveDDDMessage; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache*, ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, void> WorkerExecuteBeginDDDRequest; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLCache*, ACBindings.Internal.CLCache.CAsyncBeginDDDRequest*, void> OnBeginDDDRequestFinished; // function pointer

        // Methods
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x0058B870
    /// char __thiscall gmCLCache::Init(void*,int*,char,int,char,int,int,int)</code>
    /// </summary>
    public sbyte Init(int* a2, sbyte a3, int a4, sbyte a5, int a6, int a7, int a8) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCLCache, int*, sbyte, int, sbyte, int, int, int, sbyte>)0x0058B870)(ref this, a2, a3, a4, a5, a6, a7, a8);

    /// <summary>
    /// <code>Offset: 0x0058B8F0
    /// void __thiscall gmCLCache::Init_Internal(gmCLCache*)</code>
    /// </summary>
    public void Init_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.gmCLCache, void>)0x0058B8F0)(ref this);
}

