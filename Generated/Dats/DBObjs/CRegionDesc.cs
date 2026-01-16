namespace ACBindings.Internal;


/// <summary>Stores configuration and state for a game region, including identification, terrain, sky, sound, scene, and encounter data, as well as optional resources such as water and fog. Provides serialization support via PackObj and DBObj interfaces for persistence and lookup within the game's database system.</summary>
public unsafe struct CRegionDesc
{
    // Base Classes
    public ACBindings.Internal.SerializeUsingPackDBObj BaseClass_SerializeUsingPackDBObj; // ACBindings.Internal.SerializeUsingPackDBObj

    // Statics
    public static ACBindings.Internal.CRegionDesc** current_region = (ACBindings.Internal.CRegionDesc**)0x0084247C;

    // Child Types
    public unsafe struct CRegionDesc_vtbl
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
    public uint region_number;
    public ACBindings.Internal.AC1Legacy.PStringBase__sbyte region_name;
    public uint version;
    public int minimize_pal;
    public uint parts_mask;
    public ACBindings.Internal.FileNameDesc* file_info;
    public ACBindings.Internal.SkyDesc* sky_info;
    public ACBindings.Internal.CSoundDesc* sound_info;
    public ACBindings.Internal.CSceneDesc* scene_info;
    public ACBindings.Internal.CTerrainDesc* terrain_info;
    public ACBindings.Internal.CEncounterDesc* encounter_info;
    public System.IntPtr water_info;
    public System.IntPtr fog_info;
    public System.IntPtr dist_fog_info;
    public System.IntPtr region_map_info;
    public ACBindings.Internal.RegionMisc* region_misc;

    // Generated Constructor
    public CRegionDesc(void** a2) {
        _ConstructorInternal(a2);
    }

    // Methods

