namespace ACBindings.Internal;


/// <summary>Represents the degradation hierarchy of a graphics object, storing base class data, the count of degradations, and an array of pointers to degraded objects.</summary>
public unsafe struct GfxObjDegradeInfo
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct GfxObjDegradeInfo_vtbl
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
    public uint num_degrades;
    public ACBindings.Internal.GfxObjInfo* degrades;

    // Methods

    /// <summary>Allocates and initializes a DBObj representing a GfxObjDegradeInfo, setting up its virtual tables and default state.
    /// <code>Offset: 0x004F7DA0
    /// DBObj* __cdecl GfxObjDegradeInfo::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed DBObj if allocation succeeds; otherwise, null.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7DA0)();

    /// <summary>Returns the constant database object type identifier for GfxObjDegradeInfo instances.
    /// <code>Offset: 0x0051EDD0
    /// unsigned int __thiscall GfxObjDegradeInfo::GetDBOType(GfxObjDegradeInfo*)</code>
    /// </summary>
    /// <returns>The unsigned integer type code (always 26).</returns>
    public uint GetDBOType() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GfxObjDegradeInfo, uint>)0x0051EDD0)(ref this);

    /// <summary>Releases allocated degrade data and resets internal counters for the object.
    /// <code>Offset: 0x0051EE20
    /// void __thiscall GfxObjDegradeInfo::Destroy(GfxObjDegradeInfo*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GfxObjDegradeInfo, void>)0x0051EE20)(ref this);

    /// <summary>Packages a <c>GfxObjDegradeInfo</c> instance into a contiguous byte stream. If the supplied buffer is large enough, writes a 4‑byte count of degrade entries followed by each entry’s serialized data (20 bytes per entry); otherwise returns the total size required without writing.
    /// <code>Offset: 0x0051EE50
    /// unsigned int __thiscall GfxObjDegradeInfo::Pack(GfxObjDegradeInfo*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to memory where packed data will be written; advanced past the written bytes on success.</param>
    /// <param name="size">Number of bytes available at <paramref name="addr"/> for packing.</param>
    /// <returns>The number of bytes that were written, or the total size required if <paramref name="size"/> is insufficient.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GfxObjDegradeInfo, void**, uint, uint>)0x0051EE50)(ref this, addr, size);

    /// <summary>Deserializes degradation information from the supplied binary buffer into this instance.
    /// <code>Offset: 0x0051EF10
    /// int __thiscall GfxObjDegradeInfo::UnPack(GfxObjDegradeInfo*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position within the buffer; advanced as data is consumed.</param>
    /// <param name="size">Size of remaining buffer (unused in this implementation).</param>
    /// <returns>Always returns 1, indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GfxObjDegradeInfo, void**, uint, int>)0x0051EF10)(ref this, addr, size);

    /// <summary>Determines the appropriate degradation index and mode for a given distance based on the object's degradation configuration and global rendering settings.
    /// <code>Offset: 0x0051EFC0
    /// void __thiscall GfxObjDegradeInfo::get_degrade(GfxObjDegradeInfo*,float,unsigned int*,int*)</code>
    /// </summary>
    /// <param name="distance">The distance value used to evaluate which degradation level applies.</param>
    /// <param name="deg_index">Pointer where the function stores the selected degradation index (0‑based).</param>
    /// <param name="deg_mode">Pointer where the function stores the corresponding degradation mode for that index.</param>
    public void get_degrade(float distance, uint* deg_index, int* deg_mode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GfxObjDegradeInfo, float, uint*, int*, void>)0x0051EFC0)(ref this, distance, deg_index, deg_mode);

    /// <summary>Collects the data identifiers of all degraded subobjects associated with this GfxObjDegradeInfo instance and appends them to the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x0051F140
    /// void __thiscall GfxObjDegradeInfo::GetSubDataIDs(GfxObjDegradeInfo*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that will receive the collected QualifiedDataID entries.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.GfxObjDegradeInfo, ACBindings.Internal.QualifiedDataIDArray*, void>)0x0051F140)(ref this, id_array);
}

