namespace ACBindings.Internal;


/// <summary>Maintains an efficient association between identifier keys and enumeration values, enabling rapid lookup during runtime processing and data serialization.</summary>
public unsafe struct DualEnumIDMap
{
    // Base Classes
    public ACBindings.Internal.EnumIDMap BaseClass_EnumIDMap; // ACBindings.Internal.EnumIDMap

    // Child Types
    public unsafe struct DualEnumIDMap_vtbl
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
    public ACBindings.Internal.HashTable___IDClass____tagDataID__uint m_IDToEnum;

    // Methods

    /// <summary>Translates a data identifier into its corresponding enumeration value using an internal hash table.
    /// <code>Offset: 0x00415CE0
    /// char __thiscall DualEnumIDMap::DIDToEnum(_DWORD*,unsigned int,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">The data identifier (ID) to look up.</param>
    /// <param name="a3">Receives the mapped enumeration value when the lookup succeeds.</param>
    /// <returns>Non‑zero if the ID was found and *a3 was set; zero otherwise.</returns>
    public sbyte DIDToEnum(uint a2, int* a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DualEnumIDMap, uint, int*, sbyte>)0x00415CE0)(ref this, a2, a3);

    /// <summary>Initializes the internal ID‑to‑enum hash table by copying mappings from the base enumeration tables, reporting errors if an ID appears more than once.
    /// <code>Offset: 0x00416180
    /// bool __thiscall DualEnumIDMap::InitLoad(DualEnumIDMap*)</code>
    /// </summary>
    /// <returns>True if all entries were inserted successfully; false if duplicate IDs were detected.</returns>
    public byte InitLoad() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DualEnumIDMap, byte>)0x00416180)(ref this);

    /// <summary>Creates a new DualEnumIDMap instance, initializes its internal hash tables, and returns a pointer to the DBObj base component.
    /// <code>Offset: 0x004FB7E0
    /// DBObj* __thiscall DualEnumIDMap::Allocate(DualEnumIDMap*)</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed DBObj object, or nullptr if memory allocation fails.</returns>
    public ACBindings.Internal.DBObj* Allocate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DualEnumIDMap, ACBindings.Internal.DBObj*>)0x004FB7E0)(ref this);
}

