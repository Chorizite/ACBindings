namespace ACBindings;

// AsyncCache
public unsafe struct AsyncCache : System.IDisposable
{
    // Child Types
    // AsyncCache_vtbl
    public unsafe struct AsyncCache_vtbl
    {
        // Members
        public System.IntPtr BlockingGet; // function pointer
        public System.IntPtr BlockingPurge; // function pointer
        public System.IntPtr BlockingSave; // function pointer
        public System.IntPtr CreateContext; // function pointer
        public fixed byte gap10[4];
        public System.IntPtr AsyncGet; // function pointer
        public System.IntPtr AsyncGetImmediate; // function pointer
        public System.IntPtr AsyncPurge; // function pointer
        public System.IntPtr AsyncSave; // function pointer
        public fixed byte gap28[8];
        public System.IntPtr AddToAsyncGet; // function pointer
        public System.IntPtr ReleaseContext; // function pointer
        public System.IntPtr GetDBOCache; // function pointer
        public System.IntPtr IsOnDisk; // function pointer
        public System.IntPtr AreOnDisk; // function pointer
        public System.IntPtr UseTime; // function pointer
        public System.IntPtr HashAndEnqueue; // function pointer
        public System.IntPtr EnqueueAsyncRequest; // function pointer
        public System.IntPtr UnhashPendingGet; // function pointer
        public System.IntPtr FlushPendingRequests; // function pointer
        public System.IntPtr OnRequestFinished; // function pointer
        public System.IntPtr OnGetRequestFinished; // function pointer
        public System.IntPtr OnSaveRequestFinished; // function pointer
        public System.IntPtr OnPurgeRequestFinished; // function pointer
        public System.IntPtr NotifyCallback; // function pointer
        public System.IntPtr OnAsyncGetFinished; // function pointer
        public System.IntPtr CallPendingCallbacks; // function pointer
        public System.IntPtr BlockingGetFromDisk; // function pointer
        public System.IntPtr BlockingLoadInto; // function pointer
        public System.IntPtr SerializeFromCachePack; // function pointer
        public System.IntPtr GetIfInMemory; // function pointer
        public System.IntPtr GetFreeObj; // function pointer
        public System.IntPtr AsyncGetFromOtherSources; // function pointer
        public System.IntPtr OnAsyncGetFromOtherSourcesFailed; // function pointer
        public System.IntPtr AddObjToDBOCache; // function pointer
        public System.IntPtr GetDiskController; // function pointer
        public System.IntPtr LoadData; // function pointer
        public System.IntPtr SaveData; // function pointer
        public System.IntPtr PurgeData; // function pointer

        // Methods
    }
    // AsyncCache::CAsyncRequest_vtbl
    public unsafe struct CAsyncRequest_vtbl
    {
        // Members
        public System.IntPtr AsyncCache; // function pointer
        public System.IntPtr bAllDependanciesDone; // function pointer
        public System.IntPtr ReadyToUnhash; // function pointer
        public System.IntPtr ReleaseDBObj; // function pointer

        // Methods
    }
    // AsyncCache::CCallbackHandler_vtbl
    public unsafe struct CCallbackHandler_vtbl
    {
        // Members
        public System.IntPtr AsyncCache; // function pointer

        // Methods
    }
    // AsyncCache::AsyncOperation
    public enum AsyncOperation : byte
    {
        opAsyncGet = 0x0,
        opAsyncPurge = 0x1,
        opAsyncSave = 0x2,
        opAsyncCacheNextAsyncOperation = 0x3
    }
    // AsyncCache::CAsyncRequest
    public unsafe struct CAsyncRequest : System.IDisposable
    {
        // Base Classes
        public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

        // Members
        public ACBindings.AsyncResult Result;
        public ACBindings._3C42703BEA86803895D02524F9B50005 ___u2;
        public ACBindings.QualifiedDataID qdid;
        public ACBindings.SmartArray__AsyncCache_CAsyncRequest_CCallbackWrapper m_pCallbacks;
        public ACBindings.DBObj* m_pObj;

        // Generated Dispose
        public void Dispose() {
            _DestructorInternal();
        }

