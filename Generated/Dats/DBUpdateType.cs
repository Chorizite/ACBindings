namespace ACBindings;

// CLCache
public unsafe struct CLCache : System.IDisposable
{
    // Base Classes
    public ACBindings.ThreadedCache BaseClass_ThreadedCache; // ACBindings.ThreadedCache
    public ACBindings.CPluginManagerTemplate__CDDDStatusPlugin BaseClass_CPluginManagerTemplate; // ACBindings.CPluginManagerTemplate__CDDDStatusPlugin

    // Child Types
    // CLCache::CAsyncBeginDDDRequest_vtbl
    public unsafe struct CAsyncBeginDDDRequest_vtbl
    {
        // Members
        public System.IntPtr CLCache; // function pointer
        public System.IntPtr bAllDependanciesDone; // function pointer
        public System.IntPtr ReadyToUnhash; // function pointer
        public System.IntPtr ReleaseDBObj; // function pointer

        // Methods
    }
    // CLCache_vtbl
    public unsafe struct CLCache_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBCache_dtor_18; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public System.IntPtr ResetCache; // function pointer
        public System.IntPtr GetFromEnum; // function pointer
        public System.IntPtr GetDIDFromEnum;
        public System.IntPtr PreFetch; // function pointer
        public System.IntPtr InqDatIDStamp; // function pointer
        public System.IntPtr ReloadObject;
        public System.IntPtr SetShutdown; // function pointer
        public System.IntPtr IsLoader; // function pointer
        public System.IntPtr SetRegion; // function pointer
        public System.IntPtr UnloadCellData; // function pointer
        public System.IntPtr AskForLastWords; // function pointer
        public System.IntPtr SetLanguageInternal; // function pointer
        public System.IntPtr DestroyObjectCaches; // function pointer
        public System.IntPtr StopThread; // function pointer
        public System.IntPtr WorkerExecuteRequest; // function pointer
        public System.IntPtr WorkerExecuteGetRequest; // function pointer
        public System.IntPtr WorkerExecuteSaveRequest; // function pointer
        public System.IntPtr WorkerExecutePurgeRequest; // function pointer
        public System.IntPtr Init;
        public System.IntPtr Init_Internal; // function pointer
        public System.IntPtr AsyncSaveDDDMessage; // function pointer
        public System.IntPtr WorkerExecuteBeginDDDRequest; // function pointer
        public System.IntPtr OnBeginDDDRequestFinished; // function pointer

