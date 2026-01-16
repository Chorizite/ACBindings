namespace ACBindings.Internal;


/// <summary>BSP node in a binary space partitioning tree used for efficient spatial queries and rendering; stores bounding sphere, splitting plane, polygon references, and child nodes.</summary>
public unsafe struct BSPNODE : System.IDisposable
{
    // Statics
    public static ACBindings.Internal.CPolygon** pack_poly = (ACBindings.Internal.CPolygon**)0x00846388;
    public static ACBindings.Internal.BSPTreeType* pack_tree_type = (ACBindings.Internal.BSPTreeType*)0x0084638C;

    // Child Types

    /// <summary>Virtual function table for BSP nodes in a spatial partitioning engine, providing callbacks for destruction, intersection tests, ray traversal, and walkability queries.</summary>
    public unsafe struct BSPNODE_vtbl
    {
        // Members
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPNODE*, void> BSPNODE_dtor_0; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPNODE*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, int> sphere_intersects_poly; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPNODE*, ACBindings.Internal.CSphere*, int, int> sphere_intersects_solid; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPNODE*, ACBindings.Internal.AC1Legacy.Vector3*, int> point_intersects_solid; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPNODE*, ACBindings.Internal.CSphere*, float, int*, ACBindings.Internal.CPolygon**, int, int> sphere_intersects_solid_poly; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPNODE*, ACBindings.Internal.Ray*, float*, ACBindings.Internal.Vector3*, uint> TraceRay; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPNODE*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, int*, void> find_walkable; // function pointer
        public static delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPNODE*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int> hits_walkable; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.Internal.CSphere sphere;
    public ACBindings.Internal.Plane splitting_plane;
    public ACBindings.Internal._429348390AB0EFA2F7BE9421CDFA9E37 ___u3;
    public uint num_polys;
    public ACBindings.Internal.CPolygon** in_polys;
    public ACBindings.Internal.BSPNODE* pos_node;
    public ACBindings.Internal.BSPNODE* neg_node;

    // Generated Constructor
    public BSPNODE() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Destroys a BSP node by recursively destroying its child nodes, freeing the array of associated polygons, and resetting internal state to indicate an empty or invalid node.
    /// <code>Offset: 0x0053CE10
    /// void __thiscall BSPNODE::Destroy(BSPNODE*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, void>)0x0053CE10)(ref this);

    /// <summary>Traverses a BSP node to render portal geometry based on the camera’s position relative to each splitting plane. When the camera lies within a small distance of a plane, both child nodes are processed; otherwise traversal follows only the side opposite the camera. The function delegates drawing to portal nodes or recurses into further BSP nodes.
    /// <code>Offset: 0x0053CE60
    /// void __thiscall BSPNODE::build_draw_portals_only(BSPNODE*,int)</code>
    /// </summary>
    /// <param name="portalPolyOrPortalContents">Specifies whether portal polygons themselves or the geometry behind them should be drawn.</param>
    public void build_draw_portals_only(int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, int, void>)0x0053CE60)(ref this, portalPolyOrPortalContents);

