namespace ACBindings.Internal;


/// <summary>Encapsulates sound table data with built-in serialization support for persistence and retrieval.</summary>
public unsafe struct CSoundTable : System.IDisposable
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct CSoundTable_vtbl
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
    public ACBindings.Internal.SoundTableData sound_data_;

    // Generated Constructor
    public CSoundTable(void** a2) {
        _ConstructorInternal(a2);
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Allocates memory for a CSoundTable instance and constructs it; returns the new DBObj pointer or null on failure.
    /// <code>Offset: 0x004F7E20
    /// DBObj* __cdecl CSoundTable::Allocator()</code>
    /// </summary>
    /// <returns>The newly constructed DBObj pointer, or nullptr if allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7E20)();

    /// <summary>Unpacks the sound table into the supplied buffer, padding the end to a four‑byte boundary.
    /// <code>Offset: 0x005528F0
    /// int __thiscall CSoundTable::UnPack(CSoundTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; after execution it points past the last written byte.</param>
    /// <param name="size">Maximum number of bytes that may be written into the buffer.</param>
    /// <returns>Always returns 1 to indicate successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundTable, void**, uint, int>)0x005528F0)(ref this, addr, size);

    /// <summary>Retrieves sub‑data identifiers from the sound table and stores them in the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x00552C70
    /// void __thiscall CSoundTable::GetSubDataIDs(CSoundTable*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array to receive the retrieved sub‑data IDs.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundTable, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00552C70)(ref this, id_array);

    /// <summary>Computes the packed size of a sound table and writes its data into a supplied buffer when space permits.
    /// <code>Offset: 0x00552C80
    /// unsigned int __thiscall CSoundTable::Pack(CSoundTable*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination memory where packed data will be written if the buffer is large enough.</param>
    /// <param name="size">Size in bytes of the provided buffer.</param>
    /// <returns>Number of bytes required to pack the sound table. If size is sufficient, the data is serialized into *addr and the pointer advanced; otherwise no packing occurs.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundTable, void**, uint, uint>)0x00552C80)(ref this, addr, size);

    /// <summary>Initializes a CSoundTable instance by constructing its DBObj and PackObj bases and default‑constructing the embedded SoundTableData.
    /// <code>Offset: 0x00553150
    /// int __thiscall CSoundTable::CSoundTable(int,void**)</code>
    /// </summary>
    /// <param name="a2">Pointer to initialization data passed to the DBObj constructor.</param>
    /// <returns>The initialized object pointer (this).</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundTable, void**, int>)0x00553150)(ref this, a2);

    /// <summary>Retrieves the database object type identifier for this sound table.
    /// <code>Offset: 0x00553180
    /// unsigned int __thiscall CSoundTable::GetDBOType(CSoundTable*)</code>
    /// </summary>
    /// <returns>The unsigned integer representing the DBO type; currently fixed at 34.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundTable, uint>)0x00553180)(ref this);

    /// <summary>Destroys a CSoundTable instance by cleaning up its internal sound data and hash table resources, resetting base class virtual tables, and invoking the base DBObj destructor.
    /// <code>Offset: 0x005531A0
    /// void __thiscall CSoundTable::~CSoundTable(CSoundTable*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSoundTable, void>)0x005531A0)(ref this);
}

