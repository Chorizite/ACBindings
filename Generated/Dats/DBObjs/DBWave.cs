namespace ACBindings.Internal;


/// <summary>Represents an audio wave resource within the database, combining serialization support and low‑level wave file handling; facilitates loading, packing, and querying of wave data through its base classes SerializeUsingPackDBObj and WaveFile.</summary>
public unsafe struct DBWave
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj
    public ACBindings.Internal.WaveFile BaseClass_WaveFile; // ACBindings.Internal.WaveFile

    // Child Types
    public unsafe struct DBWave_vtbl
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

    // Generated Constructor
    public DBWave(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>Allocates and constructs a new DBWave object, returning a pointer to the resulting DBObj instance.
    /// <code>Offset: 0x004F7BD0
    /// DBObj* __cdecl DBWave::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly created DBObj on success; otherwise null if memory allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7BD0)();

    /// <summary>Initializes a DBWave instance by constructing its base objects, setting up virtual tables for serialization and wave file handling, and preparing internal wave data structures.
    /// <code>Offset: 0x005526C0
    /// int __thiscall DBWave::DBWave(int,void**)</code>
    /// </summary>
    /// <param name="a2">Array of pointers containing initialization data used by the underlying DBObj constructor.</param>
    /// <returns>The address of the newly constructed object (this).</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBWave, void**, int>)0x005526C0)(ref this, a2);

    /// <summary>Packs the wave file’s format chunk into a contiguous memory buffer and returns its total byte size.
    /// <code>Offset: 0x00552730
    /// unsigned int __thiscall DBWave::Pack(DBWave*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer; on success, advanced past the written data.</param>
    /// <param name="size">Maximum number of bytes available for writing.</param>
    /// <returns>Number of bytes required to store the format chunk (header plus data).</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBWave, void**, uint, uint>)0x00552730)(ref this, addr, size);

    /// <summary>Unpacks wave file format and audio data from a packed buffer into this DBWave instance, allocating memory for the header and payload.
    /// <code>Offset: 0x005527B0
    /// int __thiscall DBWave::UnPack(DBWave*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the input buffer; advanced as bytes are read during unpacking.</param>
    /// <param name="size">Total size of the input buffer (unused by the function but may indicate available data).</param>
    /// <returns>Non‑zero if unpacking succeeds; zero on allocation failure or invalid data.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.DBWave, void**, uint, int>)0x005527B0)(ref this, addr, size);

    /// <summary>Retrieves a database object associated with the specified identifier within this wave instance.
    /// <code>Offset: 0x005534A0
    /// DBObj* __cdecl DBWave::Get(int)</code>
    /// </summary>
    /// <param name="a1">The numerical ID used to locate the desired DBObj in the wave's data store.</param>
    /// <returns>A pointer to the found DBObj, or nullptr if no matching entry exists.</returns>
    public static ACBindings.Internal.DBObj* Get(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.DBObj*>)0x005534A0)(a1);
}

