namespace ACBindings.Internal;

public unsafe struct DBOCache : System.IDisposable
{
    // Child Types
    public unsafe struct DBOCache_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBOCache*, void> DBOCache_dtor_0; // function pointer
        public System.IntPtr GetIfInMemory;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBOCache*, ACBindings.Internal.DBObj*> GetFreeObj; // function pointer
        public System.IntPtr GetCollection;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBOCache*, System.IntPtr, byte> SetCollection; // function pointer
        public System.IntPtr Release;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBOCache*, ACBindings.Internal.DBObj*, byte> AddObj; // function pointer
        public System.IntPtr RemoveObj;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBOCache*, byte> CanLoadFromDisk; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBOCache*, byte> CanRequestFromNet; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBOCache*, void> FlushFreeObjects; // function pointer
        public System.IntPtr SaveObjectToDisk;
        public System.IntPtr ReloadObject;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBOCache*, void> LastWords; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBOCache*, ACBindings.Internal.DBObj*, byte> AddObj_Internal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBOCache*, ACBindings.Internal.DBObj*, void> RemoveObj_Internal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBOCache*, ACBindings.Internal.DBObj*, void> FreeObject; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBOCache*, ACBindings.Internal.DBObj*, void> DestroyObj; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBOCache*, ACBindings.Internal.DBObj*, void> FreelistAdd; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBOCache*, ACBindings.Internal.DBObj*, void> FreelistRemove; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBOCache*, ACBindings.Internal.DBObj*> FreelistRemoveOldest; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.AutoGrowHashTable___IDClass____tagDataID___DBObj_ptr m_ObjTable;
    public uint m_dbtype;
    public ACBindings.Internal.HashTable__uint__float m_fidelityTable;
    public byte m_fCanKeepFreeObjs;
    public byte m_fKeepFreeObjs;
    public byte m_bFreelistActive;
    public ACBindings.Internal.FreelistDef m_freelistDef;
    public ACBindings.Internal.DBObj* m_pOldestFree;
    public ACBindings.Internal.DBObj* m_pYoungestFree;
    public uint m_nFree;
    public uint m_nTotalCount;
    public delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*> m_pfnAllocator; // function pointer

    // Generated Constructor
    public DBOCache(delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*> allocator, uint dbtype) {
        _ConstructorInternal(allocator, dbtype);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Inserts a DBObj into the cache, incrementing its link counter on success.
    /// <code>Offset: 0x00416950
    /// bool __thiscall DBOCache::AddObj(DBOCache*,DBObj*)</code>
    /// </summary>
    /// <param name="obj_p">The DBObj to add to the cache.</param>
    /// <returns>True if the object was added; false otherwise.</returns>
    public byte AddObj(ACBindings.Internal.DBObj* obj_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, ACBindings.Internal.DBObj*, byte>)0x00416950)(ref this, obj_p);

