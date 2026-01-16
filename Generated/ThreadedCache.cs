namespace ACBindings.Internal;


/// <summary>Manages asynchronous cache operations in a dedicated worker thread, coordinating job and reply queues, event signaling, and base database caching functionality.</summary>
/// <remarks>Inherits from DBCache for core database access and PortalThread for threading support; utilizes lock‑free queues to enqueue asynchronous requests, processes them in a background thread, and signals completion via events.</remarks>
public unsafe struct ThreadedCache : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBCache BaseClass_DBCache; // ACBindings.Internal.DBCache
    public ACBindings.Internal.PortalThread BaseClass_PortalThread; // ACBindings.Internal.PortalThread

    // Child Types
    public unsafe struct ThreadedCache_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> DBCache_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.DBCache.Enum3> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> ResetCache; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, int, int, uint, ACBindings.Internal.DBObj*> GetFromEnum; // function pointer
        public System.IntPtr GetDIDFromEnum;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.CACHE_OBJECT_CODES> PreFetch; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.DatIDStamp*, byte> InqDatIDStamp; // function pointer
        public System.IntPtr ReloadObject;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte, byte> SetShutdown; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte> IsLoader; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, uint, byte> SetRegion; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte> UnloadCellData; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> AskForLastWords; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, uint, byte, byte> SetLanguageInternal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> DestroyObjectCaches; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, void> StopThread; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.AsyncCache.CAsyncRequest*, void> WorkerExecuteRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.CAsyncGetRequest*, void> WorkerExecuteGetRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.CAsyncSaveRequest*, void> WorkerExecuteSaveRequest; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.ThreadedCache*, ACBindings.Internal.CAsyncPurgeRequest*, void> WorkerExecutePurgeRequest; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.LFQueue___AsyncCache_CAsyncRequest_ptr m_WorkerThreadJobQueue;
    public ACBindings.Internal.LFQueue___AsyncCache_CAsyncRequest_ptr m_WorkerThreadReplyQueue;
    public ACBindings.Internal.PortalEvent m_evtWorkerHasJobs;

    // Generated Constructor
    public ThreadedCache() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys the ThreadedCache object by cleaning up worker thread queues, releasing allocated memory for job and reply buckets, flushing pending requests, signaling shutdown of the worker event, and invoking base class destructors.
    /// <code>Offset: 0x004FA5C0
    /// void __thiscall ThreadedCache::~ThreadedCache(ThreadedCache*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, void>)0x004FA5C0)(ref this);

    /// <summary>Executes an asynchronous cache request by performing a reference‑count operation (AddRef, Release, or QueryInterface) on the ThreadedCache object according to the request’s Op code.
    /// <code>Offset: 0x006785B0
    /// void __thiscall ThreadedCache::WorkerExecuteRequest(ThreadedCache*,AsyncCache::CAsyncRequest*)</code>
    /// </summary>
    /// <param name="pReq">The async request containing the operation code and target data.</param>
    public void WorkerExecuteRequest(ACBindings.Internal.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, ACBindings.Internal.AsyncCache.CAsyncRequest*, void>)0x006785B0)(ref this, pReq);

    /// <summary>Configures the underlying cache to release or retain free objects based on the shutdown flag.
    /// <code>Offset: 0x006785E0
    /// bool __thiscall ThreadedCache::SetShutdown(ThreadedCache*,bool)</code>
    /// </summary>
    /// <param name="shut_f">True to initiate shutdown, false to keep running.</param>
    /// <returns>The negated result of DBCache::KeepFreeObjects; returns true if the call failed, otherwise false.</returns>
    public byte SetShutdown(byte shut_f) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, byte, byte>)0x006785E0)(ref this, shut_f);

    /// <summary>Stops the worker thread of the threaded cache by signaling it to exit and waiting until termination completes.
    /// <code>Offset: 0x00678610
    /// void __thiscall ThreadedCache::StopThread(ThreadedCache*)</code>
    /// </summary>
    public void StopThread() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, void>)0x00678610)(ref this);

    /// <summary>Notifies the cache system that any queued callback handlers should be processed, allowing worker threads to continue execution.
    /// <code>Offset: 0x00678630
    /// void __thiscall ThreadedCache::WakeForTheReaper(ThreadedCache*)</code>
    /// </summary>
    public void WakeForTheReaper() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, void>)0x00678630)(ref this);

    /// <summary>Executes an asynchronous get request by attempting to load the requested data into the provided buffer and storing the outcome in the request’s result.
    /// <code>Offset: 0x00678640
    /// void __thiscall ThreadedCache::WorkerExecuteGetRequest(ThreadedCache*,CAsyncGetRequest*)</code>
    /// </summary>
    /// <param name="pGetReq">The CAsyncGetRequest containing the QualifiedDataID to fetch and a buffer for the loaded data.</param>
    public void WorkerExecuteGetRequest(ACBindings.Internal.CAsyncGetRequest* pGetReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, ACBindings.Internal.CAsyncGetRequest*, void>)0x00678640)(ref this, pGetReq);

    /// <summary>Executes a purge request on the threaded cache, removing the specified data and updating the request’s Result field to indicate success or failure.
    /// <code>Offset: 0x00678670
    /// void __thiscall ThreadedCache::WorkerExecutePurgeRequest(ThreadedCache*,CAsyncPurgeRequest*)</code>
    /// </summary>
    /// <param name="pPurgeReq">The purge request containing the qualified data identifier; its Result field is set after attempting removal.</param>
    public void WorkerExecutePurgeRequest(ACBindings.Internal.CAsyncPurgeRequest* pPurgeReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, ACBindings.Internal.CAsyncPurgeRequest*, void>)0x00678670)(ref this, pPurgeReq);

    /// <summary>Processes an asynchronous save request by verifying disk availability and setting the request result accordingly.
    /// <code>Offset: 0x006786A0
    /// void __thiscall ThreadedCache::WorkerExecuteSaveRequest(ThreadedCache*,CAsyncSaveRequest*)</code>
    /// </summary>
    /// <param name="pSaveReq">The async save request whose data is written to disk, if possible; the function updates its Result field to indicate success or failure.</param>
    public void WorkerExecuteSaveRequest(ACBindings.Internal.CAsyncSaveRequest* pSaveReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, ACBindings.Internal.CAsyncSaveRequest*, void>)0x006786A0)(ref this, pSaveReq);

    /// <summary>Begins processing queued cache callbacks, moving each request from the pending queue into the busy table and enqueuing it for execution. After all pending callbacks have been handled, waits for a signal that new work is available.
    /// <code>Offset: 0x00678960
    /// int __thiscall ThreadedCache::Startup(ThreadedCache*)</code>
    /// </summary>
    /// <returns>An integer status code (always zero).</returns>
    public int Startup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, int>)0x00678960)(ref this);

    /// <summary>Adds an async cache request to the worker thread's job queue and signals the worker that work is available.
    /// <code>Offset: 0x006789E0
    /// void __thiscall ThreadedCache::PutOnWorkerThreadJobQueue(ThreadedCache*,AsyncCache::CAsyncRequest*)</code>
    /// </summary>
    /// <param name="this">Pointer to the ThreadedCache instance.</param>
    /// <param name="pReq">The asynchronous request to enqueue; its reference count is increased before queuing.</param>
    public void PutOnWorkerThreadJobQueue(ACBindings.Internal.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, ACBindings.Internal.AsyncCache.CAsyncRequest*, void>)0x006789E0)(ref this, pReq);

    /// <summary>Processes queued asynchronous cache requests for up to 25 milliseconds, releasing completed requests and updating the underlying database cache.
    /// <code>Offset: 0x00678A10
    /// void __thiscall ThreadedCache::UseTime(ThreadedCache*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, void>)0x00678A10)(ref this);

    /// <summary>Processes an asynchronous cache get request by first checking whether the requested object is already in memory; if so, marks the request as successful and completes it immediately, otherwise decides to load from disk, fetch from other sources, or fail based on the request’s flags and the underlying object cache.
    /// <code>Offset: 0x00678A90
    /// void __thiscall ThreadedCache::AsyncGetInternal(ThreadedCache*,CAsyncGetRequest*)</code>
    /// </summary>
    /// <param name="pReq">The asynchronous get request containing the qualified data ID, caching flags, and associated object cache information.</param>
    public void AsyncGetInternal(ACBindings.Internal.CAsyncGetRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, ACBindings.Internal.CAsyncGetRequest*, void>)0x00678A90)(ref this, pReq);

    /// <summary>Initializes a ThreadedCache instance, setting up worker thread queues, synchronization primitives, and event handles.
    /// <code>Offset: 0x00678B50
    /// void __thiscall ThreadedCache::ThreadedCache(ThreadedCache*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, void>)0x00678B50)(ref this);

    /// <summary>Queues an asynchronous cache request for background processing. If the request is a normal operation it increments its reference count, posts it to the worker thread's job queue and signals the reply queue; otherwise it delegates the get operation to the internal async-get handler.
    /// <code>Offset: 0x00678C60
    /// void __thiscall ThreadedCache::EnqueueAsyncRequest(ThreadedCache*,AsyncCache::CAsyncRequest*)</code>
    /// </summary>
    /// <param name="pReq">The async cache request to enqueue.</param>
    public void EnqueueAsyncRequest(ACBindings.Internal.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, ACBindings.Internal.AsyncCache.CAsyncRequest*, void>)0x00678C60)(ref this, pReq);
}

