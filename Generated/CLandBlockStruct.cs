namespace ACBindings.Internal;


/// <summary>Represents a land block within the terrain system, holding vertex lighting, geometric topology, and surface data used for rendering and simulation of natural environments.</summary>
public unsafe struct CLandBlockStruct : System.IDisposable
{
    // Statics
    public static ACBindings.Internal.CVec2Duv** land_uvs = (ACBindings.Internal.CVec2Duv**)0x00845CB8;

    // Members
    public ACBindings.Internal.RGBColor* vertex_lighting;
    public ACBindings.Internal.LandDefs.Direction trans_dir;
    public int side_vertex_count;
    public int side_polygon_count;
    public int side_cell_count;
    public ACBindings.Internal.LandDefs.WaterType water_type;
    public byte* height;
    public ushort* terrain;
    public ACBindings.Internal.CVertexArray vertex_array;
    public ACBindings.Internal.CPolygon* polygons;
    public uint num_surface_strips;
    public ACBindings.Internal.CSurfaceTriStrips* surface_strips;
    public uint block_surface_index;
    public ACBindings.Internal.CLandCell* lcell;
    public int* SWtoNEcut;

    // Generated Constructor
    public CLandBlockStruct() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Initializes a new land block structure with default values, allocating memory for height and terrain data.
    /// <code>Offset: 0x00531B70
    /// void __thiscall CLandBlockStruct::CLandBlockStruct(CLandBlockStruct*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x00531B70)(ref this);