        // Methods
    }
    // CLCache::CAsyncBeginDDDRequest
    public unsafe struct CAsyncBeginDDDRequest
    {
        // Base Classes
        public ACBindings.AsyncCache.CAsyncRequest BaseClass_AsyncCache_CAsyncRequest; // ACBindings.AsyncCache.CAsyncRequest

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
    public ACBindings.SmartArray__DiskController_ptr m_DatFiles;
    public byte m_fReadOnly;
    public byte m_fEngineOnly;
    public uint m_ridDDDRegion;
    public ACBindings._F43682D933327F9F3CA6C70AFCFC5243 m_DDDState;
    public ACBindings.SmartArray__MissingIteration m_MissingIters;
    public ACBindings.AutoGrowHashTable__QualifiedDataID__MissingIteration_ptr m_PendingDownloads;
    public ACBindings.HashTable__ulong__DiskController_ptr m_DatFileByIDTable;
    public ACBindings.SmartArray__QualifiedDataID m_EarlySaves;
    public uint m_cbEarlySaves;
    public uint m_eNameRuleLanguage;
    public System.IntPtr m_pNetQueue;
    public ACBindings.PStringBase__ushort m_strDatFilePath;

    // Generated Constructor
    public CLCache() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CLCache::ResetCache(CLCache*)
    public void ResetCache() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, void>)0x004F7F40)(ref this);
    // int __thiscall CLCache::SetNetQueue(_DWORD*,int)
    public int SetNetQueue(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, int, int>)0x004F7F70)(ref this, a2);
    // void __thiscall CLCache::WorkerExecuteRequest(CLCache*,AsyncCache::CAsyncRequest*)
    public void WorkerExecuteRequest(ACBindings.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, ACBindings.AsyncCache.CAsyncRequest*, void>)0x004F7F80)(ref this, pReq);
    // void __thiscall CLCache::OnRequestFinished(CLCache*,AsyncCache::CAsyncRequest*)
    public void OnRequestFinished(ACBindings.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, ACBindings.AsyncCache.CAsyncRequest*, void>)0x004F7FA0)(ref this, pReq);
    // TResult* __thiscall CLCache::QueryInterface(CLCache*,TResult*,const Turbine_GUID*,void**)
    public ACBindings.TResult* QueryInterface(ACBindings.TResult* result, ACBindings.Turbine_GUID* i_rInterfaceType, void** o_ppOutInterface) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, ACBindings.TResult*, ACBindings.Turbine_GUID*, void**, ACBindings.TResult*>)0x004F8380)(ref this, result, i_rInterfaceType, o_ppOutInterface);
    // void __thiscall CLCache::WorkerExecuteBeginDDDRequest(CLCache*,CLCache::CAsyncBeginDDDRequest*)
    public void WorkerExecuteBeginDDDRequest(ACBindings.CLCache.CAsyncBeginDDDRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, ACBindings.CLCache.CAsyncBeginDDDRequest*, void>)0x004F8430)(ref this, pReq);
    // bool __thiscall CLCache::InqDatIDStamp(CLCache*,DatIDStamp*)
    public byte InqDatIDStamp(ACBindings.DatIDStamp* id_vstamp) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, ACBindings.DatIDStamp*, byte>)0x004F8570)(ref this, id_vstamp);
    // TResult* __thiscall CLCache::AdoptAndDeliverMessage(CLCache*,TResult*,FakeMessageData*)
    public ACBindings.TResult* AdoptAndDeliverMessage(ACBindings.TResult* result, ACBindings.FakeMessageData* i_FMD) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, ACBindings.TResult*, ACBindings.FakeMessageData*, ACBindings.TResult*>)0x004F85B0)(ref this, result, i_FMD);
    // bool __thiscall CLCache::AsyncGetFromOtherSources(CLCache*,const QualifiedDataID*,DBOCache*)
    public byte AsyncGetFromOtherSources(ACBindings.QualifiedDataID* qdid, ACBindings.DBOCache* pObjCache) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, ACBindings.QualifiedDataID*, ACBindings.DBOCache*, byte>)0x004F8C50)(ref this, qdid, pObjCache);
    // void __thiscall CLCache::NotifyDDDEvent(CLCache*,DDDEvent,unsigned int)
    public void NotifyDDDEvent(ACBindings.DDDEvent EventNum, uint nBytes) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, ACBindings.DDDEvent, uint, void>)0x004F8CB0)(ref this, EventNum, nBytes);
    // AsyncContext* __thiscall CLCache::AsyncSaveDDDMessage(CLCache*,AsyncContext*,const DDD_DataMessage*)
    public ACBindings.AsyncContext* AsyncSaveDDDMessage(ACBindings.AsyncContext* result, ACBindings.DDD_DataMessage* pEvent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, ACBindings.AsyncContext*, ACBindings.DDD_DataMessage*, ACBindings.AsyncContext*>)0x004F8E90)(ref this, result, pEvent);
    // bool __thiscall CLCache::SetRegion(CLCache*,unsigned int)
    public byte SetRegion(uint rid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, uint, byte>)0x004F92D0)(ref this, rid);
    // bool __thiscall CLCache::SetLanguageInternal(CLCache*,unsigned int,bool)
    public byte SetLanguageInternal(uint language_l, byte engine_only) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, uint, byte, byte>)0x004F95F0)(ref this, language_l, engine_only);
    // DiskController* __thiscall CLCache::GetDiskController(CLCache*,const QualifiedDataID*,unsigned __int64)
    public ACBindings.DiskController* GetDiskController(ACBindings.QualifiedDataID* qdid, ulong idRequestedDatFile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, ACBindings.QualifiedDataID*, ulong, ACBindings.DiskController*>)0x004F9B40)(ref this, qdid, idRequestedDatFile);
    // bool __thiscall CLCache::IsDatFileLoaded(CLCache*,unsigned __int64)
    public byte IsDatFileLoaded(ulong idDatFile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, ulong, byte>)0x004F9C30)(ref this, idDatFile);
    // void __thiscall CLCache::OnBeginDDD(CLCache*,const DDD_BeginDDDMessage*)
    public void OnBeginDDD(ACBindings.DDD_BeginDDDMessage* pEvent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, ACBindings.DDD_BeginDDDMessage*, void>)0x004FA660)(ref this, pEvent);
    // char __thiscall CLCache::Init(int,int*,char,int,char,int,int,int)
    public sbyte Init(int* a2, sbyte a3, int a4, sbyte a5, int a6, int a7, int a8) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, int*, sbyte, int, sbyte, int, int, int, sbyte>)0x004FA8B0)(ref this, a2, a3, a4, a5, a6, a7, a8);
    // void __thiscall CLCache::LoadHighResDat(CLCache*)
    public void LoadHighResDat() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, void>)0x004FADF0)(ref this);
    // void __thiscall CLCache::OnServerInterrogation(CLCache*,const DDD_InterrogationMessage*)
    public void OnServerInterrogation(ACBindings.DDD_InterrogationMessage* pEvent) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, ACBindings.DDD_InterrogationMessage*, void>)0x004FAF80)(ref this, pEvent);
    // bool __thiscall CLCache::RemovePendingDownload(CLCache*,const QualifiedDataID*)
    public byte RemovePendingDownload(ACBindings.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, ACBindings.QualifiedDataID*, byte>)0x004FB290)(ref this, qdid);
    // void __thiscall CLCache::OnEndDDD(CLCache*)
    public void OnEndDDD() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, void>)0x004FB450)(ref this);
    // void __thiscall CLCache::OnBeginDDDRequestFinished(CLCache*,CLCache::CAsyncBeginDDDRequest*)
    public void OnBeginDDDRequestFinished(ACBindings.CLCache.CAsyncBeginDDDRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, ACBindings.CLCache.CAsyncBeginDDDRequest*, void>)0x004FB4E0)(ref this, pReq);
    // void __thiscall CLCache::Init_Internal(CLCache*)
    public void Init_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, void>)0x004FB850)(ref this);
    // void __thiscall CLCache::~CLCache(CLCache*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, void>)0x004FC9D0)(ref this);
    // void __thiscall CLCache::UseTime(CLCache*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, void>)0x004FCBE0)(ref this);
    // void __thiscall CLCache::OnSaveRequestFinished(CLCache*,CAsyncSaveRequest*)
    public void OnSaveRequestFinished(ACBindings.CAsyncSaveRequest* pSaveReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, ACBindings.CAsyncSaveRequest*, void>)0x004FCEB0)(ref this, pSaveReq);
    // void __thiscall CLCache::CLCache(CLCache*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLCache, void>)0x004FCF90)(ref this);
}

