namespace ACBindings.Internal;

public unsafe struct DBObj : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.Interface BaseClass_Interface; // ACBindings.Internal.Interface

    // Child Types
    public unsafe struct DBObj_vtbl
    {
        // Members
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public uint m_dataCategory;
    public byte m_bLoaded;
    public double m_timeStamp;
    public ACBindings.Internal.DBObj* m_pNext;
    public ACBindings.Internal.DBObj* m_pLast;
    public ACBindings.Internal.DBOCache* m_pMaintainer;
    public int m_numLinks;
    public ACBindings.Internal.IDClass____tagDataID m_DID;
    public byte m_AllowedInFreeList;

    // Generated Constructor
    public DBObj(void** a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Adds the current object to the data graph managed by the database cache.
    /// <code>Offset: 0x004153C0
    /// void __thiscall DBObj::AddToDataGraph(DBObj*)</code>
    /// </summary>
    public void AddToDataGraph() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBObj, void>)0x004153C0)(ref this);

    /// <summary>Adds a reference to the object, incrementing its internal counter unless a cache maintainer handles reference management.
    /// <code>Offset: 0x004153D0
    /// unsigned int __thiscall DBObj::AddRef(DBObj*)</code>
    /// </summary>
    /// <returns>The current number of references held by this object after the operation. If a maintainer exists, the returned value reflects the counter managed by that maintainer; otherwise it is the new link count.</returns>
    public uint AddRef() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBObj, uint>)0x004153D0)(ref this);

    /// <summary>Decrements the object's link counter and releases it when no more references remain, optionally delegating to an associated cache.
    /// <code>Offset: 0x00415400
    /// unsigned int __thiscall DBObj::Release(DBObj*)</code>
    /// </summary>
    /// <returns>The updated reference count after decrement; zero indicates the object has been released.</returns>
    public uint Release() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBObj, uint>)0x00415400)(ref this);

    /// <summary>Retrieves a database object matching the specified qualified data ID from the global cache; returns nullptr when no cache is available or the requested object does not exist.
    /// <code>Offset: 0x00415430
    /// DBObj* __cdecl DBObj::Get(const QualifiedDataID*)</code>
    /// </summary>
    /// <param name="qdid">The QualifiedDataID identifying the desired database object.</param>
    /// <returns>A pointer to the found DBObj instance, or nullptr if retrieval fails.</returns>
    public static ACBindings.Internal.DBObj* Get(ACBindings.Internal.QualifiedDataID* qdid) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.QualifiedDataID*, ACBindings.Internal.DBObj*>)0x00415430)(qdid);

    /// <summary>Initializes a DBObj instance with default values and stores the supplied maintainer pointer.
    /// <code>Offset: 0x00415460
    /// void*** __thiscall DBObj::DBObj(void***,void**)</code>
    /// </summary>
    /// <param name="a2">Pointer to the object's maintainer or related component.</param>
    public void*** _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBObj, void**, void***>)0x00415460)(ref this, a2);

    /// <summary>Returns true to indicate successful initialization.
    /// <code>Offset: 0x004154A0
    /// bool __cdecl DBObj::InitLoad()</code>
    /// </summary>
    /// <returns>True.</returns>
    public static byte InitLoad() => ((delegate* unmanaged[Cdecl]<byte>)0x004154A0)();

    /// <summary>Restores the virtual function table of the base interface to DBObj’s vtable when a DBObj instance is destroyed.
    /// <code>Offset: 0x004154B0
    /// void __thiscall DBObj::~DBObj(DBObj*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBObj, void>)0x004154B0)(ref this);

    /// <summary>Attempts to retrieve a specified interface from a database object, supporting only the predefined interface GUID.
    /// <code>Offset: 0x004154C0
    /// TResult* __thiscall DBObj::QueryInterface(DBObj*,TResult*,const Turbine_GUID*,void**)</code>
    /// </summary>
    /// <param name="result">Structure used for receiving the operation status code; on success its m_val is set to 0.</param>
    /// <param name="i_rcInterface">GUID of the requested interface.</param>
    /// <param name="o_ppObject">Receives pointer to the interface implementation when successful.</param>
    /// <returns>The same result pointer passed in, enabling method chaining.</returns>
    public ACBindings.Internal.TResult* QueryInterface(ACBindings.Internal.TResult* result, ACBindings.Internal.Turbine_GUID* i_rcInterface, void** o_ppObject) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBObj, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*>)0x004154C0)(ref this, result, i_rcInterface, o_ppObject);

    /// <summary>Reloads the object's data from disk using its identifier and the associated cache.
    /// <code>Offset: 0x00415520
    /// bool __thiscall DBObj::ReloadFromDisk(DBObj*)</code>
    /// </summary>
    /// <returns>True if the reload succeeded; otherwise false when no ID or cache is unavailable.</returns>
    public byte ReloadFromDisk() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBObj, byte>)0x00415520)(ref this);

    /// <summary>Persists the current database object to disk using the supplied preprocessing header, delegating to the object's managing cache when available.
    /// <code>Offset: 0x00415550
    /// char __thiscall DBObj::SaveToDisk(DBObj*,const PreprocHeader*)</code>
    /// </summary>
    /// <param name="a2">Preprocessing header containing metadata required for serialization.</param>
    /// <returns>Non‑zero if the save succeeded; zero otherwise.</returns>
    public sbyte SaveToDisk(ACBindings.Internal.PreprocHeader* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBObj, ACBindings.Internal.PreprocHeader*, sbyte>)0x00415550)(ref this, a2);

    /// <summary>Serializes or deserializes the object’s identifier and, when applicable, its data category to or from an archive based on the archive’s flags.
    /// <code>Offset: 0x00415590
    /// void __thiscall DBObj::Serialize(DBObj*,Archive*)</code>
    /// </summary>
    /// <param name="this">The DBObj instance whose state is being serialized or deserialized.</param>
    /// <param name="io_archive">The archive used for reading or writing the object's data.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBObj, ACBindings.Internal.Archive*, void>)0x00415590)(ref this, io_archive);

    /// <summary>Detaches the given database object from its cache when it implements the required interface, using its unique data identifier.
    /// <code>Offset: 0x00415610
    /// void __cdecl DBObj::Remove(const DBObj*)</code>
    /// </summary>
    /// <param name="pObj">The DBObj instance to be removed from its maintaining cache.</param>
    public static void Remove(ACBindings.Internal.DBObj* pObj) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*, void>)0x00415610)(pObj);

    /// <summary>
    /// Retrieves or constructs an IDClass instance corresponding to the specified enumeration values by delegating to DBCache::GetDIDFromEnumStatic, then returns the supplied pointer.
    /// 
    /// <code>Offset: 0x00415640
    /// IDClass&lt;_tagDataID,32,0&gt;* __cdecl DBObj::GetDIDByEnum(IDClass&lt;_tagDataID,32,0&gt;*,int,int)</code>
    /// </summary>
    /// <param name="a1">Pointer to an IDClass object that will be initialized with the resulting data identifier.</param>
    /// <param name="a2">Enumeration value or category index used for lookup.</param>
    /// <param name="a3">Additional enumeration parameter (e.g., sub‑index or modifier).</param>
    /// <returns>Same pointer passed in, now populated with the retrieved IDClass information.</returns>
    public static ACBindings.Internal.IDClass____tagDataID* GetDIDByEnum(ACBindings.Internal.IDClass____tagDataID* a1, int a2, int a3) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.IDClass____tagDataID*, int, int, ACBindings.Internal.IDClass____tagDataID*>)0x00415640)(a1, a2, a3);

    /// <summary>Retrieves a <c>DBObj</c> instance matching the provided enum identifier and group for the specified data type.
    /// <code>Offset: 0x00415730
    /// DBObj* __cdecl DBObj::GetByEnum(int,int,unsigned int)</code>
    /// </summary>
    /// <param name="enum_id">The numeric value of the enumeration to look up.</param>
    /// <param name="enum_group">Group or category that narrows the enum search.</param>
    /// <param name="MyType">Bitmask indicating which object types are acceptable.</param>
    /// <returns>Pointer to the matching <c>DBObj</c>, or <c>nullptr</c> if no match is found.</returns>
    public static ACBindings.Internal.DBObj* GetByEnum(int enum_id, int enum_group, uint MyType) => ((delegate* unmanaged[Cdecl]<int, int, uint, ACBindings.Internal.DBObj*>)0x00415730)(enum_id, enum_group, MyType);

    /// <summary>Adds the object's primary data ID to the supplied graph and connects it with all related data IDs maintained by the object.
    /// <code>Offset: 0x00415760
    /// void __thiscall DBObj::FillDataGraph(DBObj*,IDataGraph*)</code>
    /// </summary>
    /// <param name="graph">The IDataGraph instance to populate.</param>
    public void FillDataGraph(ACBindings.Internal.IDataGraph* graph) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBObj, ACBindings.Internal.IDataGraph*, void>)0x00415760)(ref this, graph);
}

