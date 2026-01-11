namespace ACBindings.Internal;

public unsafe struct CAsyncPurgeRequest
{
    // Base Classes
    public ACBindings.Internal.AsyncCache.CAsyncRequest BaseClass_AsyncCache_CAsyncRequest; // ACBindings.Internal.AsyncCache.CAsyncRequest

    // Child Types
    public unsafe struct CAsyncPurgeRequest_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncPurgeRequest*, void> CAsyncPurgeRequest_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncPurgeRequest*, byte> bAllDependanciesDone; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncPurgeRequest*, byte> ReadyToUnhash; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncPurgeRequest*, void> ReleaseDBObj; // function pointer

        // Methods
    }

    // Methods
}

