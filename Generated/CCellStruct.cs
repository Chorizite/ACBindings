namespace ACBindings.Internal;


/// <summary>Represents a spatial cell within the game world, holding geometry, portals, surface strips, and physics polygons. Provides precomputed BSP trees for efficient rendering and collision detection.</summary>
public unsafe struct CCellStruct : System.IDisposable
{
    // Members
    public uint cellstruct_id;
    public ACBindings.Internal.CVertexArray vertex_array;
    public uint num_portals;
    public ACBindings.Internal.CPolygon** portals;
    public uint num_surface_strips;
    public ACBindings.Internal.CSurfaceTriStrips* surface_strips;
    public uint num_polygons;
    public ACBindings.Internal.CPolygon* polygons;
    public ACBindings.Internal.BSPTREE* drawing_bsp;
    public uint num_physics_polygons;
    public ACBindings.Internal.CPolygon* physics_polygons;
    public ACBindings.Internal.BSPTREE* physics_bsp;
    public ACBindings.Internal.BSPTREE* cell_bsp;

    // Generated Constructor
    public CCellStruct() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Creates an empty cell structure, resetting the identifier and clearing all arrays and pointers so the instance is ready for subsequent data loading.
    /// <code>Offset: 0x005345B0
    /// void __thiscall CCellStruct::CCellStruct(CCellStruct*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, void>)0x005345B0)(ref this);

    /// <summary>Retrieves a portal polygon identified by its ID from the cell's portal list.
    /// <code>Offset: 0x005345F0
    /// CPolygon* __thiscall CCellStruct::get_portal(CCellStruct*,unsigned __int16)</code>
    /// </summary>
    /// <param name="poly_id">The unique identifier of the desired portal polygon.</param>
    /// <returns>Pointer to the matching CPolygon object, or nullptr if no such portal exists within this cell.</returns>
    public ACBindings.Internal.CPolygon* get_portal(ushort poly_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, ushort, ACBindings.Internal.CPolygon*>)0x005345F0)(ref this, poly_id);

    /// <summary>Determines whether a point lies within the spatial bounds of this cell by testing it against the cell's BSP tree.
    /// <code>Offset: 0x00534630
    /// int __thiscall CCellStruct::point_in_cell(CCellStruct*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="origin">The position to test, expressed as an AC1Legacy::Vector3.</param>
    /// <returns>Non‑zero (1) if the point is inside the cell; zero if outside.</returns>
    public int point_in_cell(ACBindings.Internal.AC1Legacy.Vector3* origin) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00534630)(ref this, origin);

    /// <summary>Evaluates whether a sphere intersects the cell’s spatial partitioning structure.
    /// <code>Offset: 0x00534640
    /// BoundingType __thiscall CCellStruct::sphere_intersects_cell(CCellStruct*,const CSphere*)</code>
    /// </summary>
    /// <param name="sphere">The sphere to test against the cell.</param>
    /// <returns>An enum value indicating the intersection status of the sphere relative to the cell.</returns>
    public ACBindings.Internal.BoundingType sphere_intersects_cell(ACBindings.Internal.CSphere* sphere) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, ACBindings.Internal.CSphere*, ACBindings.Internal.BoundingType>)0x00534640)(ref this, sphere);

    /// <summary>Determines whether the supplied bounding box intersects any geometry within the cell’s BSP tree.
    /// <code>Offset: 0x00534650
    /// int __thiscall CCellStruct::box_intersects_cell(CCellStruct*,const BBox*)</code>
    /// </summary>
    /// <param name="box">The axis-aligned bounding box to test against the cell.</param>
    /// <returns>An integer value indicating intersection status (non‑zero if the box intersects, zero otherwise).</returns>
    public int box_intersects_cell(ACBindings.Internal.BBox* box) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, ACBindings.Internal.BBox*, int>)0x00534650)(ref this, box);

    /// <summary>Calculates the byte count required to serialize the cell, including its vertex array, polygons, portals, and associated BSP trees, with 4‑byte alignment applied where necessary.
    /// <code>Offset: 0x00534660
    /// unsigned int __thiscall CCellStruct::pack_size(CCellStruct*)</code>
    /// </summary>
    /// <returns>The total packed size in bytes.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, uint>)0x00534660)(ref this);

    /// <summary>Packs a CCellStruct instance into a binary buffer when space permits; otherwise returns the required byte count.
    /// <code>Offset: 0x00534760
    /// unsigned int __thiscall CCellStruct::Pack(CCellStruct*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">The address of the buffer where packed data will be written; updated to point past the last byte used.</param>
    /// <param name="size">The number of bytes available in the provided buffer.</param>
    /// <returns>The total number of bytes needed to serialize the CCellStruct. If size is sufficient, the buffer contains the packed representation.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, void**, uint, uint>)0x00534760)(ref this, addr, size);

    /// <summary>Releases all dynamically allocated resources owned by a CCellStruct instance, including BSP trees, portals, physics polygons, drawing polygons, surface strips, and vertex data, then resets internal pointers to null.
    /// <code>Offset: 0x00534910
    /// void __thiscall CCellStruct::Destroy(CCellStruct*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, void>)0x00534910)(ref this);

    /// <summary>Unpacks a cell structure from a serialized buffer into this object after clearing its previous contents.
    /// <code>Offset: 0x00534A40
    /// int __thiscall CCellStruct::UnPack(CCellStruct*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the input buffer that will be advanced as data is read during unpacking.</param>
    /// <param name="size">Maximum number of bytes allowed for each sub‑unpack operation, used to guard against overreads.</param>
    /// <returns>1 if the cell structure was successfully unpacked; otherwise returns the value produced by CVertexArray::UnPack (typically zero).</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, void**, uint, int>)0x00534A40)(ref this, addr, size);

    /// <summary>Releases resources owned by a CCellStruct instance and notifies the notice handler about the previous spell selection.
    /// <code>Offset: 0x00534CD0
    /// void __thiscall CCellStruct::~CCellStruct(CCellStruct*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, void>)0x00534CD0)(ref this);
}

