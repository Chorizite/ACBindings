namespace ACBindings.Internal;


/// <summary>Encapsulates a database object holding secondary attributes for maximum health, stamina, and mana. Supports packing and unpacking for persistent storage and dynamic retrieval through qualified identifiers.</summary>
public unsafe struct Attribute2ndTable : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct Attribute2ndTable_vtbl
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
    public ACBindings.Internal.Attribute2ndBase _max_health;
    public ACBindings.Internal.Attribute2ndBase _max_stamina;
    public ACBindings.Internal.Attribute2ndBase _max_mana;

    // Generated Constructor
    public Attribute2ndTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves the database object type identifier for an Attribute2ndTable instance.
    /// <code>Offset: 0x004E7230
    /// unsigned int __thiscall Attribute2ndTable::GetDBOType(Attribute2ndTable*)</code>
    /// </summary>
    /// <returns>The unsigned integer representing the DBO type of Attribute2ndTable.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndTable, uint>)0x004E7230)(ref this);

    /// <summary>
    /// Copies the formula data of a specified attribute base into the provided buffer and indicates success.
    /// 
    /// <code>Offset: 0x004F1E30
    /// int __thiscall Attribute2ndTable::InqAttribute2ndBase(Attribute2ndTable*,unsigned int,Attribute2ndBase*)</code>
    /// </summary>
    /// <param name="key">The attribute identifier (1 for health, 3 for stamina, 5 for mana).</param>
    /// <param name="sbase">Pointer to an Attribute2ndBase structure that receives the copied formula.</param>
    /// <returns>Returns 1 when the key matches a known attribute and data is copied; otherwise returns 0.</returns>
    public int InqAttribute2ndBase(uint key, ACBindings.Internal.Attribute2ndBase* sbase) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndTable, uint, ACBindings.Internal.Attribute2ndBase*, int>)0x004F1E30)(ref this, key, sbase);

    /// <summary>Allocates memory for an Attribute2ndTable instance, constructs the object, and returns a pointer to its DBObj base.
    /// <code>Offset: 0x0058B6B0
    /// DBObj* __cdecl Attribute2ndTable::Allocator()</code>
    /// </summary>
    /// <returns>Pointer to the newly constructed DBObj on success; null if allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x0058B6B0)();

    /// <summary>Packs an Attribute2ndTable into a provided memory buffer and returns the total number of bytes needed for serialization. If the supplied buffer is large enough, writes each component in order.
    /// <code>Offset: 0x005CC2E0
    /// unsigned int __thiscall Attribute2ndTable::Pack(Attribute2ndTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer where packed data will be written.</param>
    /// <param name="size">Size in bytes of the destination buffer.</param>
    /// <returns>Number of bytes required to pack the table; if size ≥ returned value, data has been written into addr.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndTable, void**, uint, uint>)0x005CC2E0)(ref this, addr, size);

    /// <summary>Unpacks serialized data from a buffer into the Attribute2ndTable's fields, validating that enough bytes are available before copying.
    /// <code>Offset: 0x005CC360
    /// int __thiscall Attribute2ndTable::UnPack(Attribute2ndTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Address of a pointer to the source buffer; updated to point past the consumed bytes on success or reset to its original value if unpacking fails.</param>
    /// <param name="size">Number of bytes available in the source buffer.</param>
    /// <returns>Nonzero if the entire packet was read successfully; zero if the buffer is too small or an error occurs during unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndTable, void**, uint, int>)0x005CC360)(ref this, addr, size);

    /// <summary>Constructs an Attribute2ndTable, initializing its database base with the supplied data and preparing the attribute bases for health, stamina, and mana.
    /// <code>Offset: 0x005CC420
    /// int __thiscall Attribute2ndTable::Attribute2ndTable(int,void**)</code>
    /// </summary>
    /// <param name="a2">Pointer to data used by the underlying DBObj constructor during initialization.</param>
    /// <returns>Pointer to the newly constructed Attribute2ndTable instance.</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndTable, void**, int>)0x005CC420)(ref this, a2);

    /// <summary>Destroys an Attribute2ndTable instance, invoking cleanup for all nested attribute objects and ensuring proper resource release from its base classes.
    /// <code>Offset: 0x005CC4F0
    /// void __thiscall Attribute2ndTable::~Attribute2ndTable(Attribute2ndTable*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.Attribute2ndTable, void>)0x005CC4F0)(ref this);
}

