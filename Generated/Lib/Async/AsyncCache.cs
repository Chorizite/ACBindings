namespace ACBindings.Internal;


/// <summary>Coordinates asynchronous caching operations for database objects, tracking pending requests, callback handlers, and active contexts. Provides a thread‑safety mechanism to retrieve, save, or purge data via async requests while managing their lifecycle.</summary>
public unsafe struct AsyncCache : System.IDisposable
{
    // Child Types

    /// <summary>Function table exposing asynchronous cache operations, supporting blocking and non‑blocking get, save, and purge requests across memory and disk layers.</summary>
    public unsafe struct AsyncCache_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, uint, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.DBObj*> BlockingGet; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.QualifiedDataID*, byte> BlockingPurge; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.Cache_Pack_t*, byte> BlockingSave; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.AsyncContext*, ACBindings.Internal.AsyncCacheCallback*, uint, ACBindings.Internal.AsyncContext*> CreateContext; // function pointer
        public fixed byte gap10[4];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.AsyncContext*, uint, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.AsyncCacheCallback*, uint, ACBindings.Internal.AsyncContext*> AsyncGet; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.AsyncContext*, uint, ACBindings.Internal.QualifiedDataIDArray*, ACBindings.Internal.AsyncCacheCallback*, uint, void> AsyncGetImmediate; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.AsyncContext*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.AsyncCacheCallback*, uint, ACBindings.Internal.AsyncContext*> AsyncPurge; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.AsyncContext*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.Cache_Pack_t*, ulong, ACBindings.Internal.AsyncCacheCallback*, uint, ACBindings.Internal.AsyncContext*> AsyncSave; // function pointer
        public fixed byte gap28[8];
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.AsyncContext, uint, ACBindings.Internal.QualifiedDataIDArray*, byte> AddToAsyncGet; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.AsyncContext, void> ReleaseContext; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.DBOCache*> GetDBOCache; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.QualifiedDataID*, byte> IsOnDisk; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.QualifiedDataIDArray*, byte> AreOnDisk; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, void> UseTime; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.CAsyncGetRequest*, void> HashAndEnqueue; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.AsyncCache.CAsyncRequest*, void> EnqueueAsyncRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.CAsyncGetRequest*, ACBindings.Internal.CAsyncGetRequest*, void> UnhashPendingGet; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, void> FlushPendingRequests; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.AsyncCache.CAsyncRequest*, void> OnRequestFinished; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.CAsyncGetRequest*, void> OnGetRequestFinished; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.CAsyncSaveRequest*, void> OnSaveRequestFinished; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.CAsyncPurgeRequest*, void> OnPurgeRequestFinished; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.AsyncCache.CAsyncRequest*, void> NotifyCallback; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.CAsyncGetRequest*, void> OnAsyncGetFinished; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, void> CallPendingCallbacks; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.DBOCache*, ACBindings.Internal.DBObj*> BlockingGetFromDisk; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.DBOCache*, byte> BlockingLoadInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.DBObj*, ACBindings.Internal.Cache_Pack_t*, byte> SerializeFromCachePack; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.DBOCache*, ACBindings.Internal.DBObj*> GetIfInMemory; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.DBOCache*, ACBindings.Internal.DBObj*> GetFreeObj; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.DBOCache*, byte> AsyncGetFromOtherSources; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.QualifiedDataID*, void> OnAsyncGetFromOtherSourcesFailed; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.DBObj*, ACBindings.Internal.DBOCache*, byte> AddObjToDBOCache; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.QualifiedDataID*, ulong, ACBindings.Internal.DiskController*> GetDiskController; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.Cache_Pack_t*, ulong, byte> LoadData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.Cache_Pack_t*, ulong, byte> SaveData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache*, ACBindings.Internal.QualifiedDataID*, ulong, byte> PurgeData; // function pointer

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

    /// <summary>
    /// Handles asynchronous cache requests by maintaining the operation result, associated callbacks, qualified data identifier, and target database object.
    /// </summary>
    public unsafe struct CAsyncRequest : System.IDisposable
    {
        // Base Classes
        public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

        // Child Types
        public unsafe struct CAsyncRequest_vtbl
        {
            // Members
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache.CAsyncRequest*, void> AsyncCache; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache.CAsyncRequest*, byte> bAllDependanciesDone; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache.CAsyncRequest*, byte> ReadyToUnhash; // function pointer
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache.CAsyncRequest*, void> ReleaseDBObj; // function pointer

            // Methods
        }

        /// <summary>Wraps a callback handler used by an asynchronous cache request and tracks how many times the operation has completed.</summary>
        public unsafe struct CCallbackWrapper
        {
            // Members
            public ACBindings.Internal.AsyncCache.CCallbackHandler* pCallbackHandler;
            public uint dwTimesFinished;

            // Methods
        }

        // Members
        public ACBindings.Internal.AsyncResult Result;
        public ACBindings.Internal._3C42703BEA86803895D02524F9B50005 ___u2;
        public ACBindings.Internal.QualifiedDataID qdid;
        public ACBindings.Internal.SmartArray___AsyncCache_CAsyncRequest_CCallbackWrapper m_pCallbacks;
        public ACBindings.Internal.DBObj* m_pObj;

        // Generated Dispose
        public void Dispose() {
            _DestructorInternal();
        }

        // Methods

