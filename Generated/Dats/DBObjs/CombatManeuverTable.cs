namespace ACBindings.Internal;


/// <summary>Stores and serializes a collection of combat maneuvers for the game’s database system.</summary>
public unsafe struct CombatManeuverTable : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct CombatManeuverTable_vtbl
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
    public uint _num_combat_maneuvers;
    public ACBindings.Internal.CombatManeuver* _cmt;

    // Generated Constructor
    public CombatManeuverTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves the database object representing the combat maneuver with the specified identifier.
    /// <code>Offset: 0x0056B8A0
    /// DBObj* __cdecl CombatManeuverTable::Get(int)</code>
    /// </summary>
    /// <param name="a1">The identifier of the desired combat maneuver.</param>
    /// <returns>A pointer to the corresponding DBObj, or null if no entry exists for that identifier.</returns>
    public static ACBindings.Internal.DBObj* Get(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.DBObj*>)0x0056B8A0)(a1);

    /// <summary>Allocates a new CombatManeuverTable instance and returns it as a DBObj*.
    /// <code>Offset: 0x0058B7B0
    /// DBObj* __cdecl CombatManeuverTable::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly created CombatManeuverTable object, or null if memory allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0058B7B0)();

    /// <summary>Releases resources owned by a CombatManeuverTable instance, freeing its combat maneuver array and resetting internal counters.
    /// <code>Offset: 0x005CB4D0
    /// void __thiscall CombatManeuverTable::~CombatManeuverTable(CombatManeuverTable*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CombatManeuverTable, void>)0x005CB4D0)(ref this);

    /// <summary>Packs the combat maneuver table into a binary buffer by writing an unsigned integer count followed by each maneuver’s serialized data.
    /// <code>Offset: 0x005CB520
    /// unsigned int __thiscall CombatManeuverTable::Pack(CombatManeuverTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a pointer to the destination buffer; after packing it points past the last byte written.</param>
    /// <param name="size">Maximum number of bytes available in the destination buffer.</param>
    /// <returns>Number of bytes that would be written (4 + 20 × count). If size is less than this value, no data is written and the returned value indicates the required space.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CombatManeuverTable, void**, uint, uint>)0x005CB520)(ref this, addr, size);

    /// <summary>Initializes the combat maneuver table with the specified number of maneuvers, allocating memory, constructing CombatManeuver objects and clearing any existing entries.
    /// <code>Offset: 0x005CB5A0
    /// int __thiscall CombatManeuverTable::Init(CombatManeuverTable*,unsigned int)</code>
    /// </summary>
    /// <param name="num_combat_maneuvers">The desired count of combat maneuvers to allocate.</param>
    /// <returns>Non‑zero if initialization succeeded; zero on failure (e.g., allocation error).</returns>
    public int Init(uint num_combat_maneuvers) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CombatManeuverTable, uint, int>)0x005CB5A0)(ref this, num_combat_maneuvers);

    /// <summary>Initializes a CombatManeuverTable object by constructing its base DBObj and PackObj components and setting up internal state.
    /// <code>Offset: 0x005CB640
    /// int __thiscall CombatManeuverTable::CombatManeuverTable(int,void**)</code>
    /// </summary>
    /// <param name="a2">Pointer to the database entry data used during construction of the DBObj base class.</param>
    /// <returns>The address of the constructed CombatManeuverTable instance.</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CombatManeuverTable, void**, int>)0x005CB640)(ref this, a2);

    /// <summary>Unpacks combat maneuver data from a binary buffer into the table, initializing internal structures and delegating to each maneuver's own unpack routine.
    /// <code>Offset: 0x005CB690
    /// int __thiscall CombatManeuverTable::UnPack(CombatManeuverTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position within the data buffer; advanced as data is consumed.</param>
    /// <param name="size">Number of bytes remaining in the buffer; must be sufficient for all maneuvers.</param>
    /// <returns>1 if unpacking succeeds; 0 if the buffer is too small or initialization fails.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CombatManeuverTable, void**, uint, int>)0x005CB690)(ref this, addr, size);
}