// CLBlockAllocator
public unsafe struct CLBlockAllocator : System.IDisposable
{
    // Members
    public ACBindings.DiskFileInfo_t* file_info_mp;
    public ACBindings.DiskDev file_man_m;
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
    // void __thiscall CLBlockAllocator::CLBlockAllocator(CLBlockAllocator*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLBlockAllocator, void>)0x00674E20)(ref this);
    // void __thiscall CLBlockAllocator::~CLBlockAllocator(CLBlockAllocator*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLBlockAllocator, void>)0x00674E40)(ref this);
    // int __thiscall CLBlockAllocator::Close_Data_File(CLBlockAllocator*)
    public int Close_Data_File() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLBlockAllocator, int>)0x00674E50)(ref this);
    // int __thiscall CLBlockAllocator::SaveFileInfo(CLBlockAllocator*)
    public int SaveFileInfo() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLBlockAllocator, int>)0x00674E70)(ref this);
    // int __thiscall CLBlockAllocator::StoreDataRollback(CLBlockAllocator*,unsigned int,int)
    public int StoreDataRollback(uint dataSize, int startOffset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLBlockAllocator, uint, int, int>)0x00674E90)(ref this, dataSize, startOffset);
    // int __thiscall CLBlockAllocator::DeleteBlocks(CLBlockAllocator*,int,int,int,bool)
    public int DeleteBlocks(int startOffset, int finalOffset, int oldFreeCount, byte fRefree) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLBlockAllocator, int, int, int, byte, int>)0x00674F50)(ref this, startOffset, finalOffset, oldFreeCount, fRefree);
    // int __thiscall CLBlockAllocator::ExpandFile(CLBlockAllocator*,int)
    public int ExpandFile(int size_l) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLBlockAllocator, int, int>)0x00675040)(ref this, size_l);
    // int __thiscall CLBlockAllocator::Store_Data(CLBlockAllocator*,Cache_Pack_t*,int)
    public int Store_Data(ACBindings.Cache_Pack_t* pack_buf, int startOffset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLBlockAllocator, ACBindings.Cache_Pack_t*, int, int>)0x00675150)(ref this, pack_buf, startOffset);
    // int __thiscall CLBlockAllocator::Update(CLBlockAllocator*,Cache_Pack_t*,int)
    public int Update(ACBindings.Cache_Pack_t* pack_buf, int inOffset) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLBlockAllocator, ACBindings.Cache_Pack_t*, int, int>)0x006752A0)(ref this, pack_buf, inOffset);
    // bool __thiscall CLBlockAllocator::Load_Data(CLBlockAllocator*,Cache_Pack_t*,int,bool)
    public byte Load_Data(ACBindings.Cache_Pack_t* buf_out, int offset, byte bShortRead) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLBlockAllocator, ACBindings.Cache_Pack_t*, int, byte, byte>)0x00675480)(ref this, buf_out, offset, bShortRead);
    // int __thiscall CLBlockAllocator::SaveTransaction(CLBlockAllocator*,DiskTransactInfo*)
    public int SaveTransaction(ACBindings.DiskTransactInfo* pTransInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLBlockAllocator, ACBindings.DiskTransactInfo*, int>)0x006755E0)(ref this, pTransInfo);
    // int __thiscall CLBlockAllocator::ClearTransaction(CLBlockAllocator*)
    public int ClearTransaction() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLBlockAllocator, int>)0x00675680)(ref this);
    // int __thiscall CLBlockAllocator::ReadTransaction(CLBlockAllocator*,DiskTransactInfo**)
    public int ReadTransaction(ACBindings.DiskTransactInfo** pTranInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLBlockAllocator, ACBindings.DiskTransactInfo**, int>)0x006756A0)(ref this, pTranInfo);
    // int __thiscall CLBlockAllocator::CreateDataFile(CLBlockAllocator*,DiskFileInfo_t*,int,int,int)
    public int CreateDataFile(ACBindings.DiskFileInfo_t* a2, int a3, int a4, int a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLBlockAllocator, ACBindings.DiskFileInfo_t*, int, int, int, int>)0x00675780)(ref this, a2, a3, a4, a5);
    // int __thiscall CLBlockAllocator::OpenDataFile(CLBlockAllocator*,volatile LONG*,int,int*,int,DiskTransactInfo**)
    public int OpenDataFile(int* lpBuffer, int a3, int* a4, int a5, ACBindings.DiskTransactInfo** pTranInfo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLBlockAllocator, int*, int, int*, int, ACBindings.DiskTransactInfo**, int>)0x00675920)(ref this, lpBuffer, a3, a4, a5, pTranInfo);
}