        /// <summary>Adopts a database object into this asynchronous request, preparing it for use.
        /// <code>Offset: 0x00417660
        /// void __thiscall AsyncCache::CAsyncRequest::AdoptDBObj(AsyncCache::CAsyncRequest*,DBObj*)</code>
        /// </summary>
        /// <param name="pObj">The DBObj instance to associate with the request.</param>
        public void AdoptDBObj(ACBindings.Internal.DBObj* pObj) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache.CAsyncRequest, ACBindings.Internal.DBObj*, void>)0x00417660)(ref this, pObj);

        /// <summary>Releases the associated DBObj by decrementing its reference count through the base class's Release method and clears the request’s object pointer to prevent further use.
        /// <code>Offset: 0x00417680
        /// void __thiscall AsyncCache::CAsyncRequest::ReleaseDBObj(AsyncCache::CAsyncRequest*)</code>
        /// </summary>
        public void ReleaseDBObj() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache.CAsyncRequest, void>)0x00417680)(ref this);

        /// <summary>Detaches all callbacks from the async request, decrementing reference counts on each callback handler and clearing the internal list.
        /// <code>Offset: 0x004178C0
        /// bool __thiscall AsyncCache::CAsyncRequest::RemoveAllCallbacks(AsyncCache::CAsyncRequest*)</code>
        /// </summary>
        /// <returns>Always true to indicate successful removal of callbacks.</returns>
        public byte RemoveAllCallbacks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache.CAsyncRequest, byte>)0x004178C0)(ref this);

        /// <summary>Removes a callback from this request, updating the internal array and decrementing its reference count. Returns true when removal succeeds, or false if the callback was not found.
        /// <code>Offset: 0x00417DB0
        /// bool __thiscall AsyncCache::CAsyncRequest::RemoveCallback(AsyncCache::CAsyncRequest*,AsyncCache::CCallbackHandler*)</code>
        /// </summary>
        /// <param name="pCallback">The callback handler to remove from the request.</param>
        /// <returns>True if the callback was successfully removed; otherwise, false.</returns>
        public byte RemoveCallback(ACBindings.Internal.AsyncCache.CCallbackHandler* pCallback) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache.CAsyncRequest, ACBindings.Internal.AsyncCache.CCallbackHandler*, byte>)0x00417DB0)(ref this, pCallback);

        /// <summary>Determines whether the async request has a reference count of two, indicating readiness for unhashing.
        /// <code>Offset: 0x00418140
        /// bool __thiscall AsyncCache::CAsyncRequest::ReadyToUnhash(AsyncCache::CAsyncRequest*)</code>
        /// </summary>
        /// <returns>True when the internal reference counter equals two, signaling that the request can be removed from the cache; otherwise false.</returns>
        public byte ReadyToUnhash() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache.CAsyncRequest, byte>)0x00418140)(ref this);

        /// <summary>Destroys an asynchronous request by releasing the associated database object, freeing any stored callback wrappers, and restoring base class virtual tables.
        /// <code>Offset: 0x00418150
        /// void __thiscall AsyncCache::CAsyncRequest::~CAsyncRequest(AsyncCache::CAsyncRequest*)</code>
        /// </summary>
        public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache.CAsyncRequest, void>)0x00418150)(ref this);

        /// <summary>Adds a callback handler to this async request and increments its reference counter for lifetime management.
        /// <code>Offset: 0x004186A0
        /// void __thiscall AsyncCache::CAsyncRequest::AddCallback(AsyncCache::CAsyncRequest*,AsyncCache::CCallbackHandler*)</code>
        /// </summary>
        /// <param name="pCallback">The callback handler to be invoked when the request completes.</param>
        public void AddCallback(ACBindings.Internal.AsyncCache.CCallbackHandler* pCallback) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache.CAsyncRequest, ACBindings.Internal.AsyncCache.CCallbackHandler*, void>)0x004186A0)(ref this, pCallback);
    }

    /// <summary>Manages callbacks for asynchronous cache operations, tracking pending requests, accumulating results, and handling the lifecycle of request contexts within the AsyncCache system.</summary>
    public unsafe struct CCallbackHandler : System.IDisposable
    {
        // Base Classes
        public ACBindings.Internal.ReferenceCountTemplate BaseClass_ReferenceCountTemplate; // ACBindings.Internal.ReferenceCountTemplate

        // Child Types
        public unsafe struct CCallbackHandler_vtbl
        {
            // Members
            public static delegate* unmanaged[Thiscall]<ACBindings.Internal.AsyncCache.CCallbackHandler*, void> AsyncCache; // function pointer

            // Methods
        }

        // Members
        public int m_nRequestsPending;
        public ACBindings.Internal.AsyncCacheCallback* m_pCallbackPlugin;
        public ACBindings.Internal.AsyncResult m_AccumulatedResults;
        public uint m_dwUser1;
        public ACBindings.Internal.SmartArray___AsyncCache_CAsyncRequest_ptr m_TopLevelReqs;
        public ACBindings.Internal.AsyncContext m_hContext;
        public byte m_bContextFinished;

        // Generated Dispose
        public void Dispose() {
            _DestructorInternal();
        }

        // Methods

        /// <summary>Releases an asynchronous context by detaching this handler from all pending top‑level requests, decrementing their reference counts, releasing any that become unused, and resetting the handler’s internal state.
        /// <code>Offset: 0x00417E30
        /// void __thiscall AsyncCache::CCallbackHandler::OnContextReleased(AsyncCache::CCallbackHandler*)</code>
        /// </summary>
        public void OnContextReleased() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache.CCallbackHandler, void>)0x00417E30)(ref this);

        /// <summary>Destroys the callback handler, removing all registered callbacks from its top‑level requests and decreasing their reference counts. If the internal request array was dynamically allocated, it is freed before the destructor completes.
        /// <code>Offset: 0x00418300
        /// void __thiscall AsyncCache::CCallbackHandler::~CCallbackHandler(AsyncCache::CCallbackHandler*)</code>
        /// </summary>
        public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache.CCallbackHandler, void>)0x00418300)(ref this);

        /// <summary>Adds an asynchronous request to the handler's top‑level list, incrementing its reference count and registering the handler as a callback.
        /// <code>Offset: 0x00418C90
        /// void __thiscall AsyncCache::CCallbackHandler::AddTopLevelRequest(AsyncCache::CCallbackHandler*,AsyncCache::CAsyncRequest*)</code>
        /// </summary>
        /// <param name="pReq">The request to add.</param>
        public void AddTopLevelRequest(ACBindings.Internal.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache.CCallbackHandler, ACBindings.Internal.AsyncCache.CAsyncRequest*, void>)0x00418C90)(ref this, pReq);
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.TDynamicCircularArray___AsyncCache_CCallbackHandler_ptr m_PendingCallbacks;
    public ACBindings.Internal.AutoGrowHashTable___QualifiedDataID___CAsyncGetRequest_ptr m_PendingGets;
    public ACBindings.Internal.AutoGrowHashTable___AsyncContext___AsyncCache_CCallbackHandler_ptr m_BusyCallbacks;
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

    /// <summary>Destroys an AsyncCache instance, freeing all allocated callback handlers, pending get requests, and internal hash tables.
    /// <code>Offset: 0x00415110
    /// void __thiscall AsyncCache::~AsyncCache(AsyncCache*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, void>)0x00415110)(ref this);

    /// <summary>Handles completion of an asynchronous cache request by delegating to the appropriate handler based on the request type.
    /// <code>Offset: 0x004176D0
    /// void __thiscall AsyncCache::OnRequestFinished(AsyncCache*,AsyncCache::CAsyncRequest*)</code>
    /// </summary>
    /// <param name="pReq">The completed async request whose result is processed.</param>
    public void OnRequestFinished(ACBindings.Internal.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.AsyncCache.CAsyncRequest*, void>)0x004176D0)(ref this, pReq);

    /// <summary>Notifies registered callbacks that a purge operation has finished.
    /// <code>Offset: 0x00417700
    /// void __thiscall AsyncCache::OnPurgeRequestFinished(AsyncCache*,CAsyncPurgeRequest*)</code>
    /// </summary>
    /// <param name="pPurgeReq">The completed purge request.</param>
    public void OnPurgeRequestFinished(ACBindings.Internal.CAsyncPurgeRequest* pPurgeReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.CAsyncPurgeRequest*, void>)0x00417700)(ref this, pPurgeReq);

    /// <summary>Executes all queued callbacks stored in the async cache, ensuring that pending asynchronous operations are processed.
    /// <code>Offset: 0x00417710
    /// void __thiscall AsyncCache::UseTime(AsyncCache*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, void>)0x00417710)(ref this);

    /// <summary>Adds a DBObj to the given DBOCache when available, delegating to the cache's AddObj method.
    /// <code>Offset: 0x00417720
    /// bool __thiscall AsyncCache::AddObjToDBOCache(AsyncCache*,DBObj*,DBOCache*)</code>
    /// </summary>
    /// <param name="pObj">The database object to add.</param>
    /// <param name="pObjCache">The target cache; must not be null for the operation to succeed.</param>
    /// <returns>True if the object was added successfully; otherwise false.</returns>
    public byte AddObjToDBOCache(ACBindings.Internal.DBObj* pObj, ACBindings.Internal.DBOCache* pObjCache) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.DBObj*, ACBindings.Internal.DBOCache*, byte>)0x00417720)(ref this, pObj, pObjCache);

    /// <summary>
    /// Retrieves a database object from the specified cache when it is already loaded in memory, otherwise returns null.
    /// 
    /// <code>Offset: 0x00417740
    /// DBObj* __thiscall AsyncCache::GetIfInMemory(DBCache*,const QualifiedDataID*,DBOCache*)</code>
    /// </summary>
    /// <param name="qdid">Identifier specifying the data object to retrieve.</param>
    /// <param name="pObjCache">The cache to search; if null, the function returns null.</param>
    /// <returns>Pointer to the requested DBObj if present and loaded; otherwise nullptr.</returns>
    public ACBindings.Internal.DBObj* GetIfInMemory(ACBindings.Internal.QualifiedDataID* qdid, ACBindings.Internal.DBOCache* pObjCache) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.DBOCache*, ACBindings.Internal.DBObj*>)0x00417740)(ref this, qdid, pObjCache);

    /// <summary>Attempts to retrieve a free database object from the supplied cache; if found, releases it under the provided QualifiedDataID before returning it.
    /// <code>Offset: 0x00417770
    /// DBObj* __thiscall AsyncCache::GetFreeObj(AsyncCache*,const QualifiedDataID*,DBOCache*)</code>
    /// </summary>
    /// <param name="qdid">Identifier used when releasing the retrieved object.</param>
    /// <param name="pObjCache">Cache from which to obtain a free object; may be null.</param>
    /// <returns>Pointer to the obtained DBObj, or nullptr if no cache is provided or no free object exists.</returns>
    public ACBindings.Internal.DBObj* GetFreeObj(ACBindings.Internal.QualifiedDataID* qdid, ACBindings.Internal.DBOCache* pObjCache) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.DBOCache*, ACBindings.Internal.DBObj*>)0x00417770)(ref this, qdid, pObjCache);

    /// <summary>Loads the data associated with the specified QualifiedDataID from disk into the provided Cache_Pack_t buffer.
    /// <code>Offset: 0x004177A0
    /// bool __thiscall AsyncCache::LoadData(AsyncCache*,const QualifiedDataID*,Cache_Pack_t*,unsigned __int64)</code>
    /// </summary>
    /// <param name="qdid">The qualified identifier of the data to load.</param>
    /// <param name="Buf">The buffer that receives the loaded data.</param>
    /// <param name="idDatFile">A 64‑bit file identifier indicating the data file containing the requested entry.</param>
    /// <returns>True if the data was successfully retrieved and stored in Buf; otherwise, false. </returns>
    public byte LoadData(ACBindings.Internal.QualifiedDataID* qdid, ACBindings.Internal.Cache_Pack_t* Buf, ulong idDatFile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.Cache_Pack_t*, ulong, byte>)0x004177A0)(ref this, qdid, Buf, idDatFile);

    /// <summary>Purge cached data identified by a qualified data ID and a 64‑bit dat file identifier, removing any associated entries from the cache.
    /// <code>Offset: 0x004177E0
    /// bool __thiscall AsyncCache::PurgeData(AsyncCache*,const QualifiedDataID*,unsigned __int64)</code>
    /// </summary>
    /// <param name="qdid">The qualified data ID specifying which data to purge.</param>
    /// <param name="idDatFile">A 64‑bit identifier for the dat file whose cached entries should be removed.</param>
    /// <returns>True if the purge operation succeeded; otherwise, false.</returns>
    public byte PurgeData(ACBindings.Internal.QualifiedDataID* qdid, ulong idDatFile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.QualifiedDataID*, ulong, byte>)0x004177E0)(ref this, qdid, idDatFile);

    /// <summary>Stores the supplied cache pack into persistent storage associated with the specified data ID, using the disk controller corresponding to the provided dat file identifier.
    /// <code>Offset: 0x00417820
    /// bool __thiscall AsyncCache::SaveData(AsyncCache*,const QualifiedDataID*,Cache_Pack_t*,unsigned __int64)</code>
    /// </summary>
    /// <param name="qdid">Identifier of the data to be cached.</param>
    /// <param name="Buf">Buffer containing the packed data to store.</param>
    /// <param name="idDatFile">64‑bit identifier of the target dat file for the operation.</param>
    /// <returns>True if the data was written successfully; otherwise, false.</returns>
    public byte SaveData(ACBindings.Internal.QualifiedDataID* qdid, ACBindings.Internal.Cache_Pack_t* Buf, ulong idDatFile) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.Cache_Pack_t*, ulong, byte>)0x00417820)(ref this, qdid, Buf, idDatFile);

    /// <summary>Purges the specified data entry from the cache synchronously and blocks until completion.
    /// <code>Offset: 0x00417860
    /// bool __thiscall AsyncCache::BlockingPurge(AsyncCache*,const QualifiedDataID*)</code>
    /// </summary>
    /// <param name="qdid">Identifier of the data to be removed.</param>
    /// <returns>True if the purge succeeded; otherwise false.</returns>
    public byte BlockingPurge(ACBindings.Internal.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.QualifiedDataID*, byte>)0x00417860)(ref this, qdid);

    /// <summary>Saves the supplied pack buffer into the cache under the specified identifier by delegating to SaveData.
    /// <code>Offset: 0x00417880
    /// bool __thiscall AsyncCache::BlockingSave(AsyncCache*,const QualifiedDataID*,Cache_Pack_t*)</code>
    /// </summary>
    /// <param name="qdid">Qualified data ID specifying where the data should be stored.</param>
    /// <param name="pack_buf">Buffer containing the data to be cached.</param>
    /// <returns>True if the save operation succeeds; otherwise, false.</returns>
    public byte BlockingSave(ACBindings.Internal.QualifiedDataID* qdid, ACBindings.Internal.Cache_Pack_t* pack_buf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.Cache_Pack_t*, byte>)0x00417880)(ref this, qdid, pack_buf);

    /// <summary>Executes a cache operation (get, save or purge) described by the supplied CAsyncRequest and records its result before triggering completion callbacks.
    /// <code>Offset: 0x00417960
    /// void __thiscall AsyncCache::EnqueueAsyncRequest(AsyncCache*,AsyncCache::CAsyncRequest*)</code>
    /// </summary>
    /// <param name="this">The AsyncCache instance handling the request.</param>
    /// <param name="pReq">Pointer to the request object containing operation type, target data ID, and callback information.</param>
    public void EnqueueAsyncRequest(ACBindings.Internal.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.AsyncCache.CAsyncRequest*, void>)0x00417960)(ref this, pReq);

    /// <summary>Finalizes an asynchronous get request, propagating its result to dependent requests and invoking any pending callbacks once all related operations complete.
    /// <code>Offset: 0x00417A30
    /// void __thiscall AsyncCache::OnAsyncGetFinished(AsyncCache*,CAsyncGetRequest*)</code>
    /// </summary>
    /// <param name="pGetReq">The completed asynchronous get request that may have spawned other waiting requests.</param>
    public void OnAsyncGetFinished(ACBindings.Internal.CAsyncGetRequest* pGetReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.CAsyncGetRequest*, void>)0x00417A30)(ref this, pGetReq);

    /// <summary>Deserializes a DBObj from a Cache_Pack_t buffer when the pack’s version is supported by the current core SDK and returns whether the operation succeeded.
    /// <code>Offset: 0x00417AC0
    /// bool __thiscall AsyncCache::SerializeFromCachePack(AsyncCache*,DBObj*,Cache_Pack_t*)</code>
    /// </summary>
    /// <param name="io_pObj">Database object to populate with data extracted from the cache pack.</param>
    /// <param name="i_cpData">Cache pack containing serialized data and its version information.</param>
    /// <returns>True if deserialization completed successfully; otherwise false (e.g., unsupported version or error during unpacking).</returns>
    public byte SerializeFromCachePack(ACBindings.Internal.DBObj* io_pObj, ACBindings.Internal.Cache_Pack_t* i_cpData) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.DBObj*, ACBindings.Internal.Cache_Pack_t*, byte>)0x00417AC0)(ref this, io_pObj, i_cpData);

    /// <summary>Processes queued asynchronous callbacks, invoking each handler while limiting execution to roughly 25 milliseconds per call and safeguarding against reentrant invocation.
    /// <code>Offset: 0x00417BC0
    /// void __thiscall AsyncCache::CallPendingCallbacks(AsyncCache*)</code>
    /// </summary>
    public void CallPendingCallbacks() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, void>)0x00417BC0)(ref this);

    /// <summary>Attempts to synchronously load the data identified by a QualifiedDataID into a DBObj from the associated DBOCache. The operation succeeds only when loading, deserialization, and identifier verification all succeed.
    /// <code>Offset: 0x00417C60
    /// bool __thiscall AsyncCache::BlockingLoadInto(AsyncCache*,DBObj*,const QualifiedDataID*,DBOCache*)</code>
    /// </summary>
    /// <param name="pObj">The database object to populate with loaded data.</param>
    /// <param name="qdid">Qualified ID specifying which data to retrieve.</param>
    /// <param name="pObjCache">Cache from which the data is read; used internally by helper methods.</param>
    /// <returns>True if the data was successfully loaded, deserialized, and its identifier matches qdid; otherwise false.</returns>
    public byte BlockingLoadInto(ACBindings.Internal.DBObj* pObj, ACBindings.Internal.QualifiedDataID* qdid, ACBindings.Internal.DBOCache* pObjCache) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.DBOCache*, byte>)0x00417C60)(ref this, pObj, qdid, pObjCache);

    /// <summary>Retrieves a database object from disk, blocking until the data has been fully loaded and inserted into the specified cache.
    /// <code>Offset: 0x00417CF0
    /// DBObj* __thiscall AsyncCache::BlockingGetFromDisk(AsyncCache*,const QualifiedDataID*,DBOCache*)</code>
    /// </summary>
    /// <param name="qdid">Identifier of the desired database object.</param>
    /// <param name="pObjCache">The cache to which the loaded object will be added if loading succeeds.</param>
    /// <returns>Pointer to the loaded DBObj on success; null if loading fails or the identifier is invalid. Any temporarily allocated object that cannot be used is released before returning null.</returns>
    public ACBindings.Internal.DBObj* BlockingGetFromDisk(ACBindings.Internal.QualifiedDataID* qdid, ACBindings.Internal.DBOCache* pObjCache) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.DBOCache*, ACBindings.Internal.DBObj*>)0x00417CF0)(ref this, qdid, pObjCache);

    /// <summary>Initiates an immediate asynchronous data retrieval, associates the result with a given context and triggers any matching pending callbacks.
    /// <code>Offset: 0x00417EA0
    /// void __thiscall AsyncCache::AsyncGetImmediate(AsyncCache*,AsyncContext*,unsigned int,const QualifiedDataIDArray*,AsyncCacheCallback*,unsigned int)</code>
    /// </summary>
    /// <param name="o_context">Context object to receive the operation's identifier.</param>
    /// <param name="type">Identifier of the request type.</param>
    /// <param name="qdids">Array of qualified data IDs to fetch.</param>
    /// <param name="pCallbackPlugin">Callback plugin invoked when the data is available.</param>
    /// <param name="dwUser1">User-supplied identifier passed through the operation.</param>
    public void AsyncGetImmediate(ACBindings.Internal.AsyncContext* o_context, uint type, ACBindings.Internal.QualifiedDataIDArray* qdids, ACBindings.Internal.AsyncCacheCallback* pCallbackPlugin, uint dwUser1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.AsyncContext*, uint, ACBindings.Internal.QualifiedDataIDArray*, ACBindings.Internal.AsyncCacheCallback*, uint, void>)0x00417EA0)(ref this, o_context, type, qdids, pCallbackPlugin, dwUser1);

    /// <summary>Verifies that each qualified data ID in the supplied array is stored on disk.
    /// <code>Offset: 0x00417F60
    /// bool __thiscall AsyncCache::AreOnDisk(AsyncCache*,const QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="qdids">The collection of qualified data IDs to verify. Must not be null; an empty collection yields true.</param>
    /// <returns>True when every referenced ID exists on disk; otherwise false.</returns>
    public byte AreOnDisk(ACBindings.Internal.QualifiedDataIDArray* qdids) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.QualifiedDataIDArray*, byte>)0x00417F60)(ref this, qdids);

    /// <summary>Handles completion of an async request by invoking its callbacks, notifying any registered plugins about the top‑level finish, updating dependent requests’ result types, and queuing newly ready requests for later processing.
    /// <code>Offset: 0x00418510
    /// void __thiscall AsyncCache::NotifyCallback(AsyncCache*,AsyncCache::CAsyncRequest*)</code>
    /// </summary>
    /// <param name="this">The AsyncCache instance that owns the pending requests.</param>
    /// <param name="pReq">The asynchronous request that has just finished and whose callbacks should be processed.</param>
    public void NotifyCallback(ACBindings.Internal.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.AsyncCache.CAsyncRequest*, void>)0x00418510)(ref this, pReq);

    /// <summary>Retrieves an existing asynchronous get request for the specified QualifiedDataID or creates a new one, initializing it with the given type and database cache reference. If a pending request already exists, its reference count is incremented and returned; otherwise a fresh request object is allocated and configured.
    /// <code>Offset: 0x00418700
    /// CAsyncGetRequest* __thiscall AsyncCache::FormGetRequest(AsyncCache*,CAsyncGetRequest*,unsigned int,const QualifiedDataID*)</code>
    /// </summary>
    /// <param name="type">The identifier specifying the type of get operation to perform.</param>
    /// <param name="qdid">QualifiedDataID that uniquely identifies the data to be fetched asynchronously.</param>
    /// <returns>Pointer to a CAsyncGetRequest representing the requested asynchronous fetch. If an existing pending request is found, the returned instance has its reference count incremented; otherwise the returned pointer refers to a newly created request object.</returns>
    public ACBindings.Internal.CAsyncGetRequest* FormGetRequest(ACBindings.Internal.CAsyncGetRequest* pParentReq, uint type, ACBindings.Internal.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.CAsyncGetRequest*, uint, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.CAsyncGetRequest*>)0x00418700)(ref this, pParentReq, type, qdid);

    /// <summary>Handles completion of an asynchronous save operation, updating any pending get requests for the same data ID and loading the saved data into the cache when appropriate.
    /// <code>Offset: 0x004187A0
    /// void __thiscall AsyncCache::OnSaveRequestFinished(AsyncCache*,CAsyncSaveRequest*)</code>
    /// </summary>
    /// <param name="pSaveReq">The finished CAsyncSaveRequest containing result status and the data buffer that was written.</param>
    public void OnSaveRequestFinished(ACBindings.Internal.CAsyncSaveRequest* pSaveReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.CAsyncSaveRequest*, void>)0x004187A0)(ref this, pSaveReq);

    /// <summary>Determines whether the specified data item is stored on disk or already loaded into memory, indicating it is ready for use.
    /// <code>Offset: 0x00418840
    /// bool __thiscall AsyncCache::IsOnDisk(AsyncCache*,const QualifiedDataID*)</code>
    /// </summary>
    /// <param name="qdid">The identifier of the data item being queried.</param>
    /// <returns>True if the item exists in memory or can be retrieved from disk; otherwise false.</returns>
    public byte IsOnDisk(ACBindings.Internal.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.QualifiedDataID*, byte>)0x00418840)(ref this, qdid);

    /// <summary>Retrieves a database object identified by the supplied QualifiedDataID, blocking until it is available and loaded from disk if necessary.
    /// <code>Offset: 0x004188D0
    /// DBObj* __thiscall AsyncCache::BlockingGet(AsyncCache*,unsigned int,const QualifiedDataID*)</code>
    /// </summary>
    /// <param name="type">Flag controlling load behavior; when set to 1 the function returns immediately even if the object has not yet been fully loaded.</param>
    /// <param name="qdid">Qualified identifier of the desired database object.</param>
    /// <returns>Pointer to the requested DBObj on success, or nullptr if the ID is invalid, the cache cannot provide the object, or loading fails.</returns>
    public ACBindings.Internal.DBObj* BlockingGet(uint type, ACBindings.Internal.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, uint, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.DBObj*>)0x004188D0)(ref this, type, qdid);

    /// <summary>Handles failure of an asynchronous data fetch from external sources by marking the corresponding request as failed and completing its lifecycle.
    /// <code>Offset: 0x004189D0
    /// void __thiscall AsyncCache::OnAsyncGetFromOtherSourcesFailed(AsyncCache*,const QualifiedDataID*)</code>
    /// </summary>
    /// <param name="qdid">Identifier of the data whose retrieval failed.</param>
    public void OnAsyncGetFromOtherSourcesFailed(ACBindings.Internal.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.QualifiedDataID*, void>)0x004189D0)(ref this, qdid);

    /// <summary>Adds asynchronous get operations for the specified data IDs under a given context and type, registering callbacks with the pending request handler and queuing each request for later processing.
    /// <code>Offset: 0x00418CF0
    /// bool __thiscall AsyncCache::AddToAsyncGet(AsyncCache*,AsyncContext,unsigned int,const QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="context">The async operation context identifying which callback handler should process the requests.</param>
    /// <param name="type">A value indicating the kind of get request to perform.</param>
    /// <param name="qdids">An array of qualified data identifiers that describe the objects to fetch asynchronously.</param>
    /// <returns>True if all requested items were queued successfully; false if the specified context has no active callback handler or the operation fails.</returns>
    public byte AddToAsyncGet(ACBindings.Internal.AsyncContext context, uint type, ACBindings.Internal.QualifiedDataIDArray* qdids) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.AsyncContext, uint, ACBindings.Internal.QualifiedDataIDArray*, byte>)0x00418CF0)(ref this, context, type, qdids);

    /// <summary>Adds the callback handler identified by the given handle to each pending async get request described by the request list, updating internal counters and associating the handler with those requests.
    /// <code>Offset: 0x00418EC0
    /// char __thiscall AsyncCache::AddToAsyncGet(AsyncCache*,unsigned int,int*)</code>
    /// </summary>
    /// <param name="a2">The identifier of the callback handler to associate with the requests.</param>
    /// <param name="a3">A pointer to an array describing one or more async get request descriptors, each containing a type and a list of data IDs to retrieve.</param>
    /// <returns>1 if the callback was successfully added; 0 if the specified handle could not be found in the busy callbacks table.</returns>
    public sbyte AddToAsyncGet(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, uint, int*, sbyte>)0x00418EC0)(ref this, a2, a3);

    /// <summary>Removes elements from io_qdids according to i_type: type 2 leaves all entries unchanged; type 3 deletes those whose data flag has bit 8 set; any other value clears the array entirely.
    /// <code>Offset: 0x00419170
    /// void __thiscall AsyncCache::FilterSubDataIDs(AsyncCache*,QualifiedDataIDArray*,unsigned int)</code>
    /// </summary>
    /// <param name="io_qdids">The QualifiedDataIDArray to filter, modified in place.</param>
    /// <param name="i_type">Specifies which elements are removed: 2 retains all, 3 removes entries with flag bit 8 set, others remove all entries.</param>
    public void FilterSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* io_qdids, uint i_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.QualifiedDataIDArray*, uint, void>)0x00419170)(ref this, io_qdids, i_type);

    /// <summary>Handles completion of an asynchronous data request, retrieving the requested object from memory or cache, deserializing it if necessary, and initiating any dependent sub‑data loads before marking the operation as finished.
    /// <code>Offset: 0x00419330
    /// void __thiscall AsyncCache::OnGetRequestFinished(AsyncCache*,CAsyncGetRequest*)</code>
    /// </summary>
    /// <param name="pGetReq">The completed get request instance.</param>
    public void OnGetRequestFinished(ACBindings.Internal.CAsyncGetRequest* pGetReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.CAsyncGetRequest*, void>)0x00419330)(ref this, pGetReq);

    /// <summary>Allocates a new callback handler for the supplied AsyncCacheCallback, assigns it a unique handle, registers it in the busy callbacks table, and returns a pointer to the created handler.
    /// <code>Offset: 0x00419530
    /// AsyncCache::CCallbackHandler* __thiscall AsyncCache::AllocateCallback(AsyncCache*,AsyncCacheCallback*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="pCallbackPlugin">The callback plugin that will receive results for requests handled by this callback.</param>
    /// <param name="dwUser1">Arbitrary user data stored with the new handler.</param>
    /// <param name="nRequests">Number of pending requests to associate with the new callback; added to its internal count.</param>
    /// <returns>Pointer to the newly created CCallbackHandler, or null if pCallbackPlugin is null. The function does not return on a memory‑allocation failure and may crash in that case.</returns>
    public ACBindings.Internal.AsyncCache.CCallbackHandler* AllocateCallback(ACBindings.Internal.AsyncCacheCallback* pCallbackPlugin, uint dwUser1, uint nRequests) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.AsyncCacheCallback*, uint, uint, ACBindings.Internal.AsyncCache.CCallbackHandler*>)0x00419530)(ref this, pCallbackPlugin, dwUser1, nRequests);

    /// <summary>Creates an asynchronous context for a supplied callback plugin, initializing its identifier and handling reference counting; if no plugin is provided, marks the context as invalid.
    /// <code>Offset: 0x004195F0
    /// AsyncContext* __thiscall AsyncCache::CreateContext(AsyncCache*,AsyncContext*,AsyncCacheCallback*,unsigned int)</code>
    /// </summary>
    /// <param name="this">Pointer to the AsyncCache instance.</param>
    /// <param name="result">The AsyncContext object to initialize and return.</param>
    /// <param name="i_pcCallbackPlugin">Callback plugin to associate with the new context.</param>
    /// <param name="i_dwUser">User-defined data passed to the callback handler.</param>
    /// <returns>Pointer to the initialized AsyncContext, or the same context pointer with an invalid identifier if no callback is supplied.</returns>
    public ACBindings.Internal.AsyncContext* CreateContext(ACBindings.Internal.AsyncContext* result, ACBindings.Internal.AsyncCacheCallback* i_pcCallbackPlugin, uint i_dwUser) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.AsyncContext*, ACBindings.Internal.AsyncCacheCallback*, uint, ACBindings.Internal.AsyncContext*>)0x004195F0)(ref this, result, i_pcCallbackPlugin, i_dwUser);

    /// <summary>Submits an asynchronous data retrieval request to the cache, optionally registering a callback plugin that will be invoked upon completion.
    /// <code>Offset: 0x00419640
    /// AsyncContext* __thiscall AsyncCache::AsyncGet(AsyncCache*,AsyncContext*,unsigned int,const QualifiedDataID*,AsyncCacheCallback*,unsigned int)</code>
    /// </summary>
    /// <param name="result">Output context used to track the request; its id field is set by this call.</param>
    /// <param name="type">Type of data being requested.</param>
    /// <param name="qdid">Qualified identifier of the desired data item.</param>
    /// <param name="pCallbackPlugin">Optional callback plugin invoked when the request completes.</param>
    /// <param name="dwUser1">User-defined value passed to the callback.</param>
    /// <returns>The same AsyncContext pointer supplied in result, now populated with a context ID if a callback was registered; otherwise it may contain an invalid id sentinel.</returns>
    public ACBindings.Internal.AsyncContext* AsyncGet(ACBindings.Internal.AsyncContext* result, uint type, ACBindings.Internal.QualifiedDataID* qdid, ACBindings.Internal.AsyncCacheCallback* pCallbackPlugin, uint dwUser1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.AsyncContext*, uint, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.AsyncCacheCallback*, uint, ACBindings.Internal.AsyncContext*>)0x00419640)(ref this, result, type, qdid, pCallbackPlugin, dwUser1);

    /// <summary>Initiates asynchronous retrieval of data specified by a QualifiedDataIDArray, optionally registering a callback plugin to receive completion notifications.
    /// <code>Offset: 0x004196F0
    /// AsyncContext* __thiscall AsyncCache::AsyncGet(AsyncCache*,AsyncContext*,unsigned int,const QualifiedDataIDArray*,AsyncCacheCallback*,unsigned int)</code>
    /// </summary>
    /// <param name="result">The AsyncContext object that will be populated with the request context identifier.</param>
    /// <param name="type">Specifies the nature of the get operation (e.g., load or query).</param>
    /// <param name="qdids">Collection of qualified identifiers for which data is requested.</param>
    /// <param name="pCallbackPlugin">Optional callback handler invoked when requests finish.</param>
    /// <param name="dwUser1">User-defined value passed through to the callback plugin.</param>
    /// <returns>The same AsyncContext* supplied in result, now containing a context identifier for the pending request(s) or an invalid marker if no identifiers were provided.</returns>
    public ACBindings.Internal.AsyncContext* AsyncGet(ACBindings.Internal.AsyncContext* result, uint type, ACBindings.Internal.QualifiedDataIDArray* qdids, ACBindings.Internal.AsyncCacheCallback* pCallbackPlugin, uint dwUser1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.AsyncContext*, uint, ACBindings.Internal.QualifiedDataIDArray*, ACBindings.Internal.AsyncCacheCallback*, uint, ACBindings.Internal.AsyncContext*>)0x004196F0)(ref this, result, type, qdids, pCallbackPlugin, dwUser1);

    /// <summary>Initiates an asynchronous purge of the specified data and returns a context that represents the operation.
    /// <code>Offset: 0x00419850
    /// AsyncContext* __thiscall AsyncCache::AsyncPurge(AsyncCache*,AsyncContext*,const QualifiedDataID*,AsyncCacheCallback*,unsigned int)</code>
    /// </summary>
    /// <param name="result">The AsyncContext object that receives the operation handle after the request is queued.</param>
    /// <param name="qdid">Identifier for the data to be purged.</param>
    /// <param name="pCallbackPlugin">Optional callback plugin invoked upon completion of the purge.</param>
    /// <param name="dwUser1">User-defined value forwarded to the callback when it executes.</param>
    /// <returns>The same AsyncContext pointer as passed in, now containing an operation handle (or INVALID_ASYNCCONTEXT_2 if no callback was provided).</returns>
    public ACBindings.Internal.AsyncContext* AsyncPurge(ACBindings.Internal.AsyncContext* result, ACBindings.Internal.QualifiedDataID* qdid, ACBindings.Internal.AsyncCacheCallback* pCallbackPlugin, uint dwUser1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.AsyncContext*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.AsyncCacheCallback*, uint, ACBindings.Internal.AsyncContext*>)0x00419850)(ref this, result, qdid, pCallbackPlugin, dwUser1);

    /// <summary>Schedules an asynchronous purge of the specified data identifiers and registers a callback plugin for completion notification.
    /// <code>Offset: 0x00419940
    /// AsyncContext* __thiscall AsyncCache::AsyncPurge(AsyncCache*,AsyncContext*,const QualifiedDataIDArray*,AsyncCacheCallback*,unsigned int)</code>
    /// </summary>
    /// <param name="result">AsyncContext that receives the operation identifier; its m_id field is set by this function.</param>
    /// <param name="qdids">Collection of qualified data IDs to be purged.</param>
    /// <param name="pCallbackPlugin">Callback plugin invoked when the purge completes or fails.</param>
    /// <param name="dwUser1">User-defined value passed to the callback.</param>
    /// <returns>Pointer to the provided AsyncContext with its m_id field set; if allocation fails, the ID is INVALID_ASYNCCONTEXT_2.</returns>
    public ACBindings.Internal.AsyncContext* AsyncPurge(ACBindings.Internal.AsyncContext* result, ACBindings.Internal.QualifiedDataIDArray* qdids, ACBindings.Internal.AsyncCacheCallback* pCallbackPlugin, uint dwUser1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.AsyncContext*, ACBindings.Internal.QualifiedDataIDArray*, ACBindings.Internal.AsyncCacheCallback*, uint, ACBindings.Internal.AsyncContext*>)0x00419940)(ref this, result, qdids, pCallbackPlugin, dwUser1);

    /// <summary>
    /// Initiates an asynchronous save of the specified cache pack to the target destination, optionally registering a callback plugin and user data. The operation is queued in the AsyncCache system and a context handle is returned for tracking completion.
    /// 
    /// <code>Offset: 0x004199A0
    /// AsyncContext* __thiscall AsyncCache::AsyncSave(AsyncCache*,AsyncContext*,const QualifiedDataID*,Cache_Pack_t*,unsigned __int64,AsyncCacheCallback*,unsigned int)</code>
    /// </summary>
    /// <param name="result">Output context that will receive the async operation identifier.</param>
    /// <param name="qdid">Qualified identifier describing the type and ID of the data to be saved.</param>
    /// <param name="pack_buf">Buffer containing the cache pack data and metadata to persist.</param>
    /// <param name="idDestination">64‑bit destination identifier where the data should be written.</param>
    /// <param name="pCallbackPlugin">Optional callback plugin invoked upon completion; may be null.</param>
    /// <param name="dwUser1">User‑defined value passed to the callback for context or identification.</param>
    /// <returns>The same AsyncContext pointer supplied in <c>result</c>, updated with a unique operation ID.</returns>
    public ACBindings.Internal.AsyncContext* AsyncSave(ACBindings.Internal.AsyncContext* result, ACBindings.Internal.QualifiedDataID* qdid, ACBindings.Internal.Cache_Pack_t* pack_buf, ulong idDestination, ACBindings.Internal.AsyncCacheCallback* pCallbackPlugin, uint dwUser1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.AsyncContext*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.Cache_Pack_t*, ulong, ACBindings.Internal.AsyncCacheCallback*, uint, ACBindings.Internal.AsyncContext*>)0x004199A0)(ref this, result, qdid, pack_buf, idDestination, pCallbackPlugin, dwUser1);

    /// <summary>Hashes a get request into the pending gets table and enqueues it for processing if it is not already present.
    /// <code>Offset: 0x00419AA0
    /// void __thiscall AsyncCache::HashAndEnqueue(AsyncCache*,CAsyncGetRequest*)</code>
    /// </summary>
    /// <param name="pGetReq">The asynchronous get request to add, whose reference count will be incremented and status flags set before queuing.</param>
    public void HashAndEnqueue(ACBindings.Internal.CAsyncGetRequest* pGetReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.CAsyncGetRequest*, void>)0x00419AA0)(ref this, pGetReq);

    /// <summary>Removes a completed or cancelled asynchronous get request from the cache's pending gets table and recursively cleans up any dependent requests, decrementing reference counts as necessary.
    /// <code>Offset: 0x00419AF0
    /// void __thiscall AsyncCache::UnhashPendingGet(AsyncCache*,CAsyncGetRequest*,CAsyncGetRequest*)</code>
    /// </summary>
    /// <p>When <paramref name="pGetReq"/> has no outstanding callbacks or waiting requests and is marked for removal, it is taken out of the hash table. The function then unhashes all requests that were waiting on this one, passing itself as the parent to handle cascading dependencies. After cleanup, the request’s reference count is decremented, freeing it when it reaches zero.</p>
    /// <param name="pGetReq">The asynchronous get request to be potentially removed from the pending gets table.</param>
    /// <param name="pParentReq">The parent request that was waiting for <paramref name="pGetReq"/>; used during recursive cleanup of dependent requests.</param>
    public void UnhashPendingGet(ACBindings.Internal.CAsyncGetRequest* pGetReq, ACBindings.Internal.CAsyncGetRequest* pParentReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.CAsyncGetRequest*, ACBindings.Internal.CAsyncGetRequest*, void>)0x00419AF0)(ref this, pGetReq, pParentReq);

    /// <summary>Removes the specified async context from the busy callbacks table, cleans up any pending requests tied to it, and releases its callback handler when the reference count drops to zero.
    /// <code>Offset: 0x00419BC0
    /// void __thiscall AsyncCache::ReleaseContext(AsyncCache*,AsyncContext)</code>
    /// </summary>
    /// <param name="hContext">The handle identifying the asynchronous context to release.</param>
    public void ReleaseContext(ACBindings.Internal.AsyncContext hContext) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.AsyncContext, void>)0x00419BC0)(ref this, hContext);

    /// <summary>Releases all busy callback contexts and decrements reference counts on pending asynchronous get requests, clearing the pending request queue.
    /// <code>Offset: 0x00419C40
    /// void __thiscall AsyncCache::FlushPendingRequests(AsyncCache*)</code>
    /// </summary>
    public void FlushPendingRequests() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, void>)0x00419C40)(ref this);

    /// <summary>Determines whether the asynchronous get request specified by <c>pGetFrom</c> is waiting for the completion of the request specified by <c>pGetTo</c>, traversing any dependency chain between them.
    /// <code>Offset: 0x00419D10
    /// bool __thiscall AsyncCache::IsWaitingFor(AsyncCache*,CAsyncGetRequest*,CAsyncGetRequest*)</code>
    /// </summary>
    /// <param name="pGetFrom">The request that may be dependent on other requests.</param>
    /// <param name="pGetTo">The potential prerequisite request being checked for a wait relationship.</param>
    /// <returns>True if <c>pGetFrom</c> is waiting (directly or indirectly) for <c>pGetTo</c>; otherwise, false.</returns>
    public byte IsWaitingFor(ACBindings.Internal.CAsyncGetRequest* pGetFrom, ACBindings.Internal.CAsyncGetRequest* pGetTo) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, ACBindings.Internal.CAsyncGetRequest*, ACBindings.Internal.CAsyncGetRequest*, byte>)0x00419D10)(ref this, pGetFrom, pGetTo);

    /// <summary>Enqueues a set of qualified data identifiers for an asynchronous get operation, updating internal bookkeeping and registering any necessary callbacks.
    /// <code>Offset: 0x00419FF0
    /// bool __thiscall AsyncCache::AddToAsyncGet(AsyncCache*,unsigned int,const QualifiedDataIDArray*,void*)</code>
    /// </summary>
    /// <param name="type">The type code identifying the async request variant.</param>
    /// <param name="qdids">Array containing the QualifiedDataID entries to be retrieved.</param>
    /// <param name="hInternal">Handle representing the state of the ongoing asynchronous get request.</param>
    /// <returns>True if the identifiers were successfully added; false if the request has already been finalized and can no longer accept new IDs.</returns>
    public byte AddToAsyncGet(uint type, ACBindings.Internal.QualifiedDataIDArray* qdids, System.IntPtr hInternal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, uint, ACBindings.Internal.QualifiedDataIDArray*, System.IntPtr, byte>)0x00419FF0)(ref this, type, qdids, hInternal);

    /// <summary>Initializes a new AsyncCache instance, allocating storage for pending callbacks and configuring hash tables to manage outstanding get requests and active callback handlers.
    /// <code>Offset: 0x0041A210
    /// void __thiscall AsyncCache::AsyncCache(AsyncCache*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, void>)0x0041A210)(ref this);

    /// <summary>Initiates retrieval of the specified UI preference item from external sources within a numeric range.
    /// <code>Offset: 0x006A1040
    /// bool __thiscall AsyncCache::AsyncGetFromOtherSources(UIPreferenceItem*,const float,const float)</code>
    /// </summary>
    /// <param name="preferenceItem">The UIPreferenceItem whose data is requested.</param>
    /// <param name="i_nMin">Lower bound for the value to query.</param>
    /// <param name="i_nMax">Upper bound for the value to query.</param>
    /// <returns>True if the request was successfully started; otherwise false.</returns>
    public byte AsyncGetFromOtherSources(float i_nMin, float i_nMax) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.AsyncCache, float, float, byte>)0x006A1040)(ref this, i_nMin, i_nMax);
}

