namespace ACBindings.Internal;


/// <summary>BSPLEAF represents a terminal node in a binary space partition tree, storing an index, solidity flag, and inherited spatial data for collision detection and navigation.</summary>
public unsafe struct BSPLEAF
{
    // Base Classes
    public ACBindings.Internal.BSPNODE BaseClass_BSPNODE; // ACBindings.Internal.BSPNODE

    // Child Types
    public unsafe struct BSPLEAF_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPLEAF*, void> BSPLEAF_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPLEAF*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, int> sphere_intersects_poly; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPLEAF*, ACBindings.Internal.CSphere*, int, int> sphere_intersects_solid; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPLEAF*, ACBindings.Internal.AC1Legacy.Vector3*, int> point_intersects_solid; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPLEAF*, ACBindings.Internal.CSphere*, float, int*, ACBindings.Internal.CPolygon**, int, int> sphere_intersects_solid_poly; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPLEAF*, ACBindings.Internal.Ray*, float*, ACBindings.Internal.Vector3*, uint> TraceRay; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPLEAF*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, int*, void> find_walkable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPLEAF*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int> hits_walkable; // function pointer

        // Methods
    }

    // Members
    public uint leaf_index;
    public int solid;

    // Generated Constructor
    public BSPLEAF() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Initializes a new BSPLEAF instance by constructing the base BSPNODE and setting default values for leaf index and solidity.
    /// <code>Offset: 0x0053E130
    /// void __thiscall BSPLEAF::BSPLEAF(BSPLEAF*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, void>)0x0053E130)(ref this);

    /// <summary>Determines whether this BSP leaf contains any polygons, indicating a solid region.
    /// <code>Offset: 0x0053E150
    /// int __thiscall BSPLEAF::point_intersects_solid(BSPLEAF*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="point">Point to test against the leaf (currently ignored by the implementation).</param>
    /// <returns>Non‑zero if the leaf has one or more polygons; zero otherwise.</returns>
    public int point_intersects_solid(ACBindings.Internal.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053E150)(ref this, point);

    /// <summary>Packs the leaf node into a binary stream, storing its index and, when the BSP type is PHYSICS_BSP, additional physics data such as solidity flag, sphere and polygon identifiers. Returns the number of bytes required to pack this leaf.
    /// <code>Offset: 0x0053E160
    /// unsigned int __thiscall BSPLEAF::PackLeaf(BSPLEAF*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the output buffer; updated past written data if sufficient space exists.</param>
    /// <param name="size">Remaining byte capacity available in the buffer.</param>
    /// <returns>The size in bytes needed for packing this leaf node. If the provided buffer is too small, no data is written but the return value still indicates the required size.</returns>
    public uint PackLeaf(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, void**, uint, uint>)0x0053E160)(ref this, addr, size);

    /// <summary>Deserializes a BSP leaf node from raw data pointed to by <c>addr</c>, populating its index, solidity flag, bounding sphere, and associated polygons.
    /// <code>Offset: 0x0053E200
    /// int __thiscall BSPLEAF::UnPackLeaf(BSPLEAF*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the input buffer; advanced as fields are unpacked.</param>
    /// <param name="size">Remaining byte count of the buffer; used only to verify sufficient data for sphere extraction.</param>
    /// <returns>Always returns 1, indicating successful unpacking.</returns>
    public int UnPackLeaf(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, void**, uint, int>)0x0053E200)(ref this, addr, size);

    /// <summary>Determines whether a moving sphere intersects any polygon within the BSP leaf and reports the first hit.
    /// <code>Offset: 0x0053E2E0
    /// int __thiscall BSPLEAF::sphere_intersects_poly(BSPLEAF*,const CSphere*,const AC1Legacy::Vector3*,const CPolygon**,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="check_pos">Sphere to test for intersection, including its center and radius.</param>
    /// <param name="movement">Vector describing the sphere's motion during the test.</param>
    /// <param name="polygon">Output pointer that receives the intersected polygon if a collision occurs.</param>
    /// <param name="contact_pt">Output vector containing the contact point on the polygon when an intersection is detected.</param>
    /// <returns>Non‑zero (1) if an intersection is found; zero otherwise.</returns>
    public int sphere_intersects_poly(ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* movement, ACBindings.Internal.CPolygon** polygon, ACBindings.Internal.AC1Legacy.Vector3* contact_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053E2E0)(ref this, check_pos, movement, polygon, contact_pt);

    /// <summary>Checks whether a given sphere intersects the solid geometry of this BSP leaf.
    /// <code>Offset: 0x0053E350
    /// int __thiscall BSPLEAF::sphere_intersects_solid(BSPLEAF*,const CSphere*,int)</code>
    /// </summary>
    /// <param name="check_pos">Sphere to test against the leaf's geometry.</param>
    /// <param name="center_check">If true and the leaf is marked as solid, immediately returns true without further checks.</param>
    /// <returns>Non‑zero if an intersection occurs; zero otherwise.</returns>
    public int sphere_intersects_solid(ACBindings.Internal.CSphere* check_pos, int center_check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, ACBindings.Internal.CSphere*, int, int>)0x0053E350)(ref this, check_pos, center_check);

    /// <summary>Determines whether the specified sphere position is considered walkable within this leaf by testing against contained polygons.
    /// <code>Offset: 0x0053E3D0
    /// int __thiscall BSPLEAF::hits_walkable(BSPLEAF*,SPHEREPATH*,CSphere*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="path">Traversal data used during collision checks.</param>
    /// <param name="valid_pos">Sphere representing the candidate position to test for walkability.</param>
    /// <param name="up">Vector indicating the upward direction for walkable surface checks.</param>
    /// <returns>1 if at least one polygon in the leaf accepts the sphere as walkable; otherwise 0.</returns>
    public int hits_walkable(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.CSphere* valid_pos, ACBindings.Internal.AC1Legacy.Vector3* up) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053E3D0)(ref this, path, valid_pos, up);

    /// <summary>Searches the leaf’s polygons for one intersecting the given sphere and, when found, aligns the sphere to that polygon’s plane while setting an output flag.
    /// <code>Offset: 0x0053E450
    /// void __thiscall BSPLEAF::find_walkable(BSPLEAF*,SPHEREPATH*,CSphere*,const CPolygon**,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,int*)</code>
    /// </summary>
    /// <param name="path">The sphere path context used during hit tests and adjustments.</param>
    /// <param name="valid_pos">Sphere representing the current position to test against leaf polygons.</param>
    /// <param name="polygon">Receives a pointer to the walkable polygon that intersects the sphere, if any.</param>
    /// <param name="movement">Vector describing intended movement direction for sphere adjustment.</param>
    /// <param name="up">Upward normal used in hit detection with polygons.</param>
    /// <param name="changed">Set to 1 when a walkable polygon was found and the sphere adjusted; otherwise unchanged.</param>
    public void find_walkable(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.CSphere* valid_pos, ACBindings.Internal.CPolygon** polygon, ACBindings.Internal.AC1Legacy.Vector3* movement, ACBindings.Internal.AC1Legacy.Vector3* up, int* changed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, int*, void>)0x0053E450)(ref this, path, valid_pos, polygon, movement, up, changed);

    /// <summary>Determines whether a given sphere intersects any polygon within the BSP leaf, optionally marking if its center lies inside the leaf’s solid region.
    /// <code>Offset: 0x0053E4E0
    /// int __thiscall BSPLEAF::sphere_intersects_solid_poly(BSPLEAF*,const CSphere*,float,int*,const CPolygon**,int)</code>
    /// </summary>
    /// <param name="check_pos">The sphere to test against the leaf’s geometry.</param>
    /// <param name="radius">Radius of the sphere (currently unused).</param>
    /// <param name="center_solid">Pointer to an integer flag set to 1 when the sphere’s center lies within a solid leaf and center_check is enabled; otherwise unchanged.</param>
    /// <param name="hit_poly">Output pointer assigned to the first polygon that intersects the sphere, if one exists.</param>
    /// <param name="center_check">When non‑zero, causes the function to evaluate and record whether the sphere’s center is inside a solid leaf.</param>
    /// <returns>Non‑zero (1) when the sphere intersects a polygon; otherwise returns the value stored in *center_solid, indicating whether the sphere’s center was inside a solid region.</returns>
    public int sphere_intersects_solid_poly(ACBindings.Internal.CSphere* check_pos, float radius, int* center_solid, ACBindings.Internal.CPolygon** hit_poly, int center_check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, ACBindings.Internal.CSphere*, float, int*, ACBindings.Internal.CPolygon**, int, int>)0x0053E4E0)(ref this, check_pos, radius, center_solid, hit_poly, center_check);
}

