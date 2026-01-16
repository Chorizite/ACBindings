namespace ACBindings.Internal;


/// <summary>Manages the collection of quest definitions in a hash table keyed by case‑insensitive string names, providing serialization and database object behavior through SerializeUsingPackDBObj inheritance.</summary>
public unsafe struct QuestDefDB : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct QuestDefDB_vtbl
    {
        // Members
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, ACBindings.Internal._GUID*, void**, int> IUnknown_QueryInterface; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_AddRef; // function pointer
        public static delegate* unmanaged[Stdcall]<ACBindings.Internal.Interface*, uint> IUnknown_Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, ACBindings.Internal.TResult*, ACBindings.Internal.Turbine_GUID*, void**, ACBindings.Internal.TResult*> QueryInterface; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> AddRef; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.Interface*, uint> Release; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> DBObj_dtor_18; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.Archive*, void> Serialize; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.QualifiedDataIDArray*, void> GetSubDataIDs; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> InitLoad; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> GetSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReleaseSubObjects; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> NotifyFidelityLevel; // function pointer
        public System.IntPtr Refresh;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*, byte> CopyInto; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, void> Destroy; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.IDataGraph*, void> FillDataGraph; // function pointer
        public System.IntPtr SetDID;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, uint> GetDBOType; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, ACBindings.Internal.DBObj*> Allocate; // function pointer
        public System.IntPtr SaveToDisk;
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.DBObj*, byte> ReloadFromDisk; // function pointer

        // Methods
    }

    // Members
    public ACBindings.Internal.PackableHashTable___AC1Legacy_CaseInsensitiveStringBase___AC1Legacy_PStringBase__sbyte___QuestDef _defs;

    // Generated Constructor
    public QuestDefDB(void** a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Returns the database object type identifier for QuestDefDB instances.
    /// <code>Offset: 0x004C0680
    /// unsigned int __thiscall QuestDefDB::GetDBOType(QuestDefDB*)</code>
    /// </summary>
    /// <returns>The unsigned integer constant 268435466 that identifies the QuestDefDB type within the serialization system.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuestDefDB, uint>)0x004C0680)(ref this);

    /// <summary>Destructs a QuestDefDB instance, freeing its internal quest definition table and releasing base class resources.
    /// <code>Offset: 0x0059A7F0
    /// void __thiscall QuestDefDB::~QuestDefDB(QuestDefDB*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuestDefDB, void>)0x0059A7F0)(ref this);

    /// <summary>Unpacks quest definition data into a supplied buffer by delegating to base class unpack routines and ensuring the consumed byte count does not exceed the provided size.
    /// <code>Offset: 0x005D3880
    /// int __thiscall QuestDefDB::UnPack(QuestDefDB*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a pointer that will receive the updated position after unpacking; restored if unpack fails.</param>
    /// <param name="size">Maximum number of bytes available for unpacking.</param>
    /// <returns>Nonzero (1) on success, zero (0) on failure.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuestDefDB, void**, uint, int>)0x005D3880)(ref this, addr, size);

    /// <summary>Initializes a QuestDefDB instance by constructing its base DBObj and setting up the internal hash table for quest definitions.
    /// <code>Offset: 0x005D38E0
    /// int __thiscall QuestDefDB::QuestDefDB(int,void**)</code>
    /// </summary>
    /// <param name="a2">Pointer to initialization data passed to the underlying DBObj constructor.</param>
    /// <returns>Reference to the constructed QuestDefDB object.</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.QuestDefDB, void**, int>)0x005D38E0)(ref this, a2);

    /// <summary>Allocates memory for a new QuestDefDB instance wrapped in a DBObj and constructs it with an invalid data ID. Returns a pointer to the created object or nullptr if allocation fails.
    /// <code>Offset: 0x005D3950
    /// DBObj* __cdecl QuestDefDB::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly allocated DBObj containing the QuestDefDB, or null on failure.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x005D3950)();
}