    /// <summary>Determines whether a sphere intersects, lies inside, or is outside the spatial region defined by this BSP node and its descendants.
    /// <code>Offset: 0x0053CFC0
    /// BoundingType __thiscall BSPNODE::sphere_intersects_cell_bsp(BSPNODE*,const CSphere*)</code>
    /// </summary>
    /// <param name="curr_sphere">Sphere to test against the node’s volume.</param>
    /// <returns>A value from the BoundingType enumeration: 0 indicates the sphere does not intersect the node; any non‑zero value indicates intersection or containment.</returns>
    public ACBindings.Internal.BoundingType sphere_intersects_cell_bsp(ACBindings.Internal.CSphere* curr_sphere) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.CSphere*, ACBindings.Internal.BoundingType>)0x0053CFC0)(ref this, curr_sphere);

    /// <summary>Determines whether a point lies within a solid region defined by the BSP node hierarchy, recursively traversing child nodes based on the point's side of each node's splitting plane.
    /// <code>Offset: 0x0053D070
    /// int __thiscall BSPNODE::point_intersects_solid(BSPNODE*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="point">The world-space position to test for solidity.</param>
    /// <returns>Non-zero if the point intersects solid geometry; zero otherwise.</returns>
    public int point_intersects_solid(ACBindings.Internal.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053D070)(ref this, point);

    /// <summary>Initializes a BSP node with default values, setting its virtual function table, type identifier, and clearing polygon count and child references.
    /// <code>Offset: 0x0053D110
    /// void __thiscall BSPNODE::BSPNODE(BSPNODE*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, void>)0x0053D110)(ref this);

    /// <summary>Destroys a BSPNODE instance by deallocating its child nodes and polygon array, resetting the virtual table pointer, clearing internal state, and marking the node as inactive.
    /// <code>Offset: 0x0053D130
    /// void __thiscall BSPNODE::~BSPNODE(BSPNODE*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, void>)0x0053D130)(ref this);

    /// <summary>Computes the total byte count required to serialize this BSP node and its descendants, accounting for child nodes and polygon data. The calculation varies by the current packing mode (DRAWING_BSP or PHYSICS_BSP).
    /// <code>Offset: 0x0053D180
    /// unsigned int __thiscall BSPNODE::pack_size(BSPNODE*)</code>
    /// </summary>
    /// <returns>The number of bytes needed to pack the node subtree.</returns>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, uint>)0x0053D180)(ref this);

    /// <summary>Packs a BSP tree node’s spatial information into a contiguous memory buffer, writing its splitting plane, optional child nodes, bounding sphere or geometry data, polygon count, and associated polygon IDs. If the supplied buffer is too small, it reports the required size without modifying the buffer.
    /// <code>Offset: 0x0053D1F0
    /// unsigned int __thiscall BSPNODE::Pack(BSPNODE*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current write position in the buffer; on success, updated to point past the last byte written.</param>
    /// <param name="size">Number of bytes available starting at *addr.</param>
    /// <returns>The total number of bytes needed to serialize this node. When enough space is provided, the function writes the data into the buffer and updates *addr accordingly.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, void**, uint, uint>)0x0053D1F0)(ref this, addr, size);

    /// <summary>
    /// Deserializes a BSPNODE from binary data pointed to by addr, updating the node's fields (splitting plane, children, sphere, polygons) and advancing addr as bytes are consumed.
    /// 
    /// <code>Offset: 0x0053D2A0
    /// int __thiscall BSPNODE::UnPack(BSPNODE*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the current read position in the buffer; updated to point after the processed data.</param>
    /// <param name="size">Number of bytes remaining in the input buffer; used to determine if sufficient data is available for the splitting plane.</param>
    /// <returns>Non‑zero on successful unpacking, zero if a child node fails to unpackage.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, void**, uint, int>)0x0053D2A0)(ref this, addr, size);

    /// <summary>Calculates the packed size of a child node by delegating to the appropriate packer based on the node type.
    /// <code>Offset: 0x0053D410
    /// unsigned int __cdecl BSPNODE::pack_child_size(BSPNODE*)</code>
    /// </summary>
    /// <param name="node">The child node whose packed size should be computed.</param>
    /// <returns>The total number of bytes required to pack the child node, including the 4‑byte header added by the specific packer.</returns>
    public static uint pack_child_size(ACBindings.Internal.BSPNODE* node) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.BSPNODE*, uint>)0x0053D410)(node);

    /// <summary>Serializes a child BSP node into a buffer when sufficient space is available and returns the required byte count.
    /// <code>Offset: 0x0053D460
    /// unsigned int __cdecl BSPNODE::PackChild(BSPNODE*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="node">The child BSP node to pack.</param>
    /// <param name="addr">Pointer to the destination memory location; updated to point past written data.</param>
    /// <param name="size">Number of bytes remaining in the buffer.</param>
    /// <returns>Byte size necessary for packing the node regardless of whether it was serialized.</returns>
    public static uint PackChild(ACBindings.Internal.BSPNODE* node, void** addr, uint size) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.BSPNODE*, void**, uint, uint>)0x0053D460)(node, addr, size);

    /// <summary>Unpacks a child node from serialized data, allocating the appropriate type (portal, leaf, or internal node) based on an identifier at the current buffer position.
    /// <code>Offset: 0x0053D4D0
    /// int __cdecl BSPNODE::UnPackChild(BSPNODE**,void**,unsigned int)</code>
    /// </summary>
    /// <param name="node">Receives a pointer to the newly constructed child node.</param>
    /// <param name="addr">Points to the current read location in the input buffer; advanced past the node header during unpacking.</param>
    /// <param name="size">Total size of the remaining data, passed through to sub‑unpack functions.</param>
    /// <returns>Zero on success or a non‑zero error code from the specific unpack routine.</returns>
    public static int UnPackChild(ACBindings.Internal.BSPNODE** node, void** addr, uint size) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.BSPNODE**, void**, uint, int>)0x0053D4D0)(node, addr, size);

    /// <summary>Links portal nodes in reverse order using the auxiliary array supplied via a2.
    /// <code>Offset: 0x0053D5B0
    /// int __thiscall BSPNODE::LinkPortalNodeChain(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="this">Starting BSPNODE that receives links to the next node.</param>
    /// <param name="a2">Array containing: element 0 – pointer to an array of portal node pointers, element 2 – count of those pointers.</param>
    /// <returns>-1 after completing the linkage (loop counter value).</returns>
    public int LinkPortalNodeChain(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, int*, int>)0x0053D5B0)(ref this, a2);

    /// <summary>Determines whether an axis-aligned bounding box overlaps the spatial region defined by this BSP node and its descendants.
    /// <code>Offset: 0x0053D5E0
    /// int __thiscall BSPNODE::box_intersects_cell_bsp(BSPNODE*,const BBox*)</code>
    /// </summary>
    /// <param name="box">The bounding box to test against the cell represented by the node.</param>
    /// <returns>Nonzero (1) if the box intersects or lies within the cell; zero if it falls entirely on the negative side of all splitting planes encountered during traversal.</returns>
    public int box_intersects_cell_bsp(ACBindings.Internal.BBox* box) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.BBox*, int>)0x0053D5E0)(ref this, box);

    /// <summary>Determines whether a sphere intersects any polygon in this node or its descendants. Uses the node’s bounding sphere for early rejection, then traverses child nodes based on the splitting plane.
    /// <code>Offset: 0x0053D790
    /// int __thiscall BSPNODE::sphere_intersects_poly(BSPNODE*,const CSphere*,const AC1Legacy::Vector3*,const CPolygon**,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="check_pos">Sphere to test against the BSP tree.</param>
    /// <param name="movement">Movement vector of the sphere; forwarded to recursive checks but not directly used here.</param>
    /// <param name="polygon">Pointer to receive a reference to an intersecting polygon if one is found.</param>
    /// <param name="contact_pt">Pointer to receive the contact point between the sphere and the intersecting polygon, potentially set by child nodes.</param>
    /// <returns>Non‑zero if an intersection is detected; zero otherwise.</returns>
    public int sphere_intersects_poly(ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* movement, ACBindings.Internal.CPolygon** polygon, ACBindings.Internal.AC1Legacy.Vector3* contact_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053D790)(ref this, check_pos, movement, polygon, contact_pt);

    /// <summary>Determines whether a given sphere intersects any solid geometry represented by the BSP tree rooted at this node.
    /// <code>Offset: 0x0053D850
    /// int __thiscall BSPNODE::sphere_intersects_solid(BSPNODE*,const CSphere*,int)</code>
    /// </summary>
    /// <param name="check_pos">The sphere to test against the scene geometry.</param>
    /// <param name="center_check">Specifies whether an additional intersection check should be performed on the side opposite the plane when the sphere straddles a node's splitting plane (non‑zero means include both sides; zero omits one).</param>
    /// <returns>Non‑zero if the sphere intersects solid geometry; zero otherwise.</returns>
    public int sphere_intersects_solid(ACBindings.Internal.CSphere* check_pos, int center_check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.CSphere*, int, int>)0x0053D850)(ref this, check_pos, center_check);

    /// <summary>
    /// Recursively evaluates whether a sphere position lies within walkable space by testing intersections with BSP node spheres and traversing child nodes based on the splitting plane.
    /// 
    /// <code>Offset: 0x0053D930
    /// int __thiscall BSPNODE::hits_walkable(BSPNODE*,SPHEREPATH*,CSphere*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="path">SPHEREPATH structure carrying traversal context for the walk.</param>
    /// <param name="valid_pos">CSphere representing the candidate position to test for walkability.</param>
    /// <param name="up">Vector indicating upward direction; retained for caller compatibility but not used directly in this method.</param>
    /// <returns>Non‑zero if the sphere is considered walkable, zero otherwise.</returns>
    public int hits_walkable(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.CSphere* valid_pos, ACBindings.Internal.AC1Legacy.Vector3* up) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053D930)(ref this, path, valid_pos, up);

    /// <summary>Recursively traverses the BSP tree, visiting child nodes whose spheres intersect a supplied sphere and using each node’s splitting plane to decide which side(s) to explore.
    /// <code>Offset: 0x0053D9E0
    /// void __thiscall BSPNODE::find_walkable(BSPNODE*,SPHEREPATH*,CSphere*,const CPolygon**,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,int*)</code>
    /// </summary>
    /// <param name="path">Structure holding traversal state; forwarded unchanged to child nodes.</param>
    /// <param name="valid_pos">Sphere representing the current position of an object, used for intersection tests with node spheres.</param>
    /// <param name="polygon">Pointer intended to receive a walkable polygon; this function does not modify it directly.</param>
    /// <param name="movement">Vector indicating desired movement direction; forwarded unchanged to child nodes.</param>
    /// <param name="up">Upward orientation vector; forwarded unchanged to child nodes.</param>
    /// <param name="changed">Integer flag that may indicate a change in walkable region; this function does not modify it directly.</param>
    public void find_walkable(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.CSphere* valid_pos, ACBindings.Internal.CPolygon** polygon, ACBindings.Internal.AC1Legacy.Vector3* movement, ACBindings.Internal.AC1Legacy.Vector3* up, int* changed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, int*, void>)0x0053D9E0)(ref this, path, valid_pos, polygon, movement, up, changed);

    /// <summary>Checks whether a given sphere intersects polygons in the BSP subtree rooted at this node and propagates whether the sphere’s center lies inside solid space.
    /// <code>Offset: 0x0053DAB0
    /// int __thiscall BSPNODE::sphere_intersects_solid_poly(BSPNODE*,const CSphere*,float,int*,const CPolygon**,int)</code>
    /// </summary>
    /// <param name="check_pos">Sphere to test for intersection against the geometry of this node's subtree.</param>
    /// <param name="radius">Tolerance used when determining which child nodes to traverse relative to the splitting plane.</param>
    /// <param name="center_solid">Pointer to a flag that will contain whether the sphere’s center is in solid space after traversal; its value is propagated from recursive calls but not modified here.</param>
    /// <param name="hit_poly">Pointer to receive the first polygon intersected by the sphere, if any; remains unchanged if no intersection occurs.</param>
    /// <param name="center_check">Flag forwarded to child nodes that indicates whether both sides of the splitting plane should be examined when the sphere straddles it.</param>
    /// <returns>Zero if the sphere does not intersect this node’s bounding sphere; otherwise returns the value pointed to by center_solid after examining the relevant child subspaces.</returns>
    public int sphere_intersects_solid_poly(ACBindings.Internal.CSphere* check_pos, float radius, int* center_solid, ACBindings.Internal.CPolygon** hit_poly, int center_check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.CSphere*, float, int*, ACBindings.Internal.CPolygon**, int, int>)0x0053DAB0)(ref this, check_pos, radius, center_solid, hit_poly, center_check);

    /// <summary>
    /// Traverses the BSP node hierarchy to locate the first intersection of a ray with scene geometry.
    /// 
    /// <code>Offset: 0x0053DBB0
    /// unsigned int __thiscall BSPNODE::TraceRay(BSPNODE*,const Ray*,float*,Vector3*)</code>
    /// </summary>
    /// <param name="Ray">The ray to test for intersections.</param>
    /// <param name="fDelta">Receives the normalized distance along the ray to the hit point; set to 1.0 if no hit occurs.</param>
    /// <param name="vImpactNormal">Receives the surface normal at the intersection when a hit is found.</param>
    /// <returns>Non‑zero (typically 1) if an intersection was detected, zero otherwise.</returns>
    public uint TraceRay(ACBindings.Internal.Ray* Ray, float* fDelta, ACBindings.Internal.Vector3* vImpactNormal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.Ray*, float*, ACBindings.Internal.Vector3*, uint>)0x0053DBB0)(ref this, Ray, fDelta, vImpactNormal);

    /// <summary>Detaches portals from the node’s child BSP nodes, collects any UIElement_Button objects into the supplied array, and clears the child references.
    /// <code>Offset: 0x0053E0A0
    /// char __thiscall BSPNODE::DetachPortalsAndPurgeNodes(_DWORD*,_DWORD*)</code>
    /// </summary>
    /// <param name="a2">Pointer to an array that will receive UIElement_Button pointers found during traversal.</param>
    /// <returns>True if all detach operations completed successfully; otherwise false.</returns>
    public sbyte DetachPortalsAndPurgeNodes(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, int*, sbyte>)0x0053E0A0)(ref this, a2);
}

