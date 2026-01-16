namespace ACBindings.Internal;


/// <summary>Handles storage and retrieval of spell base data and spell sets, providing hash‑based lookups, packing/unpacking for persistence, and integration with the global database cache.</summary>
public unsafe struct CSpellTable : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct CSpellTable_vtbl
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
    public ACBindings.Internal.PackableHashTable__uint___CSpellBase _spellBaseHash;
    public ACBindings.Internal.PHashTable__uint___SpellSet m_SpellSetHash;

    // Generated Constructor
    public CSpellTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves a spell base record by its unique identifier and writes it into the supplied structure.
    /// <code>Offset: 0x00567E50
    /// int __thiscall CSpellTable::InqSpellBase(CSpellTable*,const unsigned int,CSpellBase*)</code>
    /// </summary>
    /// <param name="key">Unique identifier of the spell to look up.</param>
    /// <param name="sbase">Pointer to a CSpellBase object where the retrieved data will be stored; must not be null.</param>
    /// <returns>1 if the spell exists and its data is copied into sbase; 0 otherwise.</returns>
    public int InqSpellBase(uint key, ACBindings.Internal.CSpellBase* sbase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellTable, uint, ACBindings.Internal.CSpellBase*, int>)0x00567E50)(ref this, key, sbase);

    /// <summary>Allocates memory and constructs a new spell table object.
    /// <code>Offset: 0x0058B700
    /// DBObj* __cdecl CSpellTable::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly created DBObj instance for the spell table, or nullptr if memory allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0058B700)();

    /// <summary>Retrieves a spell base entry from the table by its unique key.
    /// <code>Offset: 0x00594980
    /// const CSpellBase* __thiscall CSpellTable::GetSpellBase(CSpellTable*,const unsigned int)</code>
    /// </summary>
    /// <param name="key">The unique identifier used to locate a spell within the hash table.</param>
    /// <returns>A pointer to the requested spell base, or nullptr if no matching entry exists.</returns>
    public ACBindings.Internal.CSpellBase* GetSpellBase(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellTable, uint, ACBindings.Internal.CSpellBase*>)0x00594980)(ref this, key);

    /// <summary>Packs the spell table into a preallocated memory buffer, serializing both spell bases and sets.
    /// <code>Offset: 0x00598450
    /// unsigned int __thiscall CSpellTable::Pack(CSpellTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to a pointer that receives the address of the packed data after serialization.</param>
    /// <param name="size">Size in bytes of the destination buffer.</param>
    /// <returns>The total number of bytes required to serialize the entire table. If the supplied buffer is large enough, the data is written and this count is returned; otherwise only the required size is reported.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellTable, void**, uint, uint>)0x00598450)(ref this, addr, size);

    /// <summary>Unpacks serialized spell data into the table from a memory buffer.
    /// <code>Offset: 0x005984C0
    /// int __thiscall CSpellTable::UnPack(CSpellTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the source buffer containing packed data.</param>
    /// <param name="size">Size in bytes of the source buffer.</param>
    /// <returns>Non‑zero if the unpack succeeded; zero if there is insufficient data or an error occurs.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellTable, void**, uint, int>)0x005984C0)(ref this, addr, size);

    /// <summary>Collects all spell base identifiers from the spell table and stores them in the supplied array.
    /// <code>Offset: 0x005986E0
    /// void __thiscall CSpellTable::GetSubDataIDs(CSpellTable*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array to populate with the qualified data IDs of each spell base found in the table.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellTable, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005986E0)(ref this, id_array);

    /// <summary>Initializes a CSpellTable instance, establishing serialization infrastructure and configuring hash tables for spell bases and spell sets.
    /// <code>Offset: 0x005993E0
    /// int __thiscall CSpellTable::CSpellTable(int,void**)</code>
    /// </summary>
    /// <param name="a2">Optional data passed to the base DBObj constructor during initialization.</param>
    /// <returns>The constructed CSpellTable object (this pointer).</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellTable, void**, int>)0x005993E0)(ref this, a2);

    /// <summary>Releases all resources owned by a CSpellTable instance, clearing spell bases, spell sets, and deallocating internal hash tables before invoking base class destructors.
    /// <code>Offset: 0x00599490
    /// void __thiscall CSpellTable::~CSpellTable(CSpellTable*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSpellTable, void>)0x00599490)(ref this);
}

