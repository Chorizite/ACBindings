namespace ACBindings.Internal;


/// <summary>Handles the collection and lifecycle of terrain surfaces for a land area, providing functionality for surface creation, selection, serialization, and resource cleanup.</summary>
public unsafe struct LandSurf : System.IDisposable
{
    // Members
    public ACBindings.Internal.PalShift* pal_shift;
    public ACBindings.Internal.TexMerge* tex_merge;
    public System.IntPtr surf_info;
    public uint num_lsurf;
    public ACBindings.Internal.CSurface** lsurf;
    public uint num_unique_surfaces;
    public uint num_block_surfs;
    public ACBindings.Internal.AC1Legacy.SmartArray___CSurface_ptr block_surf_array;
    public byte* curr_tex;

    // Generated Constructor
    public LandSurf() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Computes the number of bytes required to serialize the LandSurf object by delegating to either PalShift or TexMerge, adding a 4‑byte header.
    /// <code>Offset: 0x005034F0
    /// unsigned int __thiscall LandSurf::pack_size(LandSurf*)</code>
    /// </summary>
    /// <returns>The packed size in bytes, including the header.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, uint>)0x005034F0)(ref this);

    /// <summary>Returns the index of the next free surface in this object's lsurf array, expanding the array by 40 elements when no free slots remain.
    /// <code>Offset: 0x00503510
    /// unsigned int __thiscall LandSurf::NextFree(LandSurf*)</code>
    /// </summary>
    /// <returns>The zero‑based index of a null entry in lsurf. If lsurf is uninitialized or all existing entries are occupied, the array grows and the method returns the index of the first newly created slot (typically 0 for a fresh allocation).</returns>
    public uint NextFree() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, uint>)0x00503510)(ref this);

    /// <summary>Retrieves the detail texture tiling for a given terrain index within the land surface.
    /// <code>Offset: 0x005035E0
    /// unsigned int __thiscall LandSurf::GetDetailTiling(LandSurf*,unsigned int)</code>
    /// </summary>
    /// <param name="terrain_number">Index of the terrain whose detail tiling is requested.</param>
    /// <returns>Detail tiling value if the terrain exists and a TexMerge is present; otherwise zero.</returns>
    public uint GetDetailTiling(uint terrain_number) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, uint, uint>)0x005035E0)(ref this, terrain_number);

    /// <summary>Releases all resources owned by the LandSurf instance and resets its internal state.
    /// <code>Offset: 0x00503600
    /// void __thiscall LandSurf::Destroy(LandSurf*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, void>)0x00503600)(ref this);

    /// <summary>Packs the LandSurf object's data into the provided buffer, writing a flag for pal_shift presence and delegating to PalShift or TexMerge based on its existence.
    /// <code>Offset: 0x00503670
    /// unsigned int __thiscall LandSurf::Pack(LandSurf*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the output buffer; advanced as bytes are written.</param>
    /// <param name="size">Pointer to the remaining size of the output buffer; decremented by the number of bytes written.</param>
    /// <returns>Remaining buffer size after packing has completed.</returns>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, void**, uint*, uint>)0x00503670)(ref this, addr, size);

    /// <summary>Unpacks surface data from a buffer into either a PalShift or TexMerge instance, allocating the appropriate object when necessary.
    /// <code>Offset: 0x005036D0
    /// int __thiscall LandSurf::UnPack(LandSurf*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position in the data buffer; advanced past the processed section.</param>
    /// <param name="size">Remaining number of bytes available in the buffer; decreased by the amount unpacked.</param>
    /// <returns>Result code returned by PalShift::UnPack or TexMerge::UnPack, typically zero on success.</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, void**, uint*, int>)0x005036D0)(ref this, addr, size);

    /// <summary>Retrieves the detail texture identifier for a specified surface level, updating the supplied ID object and returning it.
    /// <code>Offset: 0x00503770
    /// IDClass&lt;_tagDataID,32,0&gt;* __thiscall LandSurf::GetDetailTex(_DWORD*,IDClass&lt;_tagDataID,32,0&gt;*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">The IDClass instance that receives the retrieved or invalid identifier.</param>
    /// <param name="a3">Index specifying which detail level to query.</param>
    /// <returns>The same IDClass pointer passed in, now containing the found texture ID or an INVALID_DID_203 if no texture is available.</returns>
    public ACBindings.Internal.IDClass____tagDataID* GetDetailTex(ACBindings.Internal.IDClass____tagDataID* a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, ACBindings.Internal.IDClass____tagDataID*, uint, ACBindings.Internal.IDClass____tagDataID*>)0x00503770)(ref this, a2, a3);

    /// <summary>Destroys a LandSurf instance, freeing its block surface array and invoking any registered cleanup callback.
    /// <code>Offset: 0x005037A0
    /// void __thiscall LandSurf::~LandSurf(LandSurf*)</code>
    /// </summary>
    /// <param name="this">The LandSurf object to destroy.</param>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, void>)0x005037A0)(ref this);

    /// <summary>Initializes the LandSurf instance by clearing all surface-related fields and allocating an internal hash table for surface information with a default capacity.
    /// <code>Offset: 0x00503830
    /// void __thiscall LandSurf::LandSurf(LandSurf*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, void>)0x00503830)(ref this);

    /// <summary>Adds a surface to the land surface collection, assigns it a unique identifier via NextFree, stores it in internal arrays and hash map, and updates surface counters.
    /// <code>Offset: 0x005038E0
    /// int __thiscall LandSurf::AddNewSurface(LandSurf*,CSurface*,unsigned int,unsigned int*)</code>
    /// </summary>
    /// <param name="surf">The CSurface instance to add to the land surface list.</param>
    /// <param name="pcode">A code identifying the surface’s property or type used as a key in the hash map.</param>
    /// <param name="surf_num">Pointer receiving the assigned unique index for the new surface.</param>
    /// <returns>Always returns 1 indicating successful addition of the surface.</returns>
    public int AddNewSurface(ACBindings.Internal.CSurface* surf, uint pcode, uint* surf_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, ACBindings.Internal.CSurface*, uint, uint*, int>)0x005038E0)(ref this, surf, pcode, surf_num);

    /// <summary>Removes the surface identified by surf_num from the land surface collection. If it is the last reference, deallocates the surface and updates related resources.
    /// <code>Offset: 0x00503950
    /// void __thiscall LandSurf::RemoveSurface(LandSurf*,unsigned int)</code>
    /// </summary>
    /// <param name="this">The LandSurf instance whose surface to remove.</param>
    /// <param name="surf_num">Index of the surface to remove within the lsurf array.</param>
    public void RemoveSurface(uint surf_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, uint, void>)0x00503950)(ref this, surf_num);

    /// <summary>Selects an existing terrain surface at the specified (x, y) coordinates using palette shift or texture merge data; if none exists it creates a new surface. Updates rotation and palette code outputs, and returns a status flag indicating success.
    /// <code>Offset: 0x00503AD0
    /// int __thiscall LandSurf::SelectTerrain(LandSurf*,int,int,unsigned int*,LandDefs::Rotation*,unsigned int*,unsigned int,int)</code>
    /// </summary>
    /// <param name="x">The X coordinate of the desired terrain position.</param>
    /// <param name="y">The Y coordinate of the desired terrain position.</param>
    /// <param name="surf_num">Output parameter that receives the index of the selected or newly created surface.</param>
    /// <param name="rot">Input rotation; may be modified to reflect the orientation of the chosen surface.</param>
    /// <param name="pal_code">Palette code used for lookup and updated during selection.</param>
    /// <param name="size">Size value employed when generating a new surface if necessary.</param>
    /// <param name="minimize_pal">Flag that influences palette minimization during surface selection.</param>
    /// <returns>Non‑zero on successful selection or creation of a terrain surface; zero indicates failure.</returns>
    public int SelectTerrain(int x, int y, uint* surf_num, ACBindings.Internal.LandDefs.Rotation* rot, uint* pal_code, uint size, int minimize_pal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, int, int, uint*, ACBindings.Internal.LandDefs.Rotation*, uint*, uint, int, int>)0x00503AD0)(ref this, x, y, surf_num, rot, pal_code, size, minimize_pal);
}

