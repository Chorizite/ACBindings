namespace ACBindings.Internal;


/// <summary>Defines configuration data for a 3D entity, encompassing geometry primitives, animation scaling, lighting, physics flags, and placement metadata used by the engine to construct and render scene objects.</summary>
public unsafe struct CSetup
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Child Types
    public unsafe struct CSetup_vtbl
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
    public uint num_parts;
    public ACBindings.Internal.IDClass____tagDataID* parts;
    public uint* parent_index;
    public ACBindings.Internal.AC1Legacy.Vector3* default_scale;
    public uint num_cylsphere;
    public ACBindings.Internal.CCylSphere* cylsphere;
    public uint num_sphere;
    public ACBindings.Internal.CSphere* sphere;
    public int has_physics_bsp;
    public int allow_free_heading;
    public float height;
    public float radius;
    public float step_down_height;
    public float step_up_height;
    public ACBindings.Internal.CSphere sorting_sphere;
    public ACBindings.Internal.CSphere selection_sphere;
    public uint num_lights;
    public ACBindings.Internal.LIGHTINFO* lights;
    public ACBindings.Internal.AC1Legacy.Vector3 anim_scale;
    public ACBindings.Internal.LongHash___LocationType* holding_locations;
    public ACBindings.Internal.LongHash___LocationType* connection_points;
    public ACBindings.Internal.LongHash___PlacementType placement_frames;
    public ACBindings.Internal.IDClass____tagDataID default_anim_id;
    public ACBindings.Internal.IDClass____tagDataID default_script_id;
    public ACBindings.Internal.IDClass____tagDataID default_mtable_id;
    public ACBindings.Internal.IDClass____tagDataID default_stable_id;
    public ACBindings.Internal.IDClass____tagDataID default_phstable_id;

    // Generated Constructor
    public CSetup() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Allocates and constructs a new CSetup object, returning it as a DBObj pointer.
    /// <code>Offset: 0x004F7B50
    /// DBObj* __cdecl CSetup::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly constructed DBObj instance, or null if allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7B50)();

    /// <summary>Collects all sub‑data identifiers associated with this setup and appends them to the supplied array.
    /// <code>Offset: 0x005208B0
    /// bool __thiscall CSetup::GetSubDataIDs(CSetup*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="a2">Destination array that will receive the collected QualifiedDataID instances.</param>
    /// <returns>True if adding the last identifier succeeded; otherwise false.</returns>
    public byte GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSetup, ACBindings.Internal.QualifiedDataIDArray*, byte>)0x005208B0)(ref this, a2);

    /// <summary>Creates a new CSetup instance, initializing its base serialization and pack objects, clearing all part lists, geometry data, physics flags, scale vectors, and hash tables to default values.
    /// <code>Offset: 0x00520A00
    /// CSetup* __thiscall CSetup::CSetup(CSetup*)</code>
    /// </summary>
    public ACBindings.Internal.CSetup* _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSetup, ACBindings.Internal.CSetup*>)0x00520A00)(ref this);

    /// <summary>Create a new CSetup object configured for simple usage based on the supplied data ID, initializing core properties and optional placement frames.
    /// <code>Offset: 0x00520BB0
    /// CSetup* __cdecl CSetup::makeSimpleSetup(int)</code>
    /// </summary>
    /// <param name="a1">Identifier of the data set used to populate the setup.</param>
    /// <returns>Pointer to the constructed CSetup instance or null if allocation fails.</returns>
    public static ACBindings.Internal.CSetup* makeSimpleSetup(int a1) => ((delegate* unmanaged[Cdecl]<int, ACBindings.Internal.CSetup*>)0x00520BB0)(a1);

    /// <summary>Creates a new CSetup instance configured for a particle system with the specified number of parts, initializing related fields to default values.
    /// <code>Offset: 0x00520D10
    /// CSetup* __cdecl CSetup::makeParticleSetup(unsigned int)</code>
    /// </summary>
    /// <param name="a1">The desired count of particles in the setup.</param>
    /// <returns>A pointer to the newly allocated and initialized CSetup object; null if memory allocation fails.</returns>
    public static ACBindings.Internal.CSetup* makeParticleSetup(uint a1) => ((delegate* unmanaged[Cdecl]<uint, ACBindings.Internal.CSetup*>)0x00520D10)(a1);

    /// <summary>Calculates the number of bytes required to pack a CSetup instance into a contiguous memory buffer. The calculation accounts for geometry data, animation frames, cylinders, spheres, physics information, and associated hooks, then aligns the total size to a 4‑byte boundary.
    /// <code>Offset: 0x00520D40
    /// int __thiscall CSetup::pack_size(CSetup*)</code>
    /// </summary>
    /// <returns>The aligned packed size in bytes.</returns>
    public int pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSetup, int>)0x00520D40)(ref this);

    /// <summary>Serializes the current <c>CSetup</c> instance into a binary buffer, writing all member data and related structures sequentially.
    /// <code>Offset: 0x005210A0
    /// unsigned int __thiscall CSetup::Pack(CSetup*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the destination buffer; updated as bytes are written.</param>
    /// <param name="size">Maximum number of bytes available for packing. If this value is less than the required size, no data is written and the function returns the needed size.</param>
    /// <returns>Number of bytes that would be needed to pack the <c>CSetup</c> object. The returned value equals the total packed size regardless of whether the buffer was sufficient.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSetup, void**, uint, uint>)0x005210A0)(ref this, addr, size);

    /// <summary>Deserializes a packed CSetup object from a binary buffer, initializing its fields and allocating necessary arrays and hash tables.
    /// <code>Offset: 0x00521770
    /// int __thiscall CSetup::UnPack(CSetup*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current read position within the serialized data; it is advanced as data is consumed.</param>
    /// <param name="size">Remaining size of the serialized data (used for bounds checks during unpacking).</param>
    /// <returns>Always returns 1 to indicate successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSetup, void**, uint, int>)0x00521770)(ref this, addr, size);

    /// <summary>Retrieves a holding location entry from the setup's hash table using an identifier, returning zero when no match exists.
    /// <code>Offset: 0x00521F10
    /// int __thiscall CSetup::GetHoldingLocation(CSetup*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The unsigned integer key identifying the desired holding location.</param>
    /// <returns>The pointer to the matching holding location record or 0 if none is found.</returns>
    public int GetHoldingLocation(uint a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSetup, uint, int>)0x00521F10)(ref this, a2);

    /// <summary>Releases all allocated resources associated with the setup, including arrays of parts, physics objects, lights, and hash tables, then resets identifiers to invalid values.
    /// <code>Offset: 0x00521F60
    /// unsigned int __thiscall CSetup::Destroy(void**)</code>
    /// </summary>
    /// <returns>An invalid data identifier indicating that the object has been destroyed.</returns>
    public uint Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CSetup, uint>)0x00521F60)(ref this);
}

