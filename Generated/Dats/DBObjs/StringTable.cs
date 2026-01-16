namespace ACBindings.Internal;


/// <summary>Encapsulates a collection of localized strings, storing metadata such as version, language, and description while providing efficient lookup through an internal hash table.</summary>
public unsafe struct StringTable : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.DBObj BaseClass_DBObj; // ACBindings.Internal.DBObj

    // Child Types
    public unsafe struct StringTable_vtbl
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
    public uint m_version;
    public ACBindings.Internal.PStringBase__ushort m_description;
    public uint m_language;
    public ACBindings.Internal.HashTable__uint___StringTableString_ptr m_strings;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Collects all sub-data identifiers from the string table into the supplied array.
    /// <code>Offset: 0x0042FCB0
    /// void __thiscall StringTable::GetSubDataIDs(StringTable*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that will receive qualified data IDs for each string entry in the table.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTable, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0042FCB0)(ref this, id_array);

    /// <summary>Retrieves the StringTableString entry identified by stringID from the table.
    /// <code>Offset: 0x004301A0
    /// StringTableString* __thiscall StringTable::GetStringTableString(StringTable*,unsigned int)</code>
    /// </summary>
    /// <param name="this">The StringTable instance containing the strings.</param>
    /// <param name="stringID">Identifier of the desired string.</param>
    /// <returns>Pointer to the corresponding StringTableString, or null if no entry exists for that ID.</returns>
    public ACBindings.Internal.StringTableString* GetStringTableString(uint stringID) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTable, uint, ACBindings.Internal.StringTableString*>)0x004301A0)(ref this, stringID);

    /// <summary>Retrieves a localized string by its identifier from this StringTable, optionally performing variable substitution with the supplied hash table, and writes the result into the destination buffer.
    /// <code>Offset: 0x00430270
    /// int __thiscall StringTable::GetString(_DWORD*,wchar_t**,unsigned int,_DWORD*,char)</code>
    /// </summary>
    /// <param name="Source">Pointer to the wide‑string buffer that will receive the rendered text; it is cleared before writing.</param>
    /// <param name="stringID">Identifier of the string entry to retrieve.</param>
    /// <param name="a4">Hash table mapping variable identifiers to replacement strings, used when variable substitution is requested.</param>
    /// <param name="a5">Flag indicating whether variables should be substituted (non‑zero) or the string should be copied verbatim (zero).</param>
    /// <returns>Zero on success; non‑zero error code if the string cannot be found, an external table lookup fails, data is invalid, or rendering encounters a problem.</returns>
    public int GetString(System.IntPtr Source, uint stringID, int* a4, sbyte a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTable, System.IntPtr, uint, int*, sbyte, int>)0x00430270)(ref this, Source, stringID, a4, a5);

    /// <summary>Resets the string table to an empty state by freeing its description buffer, deleting all stored strings, and clearing version and language data.
    /// <code>Offset: 0x004306C0
    /// void __thiscall StringTable::Destroy(StringTable*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTable, void>)0x004306C0)(ref this);

    /// <summary>Retrieves the database object type identifier for a string table instance.
    /// <code>Offset: 0x00430840
    /// unsigned int __thiscall StringTable::GetDBOType(StringTable*)</code>
    /// </summary>
    /// <returns>An unsigned integer identifying the DB object type; for StringTable this is always 37.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTable, uint>)0x00430840)(ref this);

    /// <summary>Destructs the StringTable instance, freeing all stored strings, releasing the description buffer, and invoking the DBObj base class destructor.
    /// <code>Offset: 0x00430850
    /// void __thiscall StringTable::~StringTable(StringTable*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTable, void>)0x00430850)(ref this);

    /// <summary>Serializes or deserializes a StringTable to the given Archive, handling versioning and string entries.
    /// <code>Offset: 0x00430B60
    /// void __thiscall StringTable::Serialize(StringTable*,Archive*)</code>
    /// </summary>
    /// <param name="this">The StringTable instance to serialize.</param>
    /// <param name="rArchive">The archive used for input or output.</param>
    public void Serialize(ACBindings.Internal.Archive* rArchive) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.StringTable, ACBindings.Internal.Archive*, void>)0x00430B60)(ref this, rArchive);
}

