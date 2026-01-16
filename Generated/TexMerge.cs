namespace ACBindings.Internal;


/// <summary>
/// Maintains texture merge data, including base texture size, corner and side terrain maps, road maps, and terrain descriptors.
/// Provides storage for texture blending information used when generating surface textures.
/// </summary>
public unsafe struct TexMerge : System.IDisposable
{
    // Statics
    public static byte** tex_data = (byte**)0x0084271C;

    // Members
    public uint base_tex_size;
    public ACBindings.Internal.AC1Legacy.SmartArray___TerrainAlphaMap_ptr corner_terrain_maps;
    public ACBindings.Internal.AC1Legacy.SmartArray___TerrainAlphaMap_ptr side_terrain_maps;
    public ACBindings.Internal.AC1Legacy.SmartArray___RoadAlphaMap_ptr road_maps;
    public ACBindings.Internal.AC1Legacy.SmartArray___TMTerrainDesc_ptr terrain_desc;

    // Generated Constructor
    public TexMerge() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Releases custom resources of a surface if it exists.
    /// <code>Offset: 0x00503E30
    /// void __thiscall TexMerge::CleanupSurface(TexMerge*,CSurface*)</code>
    /// </summary>
    /// <param name="surf">The surface to clean up.</param>
    public void CleanupSurface(ACBindings.Internal.CSurface* surf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, ACBindings.Internal.CSurface*, void>)0x00503E30)(ref this, surf);

    /// <summary>Computes road fill flag and two-part code from input bitmask.
    /// <code>Offset: 0x00503E50
    /// int __thiscall TexMerge::GetRoadCode(TexMerge*,unsigned int,int*,unsigned int*)</code>
    /// </summary>
    /// <param name="pcode">Input bitmask representing terrain map configuration.</param>
    /// <param name="road_fill">Output parameter; set to 1 if the road should be filled, otherwise 0.</param>
    /// <param name="rcode">Output array of two unsigned integers: rcode[0] holds the primary road code, and rcode[1] holds a secondary or variant code based on the input pattern.</param>
    /// <returns>Integer status indicator; currently always returns 1 to signify successful execution.</returns>
    public int GetRoadCode(uint pcode, int* road_fill, uint* rcode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, uint, int*, uint*, int>)0x00503E50)(ref this, pcode, road_fill, rcode);

    /// <summary>Initializes a TexMerge instance by setting the default base texture size and clearing all terrain and road map arrays.
    /// <code>Offset: 0x00503FB0
    /// void __thiscall TexMerge::TexMerge(TexMerge*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, void>)0x00503FB0)(ref this);

    /// <summary>Copies and tiles the base texture described by a TerrainTex into a destination buffer, loading the texture from the database if it has not already been loaded.
    /// <code>Offset: 0x00503FE0
    /// int __thiscall TexMerge::CopyAndTile(TexMerge*,unsigned __int8*,unsigned int,TerrainTex*)</code>
    /// </summary>
    /// <param name="data">Pointer to the output image data buffer where the tiled texture will be written.</param>
    /// <param name="tex_size">The width (and height) in pixels of the square source texture. The same value is used for both dimensions when copying.</param>
    /// <param name="terrain_tex">Structure describing the terrain texture, including its base texture pointer and tiling parameters.</param>
    /// <returns>Non‑zero if a valid texture was copied into the buffer; zero if the texture could not be retrieved or loaded.</returns>
    public int CopyAndTile(byte* data, uint tex_size, ACBindings.Internal.TerrainTex* terrain_tex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, byte*, uint, ACBindings.Internal.TerrainTex*, int>)0x00503FE0)(ref this, data, tex_size, terrain_tex);

    /// <summary>Searches TexMerge's road_maps for a RoadAlphaMap whose rcode matches the supplied value and returns the map pointer together with its rotation.
    /// <code>Offset: 0x00504060
    /// int __thiscall TexMerge::FindRoadAlpha(TexMerge*,unsigned int,RoadAlphaMap**,LandDefs::Rotation*,unsigned int)</code>
    /// </summary>
    /// <param name="rcode">The code of the desired road to locate.</param>
    /// <param name="alpha">Receives the found RoadAlphaMap; set to null if no match is found.</param>
    /// <param name="rot">Receives the rotation within the map that corresponds to the matching rcode.</param>
    /// <param name="pcode">Used as a secondary offset when determining where in the road_maps array to begin searching.</param>
    /// <returns>1 if a matching RoadAlphaMap was located; otherwise 0.</returns>
    public int FindRoadAlpha(uint rcode, ACBindings.Internal.RoadAlphaMap** alpha, ACBindings.Internal.LandDefs.Rotation* rot, uint pcode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, uint, ACBindings.Internal.RoadAlphaMap**, ACBindings.Internal.LandDefs.Rotation*, uint, int>)0x00504060)(ref this, rcode, alpha, rot, pcode);

    /// <summary>Locates a TerrainAlphaMap that matches the requested type code within the TexMerge's corner or side collections, rotating through possible orientations until a match is found.
    /// <code>Offset: 0x00504160
    /// int __thiscall TexMerge::FindTerrainAlpha(TexMerge*,unsigned int,TerrainAlphaMap**,LandDefs::Rotation*,unsigned int)</code>
    /// </summary>
    /// <param name="tcode">Terrain alpha code indicating the desired map (corner codes 1, 2, 4, 8 use corner maps; other values use side maps).</param>
    /// <param name="alpha">Output pointer that receives the located TerrainAlphaMap instance.</param>
    /// <param name="rot">Output pointer that receives the rotation applied to align the tcode with the stored map.</param>
    /// <param name="pcode">Identifier used to select a specific map entry from the collection, providing deterministic pseudo‑random selection.</param>
    /// <returns>Non‑zero if a matching TerrainAlphaMap was found and its texture loaded (if necessary); zero when no match could be located within four rotations.</returns>
    public int FindTerrainAlpha(uint tcode, ACBindings.Internal.TerrainAlphaMap** alpha, ACBindings.Internal.LandDefs.Rotation* rot, uint pcode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, uint, ACBindings.Internal.TerrainAlphaMap**, ACBindings.Internal.LandDefs.Rotation*, uint, int>)0x00504160)(ref this, tcode, alpha, rot, pcode);

    /// <summary>Merges supplied image data into the terrain's base texture using specified tiling and rotation, updating the target ImgTex when a base texture is available or initialized.
    /// <code>Offset: 0x00504320
    /// int __thiscall TexMerge::Merge(TexMerge*,unsigned __int8*,unsigned int,ImgTex*,LandDefs::Rotation,TerrainTex*)</code>
    /// </summary>
    /// <param name="data">Pointer to raw image data used for merging.</param>
    /// <param name="tex_size">Dimension (width/height) of the texture being processed.</param>
    /// <param name="texture">Destination ImgTex into which the new texture will be merged.</param>
    /// <param name="rot">Rotation applied during merging, as defined by LandDefs::Rotation.</param>
    /// <param name="terrain">TerrainTex providing base texture and tiling information for the merge operation.</param>
    /// <returns>1 if merge succeeded; 0 otherwise.</returns>
    public int Merge(byte* data, uint tex_size, ACBindings.Internal.ImgTex* texture, ACBindings.Internal.LandDefs.Rotation rot, ACBindings.Internal.TerrainTex* terrain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, byte*, uint, ACBindings.Internal.ImgTex*, ACBindings.Internal.LandDefs.Rotation, ACBindings.Internal.TerrainTex*, int>)0x00504320)(ref this, data, tex_size, texture, rot, terrain);

    /// <summary>Retrieves the terrain texture that matches a specified terrain type from the merge’s descriptors.
    /// <code>Offset: 0x005043A0
    /// TerrainTex* __thiscall TexMerge::GetTerrainTex(TexMerge*,unsigned int)</code>
    /// </summary>
    /// <param name="t1">The identifier of the terrain type to search for.</param>
    /// <returns>The matching TerrainTex object, or the first descriptor’s texture if no exact match is found; returns null when there are no descriptors.</returns>
    public ACBindings.Internal.TerrainTex* GetTerrainTex(uint t1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, uint, ACBindings.Internal.TerrainTex*>)0x005043A0)(ref this, t1);

    /// <summary>Calculates the total number of bytes required to pack the TexMerge object's data, including corner terrain maps, side terrain maps, road maps, and terrain descriptions.
    /// <code>Offset: 0x00504400
    /// unsigned int __thiscall TexMerge::pack_size(TexMerge*)</code>
    /// </summary>
    /// <returns>The size in bytes necessary for packing all arrays within the TexMerge instance.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, uint>)0x00504400)(ref this);

    /// <summary>Retrieves the identifier for the detail texture at a given index and writes it into the supplied IDClass instance. If the index exceeds the collection size, the ID is set to an invalid sentinel value.
    /// <code>Offset: 0x00504440
    /// IDClass&lt;_tagDataID,32,0&gt;* __thiscall TexMerge::GetDetailTex(_DWORD*,IDClass&lt;_tagDataID,32,0&gt;*,unsigned int)</code>
    /// </summary>
    /// <param name="a2">Output parameter that receives the retrieved texture ID.</param>
    /// <param name="a3">Zero‑based index of the desired detail texture within the TexMerge object.</param>
    /// <returns>Pointer to the updated IDClass instance passed in as a2.</returns>
    public ACBindings.Internal.IDClass____tagDataID* GetDetailTex(ACBindings.Internal.IDClass____tagDataID* a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, ACBindings.Internal.IDClass____tagDataID*, uint, ACBindings.Internal.IDClass____tagDataID*>)0x00504440)(ref this, a2, a3);

    /// <summary>Collects all texture identifiers referenced by the terrain and road maps of this TexMerge instance and appends them to the supplied QualifiedDataIDArray.
    /// <code>Offset: 0x00504710
    /// void __thiscall TexMerge::GetSubDataIDs(TexMerge*,QualifiedDataIDArray*)</code>
    /// </summary>
    /// <param name="id_array">The array that receives the gathered qualified data IDs.</param>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00504710)(ref this, id_array);

    /// <summary>Retrieves terrain texture pointers based on a composite terrain code and stores them in the supplied array.
    /// <code>Offset: 0x00504820
    /// int __thiscall TexMerge::GetTerrain(TexMerge*,unsigned int,TerrainTex**,unsigned int*)</code>
    /// </summary>
    /// <param name="pcode">Composite identifier encoding up to four sub‑terrain types.</param>
    /// <param name="terrain_tex">Output array of TerrainTex*; indices 0‑3 receive textures for each sub‑terrain component.</param>
    /// <param name="tcode">Output flags indicating which sub‑terrains are present for each index.</param>
    /// <returns>Always returns 1 to indicate successful retrieval.</returns>
    public int GetTerrain(uint pcode, ACBindings.Internal.TerrainTex** terrain_tex, uint* tcode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, uint, ACBindings.Internal.TerrainTex**, uint*, int>)0x00504820)(ref this, pcode, terrain_tex, tcode);

    /// <summary>Serializes a TexMerge instance into a binary buffer, writing its base texture size, counts of corner, side and road terrain maps along with each map’s tcode and texture ID, and the list of terrain descriptors.
    /// <code>Offset: 0x00504B40
    /// unsigned int __thiscall TexMerge::Pack(TexMerge*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position within the destination buffer; advanced as data is written.</param>
    /// <param name="size">Pointer to the remaining byte count in the buffer; decremented by every 4‑byte write performed during serialization.</param>
    /// <returns>Number of bytes left unused in the buffer after packing the TexMerge data.</returns>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, void**, uint*, uint>)0x00504B40)(ref this, addr, size);

    /// <summary>Releases all resources owned by the TexMerge instance, including textures, terrain maps, road maps, and terrain descriptions, then deallocates the associated memory.
    /// <code>Offset: 0x00504D80
    /// void __thiscall TexMerge::Destroy(TexMerge*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, void>)0x00504D80)(ref this);

    /// <summary>Builds a temporary texture buffer by merging terrain and road textures for the specified code and size.
    /// <code>Offset: 0x00504EB0
    /// int __thiscall TexMerge::FillTempTexBuffer(TexMerge*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="pcode">Identifier used to locate the appropriate terrain and road data.</param>
    /// <param name="tex_size">Size of the texture area to fill.</param>
    /// <returns>1 if the buffer was successfully created; 0 otherwise.</returns>
    public int FillTempTexBuffer(uint pcode, uint tex_size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, uint, uint, int>)0x00504EB0)(ref this, pcode, tex_size);

    /// <summary>Unpacks texture merge data from a binary stream into the TexMerge object's arrays of corner, side, and road terrain alpha maps as well as terrain descriptions.
    /// <code>Offset: 0x00505010
    /// int __thiscall TexMerge::UnPack(TexMerge*,void**,unsigned int*)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the input buffer; advances as bytes are read during unpacking.</param>
    /// <param name="size">Number of remaining bytes in the input buffer; decreased by the amount consumed while reading data.</param>
    /// <returns>Non‑zero if all data was successfully unpacked; zero if an error occurs (e.g., insufficient data or allocation failure).</returns>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, void**, uint*, int>)0x00505010)(ref this, addr, size);

    /// <summary>Destroys a TexMerge instance, releasing all owned resources such as terrain maps, road maps, side and corner terrain maps, and terrain descriptions.
    /// <code>Offset: 0x00505330
    /// void __thiscall TexMerge::~TexMerge(TexMerge*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, void>)0x00505330)(ref this);

    /// <summary>Restores a surface’s texture by creating and applying a merged image based on its ID.
    /// <code>Offset: 0x00505370
    /// bool __cdecl TexMerge::RestoreSurface(CSurface*)</code>
    /// </summary>
    /// <param name="surface">The surface whose texture is to be restored.</param>
    /// <returns>True if the restoration succeeds; otherwise, false.</returns>
    public static byte RestoreSurface(ACBindings.Internal.CSurface* surface) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface*, byte>)0x00505370)(surface);

    /// <summary>Creates a new surface by generating an appropriately sized texture from the TexMerge data and assigning it to the surface.
    /// <code>Offset: 0x00505410
    /// CSurface* __thiscall TexMerge::MakeNewSurface(TexMerge*,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="pcode">Identifier used when releasing the previous texture map and filling the temporary buffer.</param>
    /// <param name="size">Scaling divisor that determines the resolution of the generated texture.</param>
    /// <returns>Pointer to the created CSurface, or nullptr if creation fails.</returns>
    public ACBindings.Internal.CSurface* MakeNewSurface(uint pcode, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, uint, uint, ACBindings.Internal.CSurface*>)0x00505410)(ref this, pcode, size);
}

