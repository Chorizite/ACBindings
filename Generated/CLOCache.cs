namespace ACBindings.Internal;

public unsafe struct CLOCache
{
    // Base Classes
    public ACBindings.Internal.DBOCache BaseClass_DBOCache; // ACBindings.Internal.DBOCache

    // Child Types
    public unsafe struct CLOCache_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, void> CLOCache_dtor_0; // function pointer
        public System.IntPtr GetIfInMemory;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*> GetFreeObj; // function pointer
        public System.IntPtr GetCollection;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, System.IntPtr, byte> SetCollection; // function pointer
        public System.IntPtr Release;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*, byte> AddObj; // function pointer
        public System.IntPtr RemoveObj;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, byte> CanLoadFromDisk; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, byte> CanRequestFromNet; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, void> FlushFreeObjects; // function pointer
        public System.IntPtr SaveObjectToDisk;
        public System.IntPtr ReloadObject;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, void> LastWords; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*, byte> AddObj_Internal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*, void> RemoveObj_Internal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*, void> FreeObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*, void> DestroyObj; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*, void> FreelistAdd; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*, void> FreelistRemove; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*> FreelistRemoveOldest; // function pointer

        // Methods
    }

    // Generated Constructor
    public CLOCache(delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*> allocator, uint dbtype) {
        _ConstructorInternal(allocator, dbtype);
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x004FD0A0
    /// void __thiscall CLOCache::CLOCache(CLOCache*,DBObj*(__cdecl*allocator)(),unsigned int)</code>
    /// </summary>
    public void _ConstructorInternal(delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*> allocator, uint dbtype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLOCache, delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>, uint, void>)0x004FD0A0)(ref this, allocator, dbtype);
}

