namespace ACBindings.Internal;


/// <summary>Asynchronous save request for a disk controller, encapsulating target file identifier, save flags, iteration counter, buffer pack, and associated disk controller pointer.</summary>
public unsafe struct CAsyncSaveRequest
{
    // Base Classes
    public ACBindings.Internal.AsyncCache.CAsyncRequest BaseClass_AsyncCache_CAsyncRequest; // ACBindings.Internal.AsyncCache.CAsyncRequest

    // Child Types
    public unsafe struct CAsyncSaveRequest_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncSaveRequest*, void> CAsyncSaveRequest_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncSaveRequest*, byte> bAllDependanciesDone; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncSaveRequest*, byte> ReadyToUnhash; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CAsyncSaveRequest*, void> ReleaseDBObj; // function pointer

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