// gmCLCache
public unsafe struct gmCLCache
{
    // Base Classes
    public ACBindings.CLCache BaseClass_CLCache; // ACBindings.CLCache

    // Child Types
    // gmCLCache_vtbl
    public unsafe struct gmCLCache_vtbl
    {
        // Members
        public System.IntPtr IUnknown_QueryInterface; // function pointer
        public System.IntPtr IUnknown_AddRef; // function pointer
        public System.IntPtr IUnknown_Release; // function pointer
        public System.IntPtr QueryInterface; // function pointer
        public System.IntPtr AddRef; // function pointer
        public System.IntPtr Release; // function pointer
        public System.IntPtr DBCache_dtor_18; // function pointer
        public System.IntPtr You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public System.IntPtr ResetCache; // function pointer
        public System.IntPtr GetFromEnum; // function pointer
        public System.IntPtr GetDIDFromEnum;
        public System.IntPtr PreFetch; // function pointer
        public System.IntPtr InqDatIDStamp; // function pointer
        public System.IntPtr ReloadObject;
        public System.IntPtr SetShutdown; // function pointer
        public System.IntPtr IsLoader; // function pointer
        public System.IntPtr SetRegion; // function pointer
        public System.IntPtr UnloadCellData; // function pointer
        public System.IntPtr AskForLastWords; // function pointer
        public System.IntPtr SetLanguageInternal; // function pointer
        public System.IntPtr DestroyObjectCaches; // function pointer
        public System.IntPtr StopThread; // function pointer
        public System.IntPtr WorkerExecuteRequest; // function pointer
        public System.IntPtr WorkerExecuteGetRequest; // function pointer
        public System.IntPtr WorkerExecuteSaveRequest; // function pointer
        public System.IntPtr WorkerExecutePurgeRequest; // function pointer
        public System.IntPtr Init;
        public System.IntPtr Init_Internal; // function pointer
        public System.IntPtr AsyncSaveDDDMessage; // function pointer
        public System.IntPtr WorkerExecuteBeginDDDRequest; // function pointer
        public System.IntPtr OnBeginDDDRequestFinished; // function pointer

        // Methods
    }

    // Methods
    // char __thiscall gmCLCache::Init(void*,int*,char,int,char,int,int,int)
    public sbyte Init(int* a2, sbyte a3, int a4, sbyte a5, int a6, int a7, int a8) => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCLCache, int*, sbyte, int, sbyte, int, int, int, sbyte>)0x0058B870)(ref this, a2, a3, a4, a5, a6, a7, a8);
    // void __thiscall gmCLCache::Init_Internal(gmCLCache*)
    public void Init_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.gmCLCache, void>)0x0058B8F0)(ref this);
}