    /// <summary>Allocates memory for a new CRegionDesc object and constructs it, returning a DBObj pointer.
    /// <code>Offset: 0x004F7DE0
    /// DBObj* __cdecl CRegionDesc::Allocator()</code>
    /// </summary>
    /// <returns>A pointer to the newly created DBObj instance, or nullptr if allocation fails.</returns>
    public static ACBindings.Internal.DBObj* Allocator() => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.DBObj*>)0x004F7DE0)();

    /// <summary>Sets the game's current region to the specified region identifier, performing cleanup of any previously active region.
    /// <code>Offset: 0x004FF370
    /// bool __cdecl CRegionDesc::SetRegion(unsigned int)</code>
    /// </summary>
    /// <param name="region_num">The numeric ID of the target region to activate.</param>
    /// <returns>True when a valid region descriptor is located and set; otherwise false if no matching region exists.</returns>
    public static byte SetRegion(uint region_num) => ((delegate* unmanaged[Cdecl]<uint, byte>)0x004FF370)(region_num);

    /// <summary>Detaches the current region, freeing associated cache objects and triggering its cleanup routine before resetting the active region handle.
    /// <code>Offset: 0x004FF3B0
    /// void __cdecl CRegionDesc::RemoveCurrentRegion()</code>
    /// </summary>
    public static void RemoveCurrentRegion() => ((delegate* unmanaged[Cdecl]<void>)0x004FF3B0)();

    /// <summary>Returns the number of scene types defined for the specified terrain type within this region. If terrain_id is out of bounds, returns zero.
    /// <code>Offset: 0x004FF3E0
    /// unsigned int __thiscall CRegionDesc::NumSceneType(CRegionDesc*,unsigned int)</code>
    /// </summary>
    /// <param name="terrain_id">Index of the terrain type in the region's terrain information.</param>
    /// <returns>The count of scene types associated with that terrain type, or 0 if the index is invalid.</returns>
    public uint NumSceneType(uint terrain_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, uint, uint>)0x004FF3E0)(ref this, terrain_id);

    /// <summary>Returns the number of scenes defined for a specified terrain and scene type within the region.
    /// <code>Offset: 0x004FF3F0
    /// unsigned int __thiscall CRegionDesc::SceneCount(CRegionDesc*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="terrain_id">Index into the region's terrain types array.</param>
    /// <param name="scene_type_id">Index into the selected terrain type's scene types array.</param>
    /// <returns>The count of scenes if both indices are valid; otherwise 0.</returns>
    public uint SceneCount(uint terrain_id, uint scene_type_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, uint, uint, uint>)0x004FF3F0)(ref this, terrain_id, scene_type_id);

    /// <summary>Determines whether the terrain's command list indicates that the region’s palette is shifted.
    /// <code>Offset: 0x004FF400
    /// int __thiscall CRegionDesc::IsPalShifted(CRegionDesc*)</code>
    /// </summary>
    /// <returns>An integer value: non‑zero if a palette shift is active, zero otherwise.</returns>
    public int IsPalShifted() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, int>)0x004FF400)(ref this);

    /// <summary>Computes the present day group for the currently active region by delegating to its associated sky descriptor.
    /// <code>Offset: 0x004FF420
    /// void __cdecl CRegionDesc::CalcDayGroup()</code>
    /// </summary>
    public static void CalcDayGroup() => ((delegate* unmanaged[Cdecl]<void>)0x004FF420)();

    /// <summary>Retrieves ambient and directional lighting parameters from the current region’s sky for the specified time of day.
    /// <code>Offset: 0x004FF440
    /// int __cdecl CRegionDesc::GetLighting(float,float*,RGBAUnion*,AC1Legacy::Vector3*,RGBAUnion*)</code>
    /// </summary>
    /// <param name="time_of_day">The normalized time of day used to compute lighting (e.g., 0.0 = midnight, 1.0 = next midnight).</param>
    /// <param name="ambient">Pointer to a float where the ambient light intensity will be written.</param>
    /// <param name="amb_color">Pointer to an RGBAUnion that receives the ambient light color.</param>
    /// <param name="directional">Pointer to an AC1Legacy::Vector3 that receives the directional light vector.</param>
    /// <param name="dir_color">Pointer to an RGBAUnion that receives the directional light color.</param>
    /// <returns>Non‑zero if lighting data was successfully retrieved; zero when no current region or sky information is available.</returns>
    public static int GetLighting(float time_of_day, float* ambient, ACBindings.Internal.RGBAUnion* amb_color, ACBindings.Internal.AC1Legacy.Vector3* directional, ACBindings.Internal.RGBAUnion* dir_color) => ((delegate* unmanaged[Cdecl]<float, float*, ACBindings.Internal.RGBAUnion*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.RGBAUnion*, int>)0x004FF440)(time_of_day, ambient, amb_color, directional, dir_color);

    /// <summary>Retrieves fog parameters for the current region based on the specified time of day.
    /// <code>Offset: 0x004FF480
    /// int __cdecl CRegionDesc::GetWorldFog(float,float*,float*,RGBAUnion*)</code>
    /// </summary>
    /// <param name="time_of_day">The game world time used to determine fog settings.</param>
    /// <param name="min">Pointer to receive the minimum fog distance.</param>
    /// <param name="max">Pointer to receive the maximum fog distance.</param>
    /// <param name="color">Pointer to receive the fog color as an RGBAUnion value.</param>
    /// <returns>Non‑zero if fog data was obtained successfully; zero when no region or sky information is available.</returns>
    public static int GetWorldFog(float time_of_day, float* min, float* max, ACBindings.Internal.RGBAUnion* color) => ((delegate* unmanaged[Cdecl]<float, float*, float*, ACBindings.Internal.RGBAUnion*, int>)0x004FF480)(time_of_day, min, max, color);

    /// <summary>Retrieves a sky value for the current region by delegating to its SkyDesc instance; returns 0 when no active region or sky descriptor exists.
    /// <code>Offset: 0x004FF4B0
    /// int __cdecl CRegionDesc::GetSky(float,int)</code>
    /// </summary>
    /// <param name="a1">A floating‑point argument forwarded unchanged to SkyDesc::GetSky.</param>
    /// <param name="a2">An integer whose bit pattern is interpreted as a float and passed to SkyDesc::GetSky.</param>
    /// <returns>The value returned by SkyDesc::GetSky, or 0 if the region or sky descriptor is not available.</returns>
    public static int GetSky(float a1, int a2) => ((delegate* unmanaged[Cdecl]<float, int, int>)0x004FF4B0)(a1, a2);

    /// <summary>Retrieves the ambient sound table descriptor associated with a specific terrain and scene type within the region. If no suitable descriptor exists or the sound table cannot be initialized, returns null.
    /// <code>Offset: 0x004FF530
    /// AmbientSTBDesc* __thiscall CRegionDesc::GetSTBDesc(CRegionDesc*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="terrain_id">Identifier of the terrain to search for an STB descriptor.</param>
    /// <param name="scene_type_id">Identifier of the scene type used when looking up the descriptor.</param>
    /// <returns>A pointer to the corresponding AmbientSTBDesc if found and successfully initialized; otherwise, null.</returns>
    public ACBindings.Internal.AmbientSTBDesc* GetSTBDesc(uint terrain_id, uint scene_type_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, uint, uint, ACBindings.Internal.AmbientSTBDesc*>)0x004FF530)(ref this, terrain_id, scene_type_id);

    /// <summary>Retrieves a scene identifier from the region’s terrain component based on provided parameters and returns it.
    /// <code>Offset: 0x004FF570
    /// IDClass&lt;_tagDataID,32,0&gt;* __thiscall CRegionDesc::GetScene(_DWORD**,IDClass&lt;_tagDataID,32,0&gt;*,int,int,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Pointer to an IDClass that will be updated with the resolved scene ID.</param>
    /// <param name="a3">First integer influencing scene selection.</param>
    /// <param name="a4">Second integer influencing scene selection.</param>
    /// <param name="a5">Unsigned flags affecting scene retrieval.</param>
    /// <returns>The same pointer passed in a2 after it has been updated by the terrain logic.</returns>
    public ACBindings.Internal.IDClass____tagDataID* GetScene(ACBindings.Internal.IDClass____tagDataID* a2, int a3, int a4, uint a5) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, ACBindings.Internal.IDClass____tagDataID*, int, int, uint, ACBindings.Internal.IDClass____tagDataID*>)0x004FF570)(ref this, a2, a3, a4, a5);

    /// <summary>Initializes a new region descriptor, setting all member fields to default values and establishing base class relationships.
    /// <code>Offset: 0x004FF6E0
    /// int __thiscall CRegionDesc::CRegionDesc(int,void**)</code>
    /// </summary>
    /// <param name="a2">Contextual data supplied to the underlying DBObj constructor; typically used for memory allocation or database linkage.</param>
    /// <returns>The pointer to the newly constructed CRegionDesc instance.</returns>
    public int _ConstructorInternal(void** a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, void**, int>)0x004FF6E0)(ref this, a2);

    /// <summary>Resets the region description by freeing allocated resources, invoking associated destructors, and marking the instance as uninitialized.
    /// <code>Offset: 0x004FF770
    /// void __thiscall CRegionDesc::Destroy(CRegionDesc*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, void>)0x004FF770)(ref this);

    /// <summary>Aggregates sub‑data identifiers from all associated region components—including sky, sound, scene, terrain, and miscellaneous—into the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x004FF840
    /// void __thiscall CRegionDesc::GetSubDataIDs(CRegionDesc*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array to which collected data IDs will be appended.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, ACBindings.Internal.QualifiedDataIDArray*, void>)0x004FF840)(ref this, id_array);

    /// <summary>Computes the byte count required to serialize the region descriptor, including its name buffer, optional sub‑objects, and alignment padding.
    /// <code>Offset: 0x004FF8D0
    /// unsigned int __thiscall CRegionDesc::pack_size(CRegionDesc*)</code>
    /// </summary>
    /// <returns>The total number of bytes that will be written when packing this region.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, uint>)0x004FF8D0)(ref this);

    /// <summary>Serializes a CRegionDesc into a binary buffer, writing data at the location pointed to by addr while ensuring that the supplied size is sufficient.
    /// <code>Offset: 0x004FF970
    /// unsigned int __thiscall CRegionDesc::Pack(CRegionDesc*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the destination buffer; updated to point after the last byte written.</param>
    /// <param name="size">Number of bytes available for packing. If less than required, the function returns the necessary size without modifying *addr.</param>
    /// <returns>Required byte count for the packed region descriptor. When the buffer is large enough and all subcomponents pack successfully, this equals the total bytes written; otherwise it may be a larger value indicating the needed space or an error code returned by a nested pack operation.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, void**, uint, uint>)0x004FF970)(ref this, addr, size);

    /// <summary>Unpacks a region description from serialized data, restoring timestamps, strings, and nested objects such as GameTime, SkyDesc, CSoundDesc, CSceneDesc, CTerrainDesc, and RegionMisc. Validates version compatibility and updates internal part masks.
    /// <code>Offset: 0x004FFEC0
    /// int __thiscall CRegionDesc::UnPack(CRegionDesc*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the data buffer; updated during unpacking.</param>
    /// <param name="size">Number of bytes remaining in the buffer from which to read.</param>
    /// <returns>Returns the new address pointer after unpacking, or 0 if an error occurs (e.g., version mismatch or unpack failure).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CRegionDesc, void**, uint, int>)0x004FFEC0)(ref this, addr, size);
}

