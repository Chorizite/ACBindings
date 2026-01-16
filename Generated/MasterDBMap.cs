namespace ACBindings.Internal;


/// <summary>Central repository for database type definitions and lookup functions used throughout the game engine, providing mapping between identifiers and file extensions, directories, and resource categories.</summary>
public unsafe struct MasterDBMap
{
    // Statics
    public static ACBindings.Internal.MasterDBMap** sm_mmap = (ACBindings.Internal.MasterDBMap**)0x00837C68;
    public static ACBindings.Internal.PStringBase__sbyte* sm_game_data_dir = (ACBindings.Internal.PStringBase__sbyte*)0x00837C70;
    public static ACBindings.Internal.PStringBase__sbyte* sm_engine_data_dir = (ACBindings.Internal.PStringBase__sbyte*)0x00837C74;

    // Child Types
    public unsafe struct MasterDBMap_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.MasterDBMap*, byte> InitDBTypeDef_Internal; // function pointer
        public fixed byte gap4[4];
        public System.IntPtr DivineType_Internal;
        public System.IntPtr InqTypeByString_Internal;
        public System.IntPtr InqStringByType_Internal;

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer

    // Methods

    /// <summary>Initializes the global MasterDBMap instance using the supplied mapper and triggers internal DB type definition setup; fails when already initialized or mapper is null.
    /// <code>Offset: 0x0041C220
    /// bool __cdecl MasterDBMap::Init(MasterDBMap*)</code>
    /// </summary>
    /// <param name="mapper">Pointer to a MasterDBMap object that will become the active map.</param>
    /// <returns>True if initialization succeeded; otherwise false.</returns>
    public static byte Init(ACBindings.Internal.MasterDBMap* mapper) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.MasterDBMap*, byte>)0x0041C220)(mapper);

    /// <summary>Deallocates the shared master database map and resets it to an uninitialized state.
    /// <code>Offset: 0x0041C240
    /// bool __cdecl MasterDBMap::Cleanup()</code>
    /// </summary>
    /// <returns>True after cleanup succeeds.</returns>
    public static byte Cleanup() => ((delegate* unmanaged[Cdecl]<byte>)0x0041C240)();

    /// <summary>Looks up a value for an integer key in the master database map, returning 0 when the map has not been initialized.
    /// <code>Offset: 0x0041C260
    /// int __cdecl MasterDBMap::DivineType(int)</code>
    /// </summary>
    /// <param name="a1">The key used to query the map.</param>
    /// <returns>The integer associated with the key via the underlying map; 0 if the map pointer is null.</returns>
    public static int DivineType(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x0041C260)(a1);

    /// <summary>Forwards the supplied integer to an internal map object, returning its result; returns zero when no map is present.
    /// <code>Offset: 0x0041C280
    /// int __cdecl MasterDBMap::DivineType_2(int)</code>
    /// </summary>
    /// <param name="a1">The value passed to the underlying map method.</param>
    /// <returns>The integer returned by the internal map or 0 if the map is absent.</returns>
    public static int DivineType_2(int a1) => ((delegate* unmanaged[Cdecl]<int, int>)0x0041C280)(a1);

    /// <summary>Updates MasterDBMap's static game data directory pointer, managing reference counts for the previous buffer and invoking cleanup on the new path.
    /// <code>Offset: 0x0041C2E0
    /// int __cdecl MasterDBMap::SetGameDataDir(void**)</code>
    /// </summary>
    /// <param name="a1">Pointer to a character buffer containing the new game data directory path.</param>
    /// <returns>Result code from PSUtils::template_cleanup_directory_name indicating success or failure of the cleanup operation.</returns>
    public static int SetGameDataDir(void** a1) => ((delegate* unmanaged[Cdecl]<void**, int>)0x0041C2E0)(a1);

    /// <summary>Assigns a new engine data directory, handling reference counting for the previous value and cleaning up its resources.
    /// <code>Offset: 0x0041C330
    /// int __cdecl MasterDBMap::SetEngineDataDir(void**)</code>
    /// </summary>
    /// <param name="a1">Pointer to the new directory buffer to set as the engine data directory.</param>
    /// <returns>Result of the directory cleanup operation; zero on success or non‑zero error code.</returns>
    public static int SetEngineDataDir(void** a1) => ((delegate* unmanaged[Cdecl]<void**, int>)0x0041C330)(a1);

    /// <summary>Retrieves the database definition for the specified dbtype identifier.
    /// <code>Offset: 0x0041C400
    /// const DBTypeDef* __cdecl MasterDBMap::GetDBTypeDef(const unsigned int)</code>
    /// </summary>
    /// <param name="dbtype">Numeric identifier of the database type to look up.</param>
    /// <returns>A pointer to a DBTypeDef structure matching the provided id, or a default instance if none exists.</returns>
    public static ACBindings.Internal.DBTypeDef* GetDBTypeDef(uint dbtype) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.DBTypeDef*>)0x0041C400)(dbtype);

    /// <summary>Checks whether the specified database type represents a portal.
    /// <code>Offset: 0x0041C480
    /// bool __cdecl MasterDBMap::IsPortalType(const unsigned int)</code>
    /// </summary>
    /// <param name="dbtype">Identifier of the database entry to evaluate.</param>
    /// <returns>True if the type is marked as a portal; otherwise, false.</returns>
    public static byte IsPortalType(uint dbtype) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x0041C480)(dbtype);

    /// <summary>Determines whether the given database type represents a cell type.
    /// <code>Offset: 0x0041C4A0
    /// bool __cdecl MasterDBMap::IsCellType(const unsigned int)</code>
    /// </summary>
    /// <param name="dbtype">Identifier of the database type to query.</param>
    /// <returns>True if the type is marked as a cell type; otherwise false.</returns>
    public static byte IsCellType(uint dbtype) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x0041C4A0)(dbtype);

    /// <summary>Determines whether the specified database type identifier represents a local type in the master database map.
    /// <code>Offset: 0x0041C4C0
    /// bool __cdecl MasterDBMap::IsLocalType(const unsigned int)</code>
    /// </summary>
    /// <param name="dbtype">Identifier of the database type to check.</param>
    /// <returns>True if the type is marked as local; otherwise, false.</returns>
    public static byte IsLocalType(uint dbtype) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x0041C4C0)(dbtype);

    /// <summary>Determines whether a given database type has the “categorized” flag set.
    /// <code>Offset: 0x0041C4E0
    /// bool __cdecl MasterDBMap::IsCategorized(const unsigned int)</code>
    /// </summary>
    /// <param name="dbtype">Identifier of the database type to query.</param>
    /// <returns>True if the specified database type is categorized; otherwise, false.</returns>
    public static byte IsCategorized(uint dbtype) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x0041C4E0)(dbtype);

    /// <summary>Retrieves the freelist definition for a specified database type.
    /// <code>Offset: 0x0041C500
    /// const FreelistDef* __cdecl MasterDBMap::GetFreelistDef(const unsigned int)</code>
    /// </summary>
    /// <param name="dbtype">The identifier of the database type whose freelist definition is requested.</param>
    /// <returns>A pointer to the corresponding <c>FreelistDef</c>.</returns>
    public static ACBindings.Internal.FreelistDef* GetFreelistDef(uint dbtype) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.FreelistDef*>)0x0041C500)(dbtype);

    /// <summary>Determines whether the supplied directory matches either the data or engine directories for a given database type, performing case‑insensitive comparison after normalizing the path.
    /// <code>Offset: 0x0041C520
    /// char __cdecl MasterDBMap::VerifyDirectory(char*,unsigned int)</code>
    /// </summary>
    /// <param name="a1">The directory path to verify.</param>
    /// <param name="dbtype">Identifier of the database type whose directories are used for validation.</param>
    /// <returns>Nonzero (true) if the directory matches one of the expected directories; zero (false) otherwise.</returns>
    public static sbyte VerifyDirectory(sbyte* a1, uint dbtype) => ((delegate* unmanaged[Cdecl]<sbyte*, uint, sbyte>)0x0041C520)(a1, dbtype);

    /// <summary>Determines the internal divine type based on a provided identifier value.
    /// <code>Offset: 0x0041C880
    /// int __stdcall MasterDBMap::DivineType_Internal(unsigned int)</code>
    /// </summary>
    /// <param name="a1">Identifier used to determine the divine type.</param>
    /// <returns>Integer code representing the divine type; returns 0 if no matching range is found.</returns>
    public static int DivineType_Internal(uint a1) => ((delegate* unmanaged[Stdcall]<uint, int>)0x0041C880)(a1);

    /// <summary>Determines the resource type of a file by examining its extension. Computes a hash of the lowercase extension, compares it to known values, and returns an integer code representing the type (e.g., texture, sound, mesh).
    /// <code>Offset: 0x0041CCE0
    /// int __stdcall MasterDBMap::DivineType_Internal(int)</code>
    /// </summary>
    /// <param name="a1">Pointer to a null‑terminated string containing a file path.</param>
    /// <returns>Integer resource identifier; zero if no known extension matches.</returns>
    public static int DivineType_Internal(int a1) => ((delegate* unmanaged[Stdcall]<int, int>)0x0041CCE0)(a1);

    /// <summary>Resolves a type name to its numeric identifier by performing a case‑insensitive lookup and returns whether the lookup succeeded.
    /// <code>Offset: 0x0041E0C0
    /// char __stdcall MasterDBMap::InqTypeByString_Internal(char**,_DWORD*)</code>
    /// </summary>
    /// <p><param name="a1">Pointer to a pointer that references the null‑terminated string containing the type name; the function lowercases the string in place before performing the lookup.</param></p>
    /// <param name="a2">Receives the numeric identifier for the matched type when the lookup succeeds.</param>
    /// <returns>Nonzero if a matching type was found; zero otherwise.</returns>
    public static sbyte InqTypeByString_Internal(sbyte** a1, int* a2) => ((delegate* unmanaged[Stdcall]<sbyte**, int*, sbyte>)0x0041E0C0)(a1, a2);

    /// <summary>Returns whether the specified database type ID has an associated name and, if so, writes that name to the provided string pointer.
    /// <code>Offset: 0x0041F370
    /// char __stdcall MasterDBMap::InqStringByType_Internal(int,void**)</code>
    /// </summary>
    /// <param name="a1">Integer identifier of the database entry type.</param>
    /// <param name="a2">Pointer to a location where a string containing the mapped name will be stored when the type is recognized.</param>
    /// <returns>Non‑zero (1) if the type is known and the output string was set; zero otherwise.</returns>
    public static sbyte InqStringByType_Internal(int a1, void** a2) => ((delegate* unmanaged[Stdcall]<int, void**, sbyte>)0x0041F370)(a1, a2);

    /// <summary>Initializes database type definitions and registers them in the internal cache for various data file formats used by the game engine.
    /// <code>Offset: 0x0041F9A0
    /// bool __thiscall MasterDBMap::InitDBTypeDef_Internal(MasterDBMap*)</code>
    /// </summary>
    /// <returns>True if the initialization succeeds (always true in this implementation).</returns>
    public byte InitDBTypeDef_Internal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.MasterDBMap, byte>)0x0041F9A0)(ref this);
}

