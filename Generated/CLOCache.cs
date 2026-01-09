namespace ACBindings;

// CLOCache
public unsafe struct CLOCache
{
    // Base Classes
    public ACBindings.DBOCache BaseClass_DBOCache; // ACBindings.DBOCache

    // Child Types
    // CLOCache_vtbl
    public unsafe struct CLOCache_vtbl
    {
        // Members
        public System.IntPtr CLOCache_dtor_0; // function pointer
        public System.IntPtr GetIfInMemory;
        public System.IntPtr GetFreeObj; // function pointer
        public System.IntPtr GetCollection;
        public System.IntPtr SetCollection; // function pointer
        public System.IntPtr Release;
        public System.IntPtr AddObj; // function pointer
        public System.IntPtr RemoveObj;
        public System.IntPtr CanLoadFromDisk; // function pointer
        public System.IntPtr CanRequestFromNet; // function pointer
        public System.IntPtr FlushFreeObjects; // function pointer
        public System.IntPtr SaveObjectToDisk;
        public System.IntPtr ReloadObject;
        public System.IntPtr LastWords; // function pointer
        public System.IntPtr AddObj_Internal; // function pointer
        public System.IntPtr RemoveObj_Internal; // function pointer
        public System.IntPtr FreeObject; // function pointer
        public System.IntPtr DestroyObj; // function pointer
        public System.IntPtr FreelistAdd; // function pointer
        public System.IntPtr FreelistRemove; // function pointer
        public System.IntPtr FreelistRemoveOldest; // function pointer

        // Methods
    }

    // Generated Constructor
    public CLOCache(delegate* unmanaged[Cdecl]<ACBindings.DBObj*> allocator, uint dbtype) {
        _ConstructorInternal(allocator, dbtype);
    }

    // Methods
    // void __thiscall CLOCache::CLOCache(CLOCache*,DBObj*(__cdecl*allocator)(),unsigned int)
    public void _ConstructorInternal(delegate* unmanaged[Cdecl]<ACBindings.DBObj*> allocator, uint dbtype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLOCache, delegate* unmanaged[Cdecl]<ACBindings.DBObj*>, uint, void>)0x004FD0A0)(ref this, allocator, dbtype);
}

