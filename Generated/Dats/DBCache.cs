namespace ACBindings.Internal;

public unsafe struct DBCache : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.Interface BaseClass_Interface; // ACBindings.Internal.Interface
    public ACBindings.Internal.AsyncCache BaseClass_AsyncCache; // ACBindings.Internal.AsyncCache

    // Statics
    public static int* s_EngDataPackVer = (int*)0x008185E8;
    public static int* s_EngCellPackVer = (int*)0x008185EC;
    public static int* s_GameDataPackVer = (int*)0x008185F0;
    public static int* s_GameCellPackVer = (int*)0x008185F4;
    public static int* s_GameDidPackVer = (int*)0x008185F8;
    public static ACBindings.Internal.DBCache* s_pCache = (ACBindings.Internal.DBCache*)0x00837BAC;

    // Child Types
    public unsafe struct DBCache_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> DBCache_dtor_18; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.DBCache.Enum3> You_Must_Not_Have_Multiple_Implementations_Of_AddRef_In_A_Hierarchy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> ResetCache; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, int, int, uint, ACBindings.Internal.DBObj*> GetFromEnum; // function pointer
        public System.IntPtr GetDIDFromEnum;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.CACHE_OBJECT_CODES> PreFetch; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, ACBindings.Internal.DatIDStamp*, byte> InqDatIDStamp; // function pointer
        public System.IntPtr ReloadObject;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte, byte> SetShutdown; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte> IsLoader; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, uint, byte> SetRegion; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, byte> UnloadCellData; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> AskForLastWords; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, uint, byte, byte> SetLanguageInternal; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBCache*, void> DestroyObjectCaches; // function pointer

        // Methods
    }
    // DBCache::Enum3
    public enum Enum3 : uint
    {
    }
    // DBCache::Enum4
    public enum Enum4 : uint
    {
    }

    // Members
    public ACBindings.Internal.Turbine_RefCount m_cTurbineRefCount;
    public ACBindings.Internal.IDClass____tagDataID m_MasterMapID;
    public uint m_CurrentRegion;
    public uint m_LocalLanguage;
    public byte m_bRuntime;
    public byte m_bIsClient;
    public byte m_bIsServer;
    public ACBindings.Internal.IDataGraph* m_pDataGraph;

    // Generated Constructor
    public DBCache() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// Resets the database cache by clearing any active pre‑fetch callbacks, resetting the prefetch context, and flushing all pending asynchronous requests.
    /// 
    /// <code>Offset: 0x004139D0
    /// void __thiscall DBCache::ResetCache(DBCache*)</code>
    /// </summary>
    public void ResetCache() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, void>)0x004139D0)(ref this);

    /// <summary>Retrieves a database object for a given enumeration ID and group from the static cache.
    /// <code>Offset: 0x00413A00
    /// DBObj* __cdecl DBCache::GetFromEnumStatic(int,int,unsigned int)</code>
    /// </summary>
    /// <param name="enum_id">The identifier of the enumeration element.</param>
    /// <param name="enum_group">The group that the enumeration belongs to.</param>
    /// <param name="cache_index">An index specifying which cached instance to retrieve, if applicable.</param>
    /// <returns>Pointer to the requested DBObj, or nullptr when the static cache is unavailable.</returns>
    public static ACBindings.Internal.DBObj* GetFromEnumStatic(int enum_id, int enum_group, uint cache_index) => ((delegate* unmanaged[Cdecl]<int, int, uint, ACBindings.Internal.DBObj*>)0x00413A00)(enum_id, enum_group, cache_index);

    /// <summary>Initiates prefetching of a static data object identified by the supplied QualifiedDataID, delegating to the global database cache if available.
    /// <code>Offset: 0x00413A30
    /// CACHE_OBJECT_CODES __cdecl DBCache::PreFetchStatic(const QualifiedDataID*)</code>
    /// </summary>
    /// <param name="qdid">Qualified identifier for the desired data object.</param>
    /// <returns>A CACHE_OBJECT_CODES value indicating the result of the prefetch request; returns zero when no cache is initialized.</returns>
    public static ACBindings.Internal.CACHE_OBJECT_CODES PreFetchStatic(ACBindings.Internal.QualifiedDataID* qdid) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.CACHE_OBJECT_CODES>)0x00413A30)(qdid);

    /// <summary>Retrieves the current region number from the global database cache and writes it to the supplied output parameter.
    /// <code>Offset: 0x00413A50
    /// bool __cdecl DBCache::GetCurrentRegion(unsigned int*)</code>
    /// </summary>
    /// <param name="region_num">Pointer to an unsigned int that will receive the current region identifier.</param>
    /// <returns>True if a valid cache exists and the region was written; otherwise, false.</returns>
    public static byte GetCurrentRegion(uint* region_num) => ((delegate* unmanaged[Cdecl]<uint*, byte>)0x00413A50)(region_num);

    /// <summary>Determines whether the global database cache operates in runtime mode.
    /// <code>Offset: 0x00413A70
    /// bool __cdecl DBCache::IsRunTime()</code>
    /// </summary>
    /// <returns>True if the cache is running at runtime, otherwise false.</returns>
    public static byte IsRunTime() => ((delegate* unmanaged[Cdecl]<byte>)0x00413A70)();

    /// <summary>Determines whether the database cache is configured for client operation by checking its internal flag.
    /// <code>Offset: 0x00413A90
    /// bool __cdecl DBCache::IsClient()</code>
    /// </summary>
    /// <returns>True if operating as a client; otherwise false.</returns>
    public static byte IsClient() => ((delegate* unmanaged[Cdecl]<byte>)0x00413A90)();

    /// <summary>Indicates whether the database cache operates as a server.
    /// <code>Offset: 0x00413AB0
    /// bool __cdecl DBCache::IsServer()</code>
    /// </summary>
    /// <returns>True when the cache instance reports server mode; otherwise false.</returns>
    public static byte IsServer() => ((delegate* unmanaged[Cdecl]<byte>)0x00413AB0)();

    /// <summary>Updates the cache's current region to the specified identifier.
    /// <code>Offset: 0x00413AD0
    /// bool __thiscall DBCache::SetRegion(DBCache*,unsigned int)</code>
    /// </summary>
    /// <param name="rid">The new region ID to set as the current region.</param>
    /// <returns>True after setting the region successfully.</returns>
    public byte SetRegion(uint rid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, uint, byte>)0x00413AD0)(ref this, rid);

    /// <summary>Sets the database cache's local language, optionally restricting changes to the engine.
    /// <code>Offset: 0x00413AE0
    /// bool __cdecl DBCache::SetLocalLanguage(unsigned int,bool)</code>
    /// </summary>
    /// <param name="language_l">Language identifier to switch to.</param>
    /// <param name="engine_only">When true, only affect engine-level settings; otherwise affect all contexts.</param>
    /// <returns>True if the language was successfully set; false if no cache exists or the operation failed.</returns>
    public static byte SetLocalLanguage(uint language_l, byte engine_only) => ((delegate* unmanaged[Cdecl]<uint, byte, byte>)0x00413AE0)(language_l, engine_only);

    /// <summary>Retrieves the identifier of the local language configured in the database cache, returning zero when the cache is unavailable.
    /// <code>Offset: 0x00413B00
    /// unsigned int __cdecl DBCache::GetLocalLanguage()</code>
    /// </summary>
    /// <returns>The local language ID as an unsigned integer; zero indicates no cache present.</returns>
    public static uint GetLocalLanguage() => ((delegate* unmanaged[Cdecl]<uint>)0x00413B00)();

    /// <summary>Replaces the cache’s master map identifier with a new value and records the previous identifier.
    /// <code>Offset: 0x00413B60
    /// _DWORD* __thiscall DBCache::SetMasterMapDID(_DWORD*,_DWORD*,int)</code>
    /// </summary>
    /// <param name="a2">Pointer to a DWORD that receives the former master map ID before it is overwritten.</param>
    /// <param name="a3">The new master map ID to store in the cache.</param>
    /// <returns>Returns the same pointer supplied as <paramref name="a2"/>, now containing the old master map ID.</returns>
    public int* SetMasterMapDID(int* a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, int*, int, int*>)0x00413B60)(ref this, a2, a3);

    /// <summary>Retrieves an entry from the DBCache using two identifiers.
    /// <code>Offset: 0x00413B80
    /// int __cdecl DBCache::Get(int,int)</code>
    /// </summary>
    /// <param name="a1">Primary identifier for the data to fetch.</param>
    /// <param name="a2">Secondary identifier (e.g., sub-index or region).</param>
    /// <returns>The result of the internal cache lookup, typically a status code or reference.</returns>
    public static int Get(int a1, int a2) => ((delegate* unmanaged[Cdecl]<int, int, int>)0x00413B80)(a1, a2);

    /// <summary>Retrieves the data identifier corresponding to an enum value using the static cache if available.
    /// <code>Offset: 0x00413BC0
    /// IDClass&lt;_tagDataID,32,0&gt;* __cdecl DBCache::GetDIDFromEnumStatic(IDClass&lt;_tagDataID,32,0&gt;*,int,int)</code>
    /// </summary>
    /// <param name="a1">ID container that receives the resolved data identifier.</param>
    /// <param name="a2">Index of the enumeration value to look up.</param>
    /// <param name="a3">Context parameter (e.g., region or language) influencing the lookup.</param>
    /// <returns>Pointer to the IDClass containing the resolved identifier; if no cache is present, the ID is set to INVALID_DID_5.</returns>
    public static ACBindings.Internal.IDClass____tagDataID* GetDIDFromEnumStatic(ACBindings.Internal.IDClass____tagDataID* a1, int a2, int a3) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.IDClass____tagDataID*, int, int, ACBindings.Internal.IDClass____tagDataID*>)0x00413BC0)(a1, a2, a3);

    /// <summary>Converts two enumeration indices into a data identifier for the current region, storing the result in the supplied IDClass. If any lookup fails, the returned ID is set to an invalid value.
    /// <code>Offset: 0x00413BF0
    /// IDClass&lt;_tagDataID,32,0&gt;* __thiscall DBCache::GetDIDFromEnum(_DWORD*,IDClass&lt;_tagDataID,32,0&gt;*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The IDClass instance that will receive the resolved data identifier.</param>
    /// <param name="a3">Second enumeration value used in the second‑level mapping to obtain the final identifier.</param>
    /// <param name="a4">First enumeration value used for the initial lookup based on the current region.</param>
    /// <returns>Pointer to <paramref name="a2"/> after it has been updated with the resolved data ID (or an invalid ID if resolution fails).</returns>
    public ACBindings.Internal.IDClass____tagDataID* GetDIDFromEnum(ACBindings.Internal.IDClass____tagDataID* a2, uint a3, uint a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, ACBindings.Internal.IDClass____tagDataID*, uint, uint, ACBindings.Internal.IDClass____tagDataID*>)0x00413BF0)(ref this, a2, a3, a4);

    /// <summary>Retrieves a DBObj from the cache for the specified enumeration ID and group, optionally filtered by database type. If the group is invalid or no matching object exists, returns null.
    /// <code>Offset: 0x00413CC0
    /// DBObj* __thiscall DBCache::GetFromEnum(DBCache*,int,int,unsigned int)</code>
    /// </summary>
    /// <param name="enum_id">The identifier of the enumeration item.</param>
    /// <param name="enum_group">The group within which to search; must be a valid data ID.</param>
    /// <param name="dbtype">Database type qualifier for the lookup.</param>
    /// <returns>Pointer to the requested DBObj, or nullptr if not found.</returns>
    public ACBindings.Internal.DBObj* GetFromEnum(int enum_id, int enum_group, uint dbtype) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, int, int, uint, ACBindings.Internal.DBObj*>)0x00413CC0)(ref this, enum_id, enum_group, dbtype);

    /// <summary>Reloads a database entry identified by the given IDs into the cache, updating any existing instance with fresh data.
    /// <code>Offset: 0x00413D20
    /// char __thiscall DBCache::ReloadObject(_DWORD*,int,int)</code>
    /// </summary>
    /// <param name="a2">Primary identifier for the object to reload.</param>
    /// <param name="a3">Secondary identifier or variant of the object.</param>
    /// <returns>True if the object was successfully reloaded; otherwise false.</returns>
    public sbyte ReloadObject(int a2, int a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, int, int, sbyte>)0x00413D20)(ref this, a2, a3);

    /// <summary>Registers a database object in the cache’s data graph when it is valid and not excluded by type checks, incrementing its reference count accordingly.
    /// <code>Offset: 0x00413DE0
    /// void __cdecl DBCache::AddToDataGraph(const DBObj*)</code>
    /// </summary>
    /// <param name="obj">The database object to add to the data graph.</param>
    public static void AddToDataGraph(ACBindings.Internal.DBObj* obj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*, void>)0x00413DE0)(obj);

    /// <summary>Initializes the database cache by ensuring a global MasterDBMap instance exists and configuring its game and engine data directories based on project settings.
    /// <code>Offset: 0x004141E0
    /// bool __stdcall DBCache::Init(int,int)</code>
    /// </summary>
    /// <returns>True if the initialization succeeds; otherwise returns false.</returns>
    public static byte Init(int a1, int a2) => ((delegate* unmanaged[Stdcall]<int, int, byte>)0x004141E0)(a1, a2);

    /// <summary>Updates time‑dependent state for the database cache and propagates changes to all associated object caches.
    /// <code>Offset: 0x00414390
    /// void __thiscall DBCache::UseTime(DBCache*)</code>
    /// </summary>
    public void UseTime() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, void>)0x00414390)(ref this);

    /// <summary>Unloads cell data from the cache by iterating over cached objects, invoking their unload routine for cell-type entries, and reports success only when all cells are cleared.
    /// <code>Offset: 0x004143F0
    /// bool __thiscall DBCache::UnloadCellData(DBCache*)</code>
    /// </summary>
    /// <returns>True if every cell was successfully unloaded; otherwise false.</returns>
    public byte UnloadCellData() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, byte>)0x004143F0)(ref this);

    /// <summary>Iterates through every entry in the cache’s intrusive hash table, invoking a cleanup routine on each stored object.
    /// <code>Offset: 0x00414480
    /// void __thiscall DBCache::AskForLastWords(DBCache*)</code>
    /// </summary>
    public void AskForLastWords() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, void>)0x00414480)(ref this);

    /// <summary>Destroys or releases cached objects for the specified database type, or all cached objects when no type is specified.
    /// <code>Offset: 0x004144E0
    /// void __thiscall DBCache::FlushFreeObjects(DBCache*,unsigned int)</code>
    /// </summary>
    /// <param name="db_type">Database type identifier; zero indicates flushing all types.</param>
    public void FlushFreeObjects(uint db_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, uint, void>)0x004144E0)(ref this, db_type);

    /// <summary>Retrieves a DBOCache instance matching the supplied dbtype from an internal hash table.
    /// <code>Offset: 0x00414590
    /// DBOCache* __cdecl DBCache::GetDBOCache(unsigned int)</code>
    /// </summary>
    /// <param name="dbtype">Identifier of the database type to look up.</param>
    /// <returns>Pointer to the corresponding DBOCache object, or null if not found.</returns>
    public static ACBindings.Internal.DBOCache* GetDBOCache(uint dbtype) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.DBOCache*>)0x00414590)(dbtype);

    /// <summary>Maintains free object pools within the DBCache for a specified database type or, when db_type is zero, all registered types; keep_f specifies whether freed objects should be retained.
    /// <code>Offset: 0x00414620
    /// bool __thiscall DBCache::KeepFreeObjects(DBCache*,bool,unsigned int)</code>
    /// </summary>
    /// <param name="keep_f">If true, preserved objects are kept; if false, they may be released.</param>
    /// <param name="db_type">Identifier of the database type to process. A value of 0 causes every type in the cache to be handled.</param>
    /// <returns>True when the operation completes successfully (always returns true).</returns>
    public byte KeepFreeObjects(byte keep_f, uint db_type) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, byte, uint, byte>)0x00414620)(ref this, keep_f, db_type);

    /// <summary>Retrieves the cached database object corresponding to the specified data ID type from the global object cache.
    /// <code>Offset: 0x004146B0
    /// DBOCache* __thiscall DBCache::GetDBOCache(DBCache*,const QualifiedDataID*)</code>
    /// </summary>
    /// <param name="qdid">The qualified data identifier whose Type field determines the cache bucket to search.</param>
    /// <returns>A pointer to the matching DBOCache instance, or null if no entry exists for that type.</returns>
    public ACBindings.Internal.DBOCache* GetDBOCache(ACBindings.Internal.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.DBOCache*>)0x004146B0)(ref this, qdid);

    /// <summary>Retrieves the status of a database object and initiates prefetching if required.
    /// <code>Offset: 0x00414FE0
    /// CACHE_OBJECT_CODES __thiscall DBCache::PreFetch(DBCache*,const QualifiedDataID*)</code>
    /// </summary>
    /// <param name="qdid">The identifier of the data to check or fetch.</param>
    /// <returns>2 when the object is already in memory, 1 when it exists on disk but is not yet loaded, and –1 when it must be fetched asynchronously.</returns>
    public ACBindings.Internal.CACHE_OBJECT_CODES PreFetch(ACBindings.Internal.QualifiedDataID* qdid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.CACHE_OBJECT_CODES>)0x00414FE0)(ref this, qdid);

    /// <summary>Destroys all object caches maintained by the database cache, releasing reference counts and clearing internal data structures.
    /// <code>Offset: 0x00415040
    /// void __thiscall DBCache::DestroyObjectCaches(DBCache*)</code>
    /// </summary>
    public void DestroyObjectCaches() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, void>)0x00415040)(ref this);

    /// <summary>Destroys a DBCache instance, releasing master database map entries, cancelling pending prefetch callbacks, resetting static cache state and reference counts, then calls the AsyncCache destructor to free its internal resources.
    /// <code>Offset: 0x004151B0
    /// void __thiscall DBCache::~DBCache(DBCache*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, void>)0x004151B0)(ref this);

    /// <summary>
    /// Attempts to acquire the requested interface from this DBCache instance. If the supplied GUID matches the supported interface, returns a reference to the object and sets a success code; otherwise returns an error code.
    /// 
    /// <code>Offset: 0x00415210
    /// TResult* __thiscall DBCache::QueryInterface(DBCache*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="result">Structure used to receive the operation status.</param>
    /// <param name="i_rcInterface">GUID identifying the desired interface.</param>
    /// <param name="o_ppObject">Output pointer that receives the requested interface on success.</param>
    /// <returns>Pointer to the result structure containing the status code.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x00415210)(ref this, result, i_rcInterface, o_ppObject);

    /// <summary>Increments the Turbine reference counter for this cache instance and returns the updated count.
    /// <code>Offset: 0x00415270
    /// unsigned int __thiscall DBCache::AddRef(DBCache*)</code>
    /// </summary>
    /// <returns>The reference count after incrementing.</returns>
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, uint>)0x00415270)(ref this);

    /// <summary>Decrements the Turbine reference count of the cache and initiates cleanup when the count reaches zero.
    /// <code>Offset: 0x00415280
    /// unsigned int __thiscall DBCache::Release(DBCache*)</code>
    /// </summary>
    /// <param name="this">The DBCache instance whose reference count is being released.</param>
    /// <returns>The remaining reference count after decrementing; a value of zero indicates the object has been fully released.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, uint>)0x00415280)(ref this);

    /// <summary>Propagates a shutdown state to all objects stored in the cache, potentially freeing their resources.
    /// <code>Offset: 0x004152B0
    /// bool __thiscall DBCache::SetShutdown(DBCache*,bool)</code>
    /// </summary>
    /// <param name="shut_f">True when the cache is being shut down; false otherwise.</param>
    /// <returns>Always returns false (the return value is not used).</returns>
    public byte SetShutdown(byte shut_f) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, byte, byte>)0x004152B0)(ref this, shut_f);

    /// <summary>Initializes a new DBCache, setting up its AsyncCache and Interface bases, configuring default region, language, and runtime flags, and registering the instance as the global cache.
    /// <code>Offset: 0x00415320
    /// void __thiscall DBCache::DBCache(DBCache*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, void>)0x00415320)(ref this);

    /// <summary>
    /// <code>Offset: 0x006A1050
    /// bool __thiscall DBCache::IsLoader(gmNoticeHandler*)</code>
    /// </summary>
    public byte IsLoader() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBCache, byte>)0x006A1050)(ref this);
}

