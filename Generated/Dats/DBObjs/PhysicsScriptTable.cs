namespace ACBindings.Internal;


/// <summary>Maintains a lookup table of physics script data, indexed by unique identifiers, and supports serialization for persistence.</summary>
public unsafe struct PhysicsScriptTable : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct PhysicsScriptTable_vtbl
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
    public ACBindings.Internal.HashTable__uint___PhysicsScriptTableData_ptr script_table;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Create a new database object for the physics script table, initializing its base components and virtual tables.
    /// <code>Offset: 0x004F7ED0
    /// DBObj* __cdecl PhysicsScriptTable::Allocator()</code>
    /// </summary>
    /// <returns>Pointer to the newly allocated DBObj; returns null if allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7ED0)();

    /// <summary>Calculates total byte size required to pack all physics scripts in the table and records their count.
    /// <code>Offset: 0x00522780
    /// unsigned int __thiscall PhysicsScriptTable::pack_size(PhysicsScriptTable*,int*)</code>
    /// </summary>
    /// <param name="num_scripts">Receives the number of physics script entries processed.</param>
    /// <returns>The combined size, in bytes, needed to serialize all stored scripts.</returns>
    public uint pack_size(int* num_scripts) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTable, int*, uint>)0x00522780)(ref this, num_scripts);

    /// <summary>Serializes the physics script table into a contiguous memory block, writing the number of scripts followed by each script’s packed data. The caller supplies a buffer large enough; the function writes to it and advances the address pointer.
    /// <code>Offset: 0x00522800
    /// unsigned int __thiscall PhysicsScriptTable::Pack(PhysicsScriptTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the buffer. After packing, this is advanced past the written data.</param>
    /// <param name="size">Size of the remaining buffer available for writing. If smaller than the required size, no data is written but the needed byte count is returned.</param>
    /// <returns>Number of bytes required to serialize the table; if the supplied buffer is large enough, this value also represents the number of bytes written.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTable, void**, uint, uint>)0x00522800)(ref this, addr, size);

    /// <summary>Collects all sub‑data identifiers from every entry in the script table and appends them to the supplied array.
    /// <code>Offset: 0x005228B0
    /// void __thiscall PhysicsScriptTable::GetSubDataIDs(PhysicsScriptTable*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that will receive the collected QualifiedDataID values.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTable, ACBindings.Internal.QualifiedDataIDArray*, void>)0x005228B0)(ref this, id_array);

    /// <summary>Retrieves the script ID associated with the given key from the physics script table, storing the result in the supplied output variable. If no matching entry exists, assigns an invalid identifier.
    /// <code>Offset: 0x00522990
    /// unsigned int* __thiscall PhysicsScriptTable::GetScript(_DWORD*,unsigned int*,unsigned int,float)</code>
    /// </summary>
    /// <param name="a2">Pointer to unsigned int where the retrieved script ID will be stored; set to INVALID_DID_234.baseclass_0.id when lookup fails.</param>
    /// <param name="a3">Script key used to locate the corresponding entry in the table.</param>
    /// <param name="a4">Additional parameter forwarded to PhysicsScriptTableData::GetScript, typically representing a context value such as time or state.</param>
    /// <returns>Returns the same pointer passed in as a2 for convenience.</returns>
    public uint* GetScript(uint* a2, uint a3, float a4) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTable, uint*, uint, float, uint*>)0x00522990)(ref this, a2, a3, a4);

    /// <summary>Retrieves the database object type identifier for a physics script table.
    /// <code>Offset: 0x00522B30
    /// unsigned int __thiscall PhysicsScriptTable::GetDBOType(PhysicsScriptTable*)</code>
    /// </summary>
    /// <returns>The constant 44 that identifies PhysicsScriptTable objects within the DB system.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTable, uint>)0x00522B30)(ref this);

    /// <summary>
    /// Deletes all entries in the physics script table, freeing memory for each stored script data object.
    /// 
    /// <code>Offset: 0x00522B50
    /// void __thiscall PhysicsScriptTable::Destroy(PhysicsScriptTable*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTable, void>)0x00522B50)(ref this);

    /// <summary>Deserializes a sequence of physics script entries from a binary stream into the table, replacing any existing contents. Each entry consists of an unsigned integer key followed by a PhysicsScriptTableData block that is unpacked via its own UnPack method.
    /// <code>Offset: 0x00522C30
    /// int __thiscall PhysicsScriptTable::UnPack(PhysicsScriptTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to a pointer to the current read position in the source buffer; advanced as data are consumed.</param>
    /// <param name="size">Size of the remaining data in bytes (unused in this implementation but part of the API).</param>
    /// <returns>Always returns 1 to indicate successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTable, void**, uint, int>)0x00522C30)(ref this, addr, size);

    /// <summary>Destroys a PhysicsScriptTable object, freeing its internal hash table of script data, deallocating any dynamically allocated bucket storage, resetting virtual function tables, and invoking the base DBObj destructor to clean up inherited resources.
    /// <code>Offset: 0x00522D30
    /// void __thiscall PhysicsScriptTable::~PhysicsScriptTable(PhysicsScriptTable*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.PhysicsScriptTable, void>)0x00522D30)(ref this);
}

