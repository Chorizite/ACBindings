namespace ACBindings.Internal;


/// <summary>Stores and manages a hash table of CContract objects, enabling allocation, retrieval by key, and providing type information for contract data within the database system.</summary>
public unsafe struct CContractTable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct CContractTable_vtbl
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
    public ACBindings.Internal.PackableHashTable__uint___CContract _contractHash;

    // Generated Constructor
    public CContractTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>Retrieves a contract from the table using its identifier.
    /// <code>Offset: 0x00497FA0
    /// const CContract* __thiscall CContractTable::GetContract(CContractTable*,const unsigned int)</code>
    /// </summary>
    /// <param name="key">Identifier of the desired contract.</param>
    /// <returns>Pointer to the contract if found; otherwise null.</returns>
    public ACBindings.Internal.CContract* GetContract(uint key) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContractTable, uint, ACBindings.Internal.CContract*>)0x00497FA0)(ref this, key);

    /// <summary>Provides the database object type identifier for this contract table, used during serialization and lookup.
    /// <code>Offset: 0x004D9530
    /// unsigned int __thiscall CContractTable::GetDBOType(CContractTable*)</code>
    /// </summary>
    /// <returns>A constant unsigned integer value (268 435 472) representing the DBO type of CContractTable.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContractTable, uint>)0x004D9530)(ref this);

    /// <summary>
    /// Allocates and constructs a new contract table object, returning its base DBObj pointer.
    /// If memory allocation fails, returns nullptr.
    /// 
    /// <code>Offset: 0x0058B7D0
    /// DBObj* __cdecl CContractTable::Allocator()</code>
    /// </summary>
    /// <returns>Pointer to the newly created CContractTable represented as a DBObj; null on failure.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0058B7D0)();

    /// <summary>Iterates through the contract table without modifying external data; the supplied QualifiedDataIDArray is not used.
    /// <code>Offset: 0x0059ABD0
    /// void __thiscall CContractTable::GetSubDataIDs(CContractTable*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array intended to receive qualified data identifiers (currently unused).</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContractTable, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0059ABD0)(ref this, id_array);

    /// <summary>Creates a contract table object by initializing its base database and packable structures and setting up an internal hash table for storing contracts.
    /// <code>Offset: 0x0059AF30
    /// int __thiscall CContractTable::CContractTable(int,void**)</code>
    /// </summary>
    /// <param name="a2">Pointer to initialization data passed to the underlying DBObj constructor.</param>
    /// <returns>Pointer to the newly constructed CContractTable instance.</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CContractTable, void**, int>)0x0059AF30)(ref this, a2);
}

