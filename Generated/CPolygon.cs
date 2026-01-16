namespace ACBindings.Internal;


/// <summary>Represents a polygonal shape, maintaining vertex references, screen coordinates, and surface attributes for rendering and interaction within the graphics engine.</summary>
public unsafe struct CPolygon
{
    // Statics
    public static ACBindings.Internal.CVertexArray** pack_verts = (ACBindings.Internal.CVertexArray**)0x0084610C;

    // Members
    public ACBindings.Internal.CVertex** vertices;
    public ushort* vertex_ids;
    public ACBindings.Internal.Vec2Dscreen** screen;
    public short poly_id;
    public byte num_pts;
    public sbyte stippling;
    public int sides_type;
    public sbyte* pos_uv_indices;
    public sbyte* neg_uv_indices;
    public ushort pos_surface;
    public ushort neg_surface;
    public ACBindings.Internal.Plane plane;

    // Generated Constructor
    public CPolygon() {
        _ConstructorInternal();
    }

    // Methods

    /// <summary>Tests whether the point’s 2‑D projection lies within the polygon according to a specified sidedness.
    /// <code>Offset: 0x00538DA0
    /// int __thiscall CPolygon::point_in_poly2D(CPolygon*,const AC1Legacy::Vector3*,Sidedness)</code>
    /// </summary>
    /// <param name="this">The CPolygon instance whose vertices define the polygon.</param>
    /// <param name="point">A Vector3 whose x and y components are used for the containment test; the z component is ignored.</param>
    /// <param name="side">Specifies which side of each directed edge is considered interior. When true, points on or to the left of every edge satisfy the test; when false, points on or to the right of every edge satisfy it.</param>
    /// <returns>1 if the point satisfies the sidedness condition for all edges (inside); otherwise 0.</returns>
    public int point_in_poly2D(ACBindings.Internal.AC1Legacy.Vector3* point, ACBindings.Internal.Sidedness side) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Sidedness, int>)0x00538DA0)(ref this, point, side);

    /// <summary>Releases memory allocated for the polygon’s vertex, UV index, and screen buffers and resets all related fields to default values.
    /// <code>Offset: 0x00538E20
    /// void __thiscall CPolygon::Destroy(CPolygon*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, void>)0x00538E20)(ref this);

    /// <summary>Computes the fraction of a movement step at which a sphere first contacts the plane defined by this polygon, or signals immediate overlap.
    /// <code>Offset: 0x00538EB0
    /// long double __thiscall CPolygon::adjust_sphere_to_poly(CPolygon*,CSphere*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="check_pos">Sphere whose center and radius determine the collision test against the polygon’s plane.</param>
    /// <param name="curr_pos">Current world position of the sphere’s center.</param>
    /// <param name="movement">Vector describing the sphere’s displacement during this step.</param>
    /// <returns>0 if movement has no component perpendicular to the plane, 1 if the sphere already overlaps the plane, otherwise a value between 0 and 1 indicating the proportion along the movement vector where collision occurs.</returns>
    public double adjust_sphere_to_poly(ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* curr_pos, ACBindings.Internal.AC1Legacy.Vector3* movement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, double>)0x00538EB0)(ref this, check_pos, curr_pos, movement);

    /// <summary>Adjusts a sphere’s position so that it does not penetrate the polygon’s plane during movement, updating interpolation state accordingly.
    /// <code>Offset: 0x00538F50
    /// int __thiscall CPolygon::adjust_sphere_to_plane(CPolygon*,SPHEREPATH*,CSphere*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="this">The polygon whose plane is used for collision detection.</param>
    /// <param name="path">Path data containing walk interpolation and other movement context.</param>
    /// <param name="valid_pos">Sphere to be adjusted; its center and radius are modified if needed.</param>
    /// <param name="movement">Direction vector of attempted movement.</param>
    /// <returns>1 if the sphere was successfully moved away from the plane, 0 otherwise (e.g., no adjustment required or movement too small).</returns>
    public int adjust_sphere_to_plane(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.CSphere* valid_pos, ACBindings.Internal.AC1Legacy.Vector3* movement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00538F50)(ref this, path, valid_pos, movement);

    /// <summary>Initializes a new polygon instance, setting all member pointers to null and numeric fields to default or sentinel values.
    /// <code>Offset: 0x005390E0
    /// void __thiscall CPolygon::CPolygon(CPolygon*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, void>)0x005390E0)(ref this);

    /// <summary>Computes the plane that best represents a polygon’s vertices by averaging cross products of consecutive edges to obtain a normalized normal vector, then sets the plane constant to the negative mean dot product of all vertex positions with this normal.
    /// <code>Offset: 0x00539110
    /// void __thiscall CPolygon::make_plane(CPolygon*)</code>
    /// </summary>
    public void make_plane() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, void>)0x00539110)(ref this);

    /// <summary>Packs the polygon's data into a contiguous buffer, advancing the supplied pointer as it writes, and reports the total byte count required.
    /// <code>Offset: 0x00539270
    /// unsigned int __thiscall CPolygon::Pack(CPolygon*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Pointer to a buffer location; upon entry points to memory where serialized data will start. The function advances this pointer as data is written.</param>
    /// <param name="size">Size in bytes of the destination buffer that *addr currently points to. If size is insufficient, packing is skipped but the required size is still returned.</param>
    /// <returns>The number of bytes necessary to serialize the polygon, including headers and per‑vertex information.</returns>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, void**, uint, uint>)0x00539270)(ref this, addr, size);

    /// <summary>Deserializes a polygon from raw data into this object, allocating vertex and surface arrays accordingly.
    /// <code>Offset: 0x00539390
    /// int __thiscall CPolygon::UnPack(CPolygon*,void**,unsigned int)</code>
    /// </summary>
    /// <param name="addr">Reference to the current position in the input buffer; advanced past the parsed data.</param>
    /// <param name="size">Total size of the input buffer (unused directly by the function).</param>
    /// <returns>Always 1 indicating successful unpacking.</returns>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, void**, uint, int>)0x00539390)(ref this, addr, size);

    /// <summary>Tests whether a given sphere intersects this polygon and writes the point on the polygon’s plane closest to the sphere’s center into contact_pt.
    /// <code>Offset: 0x00539500
    /// int __thiscall CPolygon::polygon_hits_sphere(CPolygon*,const CSphere*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="object">The sphere to test for intersection with the polygon.</param>
    /// <param name="contact_pt">Receives the projected center of the sphere onto the polygon’s plane; written regardless of whether an intersection is later confirmed.</param>
    /// <returns>Non-zero if the sphere intersects the polygon; zero otherwise.</returns>
    public int polygon_hits_sphere(ACBindings.Internal.CSphere* object_, ACBindings.Internal.AC1Legacy.Vector3* contact_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00539500)(ref this, object_, contact_pt);

    /// <summary>Detects whether a sphere intersects the polygon and outputs the sphere center projected onto the polygon’s plane as a contact point.
    /// <code>Offset: 0x00539750
    /// int __thiscall CPolygon::polygon_hits_sphere_slow_but_sure(CPolygon*,const CSphere*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="object">The sphere to test against this polygon.</param>
    /// <param name="contact_pt">Receives the projection of the sphere center onto the polygon’s plane; may not represent the true closest point if the collision occurs at an edge or vertex.</param>
    /// <returns>Non-zero if the sphere collides with the polygon, zero otherwise.</returns>
    public int polygon_hits_sphere_slow_but_sure(ACBindings.Internal.CSphere* object_, ACBindings.Internal.AC1Legacy.Vector3* contact_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00539750)(ref this, object_, contact_pt);

    /// <summary>Moves two spheres along a polygon’s plane normal so that they lie outside or on the surface, using the supplied radius and solidity flags to determine the direction of translation.
    /// <code>Offset: 0x00539A20
    /// void __thiscall CPolygon::adjust_to_placement_poly(CPolygon*,CSphere*,CSphere*,float,int,int)</code>
    /// </summary>
    /// <param name="struck_sphere">The first sphere whose center is translated.</param>
    /// <param name="other_sphere">The second sphere translated by the same amount.</param>
    /// <param name="radius">Reference distance used for calculating the adjustment offset.</param>
    /// <param name="center_solid">Flag that inverts the direction when solidity is considered.</param>
    /// <param name="solid_check">Determines whether solid-check logic is applied to compute the offset.</param>
    public void adjust_to_placement_poly(ACBindings.Internal.CSphere* struck_sphere, ACBindings.Internal.CSphere* other_sphere, float radius, int center_solid, int solid_check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, ACBindings.Internal.CSphere*, float, int, int, void>)0x00539A20)(ref this, struck_sphere, other_sphere, radius, center_solid, solid_check);

    /// <summary>Determines whether a given point lies within the planar area of this polygon by testing its position relative to each edge.
    /// <code>Offset: 0x00539AD0
    /// int __thiscall CPolygon::point_in_polygon(CPolygon*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="point">The 3D point to evaluate against the polygon.</param>
    /// <returns>Non-zero if the point is inside (or on) the polygon; zero otherwise.</returns>
    public int point_in_polygon(ACBindings.Internal.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00539AD0)(ref this, point);

    /// <summary>Determines whether a sphere can stand on the polygon surface when projected along a specified upward direction, returning non‑zero if the sphere is supported by or touches the polygon.
    /// <code>Offset: 0x00539BA0
    /// int __thiscall CPolygon::check_walkable(CPolygon*,CSphere*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="sphere">The sphere whose position and radius are tested against the polygon.</param>
    /// <param name="up">Upward direction vector used to project the sphere onto the polygon plane.</param>
    /// <returns>Non‑zero (1) if the sphere can walk on the polygon; zero (0) otherwise.</returns>
    public int check_walkable(ACBindings.Internal.CSphere* sphere, ACBindings.Internal.AC1Legacy.Vector3* up) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00539BA0)(ref this, sphere, up);

    /// <summary>Checks whether the polygon is walkable from a sphere projected along an up vector.
    /// <code>Offset: 0x00539DF0
    /// int __thiscall CPolygon::check_small_walkable(CPolygon*,CSphere*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="sphere">Sphere used for projection, defined by its center and radius.</param>
    /// <param name="up">Upward direction vector guiding the projection onto the plane.</param>
    /// <returns>Non‑zero if the projected point lies within a small walkable zone; zero otherwise.</returns>
    public int check_small_walkable(ACBindings.Internal.CSphere* sphere, ACBindings.Internal.AC1Legacy.Vector3* up) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00539DF0)(ref this, sphere, up);

    /// <summary>Computes a unit vector perpendicular to an edge of the polygon and to its plane normal using the provided up direction.
    /// <code>Offset: 0x0053A040
    /// int __thiscall CPolygon::find_crossed_edge(CPolygon*,CSphere*,const AC1Legacy::Vector3*,AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="sphere">Ignored; present only for API compatibility.</param>
    /// <param name="up">Direction used to verify that it is not nearly orthogonal to the polygon’s plane normal before processing edges.</param>
    /// <param name="normal">Output vector that receives the normalized cross product of an edge and the plane normal.</param>
    /// <returns>Returns 1 if a suitable edge was found and the normal calculated; otherwise returns 0.</returns>
    public int find_crossed_edge(ACBindings.Internal.CSphere* sphere, ACBindings.Internal.AC1Legacy.Vector3* up, ACBindings.Internal.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053A040)(ref this, sphere, up, normal);

    /// <summary>Determines whether the polygon intersects a sphere moving along a given direction, computing the contact point and the struck polygon when appropriate.
    /// <code>Offset: 0x0053A230
    /// int __thiscall CPolygon::pos_hits_sphere(CPolygon*,const CSphere*,const AC1Legacy::Vector3*,AC1Legacy::Vector3*,const CPolygon**)</code>
    /// </summary>
    /// <param name="object">Sphere to test against the polygon.</param>
    /// <param name="movement">Direction vector of the sphere’s motion.</param>
    /// <param name="contact_pt">Output parameter receiving the point of intersection on the polygon if a hit occurs.</param>
    /// <param name="struck_poly">Output parameter receiving the polygon that was struck by the sphere.</param>
    /// <returns>Non‑zero value when an intersection is detected with the sphere moving toward the interior of the polygon; zero otherwise.</returns>
    public int pos_hits_sphere(ACBindings.Internal.CSphere* object_, ACBindings.Internal.AC1Legacy.Vector3* movement, ACBindings.Internal.AC1Legacy.Vector3* contact_pt, ACBindings.Internal.CPolygon** struck_poly) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CPolygon**, int>)0x0053A230)(ref this, object_, movement, contact_pt, struck_poly);

    /// <summary>Checks whether this polygon intersects the specified sphere and reports a collision result.
    /// <code>Offset: 0x0053A280
    /// int __thiscall CPolygon::hits_sphere(CPolygon*,const CSphere*)</code>
    /// </summary>
    /// <param name="object">The sphere to test against this polygon.</param>
    /// <returns>Non‑zero if the polygon collides with the sphere; zero otherwise.</returns>
    public int hits_sphere(ACBindings.Internal.CSphere* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, int>)0x0053A280)(ref this, object_);

    /// <summary>Determines whether a given sphere can walk onto or hit this polygon by comparing the polygon normal against a walkability allowance and performing a collision test.
    /// <code>Offset: 0x0053A2A0
    /// int __thiscall CPolygon::walkable_hits_sphere(CPolygon*,SPHEREPATH*,const CSphere*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    /// <param name="path">Path information containing the walkable allowance threshold used to evaluate the angle between the polygon plane and the up vector.</param>
    /// <param name="object">Sphere whose intersection with the polygon is tested.</param>
    /// <param name="up">Upward direction vector used for assessing walkability against the polygon normal.</param>
    /// <returns>Zero if the sphere cannot be considered walkable on this polygon; otherwise a non‑zero value indicating a hit, as returned by the collision routine.</returns>
    public int walkable_hits_sphere(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.CSphere* object_, ACBindings.Internal.AC1Legacy.Vector3* up) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053A2A0)(ref this, path, object_, up);

    /// <summary>Determines whether a ray intersects this polygon and returns the result.
    /// <code>Offset: 0x0053A320
    /// int __thiscall CPolygon::polygon_hits_ray(CPolygon*,const Ray*,long double*)</code>
    /// </summary>
    /// <param name="line">The ray to test against the polygon.</param>
    /// <param name="time">If an intersection occurs, receives the distance along the ray where it hits.</param>
    /// <returns>Non‑zero if the ray strikes the polygon; zero otherwise.</returns>
    public int polygon_hits_ray(ACBindings.Internal.Ray* line, double* time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.Ray*, double*, int>)0x0053A320)(ref this, line, time);
}

