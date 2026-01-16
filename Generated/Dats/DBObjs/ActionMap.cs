namespace ACBindings.Internal;


/// <summary>Maintains action-to-map bindings for the input system, linking each map to a string table and recording conflicts between maps.</summary>
/// <remarks>This struct derives from DBObj and participates in the game's database object framework.</remarks>
public unsafe struct ActionMap : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct ActionMap_vtbl
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
    public ACBindings.Internal.HashList__uint___HashList__uint___ActionMapValue m_hashInputMaps;
    public ACBindings.Internal.IDClass____tagDataID m_didStringTable;
    public ACBindings.Internal.HashTable__uint___InputMapConflictsValue m_hashConflictingMaps;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Allocates an ActionMap object, initializing its base class vtable, internal hash tables, timestamps, and link pointers before returning the instance.
    /// <code>Offset: 0x004F7E50
    /// DBObj* __cdecl ActionMap::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed ActionMap.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7E50)();

    /// <summary>Retrieves the set of input maps that conflict with the specified map identifier and writes them into the supplied list.
    /// <code>Offset: 0x00685F30
    /// char __thiscall ActionMap::GetConflictingInputMaps(_DWORD*,unsigned int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Identifier of the input map whose conflicts are requested.</param>
    /// <param name="a3">Pointer to a list where conflicting input map identifiers will be stored.</param>
    /// <returns>Non‑zero if the operation succeeded; zero otherwise (always succeeds in current implementation).</returns>
    public sbyte GetConflictingInputMaps(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, uint, int*, sbyte>)0x00685F30)(ref this, a2, a3);

    /// <summary>Retrieves the toggle type assigned to a specific action within an input map, returning zero if no such mapping exists.
    /// <code>Offset: 0x006863A0
    /// unsigned int __thiscall ActionMap::GetToggleType(ActionMap*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_eMapID">Identifier of the input map to search for the action.</param>
    /// <param name="i_eAction">Identifier of the action whose toggle type is requested.</param>
    /// <returns>Unsigned integer representing the toggle type; zero indicates that the action or map was not found.</returns>
    public uint GetToggleType(uint i_eAction, uint i_eMapID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, uint, uint, uint>)0x006863A0)(ref this, i_eAction, i_eMapID);

    /// <summary>Determines whether the specified action is permitted within a given input map, returning true for all actions of type 1 or when an entry exists that allows the action; otherwise false.
    /// <code>Offset: 0x00686470
    /// bool __thiscall ActionMap::IsActionAllowedInInputMap(ActionMap*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_eAction">The identifier of the action to check.</param>
    /// <param name="i_eMapID">The identifier of the input map in which to verify the action's allowance.</param>
    /// <returns>True if the action is allowed in the specified input map, or if the action is type 1; otherwise false.</returns>
    public byte IsActionAllowedInInputMap(uint i_eAction, uint i_eMapID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, uint, uint, byte>)0x00686470)(ref this, i_eAction, i_eMapID);

    /// <summary>Determines whether the specified action can be bound by the user within the given input map.
    /// <code>Offset: 0x00686530
    /// bool __thiscall ActionMap::IsUserBindable(ActionMap*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_eAction">The identifier of the action to check for bindability.</param>
    /// <param name="i_eMapID">The identifier of the input map to consider when evaluating bindability.</param>
    /// <returns>True if the action is user-bindable; otherwise, false.</returns>
    public byte IsUserBindable(uint i_eAction, uint i_eMapID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, uint, uint, byte>)0x00686530)(ref this, i_eAction, i_eMapID);

    /// <summary>Attempts to retrieve the class identifier associated with a given action within a specified input map. Currently always returns zero.
    /// <code>Offset: 0x00686610
    /// unsigned int __thiscall ActionMap::GetActionClass(ActionMap*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="i_eAction">Identifier of the action whose class is being queried.</param>
    /// <param name="i_eMapID">Identifier of the input map containing the action.</param>
    /// <returns>Unsigned integer representing the action's class ID (zero for all inputs in current implementation).</returns>
    public uint GetActionClass(uint i_eAction, uint i_eMapID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, uint, uint, uint>)0x00686610)(ref this, i_eAction, i_eMapID);

    /// <summary>
    /// Retrieves descriptive strings for an action map entry identified by two keys and writes them into the provided buffers.
    /// 
    /// <code>Offset: 0x006866E0
    /// char __thiscall ActionMap::GetDescripValues(_DWORD*,int,int,wchar_t*,wchar_t*)</code>
    /// </summary>
    /// <param name="a2">The identifier of the specific action within the input map.</param>
    /// <param name="a3">The identifier of the input map to search.</param>
    /// <param name="a4">Buffer to receive the primary description string.</param>
    /// <param name="a5">Buffer to receive the secondary description string (e.g., tooltip).</param>
    /// <returns>Non‑zero if the action was found and descriptions were written; zero otherwise.</returns>
    public sbyte GetDescripValues(int a2, int a3, System.IntPtr a4, System.IntPtr a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, int, int, System.IntPtr, System.IntPtr, sbyte>)0x006866E0)(ref this, a2, a3, a4, a5);

    /// <summary>Destroys the ActionMap instance by resetting its string table identifier and clearing all stored input maps.
    /// <code>Offset: 0x00686BD0
    /// void __thiscall ActionMap::Destroy(ActionMap*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, void>)0x00686BD0)(ref this);

    /// <summary>Retrieves the database object type identifier associated with an ActionMap instance.
    /// <code>Offset: 0x00686C50
    /// unsigned int __thiscall ActionMap::GetDBOType(ActionMap*)</code>
    /// </summary>
    /// <returns>The integer constant representing the ActionMap's DBO type (currently 39).</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, uint>)0x00686C50)(ref this);

    /// <summary>Destroys an ActionMap instance, releasing all internal hash tables and freeing allocated memory before delegating to the base DBObj destructor.
    /// <code>Offset: 0x00686C60
    /// void __thiscall ActionMap::~ActionMap(ActionMap*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, void>)0x00686C60)(ref this);

    /// <summary>Serializes the action map's internal data—input mappings, string table identifier, and conflict resolution tables—to or from an archive.
    /// <code>Offset: 0x00686F60
    /// void __thiscall ActionMap::Serialize(ActionMap*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive instance used for persisting or restoring the object's state. When saving, writes current values; when loading, reads archived values into the ActionMap.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.ActionMap, ACBindings.Internal.Archive*, void>)0x00686F60)(ref this, io_archive);
}

