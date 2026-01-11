namespace ACBindings.Internal;

public unsafe struct ThreadedCache : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBCache BaseClass_DBCache; // ACBindings.Internal.DBCache
    public ACBindings.Internal.PortalThread BaseClass_PortalThread; // ACBindings.Internal.PortalThread

    // Child Types
    public unsafe struct ThreadedCache_vtbl
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

    /// <summary>
    /// <code>Offset: 0x004FA5C0
    /// void __thiscall ThreadedCache::~ThreadedCache(ThreadedCache*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, void>)0x004FA5C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x006785B0
    /// void __thiscall ThreadedCache::WorkerExecuteRequest(ThreadedCache*,AsyncCache::CAsyncRequest*)</code>
    /// </summary>
    public void WorkerExecuteRequest(ACBindings.Internal.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, ACBindings.Internal.AsyncCache.CAsyncRequest*, void>)0x006785B0)(ref this, pReq);

    /// <summary>
    /// <code>Offset: 0x006785E0
    /// bool __thiscall ThreadedCache::SetShutdown(ThreadedCache*,bool)</code>
    /// </summary>
    public byte SetShutdown(byte shut_f) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, byte, byte>)0x006785E0)(ref this, shut_f);

    /// <summary>
    /// <code>Offset: 0x00678610
    /// void __thiscall ThreadedCache::StopThread(ThreadedCache*)</code>
    /// </summary>
    public void StopThread() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, void>)0x00678610)(ref this);

    /// <summary>
    /// <code>Offset: 0x00678630
    /// void __thiscall ThreadedCache::WakeForTheReaper(ThreadedCache*)</code>
    /// </summary>
    public void WakeForTheReaper() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, void>)0x00678630)(ref this);

    /// <summary>
    /// <code>Offset: 0x00678640
    /// void __thiscall ThreadedCache::WorkerExecuteGetRequest(ThreadedCache*,CAsyncGetRequest*)</code>
    /// </summary>
    public void WorkerExecuteGetRequest(ACBindings.Internal.CAsyncGetRequest* pGetReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, ACBindings.Internal.CAsyncGetRequest*, void>)0x00678640)(ref this, pGetReq);

    /// <summary>
    /// <code>Offset: 0x00678670
    /// void __thiscall ThreadedCache::WorkerExecutePurgeRequest(ThreadedCache*,CAsyncPurgeRequest*)</code>
    /// </summary>
    public void WorkerExecutePurgeRequest(ACBindings.Internal.CAsyncPurgeRequest* pPurgeReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, ACBindings.Internal.CAsyncPurgeRequest*, void>)0x00678670)(ref this, pPurgeReq);

    /// <summary>
    /// <code>Offset: 0x006786A0
    /// void __thiscall ThreadedCache::WorkerExecuteSaveRequest(ThreadedCache*,CAsyncSaveRequest*)</code>
    /// </summary>
    public void WorkerExecuteSaveRequest(ACBindings.Internal.CAsyncSaveRequest* pSaveReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, ACBindings.Internal.CAsyncSaveRequest*, void>)0x006786A0)(ref this, pSaveReq);

    /// <summary>
    /// <code>Offset: 0x00678960
    /// int __thiscall ThreadedCache::Startup(ThreadedCache*)</code>
    /// </summary>
    public int Startup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, int>)0x00678960)(ref this);

    /// <summary>
    /// <code>Offset: 0x006789E0
    /// void __thiscall ThreadedCache::PutOnWorkerThreadJobQueue(ThreadedCache*,AsyncCache::CAsyncRequest*)</code>
    /// </summary>
    public void PutOnWorkerThreadJobQueue(ACBindings.Internal.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, ACBindings.Internal.AsyncCache.CAsyncRequest*, void>)0x006789E0)(ref this, pReq);

    /// <summary>
    /// <code>Offset: 0x00678A10
    /// void __thiscall ThreadedCache::UseTime(ThreadedCache*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, void>)0x00678A10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00678A90
    /// void __thiscall ThreadedCache::AsyncGetInternal(ThreadedCache*,CAsyncGetRequest*)</code>
    /// </summary>
    public void AsyncGetInternal(ACBindings.Internal.CAsyncGetRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, ACBindings.Internal.CAsyncGetRequest*, void>)0x00678A90)(ref this, pReq);

    /// <summary>
    /// <code>Offset: 0x00678B50
    /// void __thiscall ThreadedCache::ThreadedCache(ThreadedCache*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, void>)0x00678B50)(ref this);

    /// <summary>
    /// <code>Offset: 0x00678C60
    /// void __thiscall ThreadedCache::EnqueueAsyncRequest(ThreadedCache*,AsyncCache::CAsyncRequest*)</code>
    /// </summary>
    public void EnqueueAsyncRequest(ACBindings.Internal.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ThreadedCache, ACBindings.Internal.AsyncCache.CAsyncRequest*, void>)0x00678C60)(ref this, pReq);
}

