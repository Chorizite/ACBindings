namespace ACBindings.Internal;

public unsafe struct CAsyncSaveRequest
{
    // Base Classes
    public ACBindings.Internal.AsyncCache.CAsyncRequest BaseClass_AsyncCache_CAsyncRequest; // ACBindings.Internal.AsyncCache.CAsyncRequest

    // Child Types
    public unsafe struct CAsyncSaveRequest_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncSaveRequest*, void> CAsyncSaveRequest_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncSaveRequest*, byte> bAllDependanciesDone; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncSaveRequest*, byte> ReadyToUnhash; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncSaveRequest*, void> ReleaseDBObj; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.Cache_Pack_t Buf;
    public ulong idTargetDatFile;
    public uint dwDiskControllerSaveFlags;
    public uint idIteration;
    public ACBindings.Internal.DiskController* pDisk;

    // Methods
}

