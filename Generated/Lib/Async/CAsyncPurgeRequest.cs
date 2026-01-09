namespace ACBindings;

// CAsyncPurgeRequest
public unsafe struct CAsyncPurgeRequest
{
    // Base Classes
    public ACBindings.AsyncCache.CAsyncRequest BaseClass_AsyncCache_CAsyncRequest; // ACBindings.AsyncCache.CAsyncRequest

    // Child Types
    // CAsyncPurgeRequest_vtbl
    public unsafe struct CAsyncPurgeRequest_vtbl
    {
        // Members
        public System.IntPtr CAsyncPurgeRequest_dtor_0; // function pointer
        public System.IntPtr bAllDependanciesDone; // function pointer
        public System.IntPtr ReadyToUnhash; // function pointer
        public System.IntPtr ReleaseDBObj; // function pointer

        // Methods
    }

    // Methods
}

