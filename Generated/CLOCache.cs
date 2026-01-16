namespace ACBindings.Internal;


/// <summary>Specialized cache managing CLO database objects, inheriting common caching behavior from DBOCache and associating them with a specific database type via the constructor.</summary>
public unsafe struct CLOCache
{
    // Base Classes
    public ACBindings.Internal.DBOCache BaseClass_DBOCache; // ACBindings.Internal.DBOCache

    // Child Types
    public unsafe struct CLOCache_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, void> CLOCache_dtor_0; // function pointer
        public System.IntPtr GetIfInMemory;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*> GetFreeObj; // function pointer
        public System.IntPtr GetCollection;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, System.IntPtr, byte> SetCollection; // function pointer
        public System.IntPtr Release;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*, byte> AddObj; // function pointer
        public System.IntPtr RemoveObj;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, byte> CanLoadFromDisk; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, byte> CanRequestFromNet; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, void> FlushFreeObjects; // function pointer
        public System.IntPtr SaveObjectToDisk;
        public System.IntPtr ReloadObject;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, void> LastWords; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*, byte> AddObj_Internal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*, void> RemoveObj_Internal; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*, void> FreeObject; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*, void> DestroyObj; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*, void> FreelistAdd; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*, void> FreelistRemove; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.CLOCache*, ACBindings.Internal.DBObj*> FreelistRemoveOldest; // function pointer

        // Methods
    }

    // Generated Constructor
    public CLOCache(delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*> allocator, uint dbtype) {
        _ConstructorInternal(allocator, dbtype);
    }

    // Methods

    /// <summary>Creates a CLOCache object, initializing its base DBOCache with the supplied allocator and database type and setting up the derived virtual table.
    /// <code>Offset: 0x004FD0A0
    /// void __thiscall CLOCache::CLOCache(CLOCache*,DBObj*(__cdecl*allocator)(),unsigned int)</code>
    /// </summary>
    /// <param name="allocator">Function pointer used to allocate DBObj instances for the cache.</param>
    /// <param name="dbtype">Identifier of the database type to associate with the cache.</param>
    public void _ConstructorInternal(delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*> allocator, uint dbtype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLOCache, delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>, uint, void>)0x004FD0A0)(ref this, allocator, dbtype);
}

