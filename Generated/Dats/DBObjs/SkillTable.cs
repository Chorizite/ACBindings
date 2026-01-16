namespace ACBindings.Internal;


/// <summary>Represents a database table containing skill definitions, providing lookup, packing, and serialization capabilities for SkillBase entries within the game’s data system.</summary>
public unsafe struct SkillTable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct SkillTable_vtbl
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
    public ACBindings.Internal.PackableHashTable__uint___SkillBase _skillBaseHash;

    // Generated Constructor
    public SkillTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>Retrieves a SkillBase instance corresponding to the given key from the internal hash table.
    /// <code>Offset: 0x0049B8B0
    /// SkillBase* __thiscall SkillTable::GetSkillBase(SkillTable*,unsigned int)</code>
    /// </summary>
    /// <param name="key">The unique identifier used to locate the skill entry.</param>
    /// <returns>A pointer to the matching SkillBase object, or nullptr when no entry matches the supplied key.</returns>
    public ACBindings.Internal.SkillBase* GetSkillBase(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillTable, uint, ACBindings.Internal.SkillBase*>)0x0049B8B0)(ref this, key);

    /// <summary>Returns the database object type identifier for this skill table.
    /// <code>Offset: 0x004E7010
    /// unsigned int __thiscall SkillTable::GetDBOType(SkillTable*)</code>
    /// </summary>
    /// <returns>The unique 32‑bit ID that identifies the skill table within the serialization system.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillTable, uint>)0x004E7010)(ref this);

    /// <summary>Attempts to locate a skill base entry by its identifier within the SkillTable's hash table, copying the result into the provided SkillBase structure when found.
    /// <code>Offset: 0x004F2510
    /// int __thiscall SkillTable::InqSkillBase(SkillTable*,unsigned int,SkillBase*)</code>
    /// </summary>
    /// <param name="key">Identifier used to search for the skill base.</param>
    /// <param name="sbase">Output parameter that receives the located SkillBase data if the lookup succeeds.</param>
    /// <returns>1 if a matching entry is found and copied; 0 otherwise.</returns>
    public int InqSkillBase(uint key, ACBindings.Internal.SkillBase* sbase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillTable, uint, ACBindings.Internal.SkillBase*, int>)0x004F2510)(ref this, key, sbase);

    /// <summary>Creates a new SkillTable instance by allocating memory and invoking its constructor; returns a pointer to the object's DBObj base.
    /// <code>Offset: 0x0058B6E0
    /// DBObj* __cdecl SkillTable::Allocator()</code>
    /// </summary>
    /// <returns>A DBObj* pointing to the allocated SkillTable object, or null when memory allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0058B6E0)();

    /// <summary>Unpacks skill table data into a caller‑supplied buffer when sufficient space exists.
    /// <code>Offset: 0x0059A8D0
    /// int __thiscall SkillTable::UnPack(SkillTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; after unpacking it points past the written data.</param>
    /// <param name="size">Maximum size, in bytes, of the memory region referenced by *addr.</param>
    /// <returns>Non‑zero if the data was successfully unpacked into the buffer; zero otherwise (e.g., insufficient buffer or overflow).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillTable, void**, uint, int>)0x0059A8D0)(ref this, addr, size);

    /// <summary>Collects all sub‑data identifiers from the skill table and appends them to the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x005CC660
    /// void __thiscall SkillTable::GetSubDataIDs(SkillTable*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that will receive qualified data IDs representing each skill in the table.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillTable, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005CC660)(ref this, id_array);

    /// <summary>Initializes a SkillTable instance, setting up base serialization and preparing the internal skill lookup hash table.
    /// <code>Offset: 0x005CCAA0
    /// int __thiscall SkillTable::SkillTable(int,void**)</code>
    /// </summary>
    /// <param name="a2">Pointer to initialization data passed to the DBObj constructor.</param>
    /// <returns>Reference to the newly constructed SkillTable object.</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.SkillTable, void**, int>)0x005CCAA0)(ref this, a2);
}

