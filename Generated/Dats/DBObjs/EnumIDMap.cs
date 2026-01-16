namespace ACBindings.Internal;


/// <summary>Maps enum values to unique identifiers and human-readable names, enabling efficient lookup and internal handling of enums within the database object system.</summary>
public unsafe struct EnumIDMap : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct EnumIDMap_vtbl
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

    /// <summary>Iterates over key-value pairs in an EnumIDMap, maintaining a reference to the parent map and using an internal hash iterator for traversal.</summary>
    public unsafe struct iterator
    {
        // Members
        public ACBindings.Internal.EnumIDMap* m_mapper;
        public ACBindings.Internal.HashIterator__uint___PStringBase__sbyte m_iter;

        // Methods
    }

    // Members
    public ACBindings.Internal.HashTable__uint___IDClass____tagDataID m_EnumToID;
    public ACBindings.Internal.HashTable__uint___IDClass____tagDataID m_EnumToIDInternal;
    public ACBindings.Internal.HashTable__uint___PStringBase__sbyte m_EnumToName;
    public ACBindings.Internal.HashTable__uint___PStringBase__sbyte m_EnumToNameInternal;

    // Generated Constructor
    public EnumIDMap() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Searches internal tables for an enumeration ID matching the supplied name (case‑insensitive) and writes the result to the output parameter.
    /// <code>Offset: 0x004159D0
    /// char __thiscall EnumIDMap::NameToEnum(_DWORD*,const char**,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to a null‑terminated string containing the name to look up.</param>
    /// <param name="a3">Receives the found enumeration identifier when the lookup succeeds.</param>
    /// <returns>Non‑zero if the name exists in the mapping; zero otherwise.</returns>
    public sbyte NameToEnum(sbyte** a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumIDMap, sbyte**, int*, sbyte>)0x004159D0)(ref this, a2, a3);

    /// <summary>Collects all sub-data identifiers from both external and internal enumeration maps into the supplied array.
    /// <code>Offset: 0x00415B00
    /// void __thiscall EnumIDMap::GetSubDataIDs(EnumIDMap*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="IDs">The array to populate with qualified data IDs, each marked as either external (flag 0) or internal (flag 2).</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* IDs) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumIDMap, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00415B00)(ref this, IDs);

    /// <summary>Maps an enumeration value to its corresponding data identifier, storing the result in the provided output parameter.
    /// <code>Offset: 0x00415C10
    /// int __thiscall EnumIDMap::EnumToDID(_DWORD*,unsigned int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">The enumeration value to translate.</param>
    /// <param name="a3">Receives the resulting data identifier when the lookup succeeds.</param>
    /// <returns>Non‑zero if the mapping exists; zero otherwise.</returns>
    public int EnumToDID(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumIDMap, uint, int*, int>)0x00415C10)(ref this, a2, a3);

    /// <summary>Retrieves the name string corresponding to the specified enum identifier.
    /// <code>Offset: 0x00415C90
    /// BOOL __thiscall EnumIDMap::GetName(_DWORD*,int,int*)</code>
    /// </summary>
    /// <param name="a2">The numeric identifier for which to look up a name.</param>
    /// <param name="a3">Pointer that receives the address of the matching name string if found.</param>
    /// <returns>True when a name is located in either the primary or internal map; otherwise false.</returns>
    public byte GetName(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumIDMap, int, int*, byte>)0x00415C90)(ref this, a2, a3);

    /// <summary>Destroys all internal mappings and releases associated resources.
    /// <code>Offset: 0x00416150
    /// void __thiscall EnumIDMap::Destroy(EnumIDMap*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumIDMap, void>)0x00416150)(ref this);

    /// <summary>Initializes an EnumIDMap instance, setting up the base database object and preparing four hash tables for enum-to-ID and enum-to-name mappings.
    /// <code>Offset: 0x00416690
    /// void __thiscall EnumIDMap::EnumIDMap(EnumIDMap*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumIDMap, void>)0x00416690)(ref this);

    /// <summary>Retrieves the database object type identifier for this enumeration map.
    /// <code>Offset: 0x00416700
    /// unsigned int __thiscall EnumIDMap::GetDBOType(EnumIDMap*)</code>
    /// </summary>
    /// <returns>The unsigned integer constant representing the DBO type of this EnumIDMap instance (currently 38).</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumIDMap, uint>)0x00416700)(ref this);

    /// <summary>Destroys an EnumIDMap instance, freeing all internal hash tables and resetting virtual function tables to their default state.
    /// <code>Offset: 0x00416710
    /// void __thiscall EnumIDMap::~EnumIDMap(EnumIDMap*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumIDMap, void>)0x00416710)(ref this);

    /// <summary>Allocates and constructs a new EnumIDMap instance, returning a pointer to its DBObj base.
    /// <code>Offset: 0x00416850
    /// DBObj* __cdecl EnumIDMap::Allocator()</code>
    /// </summary>
    /// <returns>A non‑null DBObj pointer if allocation succeeded; otherwise nullptr.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x00416850)();

    /// <summary>Writes or reads EnumIDMap's internal mappings to or from the supplied archive, including base DBObj data and conditional clearing of hash tables during load operations.
    /// <code>Offset: 0x00416890
    /// void __thiscall EnumIDMap::Serialize(EnumIDMap*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive instance used for serializing or deserializing enum-to-id and enum-to-name maps.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumIDMap, ACBindings.Internal.Archive*, void>)0x00416890)(ref this, io_archive);
}

