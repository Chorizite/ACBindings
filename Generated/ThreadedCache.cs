namespace ACBindings;

// ThreadedCache
public unsafe struct ThreadedCache : System.IDisposable
{
    // Base Classes
    public ACBindings.DBCache BaseClass_DBCache; // ACBindings.DBCache
    public ACBindings.PortalThread BaseClass_PortalThread; // ACBindings.PortalThread

    // Child Types
    // ThreadedCache_vtbl
    public unsafe struct ThreadedCache_vtbl
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

        // Methods
    }

    // Members
    public ACBindings.LFQueue__AsyncCache_CAsyncRequest_ptr m_WorkerThreadJobQueue;
    public ACBindings.LFQueue__AsyncCache_CAsyncRequest_ptr m_WorkerThreadReplyQueue;
    public ACBindings.PortalEvent m_evtWorkerHasJobs;

    // Generated Constructor
    public ThreadedCache() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall ThreadedCache::~ThreadedCache(ThreadedCache*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ThreadedCache, void>)0x004FA5C0)(ref this);
    // void __thiscall ThreadedCache::WorkerExecuteRequest(ThreadedCache*,AsyncCache::CAsyncRequest*)
    public void WorkerExecuteRequest(ACBindings.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ThreadedCache, ACBindings.AsyncCache.CAsyncRequest*, void>)0x006785B0)(ref this, pReq);
    // bool __thiscall ThreadedCache::SetShutdown(ThreadedCache*,bool)
    public byte SetShutdown(byte shut_f) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ThreadedCache, byte, byte>)0x006785E0)(ref this, shut_f);
    // void __thiscall ThreadedCache::StopThread(ThreadedCache*)
    public void StopThread() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ThreadedCache, void>)0x00678610)(ref this);
    // void __thiscall ThreadedCache::WakeForTheReaper(ThreadedCache*)
    public void WakeForTheReaper() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ThreadedCache, void>)0x00678630)(ref this);
    // void __thiscall ThreadedCache::WorkerExecuteGetRequest(ThreadedCache*,CAsyncGetRequest*)
    public void WorkerExecuteGetRequest(ACBindings.CAsyncGetRequest* pGetReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ThreadedCache, ACBindings.CAsyncGetRequest*, void>)0x00678640)(ref this, pGetReq);
    // void __thiscall ThreadedCache::WorkerExecutePurgeRequest(ThreadedCache*,CAsyncPurgeRequest*)
    public void WorkerExecutePurgeRequest(ACBindings.CAsyncPurgeRequest* pPurgeReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ThreadedCache, ACBindings.CAsyncPurgeRequest*, void>)0x00678670)(ref this, pPurgeReq);
    // void __thiscall ThreadedCache::WorkerExecuteSaveRequest(ThreadedCache*,CAsyncSaveRequest*)
    public void WorkerExecuteSaveRequest(ACBindings.CAsyncSaveRequest* pSaveReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ThreadedCache, ACBindings.CAsyncSaveRequest*, void>)0x006786A0)(ref this, pSaveReq);
    // int __thiscall ThreadedCache::Startup(ThreadedCache*)
    public int Startup() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ThreadedCache, int>)0x00678960)(ref this);
    // void __thiscall ThreadedCache::PutOnWorkerThreadJobQueue(ThreadedCache*,AsyncCache::CAsyncRequest*)
    public void PutOnWorkerThreadJobQueue(ACBindings.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ThreadedCache, ACBindings.AsyncCache.CAsyncRequest*, void>)0x006789E0)(ref this, pReq);
    // void __thiscall ThreadedCache::UseTime(ThreadedCache*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ThreadedCache, void>)0x00678A10)(ref this);
    // void __thiscall ThreadedCache::AsyncGetInternal(ThreadedCache*,CAsyncGetRequest*)
    public void AsyncGetInternal(ACBindings.CAsyncGetRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ThreadedCache, ACBindings.CAsyncGetRequest*, void>)0x00678A90)(ref this, pReq);
    // void __thiscall ThreadedCache::ThreadedCache(ThreadedCache*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.ThreadedCache, void>)0x00678B50)(ref this);
    // void __thiscall ThreadedCache::EnqueueAsyncRequest(ThreadedCache*,AsyncCache::CAsyncRequest*)
    public void EnqueueAsyncRequest(ACBindings.AsyncCache.CAsyncRequest* pReq) => ((delegate* unmanaged[Thiscall]<ref ACBindings.ThreadedCache, ACBindings.AsyncCache.CAsyncRequest*, void>)0x00678C60)(ref this, pReq);
}

