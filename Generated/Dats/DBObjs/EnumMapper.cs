namespace ACBindings.Internal;


/// <summary>Provides bidirectional mapping between enumeration identifiers and their string representations, enabling fast lookups in both directions.</summary>
public unsafe struct EnumMapper : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct EnumMapper_vtbl
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

    /// <summary>Iterates over EnumMapper entries, exposing the current enum value and string identifier while internally managing hash traversal state.</summary>
    public unsafe struct iterator
    {
        // Members
        public ACBindings.Internal.EnumMapper* m_mapper;
        public ACBindings.Internal.HashIterator__uint___CaseInsensitiveStringBase___PStringBase__sbyte m_iter;

        // Generated Constructor
        public iterator(int a2, int* a3) {
            _ConstructorInternal(a2, a3);
        }

        // Methods

        /// <summary>Retrieves the enum value currently pointed to by the iterator.
        /// <code>Offset: 0x0041AB50
        /// unsigned int __thiscall EnumMapper::iterator::get_enum(EnumMapper::iterator*)</code>
        /// </summary>
        /// <returns>An unsigned integer representing the current enumeration entry.</returns>
        public uint get_enum() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumMapper.iterator, uint>)0x0041AB50)(ref this);

        /// <summary>Retrieves the current enumeration string identifier and increments its reference counter.
        /// <code>Offset: 0x0041AB60
        /// _DWORD* __thiscall EnumMapper::iterator::get_string(_DWORD*,_DWORD*)</code>
        /// </summary>
        /// <param name="a2">Pointer to a DWORD that will receive the string identifier.</param>
        /// <returns>The same pointer passed in as <c>a2</c>, enabling method chaining.</returns>
        public int* get_string(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumMapper.iterator, int*, int*>)0x0041AB60)(ref this, a2);

        /// <summary>Creates an iterator that traverses the entries of an EnumMapper starting from a given position.
        /// <code>Offset: 0x0041AC60
        /// _DWORD* __thiscall EnumMapper::iterator::iterator(_DWORD*,int,_DWORD*)</code>
        /// </summary>
        /// <param name="a2">Pointer to the EnumMapper instance to iterate.</param>
        /// <param name="a3">Array containing initial iterator state values (hash bucket and node pointers).</param>
        /// <returns>The initialized iterator object.</returns>
        public int* _ConstructorInternal(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumMapper.iterator, int, int*, int*>)0x0041AC60)(ref this, a2, a3);
    }

    // Members
    public ACBindings.Internal.IDClass____tagDataID m_base_emp_did;
    public ACBindings.Internal.EnumMapper* m_base_emp;
    public ACBindings.Internal.AutoGrowHashTable__uint___CaseInsensitiveStringBase___PStringBase__sbyte m_id_to_string_map;
    public ACBindings.Internal.AutoGrowHashTable___CaseInsensitiveStringBase___PStringBase__sbyte__uint m_string_to_id_map;

    // Generated Constructor
    public EnumMapper() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases the referenced base enumeration object and clears its internal pointer, ensuring proper cleanup of sub‑objects.
    /// <code>Offset: 0x0041A970
    /// bool __thiscall EnumMapper::ReleaseSubObjects(EnumMapper*)</code>
    /// </summary>
    /// <returns>True after performing release operations.</returns>
    public byte ReleaseSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumMapper, byte>)0x0041A970)(ref this);

    /// <summary>Attempts to locate the base EnumMapper referenced by m_base_emp_did and assigns it to m_base_emp. If no identifier is present, leaves m_base_emp unchanged.
    /// <code>Offset: 0x0041A990
    /// bool __thiscall EnumMapper::GetSubObjects(EnumMapper*)</code>
    /// </summary>
    /// <returns>true if no lookup was required (identifier equals zero) or a matching EnumMapper was successfully retrieved; false when an identifier exists but no corresponding object can be found.</returns>
    public byte GetSubObjects() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumMapper, byte>)0x0041A990)(ref this);

    /// <summary>Adds the enum mapper's base data ID to the supplied QualifiedDataIDArray when a valid base ID exists.
    /// <code>Offset: 0x0041AAD0
    /// void __thiscall EnumMapper::GetSubDataIDs(EnumMapper*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that will receive the qualified data identifier if present.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumMapper, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0041AAD0)(ref this, id_array);

    /// <summary>Returns an iterator positioned after the last element in the EnumMapper's ID‑to‑string hash table.
    /// <code>Offset: 0x0041AC30
    /// EnumMapper::iterator* __thiscall EnumMapper::end(EnumMapper*,EnumMapper::iterator*)</code>
    /// </summary>
    /// <param name="this">Current EnumMapper instance.</param>
    /// <param name="result">Iterator to initialize and return.</param>
    /// <returns>Iterator pointing to the end of the enumeration map.</returns>
    public ACBindings.Internal.EnumMapper.iterator* end(ACBindings.Internal.EnumMapper.iterator* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumMapper, ACBindings.Internal.EnumMapper.iterator*, ACBindings.Internal.EnumMapper.iterator*>)0x0041AC30)(ref this, result);

    /// <summary>Initializes an iterator to the first element in the enum mapper's ID‑to‑string mapping and returns it.
    /// <code>Offset: 0x0041AD00
    /// EnumMapper::iterator* __thiscall EnumMapper::begin(EnumMapper*,EnumMapper::iterator*)</code>
    /// </summary>
    /// <param name="result">The iterator instance to be initialized with the beginning of the collection.</param>
    /// <returns>The same iterator instance, positioned at the start of the mapping.</returns>
    public ACBindings.Internal.EnumMapper.iterator* begin(ACBindings.Internal.EnumMapper.iterator* result) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumMapper, ACBindings.Internal.EnumMapper.iterator*, ACBindings.Internal.EnumMapper.iterator*>)0x0041AD00)(ref this, result);

    /// <summary>Retrieves the string associated with an enum identifier from internal mappings and returns a status indicator.
    /// <code>Offset: 0x0041AF60
    /// char __thiscall EnumMapper::GetString(_DWORD*,int,volatile LONG**)</code>
    /// </summary>
    /// <param name="a2">The integer enumeration value to look up.</param>
    /// <param name="a3">Output parameter receiving a reference‑counted pointer to the corresponding string buffer, if found.</param>
    /// <returns>Non‑zero (typically 1) if the identifier exists and the buffer is returned; zero otherwise.</returns>
    public sbyte GetString(int a2, int** a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumMapper, int, int**, sbyte>)0x0041AF60)(ref this, a2, a3);

    /// <summary>Retrieves string identifier for an enum entry identified by type and index, returning a success flag.
    /// <code>Offset: 0x0041B060
    /// char __cdecl EnumMapper::GetString(int,int,int*)</code>
    /// </summary>
    /// <param name="a1">Enum type identifier.</param>
    /// <param name="a2">Index of the value within that enum type.</param>
    /// <param name="a3">Receives resulting string identifier; remains unchanged if no mapping exists.</param>
    /// <returns>Non‑zero when a mapping is found, zero otherwise.</returns>
    public static sbyte GetString(int a1, int a2, int* a3) => ((delegate* unmanaged[Cdecl]<int, int, int*, sbyte>)0x0041B060)(a1, a2, a3);

    /// <summary>Retrieves a character associated with two enumeration identifiers and updates the reference handle for the returned string.
    /// <code>Offset: 0x0041B160
    /// char __cdecl EnumMapper::InqString(int,int,int*)</code>
    /// </summary>
    /// <param name="a1">First identifier used in lookup.</param>
    /// <param name="a2">Second identifier that further refines the lookup.</param>
    /// <param name="a3">Pointer to an integer holding a reference handle; updated if a different string is returned.</param>
    /// <returns>Character value obtained from the enumeration mapping for the given identifiers.</returns>
    public static sbyte InqString(int a1, int a2, int* a3) => ((delegate* unmanaged[Cdecl]<int, int, int*, sbyte>)0x0041B160)(a1, a2, a3);

    /// <summary>Retrieves the name for an enumeration entry identified by its data ID and index, storing related context in the supplied output pointer.
    /// <code>Offset: 0x0041B220
    /// char __cdecl EnumMapper::GetStringByDID(int,int,int*)</code>
    /// </summary>
    /// <param name="a1">Identifier of the enumeration table.</param>
    /// <param name="a2">Index or value within that enumeration.</param>
    /// <param name="a3">Output pointer receiving additional information (e.g., database ID) when a string is found.</param>
    /// <returns>Non‑zero if a name was successfully retrieved; otherwise zero.</returns>
    public static sbyte GetStringByDID(int a1, int a2, int* a3) => ((delegate* unmanaged[Cdecl]<int, int, int*, sbyte>)0x0041B220)(a1, a2, a3);

    /// <summary>Retrieves the enumeration value for a given identifier by searching this mapper and, if necessary, its base mapper.
    /// <code>Offset: 0x0041B490
    /// int __thiscall EnumMapper::GetEnum(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to the identifier used to look up the enum value.</param>
    /// <returns>The integer enum corresponding to the identifier, or 0 if not found.</returns>
    public int GetEnum(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumMapper, int*, int>)0x0041B490)(ref this, a2);

    /// <summary>
    /// Maps a string identifier to its enumeration value using the mapper’s internal hash tables, optionally delegating to a parent mapper if the key is not found.
    /// 
    /// <code>Offset: 0x0041B7E0
    /// char __thiscall EnumMapper::GetEnum(_DWORD*,int,_DWORD*)</code>
    /// </summary>
    /// <param name="this">The EnumMapper instance performing the lookup.</param>
    /// <param name="a2">Pointer to the input string key whose enum value is requested.</param>
    /// <param name="a3">Output parameter that receives the mapped enumeration value when the key is found.</param>
    /// <returns>Non‑zero if the mapping succeeded; zero otherwise.</returns>
    public sbyte GetEnum(int a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumMapper, int, int*, sbyte>)0x0041B7E0)(ref this, a2, a3);

    /// <summary>Converts an enumeration identifier into its numeric value according to the specified enum type and writes the result into the provided output location.
    /// <code>Offset: 0x0041B8F0
    /// bool __cdecl EnumMapper::GetEnum(int,int,_DWORD*)</code>
    /// </summary>
    /// <param name="a1">Identifier for the enum type to look up.</param>
    /// <param name="a2">Pointer to the enumeration name or identifier string to convert.</param>
    /// <param name="a3">Address where the resolved numeric value will be stored if conversion succeeds.</param>
    /// <returns>True if the lookup was successful; otherwise, false.</returns>
    public static byte GetEnum(int a1, int a2, int* a3) => ((delegate* unmanaged[Cdecl]<int, int, int*, byte>)0x0041B8F0)(a1, a2, a3);

    /// <summary>Retrieves the enum value identified by a2 from the enum map referenced by a1, storing the result in a3.
    /// <code>Offset: 0x0041BA30
    /// bool __cdecl EnumMapper::InqEnum(int,int,_DWORD*)</code>
    /// </summary>
    /// <param name="a1">Index or identifier of the enum set to query.</param>
    /// <param name="a2">Key identifying the specific enum entry within that set.</param>
    /// <param name="a3">Pointer to receive the retrieved enumeration value if found.</param>
    /// <returns>True if the key exists and the value was returned; otherwise false.</returns>
    public static byte InqEnum(int a1, int a2, int* a3) => ((delegate* unmanaged[Cdecl]<int, int, int*, byte>)0x0041BA30)(a1, a2, a3);

    /// <summary>Retrieves the enumeration name and associated data for a given data ID by querying the master database. The enum name is written to the string referenced by a2, while supplementary information is stored at a3. Returns true when a matching entry exists; otherwise returns false.
    /// <code>Offset: 0x0041BAC0
    /// bool __cdecl EnumMapper::GetEnumByDID(int,int,_DWORD*)</code>
    /// </summary>
    /// <param name="a1">The data identifier whose enumeration mapping should be retrieved.</param>
    /// <param name="a2">Reference to a pointer that will receive the enum name string.</param>
    /// <param name="a3">Pointer where additional enum-related information (e.g., value or flags) is stored.</param>
    /// <returns>True if an enum entry was found and output parameters populated; false otherwise.</returns>
    public static byte GetEnumByDID(int a1, int a2, int* a3) => ((delegate* unmanaged[Cdecl]<int, int, int*, byte>)0x0041BAC0)(a1, a2, a3);

    /// <summary>Destroys the EnumMapper instance, clearing ID‑to‑string mappings, releasing any linked base mapper, and resetting internal identifiers.
    /// <code>Offset: 0x0041BEE0
    /// void __thiscall EnumMapper::Destroy(EnumMapper*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumMapper, void>)0x0041BEE0)(ref this);

    /// <summary>Destroys an EnumMapper instance by freeing its string‑to‑ID and ID‑to‑string hash tables, releasing any referenced base object, resetting internal identifiers to invalid states, and invoking the base DBObj destructor.
    /// <code>Offset: 0x0041BF80
    /// void __thiscall EnumMapper::~EnumMapper(EnumMapper*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumMapper, void>)0x0041BF80)(ref this);

    /// <summary>Returns the database object type ID for an AllegianceHierarchy instance.
    /// <code>Offset: 0x0041C040
    /// unsigned int __thiscall EnumMapper::GetDBOType(AllegianceHierarchy*)</code>
    /// </summary>
    /// <param name="this">The allegiance hierarchy whose DBO type is queried.</param>
    /// <returns>The unsigned integer representing the DBO type, currently fixed at 36.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumMapper, uint>)0x0041C040)(ref this);

    /// <summary>Constructs an EnumMapper, initializing its base database object, setting up default ID mappings, and preparing internal hash tables for efficient enum-to-string and string-to-enum lookups.
    /// <code>Offset: 0x0041C050
    /// void __thiscall EnumMapper::EnumMapper(EnumMapper*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumMapper, void>)0x0041C050)(ref this);

    /// <summary>Creates a new EnumMapper instance by allocating memory and invoking its constructor, then returns the object's DBObj base pointer.
    /// <code>Offset: 0x0041C0F0
    /// DBObj* __cdecl EnumMapper::Allocator()</code>
    /// </summary>
    /// <returns>A DBObj pointer to the newly constructed EnumMapper, or nullptr if allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0041C0F0)();

    /// <summary>Serializes the enum mapper’s data—including its base entity identifier and bidirectional hash tables that map numeric IDs to case‑insensitive string names—to or from an archive.
    /// <code>Offset: 0x0041C110
    /// void __thiscall EnumMapper::Serialize(EnumMapper*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">The Archive instance used for reading or writing the mapping information.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.EnumMapper, ACBindings.Internal.Archive*, void>)0x0041C110)(ref this, io_archive);
}

