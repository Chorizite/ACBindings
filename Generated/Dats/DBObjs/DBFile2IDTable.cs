namespace ACBindings.Internal;


/// <summary>Handles database object registration and file‑to‑ID mapping by combining generic DBObj behavior with TFile2IDTable lookup logic.</summary>
public unsafe struct DBFile2IDTable : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj
    public ACBindings.Internal.TFile2IDTable BaseClass_TFile2IDTable; // ACBindings.Internal.TFile2IDTable

    // Child Types
    public unsafe struct DBFile2IDTable_vtbl
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

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Creates and initializes a new database object, allocating memory for the object and setting up its base classes.
    /// <code>Offset: 0x004F7CA0
    /// DBObj* __thiscall DBFile2IDTable::Allocate(DBFile2IDTable*)</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed DBObj instance; returns nullptr if allocation fails.</returns>
    public ACBindings.Internal.DBObj* Allocate() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBFile2IDTable, ACBindings.Internal.DBObj*>)0x004F7CA0)(ref this);

    /// <summary>Returns the database object type identifier for a sound tweaked hook.
    /// <code>Offset: 0x004F7CF0
    /// int __thiscall DBFile2IDTable::GetDBOType(SoundTweakedHook*)</code>
    /// </summary>
    /// <param name="this">Pointer to the SoundTweakedHook instance used to determine the DBO type.</param>
    /// <returns>An integer representing the DBO type, always 21 for this table.</returns>
    public int GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBFile2IDTable, int>)0x004F7CF0)(ref this);

    /// <summary>Destroys a DBFile2IDTable instance, releasing its internal structures and invoking destructors of inherited components.
    /// <code>Offset: 0x004F7D20
    /// void __thiscall DBFile2IDTable::~DBFile2IDTable(DBFile2IDTable*)</code>
    /// </summary>
    /// <param name="this">Pointer to the DBFile2IDTable object being destroyed.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBFile2IDTable, void>)0x004F7D20)(ref this);

    /// <summary>Serializes or deserializes the DBFile2IDTable data using the provided Archive, handling file-to-ID mappings and related metadata.
    /// <code>Offset: 0x0067C310
    /// void __thiscall DBFile2IDTable::Serialize(DBFile2IDTable*,Archive*)</code>
    /// </summary>
    /// <param name="io_archive">Archive instance used for reading from or writing to persistent storage.</param>
    public void Serialize(ACBindings.Internal.Archive* io_archive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBFile2IDTable, ACBindings.Internal.Archive*, void>)0x0067C310)(ref this, io_archive);
}

