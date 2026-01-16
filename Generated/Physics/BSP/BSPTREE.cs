namespace ACBindings.Internal;


/// <summary>Top-level container for a binary space partitioning tree, holding reference to its root node.</summary>
public unsafe struct BSPTREE : System.IDisposable
{
    // Members
    public ACBindings.Internal.BSPNODE* root_node;

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>Retrieves the bounding sphere defined by the BSP tree's root node.
    /// <code>Offset: 0x0053A540
    /// const CSphere* __thiscall BSPTREE::GetSphere(BSPTREE*)</code>
    /// </summary>
    /// <returns>A pointer to the constant CSphere representing the root node's sphere.</returns>
    public ACBindings.Internal.CSphere* GetSphere() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.CSphere*>)0x0053A540)(ref this);

    /// <summary>Computes the packed representation of a BSP tree and optionally writes it into a provided buffer when sufficient space is available.
    /// <code>Offset: 0x0053A550
    /// unsigned int __thiscall BSPTREE::Pack(BSPTREE*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the destination buffer where packed data will be stored if the requested size permits.</param>
    /// <param name="size">Size, in bytes, of the destination buffer. If this value is smaller than the required size, no packing occurs and the function returns the needed size.</param>
    /// <returns>The number of bytes that would be written to or actually written into the buffer; if the supplied buffer is too small, it indicates the required size for complete packing.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, void**, uint, uint>)0x0053A550)(ref this, addr, size);

    /// <summary>Reconstructs a BSP tree from a serialized buffer, replacing any existing root node.
    /// <code>Offset: 0x0053A590
    /// int __thiscall BSPTREE::UnPack(BSPTREE*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to the memory location of the serialized tree data; may be updated during unpacking.</param>
    /// <param name="size">Number of bytes in the serialized data buffer.</param>
    /// <returns>Result code produced by BSPNODE::UnPackChild, indicating success or failure of the operation.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, void**, uint, int>)0x0053A590)(ref this, addr, size);

    /// <summary>Builds and renders only the portal geometry of a BSP tree, optionally selecting between polygon and content mode.
    /// <code>Offset: 0x0053A5C0
    /// void __thiscall BSPTREE::build_draw_portals_only(BSPTREE*,int)</code>
    /// </summary>
    /// <param name="portalPolyOrPortalContents">Specifies whether to draw portal polygons (e.g., 0) or portal contents (e.g., 1).</param>
    public void build_draw_portals_only(int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, int, void>)0x0053A5C0)(ref this, portalPolyOrPortalContents);

    /// <summary>Destroys the BSP tree by deallocating its root node, if present, and clearing the internal root pointer.
    /// <code>Offset: 0x0053A6A0
    /// void __thiscall BSPTREE::~BSPTREE(BSPTREE*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, void>)0x0053A6A0)(ref this);

    /// <summary>Attempts to place an object defined by its sphere path into the BSP tree, adjusting its position to avoid solid polygon collisions.
    /// <code>Offset: 0x0053A6C0
    /// TransitionState __thiscall BSPTREE::placement_insert(BSPTREE*,CTransition*)</code>
    /// </summary>
    /// <param name="transition">The transition data containing the object's sphere path and related information.</param>
    /// <returns>The TransitionState that indicates the result of the placement attempt (e.g., success, adjustment required, or failure).</returns>
    public ACBindings.Internal.TransitionState placement_insert(ACBindings.Internal.CTransition* transition) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.CTransition*, ACBindings.Internal.TransitionState>)0x0053A6C0)(ref this, transition);

    /// <summary>Adjusts the center of a sphere so it no longer intersects a specified polygon surface by iteratively moving along its current displacement vector and resolving collisions against the BSP tree.
    /// <code>Offset: 0x0053A950
    /// int __thiscall BSPTREE::adjust_to_plane(BSPTREE*,CSphere*,const AC1Legacy::Vector3,const CPolygon*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="check_pos">Sphere whose center will be moved to avoid intersection.</param>
    /// <param name="curr_pos">Original position of the sphere before adjustment.</param>
    /// <param name="hit_poly">Polygon that caused the initial intersection.</param>
    /// <param name="contact_pt">Output point where the adjusted sphere contacts the polygon plane.</param>
    /// <returns>Returns 1 when the sphere is successfully positioned outside the polygon; returns 0 if the adjustment fails after a maximum number of iterations.</returns>
    public int adjust_to_plane(ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3 curr_pos, ACBindings.Internal.CPolygon* hit_poly, ACBindings.Internal.AC1Legacy.Vector3* contact_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3, ACBindings.Internal.CPolygon*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053A950)(ref this, check_pos, curr_pos, hit_poly, contact_pt);

    /// <summary>Slides a sphere along its current trajectory by converting the supplied local‑space collision normal into world space and delegating to CSphere::slide_sphere.
    /// <code>Offset: 0x0053ABB0
    /// TransitionState __thiscall BSPTREE::slide_sphere(BSPTREE*,SPHEREPATH*,COLLISIONINFO*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="path">Contains sphere data, current position, and path information used during sliding.</param>
    /// <param name="collisions">Stores collision state before and after the slide; updated by the operation.</param>
    /// <param name="collision_normal">Local‑space normal that determines the sliding direction once transformed to world coordinates.</param>
    /// <returns>TransitionState indicating whether the slide succeeded, hit a surface, or encountered an error.</returns>
    public ACBindings.Internal.TransitionState slide_sphere(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.AC1Legacy.Vector3* collision_normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.TransitionState>)0x0053ABB0)(ref this, path, collisions, collision_normal);

    /// <summary>Evaluates whether the sphere at <paramref name="check_pos"/> is positioned on walkable terrain in the BSP tree, updating the path’s localspace_z with the collision normal.
    /// <code>Offset: 0x0053AC30
    /// TransitionState __thiscall BSPTREE::check_walkable(BSPTREE*,SPHEREPATH*,const CSphere*,float)</code>
    /// </summary>
    /// <param name="path">The SPHEREPATH structure that receives updated traversal data such as the collision normal via its localspace_z field.</param>
    /// <param name="check_pos">Sphere defining the position and radius to test for walkability.</param>
    /// <param name="scale">Scaling factor intended for the sphere’s radius; currently unused in this implementation.</param>
    /// <returns>A TransitionState value reflecting whether the tested sphere is walkable (e.g., 1 for walkable, 2 for not walkable).</returns>
    public ACBindings.Internal.TransitionState check_walkable(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.CSphere* check_pos, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, float, ACBindings.Internal.TransitionState>)0x0053AC30)(ref this, path, check_pos, scale);

    /// <summary>Attempts to move a sphere upward along a collision normal transformed into local space; if direct step fails, performs slide adjustment instead.
    /// <code>Offset: 0x0053AC80
    /// TransitionState __thiscall BSPTREE::step_sphere_up(BSPTREE*,CTransition*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="transition">Context containing sphere path, object info and collision data used during the transition.</param>
    /// <param name="collision_normal">Normal vector at the collision point in world coordinates.</param>
    /// <returns>TransitionState indicating whether the upward step succeeded (1) or a sliding motion was performed.</returns>
    public ACBindings.Internal.TransitionState step_sphere_up(ACBindings.Internal.CTransition* transition, ACBindings.Internal.AC1Legacy.Vector3* collision_normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.CTransition*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.TransitionState>)0x0053AC80)(ref this, transition, collision_normal);

    /// <summary>Removes all non‑portal nodes from the BSP tree by detaching portals, purging obsolete nodes, and rebuilding the portal node chain.  If temporary memory was allocated during the process it is freed afterward.
    /// <code>Offset: 0x0053ADA0
    /// void __thiscall BSPTREE::RemoveNonPortalNodes(BSPTREE*)</code>
    /// </summary>
    public void RemoveNonPortalNodes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, void>)0x0053ADA0)(ref this);

    /// <summary>
    /// Collides a point represented by a sphere against a polygon within the BSP tree, updating collision data and optionally adjusting the sphere’s position based on the object’s state.
    /// 
    /// <code>Offset: 0x0053ADF0
    /// TransitionState __thiscall BSPTREE::collide_with_pt(BSPTREE*,OBJECTINFO*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,const AC1Legacy::Vector3*,const CPolygon*,AC1Legacy::Vector3*,float)</code>
    /// </summary>
    /// <param name="object">Information about the physics object involved in the collision.</param>
    /// <param name="path">Current path information for the sphere being tested.</param>
    /// <param name="collisions">Structure to receive updated collision normal and other data.</param>
    /// <param name="check_pos">Sphere used as the point of contact for collision detection.</param>
    /// <param name="curr_pos">Current position vector of the object in local space.</param>
    /// <param name="hit_poly">Polygon that was intersected by the sphere.</param>
    /// <param name="contact_pt">Output point on the polygon where contact occurs.</param>
    /// <param name="scale">Factor applied to the collision normal when adjusting the sphere’s position.</param>
    /// <returns>TransitionState indicating the result of the collision check (typically 2 for a basic detection or 3 when the sphere has been adjusted).</returns>
    public ACBindings.Internal.TransitionState collide_with_pt(ACBindings.Internal.OBJECTINFO* object_, ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* curr_pos, ACBindings.Internal.CPolygon* hit_poly, ACBindings.Internal.AC1Legacy.Vector3* contact_pt, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.OBJECTINFO*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CPolygon*, ACBindings.Internal.AC1Legacy.Vector3*, float, ACBindings.Internal.TransitionState>)0x0053ADF0)(ref this, object_, path, collisions, check_pos, curr_pos, hit_poly, contact_pt, scale);

    /// <summary>Steps a sphere downward through the BSP tree until it reaches a walkable surface, updating its position and collision data.
    /// <code>Offset: 0x0053AF70
    /// TransitionState __thiscall BSPTREE::step_sphere_down(BSPTREE*,SPHEREPATH*,COLLISIONINFO*,const CSphere*,float)</code>
    /// </summary>
    /// <param name="path">State container holding traversal information and current cell data.</param>
    /// <param name="collisions">Structure to receive the resulting contact plane and related information.</param>
    /// <param name="check_pos">Sphere defining the initial position and radius for the downward search.</param>
    /// <param name="scale">Scale factor applied when converting local normals to world coordinates.</param>
    /// <returns>TransitionState value: 1 if no walkable surface was found; 3 on successful step with collision data set.</returns>
    public ACBindings.Internal.TransitionState step_sphere_down(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.COLLISIONINFO* collisions, ACBindings.Internal.CSphere* check_pos, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.COLLISIONINFO*, ACBindings.Internal.CSphere*, float, ACBindings.Internal.TransitionState>)0x0053AF70)(ref this, path, collisions, check_pos, scale);

    /// <summary>Determines how a sphere described by the supplied CTransition interacts with the BSP tree geometry, handling obstructions, walkable surfaces, stepping and sliding logic, then returns a TransitionState code indicating the collision outcome.
    /// <code>Offset: 0x0053B1A0
    /// TransitionState __thiscall BSPTREE::find_collisions(BSPTREE*,CTransition*,float)</code>
    /// </summary>
    /// <param name="transition">The transition data containing the sphere path, object information, and collision buffers used during the test.</param>
    /// <param name="scale">A scaling factor applied to positional offsets when resolving collisions.</param>
    /// <returns>A TransitionState value: 1 for no special collision, 2 for an obstruction or solid hit, 3 for a walkable surface adjustment; other codes represent stepping up/down or sliding responses.</returns>
    public ACBindings.Internal.TransitionState find_collisions(ACBindings.Internal.CTransition* transition, float scale) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPTREE, ACBindings.Internal.CTransition*, float, ACBindings.Internal.TransitionState>)0x0053B1A0)(ref this, transition, scale);
}

