namespace ACBindings;

// DBOCache
public unsafe struct DBOCache : System.IDisposable
{
    // Child Types
    // DBOCache_vtbl
    public unsafe struct DBOCache_vtbl
    {
        // Members
        public System.IntPtr DBOCache_dtor_0; // function pointer
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

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.AutoGrowHashTable__IDClass___tagDataID__DBObj_ptr m_ObjTable;
    public uint m_dbtype;
    public ACBindings.HashTable__uint__float m_fidelityTable;
    public byte m_fCanKeepFreeObjs;
    public byte m_fKeepFreeObjs;
    public byte m_bFreelistActive;
    public ACBindings.FreelistDef m_freelistDef;
    public ACBindings.DBObj* m_pOldestFree;
    public ACBindings.DBObj* m_pYoungestFree;
    public uint m_nFree;
    public uint m_nTotalCount;
    public System.IntPtr m_pfnAllocator; // function pointer

    // Generated Constructor
    public DBOCache(delegate* unmanaged[Cdecl]<ACBindings.DBObj*> allocator, uint dbtype) {
        _ConstructorInternal(allocator, dbtype);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // bool __thiscall DBOCache::AddObj(DBOCache*,DBObj*)
    public byte AddObj(ACBindings.DBObj* obj_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, ACBindings.DBObj*, byte>)0x00416950)(ref this, obj_p);
    // bool __thiscall DBOCache::KeepFreeObjects(DBOCache*,bool)
    public byte KeepFreeObjects(byte keep_f) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, byte, byte>)0x00416970)(ref this, keep_f);
    // void __thiscall DBOCache::FreeObject(DBOCache*,DBObj*)
    public void FreeObject(ACBindings.DBObj* object_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, ACBindings.DBObj*, void>)0x004169A0)(ref this, object_p);
    // void __thiscall DBOCache::FreelistRemove(DBOCache*,DBObj*)
    public void FreelistRemove(ACBindings.DBObj* object_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, ACBindings.DBObj*, void>)0x004169F0)(ref this, object_p);
    // DBObj* __thiscall DBOCache::FreelistRemoveOldest(DBOCache*)
    public ACBindings.DBObj* FreelistRemoveOldest() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, ACBindings.DBObj*>)0x00416A50)(ref this);
    // DBObj* __thiscall DBOCache::GetFreeObj(DBOCache*)
    public ACBindings.DBObj* GetFreeObj() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, ACBindings.DBObj*>)0x00416A70)(ref this);
    // void __thiscall DBOCache::UseTime(DBOCache*)
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, void>)0x00416AC0)(ref this);
    // void __thiscall DBOCache::FlushFreeObjects(DBOCache*)
    public void FlushFreeObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, void>)0x00416B10)(ref this);
    // int __thiscall DBOCache::ReloadObject(_DWORD*,int)
    public int ReloadObject(int a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, int, int>)0x00416B30)(ref this, a2);
    // void __thiscall DBOCache::FreelistAdd(DBOCache*,DBObj*)
    public void FreelistAdd(ACBindings.DBObj* object_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, ACBindings.DBObj*, void>)0x00416B50)(ref this, object_p);
    // bool __thiscall DBOCache::IsInMemory(_DWORD*,unsigned int)
    public byte IsInMemory(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, uint, byte>)0x00416C50)(ref this, a2);
    // void __thiscall DBOCache::DestroyObj(DBOCache*,DBObj*)
    public void DestroyObj(ACBindings.DBObj* object_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, ACBindings.DBObj*, void>)0x00416C80)(ref this, object_p);
    // bool __thiscall DBOCache::RemoveObj(_DWORD*,unsigned int)
    public byte RemoveObj(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, uint, byte>)0x00416E40)(ref this, a2);
    // int __thiscall DBOCache::GetIfInMemory(_DWORD*,unsigned int,char)
    public int GetIfInMemory(uint a2, sbyte a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, uint, sbyte, int>)0x00416EB0)(ref this, a2, a3);
    // int __thiscall DBOCache::GetIfUsing(_DWORD*,unsigned int)
    public int GetIfUsing(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, uint, int>)0x00416F40)(ref this, a2);
    // int __thiscall DBOCache::Release(_DWORD*,unsigned int)
    public int Release(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, uint, int>)0x00416FA0)(ref this, a2);
    // void __thiscall DBOCache::~DBOCache(DBOCache*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, void>)0x00417360)(ref this);
    // bool __thiscall DBOCache::AddObj_Internal(DBOCache*,DBObj*)
    public byte AddObj_Internal(ACBindings.DBObj* object_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, ACBindings.DBObj*, byte>)0x00417440)(ref this, object_p);
    // void __thiscall DBOCache::RemoveObj_Internal(DBOCache*,DBObj*)
    public void RemoveObj_Internal(ACBindings.DBObj* object_p) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, ACBindings.DBObj*, void>)0x004174C0)(ref this, object_p);
    // void __thiscall DBOCache::DBOCache(DBOCache*,DBObj*(__cdecl*allocator)(),unsigned int)
    public void _ConstructorInternal(delegate* unmanaged[Cdecl]<ACBindings.DBObj*> allocator, uint dbtype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.DBOCache, delegate* unmanaged[Cdecl]<ACBindings.DBObj*>, uint, void>)0x00417510)(ref this, allocator, dbtype);
}

