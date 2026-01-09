namespace ACBindings;

// CAsyncSaveRequest
public unsafe struct CAsyncSaveRequest
{
    // Base Classes
    public ACBindings.AsyncCache.CAsyncRequest BaseClass_AsyncCache_CAsyncRequest; // ACBindings.AsyncCache.CAsyncRequest

    // Child Types
    // CAsyncSaveRequest_vtbl
    public unsafe struct CAsyncSaveRequest_vtbl
    {
        // Members
        public System.IntPtr CAsyncSaveRequest_dtor_0; // function pointer
        public System.IntPtr bAllDependanciesDone; // function pointer
        public System.IntPtr ReadyToUnhash; // function pointer
        public System.IntPtr ReleaseDBObj; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Cache_Pack_t Buf;
    public ulong idTargetDatFile;
    public uint dwDiskControllerSaveFlags;
    public uint idIteration;
    public ACBindings.DiskController* pDisk;

    // Methods
}

