namespace ACBindings.Internal;


/// <summary>Stores information about a block of land within the environment, including objects, buildings, and cell data.</summary>
public unsafe struct CLandBlockInfo
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct CLandBlockInfo_vtbl
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
    public uint num_objects;
    public System.IntPtr object_ids;
    public ACBindings.Internal.Frame* object_frames;
    public uint num_buildings;
    public ACBindings.Internal.BuildInfo** buildings;
    public System.IntPtr restriction_table;
    public System.IntPtr cell_ownership;
    public uint num_cells;
    public uint* cell_ids;
    public ACBindings.Internal.CEnvCell** cells;

    // Methods

    /// <summary>Allocates memory for a CLandBlockInfo object, initializes its DBObj base and PackObj components, and returns a pointer to the new instance.
    /// <code>Offset: 0x004F7A50
    /// DBObj* __cdecl CLandBlockInfo::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly created DBObj representing the CLandBlockInfo, or null if allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7A50)();

    /// <summary>Returns the database object type identifier for a land block information instance.
    /// <code>Offset: 0x005276A0
    /// unsigned int __thiscall CLandBlockInfo::GetDBOType(CLandBlockInfo*)</code>
    /// </summary>
    /// <returns>An unsigned integer identifying the type of the DB object; for CLandBlockInfo this value is 2.</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockInfo, uint>)0x005276A0)(ref this);

    /// <summary>Initiates prefetching of environmental cells for all building portals within the land block. Returns a status flag indicating whether every portal succeeded in prefetching.
    /// <code>Offset: 0x0052F420
    /// int __thiscall CLandBlockInfo::PreFetchCells(CLandBlockInfo*)</code>
    /// </summary>
    /// <returns>Non-zero if all portals prefetched successfully; zero otherwise.</returns>
    public int PreFetchCells() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockInfo, int>)0x0052F420)(ref this);

    /// <summary>Destroys all resources owned by the land block instance, freeing allocated memory, releasing database references, and clearing associated data structures.
    /// <code>Offset: 0x0052F620
    /// void __thiscall CLandBlockInfo::Destroy(CLandBlockInfo*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockInfo, void>)0x0052F620)(ref this);

    /// <summary>Computes total byte count required to serialize a land block, including objects, buildings with portals, and restriction table data.
    /// <code>Offset: 0x0052F720
    /// unsigned int __thiscall CLandBlockInfo::pack_size(CLandBlockInfo*)</code>
    /// </summary>
    /// <returns>The size in bytes necessary to store the packed representation of the land block info.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockInfo, uint>)0x0052F720)(ref this);

    /// <summary>Serializes a CLandBlockInfo instance into a binary buffer.
    /// <code>Offset: 0x0052F7C0
    /// unsigned int __thiscall CLandBlockInfo::Pack(CLandBlockInfo*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">A pointer to the current write location in the output buffer; this is advanced as data is written.</param>
    /// <param name="size">The maximum number of bytes that may be written to the buffer. If insufficient, no data is emitted.</param>
    /// <returns>The total size required to serialize the object. The function returns this value whether or not the provided buffer was large enough.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockInfo, void**, uint, uint>)0x0052F7C0)(ref this, addr, size);

    /// <summary>Unpacks serialized land block data into this instance, allocating and initializing internal structures.
    /// <code>Offset: 0x0052F900
    /// int __thiscall CLandBlockInfo::UnPack(CLandBlockInfo*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the packed byte stream; it will be advanced as data is consumed.</param>
    /// <param name="size">Total size of the remaining buffer (unused directly in the function).</param>
    /// <returns>Non-zero status code; returns 1 on success or an error code otherwise.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockInfo, void**, uint, int>)0x0052F900)(ref this, addr, size);

    /// <summary>Retrieves the restriction identifier associated with a specified land cell ID.
    /// <code>Offset: 0x0052FBD0
    /// unsigned int __thiscall CLandBlockInfo::GetRestrictionIID(CLandBlockInfo*,const unsigned int)</code>
    /// </summary>
    /// <param name="landcellid">The unique identifier of the land cell to query.</param>
    /// <returns>The restriction ID for the cell, or zero when no restriction is defined.</returns>
    public uint GetRestrictionIID(uint landcellid) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockInfo, uint, uint>)0x0052FBD0)(ref this, landcellid);
}