        // Methods
        // void __thiscall AsyncCache::CAsyncRequest::AdoptDBObj(AsyncCache::CAsyncRequest*,DBObj*)
        public void AdoptDBObj(ACBindings.DBObj* pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache.CAsyncRequest, ACBindings.DBObj*, void>)0x00417660)(ref this, pObj);
        // void __thiscall AsyncCache::CAsyncRequest::ReleaseDBObj(AsyncCache::CAsyncRequest*)
        public void ReleaseDBObj() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache.CAsyncRequest, void>)0x00417680)(ref this);
        // bool __thiscall AsyncCache::CAsyncRequest::RemoveAllCallbacks(AsyncCache::CAsyncRequest*)
        public byte RemoveAllCallbacks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache.CAsyncRequest, byte>)0x004178C0)(ref this);
        // bool __thiscall AsyncCache::CAsyncRequest::RemoveCallback(AsyncCache::CAsyncRequest*,AsyncCache::CCallbackHandler*)
        public byte RemoveCallback(ACBindings.AsyncCache.CCallbackHandler* pCallback) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache.CAsyncRequest, ACBindings.AsyncCache.CCallbackHandler*, byte>)0x00417DB0)(ref this, pCallback);
        // bool __thiscall AsyncCache::CAsyncRequest::ReadyToUnhash(AsyncCache::CAsyncRequest*)
        public byte ReadyToUnhash() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache.CAsyncRequest, byte>)0x00418140)(ref this);
        // void __thiscall AsyncCache::CAsyncRequest::~CAsyncRequest(AsyncCache::CAsyncRequest*)
        public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache.CAsyncRequest, void>)0x00418150)(ref this);
        // void __thiscall AsyncCache::CAsyncRequest::AddCallback(AsyncCache::CAsyncRequest*,AsyncCache::CCallbackHandler*)
        public void AddCallback(ACBindings.AsyncCache.CCallbackHandler* pCallback) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache.CAsyncRequest, ACBindings.AsyncCache.CCallbackHandler*, void>)0x004186A0)(ref this, pCallback);
    }
    // AsyncCache::CCallbackHandler
    public unsafe struct CCallbackHandler : System.IDisposable
    {
        // Base Classes
        public ACBindings.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.ReferenceCountTemplate

        // Members
        public int m_nRequestsPending;
        public ACBindings.AsyncCacheCallback* m_pCallbackPlugin;
        public ACBindings.AsyncResult m_AccumulatedResults;
        public uint m_dwUser1;
        public ACBindings.SmartArray__AsyncCache_CAsyncRequest_ptr m_TopLevelReqs;
        public ACBindings.AsyncContext m_hContext;
        public byte m_bContextFinished;

        // Generated Dispose
        public void Dispose() {
            _DestructorInternal();
        }

        // Methods
        // void __thiscall AsyncCache::CCallbackHandler::OnContextReleased(AsyncCache::CCallbackHandler*)
        public void OnContextReleased() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache.CCallbackHandler, void>)0x00417E30)(ref this);
        // void __thiscall AsyncCache::CCallbackHandler::~CCallbackHandler(AsyncCache::CCallbackHandler*)
        public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache.CCallbackHandler, void>)0x00418300)(ref this);
        // void __thiscall AsyncCache::CCallbackHandler::AddTopLevelRequest(AsyncCache::CCallbackHandler*,AsyncCache::CAsyncRequest*)
        public void AddTopLevelRequest(ACBindings.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache.CCallbackHandler, ACBindings.AsyncCache.CAsyncRequest*, void>)0x00418C90)(ref this, pReq);
    }
    // AsyncCache::CAsyncRequest::CCallbackWrapper
    public unsafe struct CCallbackWrapper
    {
        // Members
        public ACBindings.AsyncCache.CCallbackHandler* pCallbackHandler;
        public uint dwTimesFinished;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.TDynamicCircularArray__AsyncCache_CCallbackHandler_ptr m_PendingCallbacks;
    public ACBindings.AutoGrowHashTable__QualifiedDataID__CAsyncGetRequest_ptr m_PendingGets;
    public ACBindings.AutoGrowHashTable__AsyncContext__AsyncCache_CCallbackHandler_ptr m_BusyCallbacks;
    public uint dwNextCallbackHandle;
    public byte m_bCallingPendingCallbacks;

    // Generated Constructor
    public AsyncCache() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall AsyncCache::~AsyncCache(AsyncCache*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, void>)0x00415110)(ref this);
    // void __thiscall AsyncCache::OnRequestFinished(AsyncCache*,AsyncCache::CAsyncRequest*)
    public void OnRequestFinished(ACBindings.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.AsyncCache.CAsyncRequest*, void>)0x004176D0)(ref this, pReq);
    // void __thiscall AsyncCache::OnPurgeRequestFinished(AsyncCache*,CAsyncPurgeRequest*)
    public void OnPurgeRequestFinished(ACBindings.CAsyncPurgeRequest* pPurgeReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.CAsyncPurgeRequest*, void>)0x00417700)(ref this, pPurgeReq);
    // void __thiscall AsyncCache::UseTime(AsyncCache*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, void>)0x00417710)(ref this);
    // bool __thiscall AsyncCache::AddObjToDBOCache(AsyncCache*,DBObj*,DBOCache*)
    public byte AddObjToDBOCache(ACBindings.DBObj* pObj, ACBindings.DBOCache* pObjCache) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.DBObj*, ACBindings.DBOCache*, byte>)0x00417720)(ref this, pObj, pObjCache);
    // DBObj* __thiscall AsyncCache::GetIfInMemory(DBCache*,const QualifiedDataID*,DBOCache*)
    public ACBindings.DBObj* GetIfInMemory(ACBindings.QualifiedDataID* qdid, ACBindings.DBOCache* pObjCache) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.QualifiedDataID*, ACBindings.DBOCache*, ACBindings.DBObj*>)0x00417740)(ref this, qdid, pObjCache);
    // DBObj* __thiscall AsyncCache::GetFreeObj(AsyncCache*,const QualifiedDataID*,DBOCache*)
    public ACBindings.DBObj* GetFreeObj(ACBindings.QualifiedDataID* qdid, ACBindings.DBOCache* pObjCache) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.QualifiedDataID*, ACBindings.DBOCache*, ACBindings.DBObj*>)0x00417770)(ref this, qdid, pObjCache);
    // bool __thiscall AsyncCache::LoadData(AsyncCache*,const QualifiedDataID*,Cache_Pack_t*,unsigned __int64)
    public byte LoadData(ACBindings.QualifiedDataID* qdid, ACBindings.Cache_Pack_t* Buf, ulong idDatFile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.QualifiedDataID*, ACBindings.Cache_Pack_t*, ulong, byte>)0x004177A0)(ref this, qdid, Buf, idDatFile);
    // bool __thiscall AsyncCache::PurgeData(AsyncCache*,const QualifiedDataID*,unsigned __int64)
    public byte PurgeData(ACBindings.QualifiedDataID* qdid, ulong idDatFile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.QualifiedDataID*, ulong, byte>)0x004177E0)(ref this, qdid, idDatFile);
    // bool __thiscall AsyncCache::SaveData(AsyncCache*,const QualifiedDataID*,Cache_Pack_t*,unsigned __int64)
    public byte SaveData(ACBindings.QualifiedDataID* qdid, ACBindings.Cache_Pack_t* Buf, ulong idDatFile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.QualifiedDataID*, ACBindings.Cache_Pack_t*, ulong, byte>)0x00417820)(ref this, qdid, Buf, idDatFile);
    // bool __thiscall AsyncCache::BlockingPurge(AsyncCache*,const QualifiedDataID*)
    public byte BlockingPurge(ACBindings.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.QualifiedDataID*, byte>)0x00417860)(ref this, qdid);
    // bool __thiscall AsyncCache::BlockingSave(AsyncCache*,const QualifiedDataID*,Cache_Pack_t*)
    public byte BlockingSave(ACBindings.QualifiedDataID* qdid, ACBindings.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.QualifiedDataID*, ACBindings.Cache_Pack_t*, byte>)0x00417880)(ref this, qdid, pack_buf);
    // void __thiscall AsyncCache::EnqueueAsyncRequest(AsyncCache*,AsyncCache::CAsyncRequest*)
    public void EnqueueAsyncRequest(ACBindings.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.AsyncCache.CAsyncRequest*, void>)0x00417960)(ref this, pReq);
    // void __thiscall AsyncCache::OnAsyncGetFinished(AsyncCache*,CAsyncGetRequest*)
    public void OnAsyncGetFinished(ACBindings.CAsyncGetRequest* pGetReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.CAsyncGetRequest*, void>)0x00417A30)(ref this, pGetReq);
    // bool __thiscall AsyncCache::SerializeFromCachePack(AsyncCache*,DBObj*,Cache_Pack_t*)
    public byte SerializeFromCachePack(ACBindings.DBObj* io_pObj, ACBindings.Cache_Pack_t* i_cpData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.DBObj*, ACBindings.Cache_Pack_t*, byte>)0x00417AC0)(ref this, io_pObj, i_cpData);
    // void __thiscall AsyncCache::CallPendingCallbacks(AsyncCache*)
    public void CallPendingCallbacks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, void>)0x00417BC0)(ref this);
    // bool __thiscall AsyncCache::BlockingLoadInto(AsyncCache*,DBObj*,const QualifiedDataID*,DBOCache*)
    public byte BlockingLoadInto(ACBindings.DBObj* pObj, ACBindings.QualifiedDataID* qdid, ACBindings.DBOCache* pObjCache) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.DBObj*, ACBindings.QualifiedDataID*, ACBindings.DBOCache*, byte>)0x00417C60)(ref this, pObj, qdid, pObjCache);
    // DBObj* __thiscall AsyncCache::BlockingGetFromDisk(AsyncCache*,const QualifiedDataID*,DBOCache*)
    public ACBindings.DBObj* BlockingGetFromDisk(ACBindings.QualifiedDataID* qdid, ACBindings.DBOCache* pObjCache) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.QualifiedDataID*, ACBindings.DBOCache*, ACBindings.DBObj*>)0x00417CF0)(ref this, qdid, pObjCache);
    // void __thiscall AsyncCache::AsyncGetImmediate(AsyncCache*,AsyncContext*,unsigned int,const QualifiedDataIDArray*,AsyncCacheCallback*,unsigned int)
    public void AsyncGetImmediate(ACBindings.AsyncContext* o_context, uint type, ACBindings.QualifiedDataIDArray* qdids, ACBindings.AsyncCacheCallback* pCallbackPlugin, uint dwUser1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.AsyncContext*, uint, ACBindings.QualifiedDataIDArray*, ACBindings.AsyncCacheCallback*, uint, void>)0x00417EA0)(ref this, o_context, type, qdids, pCallbackPlugin, dwUser1);
    // bool __thiscall AsyncCache::AreOnDisk(AsyncCache*,const QualifiedDataIDArray*)
    public byte AreOnDisk(ACBindings.QualifiedDataIDArray* qdids) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.QualifiedDataIDArray*, byte>)0x00417F60)(ref this, qdids);
    // void __thiscall AsyncCache::NotifyCallback(AsyncCache*,AsyncCache::CAsyncRequest*)
    public void NotifyCallback(ACBindings.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.AsyncCache.CAsyncRequest*, void>)0x00418510)(ref this, pReq);
    // CAsyncGetRequest* __thiscall AsyncCache::FormGetRequest(AsyncCache*,CAsyncGetRequest*,unsigned int,const QualifiedDataID*)
    public ACBindings.CAsyncGetRequest* FormGetRequest(ACBindings.CAsyncGetRequest* pParentReq, uint type, ACBindings.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.CAsyncGetRequest*, uint, ACBindings.QualifiedDataID*, ACBindings.CAsyncGetRequest*>)0x00418700)(ref this, pParentReq, type, qdid);
    // void __thiscall AsyncCache::OnSaveRequestFinished(AsyncCache*,CAsyncSaveRequest*)
    public void OnSaveRequestFinished(ACBindings.CAsyncSaveRequest* pSaveReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.CAsyncSaveRequest*, void>)0x004187A0)(ref this, pSaveReq);
    // bool __thiscall AsyncCache::IsOnDisk(AsyncCache*,const QualifiedDataID*)
    public byte IsOnDisk(ACBindings.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.QualifiedDataID*, byte>)0x00418840)(ref this, qdid);
    // DBObj* __thiscall AsyncCache::BlockingGet(AsyncCache*,unsigned int,const QualifiedDataID*)
    public ACBindings.DBObj* BlockingGet(uint type, ACBindings.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, uint, ACBindings.QualifiedDataID*, ACBindings.DBObj*>)0x004188D0)(ref this, type, qdid);
    // void __thiscall AsyncCache::OnAsyncGetFromOtherSourcesFailed(AsyncCache*,const QualifiedDataID*)
    public void OnAsyncGetFromOtherSourcesFailed(ACBindings.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.QualifiedDataID*, void>)0x004189D0)(ref this, qdid);
    // bool __thiscall AsyncCache::AddToAsyncGet(AsyncCache*,AsyncContext,unsigned int,const QualifiedDataIDArray*)
    public byte AddToAsyncGet(ACBindings.AsyncContext context, uint type, ACBindings.QualifiedDataIDArray* qdids) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.AsyncContext, uint, ACBindings.QualifiedDataIDArray*, byte>)0x00418CF0)(ref this, context, type, qdids);
    // char __thiscall AsyncCache::AddToAsyncGet(AsyncCache*,unsigned int,int*)
    public sbyte AddToAsyncGet(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, uint, int*, sbyte>)0x00418EC0)(ref this, a2, a3);
    // void __thiscall AsyncCache::FilterSubDataIDs(AsyncCache*,QualifiedDataIDArray*,unsigned int)
    public void FilterSubDataIDs(ACBindings.QualifiedDataIDArray* io_qdids, uint i_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.QualifiedDataIDArray*, uint, void>)0x00419170)(ref this, io_qdids, i_type);
    // void __thiscall AsyncCache::OnGetRequestFinished(AsyncCache*,CAsyncGetRequest*)
    public void OnGetRequestFinished(ACBindings.CAsyncGetRequest* pGetReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.CAsyncGetRequest*, void>)0x00419330)(ref this, pGetReq);
    // AsyncCache::CCallbackHandler* __thiscall AsyncCache::AllocateCallback(AsyncCache*,AsyncCacheCallback*,unsigned int,unsigned int)
    public ACBindings.AsyncCache.CCallbackHandler* AllocateCallback(ACBindings.AsyncCacheCallback* pCallbackPlugin, uint dwUser1, uint nRequests) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.AsyncCacheCallback*, uint, uint, ACBindings.AsyncCache.CCallbackHandler*>)0x00419530)(ref this, pCallbackPlugin, dwUser1, nRequests);
    // AsyncContext* __thiscall AsyncCache::CreateContext(AsyncCache*,AsyncContext*,AsyncCacheCallback*,unsigned int)
    public ACBindings.AsyncContext* CreateContext(ACBindings.AsyncContext* result, ACBindings.AsyncCacheCallback* i_pcCallbackPlugin, uint i_dwUser) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.AsyncContext*, ACBindings.AsyncCacheCallback*, uint, ACBindings.AsyncContext*>)0x004195F0)(ref this, result, i_pcCallbackPlugin, i_dwUser);
    // AsyncContext* __thiscall AsyncCache::AsyncGet(AsyncCache*,AsyncContext*,unsigned int,const QualifiedDataID*,AsyncCacheCallback*,unsigned int)
    public ACBindings.AsyncContext* AsyncGet(ACBindings.AsyncContext* result, uint type, ACBindings.QualifiedDataID* qdid, ACBindings.AsyncCacheCallback* pCallbackPlugin, uint dwUser1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.AsyncContext*, uint, ACBindings.QualifiedDataID*, ACBindings.AsyncCacheCallback*, uint, ACBindings.AsyncContext*>)0x00419640)(ref this, result, type, qdid, pCallbackPlugin, dwUser1);
    // AsyncContext* __thiscall AsyncCache::AsyncGet(AsyncCache*,AsyncContext*,unsigned int,const QualifiedDataIDArray*,AsyncCacheCallback*,unsigned int)
    public ACBindings.AsyncContext* AsyncGet(ACBindings.AsyncContext* result, uint type, ACBindings.QualifiedDataIDArray* qdids, ACBindings.AsyncCacheCallback* pCallbackPlugin, uint dwUser1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.AsyncContext*, uint, ACBindings.QualifiedDataIDArray*, ACBindings.AsyncCacheCallback*, uint, ACBindings.AsyncContext*>)0x004196F0)(ref this, result, type, qdids, pCallbackPlugin, dwUser1);
    // AsyncContext* __thiscall AsyncCache::AsyncPurge(AsyncCache*,AsyncContext*,const QualifiedDataID*,AsyncCacheCallback*,unsigned int)
    public ACBindings.AsyncContext* AsyncPurge(ACBindings.AsyncContext* result, ACBindings.QualifiedDataID* qdid, ACBindings.AsyncCacheCallback* pCallbackPlugin, uint dwUser1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.AsyncContext*, ACBindings.QualifiedDataID*, ACBindings.AsyncCacheCallback*, uint, ACBindings.AsyncContext*>)0x00419850)(ref this, result, qdid, pCallbackPlugin, dwUser1);
    // AsyncContext* __thiscall AsyncCache::AsyncPurge(AsyncCache*,AsyncContext*,const QualifiedDataIDArray*,AsyncCacheCallback*,unsigned int)
    public ACBindings.AsyncContext* AsyncPurge(ACBindings.AsyncContext* result, ACBindings.QualifiedDataIDArray* qdids, ACBindings.AsyncCacheCallback* pCallbackPlugin, uint dwUser1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.AsyncContext*, ACBindings.QualifiedDataIDArray*, ACBindings.AsyncCacheCallback*, uint, ACBindings.AsyncContext*>)0x00419940)(ref this, result, qdids, pCallbackPlugin, dwUser1);
    // AsyncContext* __thiscall AsyncCache::AsyncSave(AsyncCache*,AsyncContext*,const QualifiedDataID*,Cache_Pack_t*,unsigned __int64,AsyncCacheCallback*,unsigned int)
    public ACBindings.AsyncContext* AsyncSave(ACBindings.AsyncContext* result, ACBindings.QualifiedDataID* qdid, ACBindings.Cache_Pack_t* pack_buf, ulong idDestination, ACBindings.AsyncCacheCallback* pCallbackPlugin, uint dwUser1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.AsyncContext*, ACBindings.QualifiedDataID*, ACBindings.Cache_Pack_t*, ulong, ACBindings.AsyncCacheCallback*, uint, ACBindings.AsyncContext*>)0x004199A0)(ref this, result, qdid, pack_buf, idDestination, pCallbackPlugin, dwUser1);
    // void __thiscall AsyncCache::HashAndEnqueue(AsyncCache*,CAsyncGetRequest*)
    public void HashAndEnqueue(ACBindings.CAsyncGetRequest* pGetReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.CAsyncGetRequest*, void>)0x00419AA0)(ref this, pGetReq);
    // void __thiscall AsyncCache::UnhashPendingGet(AsyncCache*,CAsyncGetRequest*,CAsyncGetRequest*)
    public void UnhashPendingGet(ACBindings.CAsyncGetRequest* pGetReq, ACBindings.CAsyncGetRequest* pParentReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.CAsyncGetRequest*, ACBindings.CAsyncGetRequest*, void>)0x00419AF0)(ref this, pGetReq, pParentReq);
    // void __thiscall AsyncCache::ReleaseContext(AsyncCache*,AsyncContext)
    public void ReleaseContext(ACBindings.AsyncContext hContext) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.AsyncContext, void>)0x00419BC0)(ref this, hContext);
    // void __thiscall AsyncCache::FlushPendingRequests(AsyncCache*)
    public void FlushPendingRequests() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, void>)0x00419C40)(ref this);
    // bool __thiscall AsyncCache::IsWaitingFor(AsyncCache*,CAsyncGetRequest*,CAsyncGetRequest*)
    public byte IsWaitingFor(ACBindings.CAsyncGetRequest* pGetFrom, ACBindings.CAsyncGetRequest* pGetTo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, ACBindings.CAsyncGetRequest*, ACBindings.CAsyncGetRequest*, byte>)0x00419D10)(ref this, pGetFrom, pGetTo);
    // bool __thiscall AsyncCache::AddToAsyncGet(AsyncCache*,unsigned int,const QualifiedDataIDArray*,void*)
    public byte AddToAsyncGet(uint type, ACBindings.QualifiedDataIDArray* qdids, System.IntPtr hInternal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, uint, ACBindings.QualifiedDataIDArray*, System.IntPtr, byte>)0x00419FF0)(ref this, type, qdids, hInternal);
    // void __thiscall AsyncCache::AsyncCache(AsyncCache*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, void>)0x0041A210)(ref this);
    // bool __thiscall AsyncCache::AsyncGetFromOtherSources(UIPreferenceItem*,const float,const float)
    public byte AsyncGetFromOtherSources(float i_nMin, float i_nMax) => ((delegate* unmanaged[Thiscall]<ref ACBindings.AsyncCache, float, float, byte>)0x006A1040)(ref this, i_nMin, i_nMax);
}

