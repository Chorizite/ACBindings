namespace ACBindings;

// CAsyncGetRequest
public unsafe struct CAsyncGetRequest : System.IDisposable
{
    // Base Classes
    public ACBindings.AsyncCache.CAsyncRequest BaseClass_AsyncCache_CAsyncRequest; // ACBindings.AsyncCache.CAsyncRequest

    // Child Types
    // CAsyncGetRequest_vtbl
    public unsafe struct CAsyncGetRequest_vtbl
    {
        // Members
        public System.IntPtr CAsyncGetRequest_dtor_0; // function pointer
        public System.IntPtr bAllDependanciesDone; // function pointer
        public System.IntPtr ReadyToUnhash; // function pointer
        public System.IntPtr ReleaseDBObj; // function pointer

        // Methods
    }

    // Members
    public uint GSDIType;
    public ACBindings.SmartArray__CAsyncGetRequest_ptr RequestsWaitingForMe;
    public ACBindings.SmartArray__CAsyncGetRequest_ptr RequestsImWaitingFor;
    public ACBindings.Cache_Pack_t Buf;
    public int nGetsRemaining;
    public ACBindings.DBOCache* pObjCache;
    public uint m_dwGetRequestFlags;

    // Generated Constructor
    public CAsyncGetRequest() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CAsyncGetRequest::ReleaseDBObj(CAsyncGetRequest*)
    public void ReleaseDBObj() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncGetRequest, void>)0x00417910)(ref this);
    // void __thiscall CAsyncGetRequest::~CAsyncGetRequest(CAsyncGetRequest*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncGetRequest, void>)0x004181A0)(ref this);
    // bool __thiscall CAsyncGetRequest::bAllDependanciesDone(CAsyncGetRequest*)
    public byte bAllDependanciesDone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncGetRequest, byte>)0x004182F0)(ref this);
    // void __thiscall CAsyncGetRequest::CAsyncGetRequest(CAsyncGetRequest*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CAsyncGetRequest, void>)0x00418410)(ref this);
}