    /// <summary>Toggles whether the cache keeps free objects; disabling it flushes any existing free objects if they were previously retained.
    /// <code>Offset: 0x00416970
    /// bool __thiscall DBOCache::KeepFreeObjects(DBOCache*,bool)</code>
    /// </summary>
    /// <param name="keep_f">Desired state for keeping free objects (true to enable, false to disable).</param>
    /// <returns>Previous keep-free-objects setting before the change.</returns>
    public byte KeepFreeObjects(byte keep_f) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, byte, byte>)0x00416970)(ref this, keep_f);

    /// <summary>Frees a database object, releasing its reference and marking it unloaded; if the cache is configured to keep free objects and the item allows it, places the object on the freelist, otherwise destroys it.
    /// <code>Offset: 0x004169A0
    /// void __thiscall DBOCache::FreeObject(DBOCache*,DBObj*)</code>
    /// </summary>
    /// <param name="object_p">The DBObj instance to be freed from the cache.</param>
    public void FreeObject(ACBindings.Internal.DBObj* object_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, ACBindings.Internal.DBObj*, void>)0x004169A0)(ref this, object_p);

    /// <summary>Removes a database object from the cache's freelist, updating linked‑list pointers and decrementing the free object count.
    /// <code>Offset: 0x004169F0
    /// void __thiscall DBOCache::FreelistRemove(DBOCache*,DBObj*)</code>
    /// </summary>
    /// <param name="object_p">The database object to be removed from the freelist.</param>
    public void FreelistRemove(ACBindings.Internal.DBObj* object_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, ACBindings.Internal.DBObj*, void>)0x004169F0)(ref this, object_p);

    /// <summary>Removes the oldest free object from the cache's freelist and returns it; if no free objects are available, returns nullptr.
    /// <code>Offset: 0x00416A50
    /// DBObj* __thiscall DBOCache::FreelistRemoveOldest(DBOCache*)</code>
    /// </summary>
    /// <returns>The freed DBObj that was at the head of the list, or nullptr when the freelist is empty.</returns>
    public ACBindings.Internal.DBObj* FreelistRemoveOldest() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, ACBindings.Internal.DBObj*>)0x00416A50)(ref this);

    /// <summary>Retrieves a free object from the cache, recycling an existing instance when possible; otherwise allocates a new object.
    /// <code>Offset: 0x00416A70
    /// DBObj* __thiscall DBOCache::GetFreeObj(DBOCache*)</code>
    /// </summary>
    /// <returns>A pointer to a DBObj that can be reused or newly allocated.</returns>
    public ACBindings.Internal.DBObj* GetFreeObj() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, ACBindings.Internal.DBObj*>)0x00416A70)(ref this);

    /// <summary>Ensures that the cache does not retain more free objects than its ideal size by removing the oldest free object if it has been idle for over thirty seconds.
    /// <code>Offset: 0x00416AC0
    /// void __thiscall DBOCache::UseTime(DBOCache*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, void>)0x00416AC0)(ref this);

    /// <summary>Clears the cache’s free object list by repeatedly removing the oldest free object and destroying it.
    /// <code>Offset: 0x00416B10
    /// void __thiscall DBOCache::FlushFreeObjects(DBOCache*)</code>
    /// </summary>
    public void FlushFreeObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, void>)0x00416B10)(ref this);

    /// <summary>Reloads a database object identified by the supplied ID in this cache instance.
    /// <code>Offset: 0x00416B30
    /// int __thiscall DBOCache::ReloadObject(_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">The identifier of the object to be reloaded.</param>
    /// <returns>Result code from the underlying cache reload operation.</returns>
    public int ReloadObject(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, int, int>)0x00416B30)(ref this, a2);

    /// <summary>Adds the specified DBObj to the cache's freelist when allowed and freelisting enabled. Updates the object's timestamp, inserts it as the newest free entry in the linked list, and enforces the maximum freelist size by removing and destroying the oldest object if necessary.
    /// <code>Offset: 0x00416B50
    /// void __thiscall DBOCache::FreelistAdd(DBOCache*,DBObj*)</code>
    /// </summary>
    /// <param name="object_p">The database object to be added to the freelist.</param>
    public void FreelistAdd(ACBindings.Internal.DBObj* object_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, ACBindings.Internal.DBObj*, void>)0x00416B50)(ref this, object_p);

    /// <summary>Determines whether an object with the specified identifier exists in this cache’s memory.
    /// <code>Offset: 0x00416C50
    /// bool __thiscall DBOCache::IsInMemory(_DWORD*,unsigned int)</code>
    /// </summary>
    /// <param name="this">The cache instance to query.</param>
    /// <param name="a2">The identifier of the object to locate.</param>
    /// <returns>True if an entry with that identifier is present; otherwise, false.</returns>
    public byte IsInMemory(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, uint, byte>)0x00416C50)(ref this, a2);

    /// <summary>Removes the specified DBObj from the cache’s hash table, updating bookkeeping and releasing the object when its link count drops to zero.
    /// <code>Offset: 0x00416C80
    /// void __thiscall DBOCache::DestroyObj(DBOCache*,DBObj*)</code>
    /// </summary>
    /// <param name="object_p">The database object to be destroyed.</param>
    public void DestroyObj(ACBindings.Internal.DBObj* object_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, ACBindings.Internal.DBObj*, void>)0x00416C80)(ref this, object_p);

    /// <summary>Removes the database object identified by the specified key from the cache, updating internal hash table entries and reference counts.
    /// <code>Offset: 0x00416E40
    /// bool __thiscall DBOCache::RemoveObj(_DWORD*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The unsigned integer identifier of the object to remove.</param>
    /// <returns>True if an object with that identifier was found and removed; otherwise false.</returns>
    public byte RemoveObj(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, uint, byte>)0x00416E40)(ref this, a2);

    /// <summary>Fetches a database object from the cache by its identifier, increments its reference count and may mark it as in use based on a flag.
    /// <code>Offset: 0x00416EB0
    /// int __thiscall DBOCache::GetIfInMemory(_DWORD*,unsigned int,char)</code>
    /// </summary>
    /// <param name="a2">Identifier of the database object to retrieve.</param>
    /// <param name="a3">If non‑zero, attempts to keep an unused object marked as in use; otherwise permits it to be freed if no longer referenced.</param>
    /// <returns>Pointer to the requested DBObj on success; null when the object is not cached or cannot be kept alive.</returns>
    public int GetIfInMemory(uint a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, uint, sbyte, int>)0x00416EB0)(ref this, a2, a3);

    /// <summary>Finds a cached object by ID and returns it only when it is already in use, incrementing its internal usage counter.
    /// <code>Offset: 0x00416F40
    /// int __thiscall DBOCache::GetIfUsing(_DWORD*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The identifier of the database object to look up.</param>
    /// <returns>A pointer to the requested object if found and currently in use; otherwise zero.</returns>
    public int GetIfUsing(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, uint, int>)0x00416F40)(ref this, a2);

    /// <summary>Decrements the reference count for the cached object identified by the specified ID and frees it when the count reaches zero.
    /// <code>Offset: 0x00416FA0
    /// int __thiscall DBOCache::Release(_DWORD*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The unique identifier of the object to release from the cache.</param>
    /// <returns>The remaining reference count after decrement, or 0 if the object was not found or already released.</returns>
    public int Release(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, uint, int>)0x00416FA0)(ref this, a2);

    /// <summary>Destroys the DBOCache instance, releasing all stored objects and clearing internal hash tables.
    /// <code>Offset: 0x00417360
    /// void __thiscall DBOCache::~DBOCache(DBOCache*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, void>)0x00417360)(ref this);

    /// <summary>Adds a DBObj instance to the cache, ensuring it is non‑null, has a valid identifier, and is not already stored.
    /// <code>Offset: 0x00417440
    /// bool __thiscall DBOCache::AddObj_Internal(DBOCache*,DBObj*)</code>
    /// </summary>
    /// <param name="this">The DBOCache instance receiving the object.</param>
    /// <param name="object_p">The DBObj to add.</param>
    /// <returns>True if the object was added; false if the pointer is null, the ID is invalid, or an entry with that ID already exists.</returns>
    public byte AddObj_Internal(ACBindings.Internal.DBObj* object_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, ACBindings.Internal.DBObj*, byte>)0x00417440)(ref this, object_p);

    /// <summary>Removes a DBObj from the cache’s internal table, updates bookkeeping counts, frees associated resources when present, and detaches the object by clearing its maintainer pointer.
    /// <code>Offset: 0x004174C0
    /// void __thiscall DBOCache::RemoveObj_Internal(DBOCache*,DBObj*)</code>
    /// </summary>
    /// <param name="object_p">The database object to remove from the cache.</param>
    public void RemoveObj_Internal(ACBindings.Internal.DBObj* object_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, ACBindings.Internal.DBObj*, void>)0x004174C0)(ref this, object_p);

    /// <summary>Initializes a database object cache with specified type, setting up internal hash tables and freelist parameters.
    /// <code>Offset: 0x00417510
    /// void __thiscall DBOCache::DBOCache(DBOCache*,DBObj*(__cdecl*allocator)(),unsigned int)</code>
    /// </summary>
    /// <param name="allocator">Function used to allocate new DBObj instances when needed.</param>
    /// <param name="dbtype">Identifier indicating the type of database for which this cache is created.</param>
    public void _ConstructorInternal(delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*> allocator, uint dbtype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBOCache, delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>, uint, void>)0x00417510)(ref this, allocator, dbtype);
}

