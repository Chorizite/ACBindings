namespace ACBindings.Internal;


/// <summary>Manages asynchronous cache retrieval operations, tracking dependencies, pending requests, and buffered results within the database object cache.</summary>
public unsafe struct CAsyncGetRequest : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.AsyncCache.CAsyncRequest BaseClass_AsyncCache_CAsyncRequest; // ACBindings.Internal.AsyncCache.CAsyncRequest

    // Child Types
    public unsafe struct CAsyncGetRequest_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncGetRequest*, void> CAsyncGetRequest_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncGetRequest*, byte> bAllDependanciesDone; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncGetRequest*, byte> ReadyToUnhash; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncGetRequest*, void> ReleaseDBObj; // function pointer

        // Methods
    }

    // Members
    public uint GSDIType;
    public ACBindings.Internal.SmartArray___CAsyncGetRequest_ptr RequestsWaitingForMe;
    public ACBindings.Internal.SmartArray___CAsyncGetRequest_ptr RequestsImWaitingFor;
    public ACBindings.Internal.Cache_Pack_t Buf;
    public int nGetsRemaining;
    public ACBindings.Internal.DBOCache* pObjCache;
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

    /// <summary>Releases the database object associated with the request, adding it back to the cache when appropriate and clearing the internal reference.
    /// <code>Offset: 0x00417910
    /// void __thiscall CAsyncGetRequest::ReleaseDBObj(CAsyncGetRequest*)</code>
    /// </summary>
    public void ReleaseDBObj() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncGetRequest, void>)0x00417910)(ref this);

    /// <summary>Destroys a CAsyncGetRequest, decrementing reference counts on waiting requests, releasing associated DB objects and buffers, adding the object to the cache when appropriate, and freeing any dynamically allocated request arrays.
    /// <code>Offset: 0x004181A0
    /// void __thiscall CAsyncGetRequest::~CAsyncGetRequest(CAsyncGetRequest*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncGetRequest, void>)0x004181A0)(ref this);

    /// <summary>Indicates whether all dependent get operations have completed.
    /// <code>Offset: 0x004182F0
    /// bool __thiscall CAsyncGetRequest::bAllDependanciesDone(CAsyncGetRequest*)</code>
    /// </summary>
    /// <returns>True when there are no remaining gets; otherwise false.</returns>
    public byte bAllDependanciesDone() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncGetRequest, byte>)0x004182F0)(ref this);

    /// <summary>Constructs an asynchronous GET request object and initializes all internal state to default values.
    /// <code>Offset: 0x00418410
    /// void __thiscall CAsyncGetRequest::CAsyncGetRequest(CAsyncGetRequest*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CAsyncGetRequest, void>)0x00418410)(ref this);
}