    /// <summary>Allocates and configures vertex, polygon, cell, and lighting arrays for a land block using its side dimensions.
    /// <code>Offset: 0x00531BD0
    /// void __thiscall CLandBlockStruct::InitPVArrays(CLandBlockStruct*)</code>
    /// </summary>
    public void InitPVArrays() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x00531BD0)(ref this);

    /// <summary>Creates a triangular polygon in the land block by assigning vertices from its vertex array and computing its plane. Sets the surface flag based on whether all vertices lie on the ground (z = 0) or are elevated, then returns a reference to the new polygon.
    /// <code>Offset: 0x00531E10
    /// CPolygon* __thiscall CLandBlockStruct::AddPolygon(CLandBlockStruct*,unsigned int,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    /// <param name="pindex">Index of the polygon slot within the block’s polygons array where the new triangle is stored.</param>
    /// <param name="vindex0">Vertex index for the first corner in the block’s vertex array.</param>
    /// <param name="vindex1">Vertex index for the second corner.</param>
    /// <param name="vindex2">Vertex index for the third corner.</param>
    /// <returns>A pointer to the newly created CPolygon within the block.</returns>
    public ACBindings.Internal.CPolygon* AddPolygon(uint pindex, uint vindex0, uint vindex1, uint vindex2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, uint, uint, uint, uint, ACBindings.Internal.CPolygon*>)0x00531E10)(ref this, pindex, vindex0, vindex1, vindex2);

    /// <summary>Computes the byte count required to serialize a land block.
    /// <code>Offset: 0x00531F10
    /// unsigned int __thiscall CLandBlockStruct::pack_size(CLandBlockStruct*)</code>
    /// </summary>
    /// <returns>The fixed size, 244 bytes, necessary for packing this structure.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, uint>)0x00531F10)(ref this);

    /// <summary>Serializes the block's terrain and height arrays into a binary stream, writing 16‑bit terrain values followed by 8‑bit heights and padding to 4‑byte alignment.
    /// <code>Offset: 0x00531F20
    /// unsigned int __thiscall CLandBlockStruct::Pack(CLandBlockStruct*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the destination buffer; updated as data is written.</param>
    /// <param name="size">Maximum size of the output buffer (unused in this implementation).</param>
    /// <returns>Zero, indicating successful serialization.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void**, uint, uint>)0x00531F20)(ref this, addr, size);

    /// <summary>Recalculates the plane equations for each polygon in the land block using its current vertex configuration.
    /// <code>Offset: 0x005320C0
    /// void __thiscall CLandBlockStruct::AdjPlanes(CLandBlockStruct*)</code>
    /// </summary>
    public void AdjPlanes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x005320C0)(ref this);

    /// <summary>Removes all surface references linked to the block’s polygons from the current region’s command list by iterating over each side cell.
    /// <code>Offset: 0x00532120
    /// void __thiscall CLandBlockStruct::RemoveSurfaces(CLandBlockStruct*)</code>
    /// </summary>
    public void RemoveSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x00532120)(ref this);

    /// <summary>Destroys the CLandBlockStruct instance by releasing all allocated resources such as vertex array data, polygons, surface strips, lighting arrays, SWtoNEcut data, and associated land cell references.
    /// <code>Offset: 0x00532190
    /// void __thiscall CLandBlockStruct::Destroy(CLandBlockStruct*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x00532190)(ref this);

    /// <summary>Determines whether a land block cell contains any water and whether the entire cell is covered with water by inspecting its terrain types.
    /// <code>Offset: 0x00532290
    /// void __thiscall CLandBlockStruct::CalcCellWater(CLandBlockStruct*,int,int,int*,int*)</code>
    /// </summary>
    /// <param name="cell_x">Horizontal index of the cell within the land block.</param>
    /// <param name="cell_y">Vertical index of the cell within the land block.</param>
    /// <param name="cell_has_water">Output flag set to 1 if any part of the cell is water; otherwise 0.</param>
    /// <param name="cell_all_water">Output flag set to 1 only when all tiles in the cell are water; otherwise 0.</param>
    public void CalcCellWater(int cell_x, int cell_y, int* cell_has_water, int* cell_all_water) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, int, int, int*, int*, void>)0x00532290)(ref this, cell_x, cell_y, cell_has_water, cell_all_water);

    /// <summary>Computes a water depth value for the specified land block cell based on internal terrain data.
    /// <code>Offset: 0x00532330
    /// float __thiscall CLandBlockStruct::calc_water_depth(CLandBlockStruct*,unsigned int,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="cell_id">The identifier of the land block cell for which water depth is calculated.</param>
    /// <param name="point">The position within the cell (currently unused).</param>
    /// <returns>A float representing the water depth: 0.1, 0.44999999, or 0.0 depending on terrain type.</returns>
    public float calc_water_depth(uint cell_id, ACBindings.Internal.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, uint, ACBindings.Internal.AC1Legacy.Vector3*, float>)0x00532330)(ref this, cell_id, point);

    /// <summary>Computes per‑vertex lighting for a land block by averaging adjacent polygon normals, normalizing them, applying ambient and sunlight contributions, and storing the resulting RGB values in vertex_lighting.
    /// <code>Offset: 0x00532440
    /// void __thiscall CLandBlockStruct::calc_lighting(CLandBlockStruct*)</code>
    /// </summary>
    public void calc_lighting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x00532440)(ref this);

    /// <summary>Generates polygon and cell data for a land block based on the provided block identifier. For each side cell, calculates vertex indices, creates polygons, sets cut flags, and assigns cell positions. The resulting polygons are stored in the block's internal structures.
    /// <code>Offset: 0x00532A50
    /// void __thiscall CLandBlockStruct::ConstructPolygons(CLandBlockStruct*,unsigned int)</code>
    /// </summary>
    /// <param name="block_id">Identifier used to offset polygon indices and determine geometry placement; if zero, no offset is applied.</param>
    public void ConstructPolygons(uint block_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, uint, void>)0x00532A50)(ref this, block_id);

    /// <summary>Unpacks serialized land block data into this instance, resetting any prior contents.
    /// <code>Offset: 0x00532D10
    /// int __thiscall CLandBlockStruct::UnPack(CLandBlockStruct*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current position within the source buffer; advanced as data is consumed.</param>
    /// <param name="size">Total size of the buffer (unused by the implementation).</param>
    /// <returns>Non‑zero value on success (currently always returns 1). If unpacking failed, zero would be returned. </returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void**, uint, int>)0x00532D10)(ref this, addr, size);

    /// <summary>
    /// Determines the surface texture usage, rotation, and surface index for a land cell at local coordinates (ix, iy) within the specified block. Computes whether the cell uses a single texture based on surrounding terrain data, then selects the appropriate terrain surface via LandSurf::SelectTerrain.
    /// 
    /// <code>Offset: 0x00532EB0
    /// void __thiscall CLandBlockStruct::GetCellRotation(CLandBlockStruct*,unsigned int,int,int,bool*,unsigned int*,LandDefs::Rotation*)</code>
    /// </summary>
    /// <param name="block_id">Identifier of the land block being queried.</param>
    /// <param name="ix">X coordinate of the cell within the block.</param>
    /// <param name="iy">Y coordinate of the cell within the block.</param>
    /// <param name="o_bSingleTextureCell">Output flag set to true if the cell uses a single texture; otherwise false.</param>
    /// <param name="o_surf_num">Output surface number index used for rendering this cell.</param>
    /// <param name="o_rot">Output rotation enumeration indicating the orientation of the cell.</param>
    public void GetCellRotation(uint block_id, int ix, int iy, byte* o_bSingleTextureCell, uint* o_surf_num, ACBindings.Internal.LandDefs.Rotation* o_rot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, uint, int, int, byte*, uint*, ACBindings.Internal.LandDefs.Rotation*, void>)0x00532EB0)(ref this, block_id, ix, iy, o_bSingleTextureCell, o_surf_num, o_rot);

    /// <summary>Adjusts vertex heights of a land block by averaging neighboring vertices along its edges, applying directional smoothing based on the viewer's orientation, and correcting corner elevations for full 2×2 cell blocks using a height lookup table.
    /// <code>Offset: 0x00533110
    /// void __thiscall CLandBlockStruct::TransAdjust(CLandBlockStruct*)</code>
    /// </summary>
    public void TransAdjust() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x00533110)(ref this);

    /// <summary>Releases resources associated with a land block, freeing height map and terrain arrays, notifying the system of vertex array cleanup, and invoking internal destruction logic.
    /// <code>Offset: 0x005334F0
    /// void __thiscall CLandBlockStruct::~CLandBlockStruct(CLandBlockStruct*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x005334F0)(ref this);

    /// <summary>Analyzes each cell in the land block to determine water coverage, marking cells as entirely water, partially water, or not water, and sets the block's overall water type accordingly.
    /// <code>Offset: 0x00533520
    /// void __thiscall CLandBlockStruct::CalcWater(CLandBlockStruct*)</code>
    /// </summary>
    public void CalcWater() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x00533520)(ref this);

    /// <summary>Creates a grid of 3‑D vertices for the land block by calculating x, y, and z coordinates from side cell count, polygon count, and height data, then stores them in the object's vertex_array.
    /// <code>Offset: 0x00533610
    /// void __thiscall CLandBlockStruct::ConstructVertices(CLandBlockStruct*)</code>
    /// </summary>
    public void ConstructVertices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x00533610)(ref this);

    /// <summary>Builds texture coordinates, stippling flags, and surface identifiers for every polygon in the land block by applying per-cell rotation data.
    /// <code>Offset: 0x005336E0
    /// void __thiscall CLandBlockStruct::ConstructUVs(CLandBlockStruct*,unsigned int)</code>
    /// </summary>
    /// <param name="block_id">Identifier of the block used to look up cell rotation, surface type, and single‑texture‑cell status during UV construction.</param>
    public void ConstructUVs(uint block_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, uint, void>)0x005336E0)(ref this, block_id);

    /// <summary>Generates or updates a land block’s geometry based on the supplied block ID, subdivision size, and orientation. Rebuilds vertices, polygons, UVs, and water data when the subdivision size changes; otherwise only adjusts vertex positions and plane adjacency for a direction change.
    /// <code>Offset: 0x005338F0
    /// int __thiscall CLandBlockStruct::generate(CLandBlockStruct*,unsigned int,unsigned int,LandDefs::Direction)</code>
    /// </summary>
    /// <param name="block_id">Identifier of the land block to generate or update.</param>
    /// <param name="poly_size">Number of divisions per side (must divide 8). Determines how many cells are used along each edge of the block.</param>
    /// <param name="tdir">Desired facing direction for the block.</param>
    /// <returns>1 if the geometry was rebuilt due to a change in polygon size; 0 otherwise.</returns>
    public int generate(uint block_id, uint poly_size, ACBindings.Internal.LandDefs.Direction tdir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, uint, uint, ACBindings.Internal.LandDefs.Direction, int>)0x005338F0)(ref this, block_id, poly_size, tdir);
}

