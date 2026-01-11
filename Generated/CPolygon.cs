namespace ACBindings.Internal;

public unsafe struct CPolygon
{
    // Statics
    public static ACBindings.Internal.CVertexArray* pack_verts = (ACBindings.Internal.CVertexArray*)0x0084610C;

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

    /// <summary>
    /// <code>Offset: 0x00538DA0
    /// int __thiscall CPolygon::point_in_poly2D(CPolygon*,const AC1Legacy::Vector3*,Sidedness)</code>
    /// </summary>
    public int point_in_poly2D(ACBindings.Internal.AC1Legacy.Vector3* point, ACBindings.Internal.Sidedness side) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.Sidedness, int>)0x00538DA0)(ref this, point, side);

    /// <summary>
    /// <code>Offset: 0x00538E20
    /// void __thiscall CPolygon::Destroy(CPolygon*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, void>)0x00538E20)(ref this);

    /// <summary>
    /// <code>Offset: 0x00538EB0
    /// long double __thiscall CPolygon::adjust_sphere_to_poly(CPolygon*,CSphere*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public double adjust_sphere_to_poly(ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* curr_pos, ACBindings.Internal.AC1Legacy.Vector3* movement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, double>)0x00538EB0)(ref this, check_pos, curr_pos, movement);

    /// <summary>
    /// <code>Offset: 0x00538F50
    /// int __thiscall CPolygon::adjust_sphere_to_plane(CPolygon*,SPHEREPATH*,CSphere*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int adjust_sphere_to_plane(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.CSphere* valid_pos, ACBindings.Internal.AC1Legacy.Vector3* movement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00538F50)(ref this, path, valid_pos, movement);

    /// <summary>
    /// <code>Offset: 0x005390E0
    /// void __thiscall CPolygon::CPolygon(CPolygon*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, void>)0x005390E0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00539110
    /// void __thiscall CPolygon::make_plane(CPolygon*)</code>
    /// </summary>
    public void make_plane() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, void>)0x00539110)(ref this);

    /// <summary>
    /// <code>Offset: 0x00539270
    /// unsigned int __thiscall CPolygon::Pack(CPolygon*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, void**, uint, uint>)0x00539270)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00539390
    /// int __thiscall CPolygon::UnPack(CPolygon*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, void**, uint, int>)0x00539390)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00539500
    /// int __thiscall CPolygon::polygon_hits_sphere(CPolygon*,const CSphere*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public int polygon_hits_sphere(ACBindings.Internal.CSphere* object_, ACBindings.Internal.AC1Legacy.Vector3* contact_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00539500)(ref this, object_, contact_pt);

    /// <summary>
    /// <code>Offset: 0x00539750
    /// int __thiscall CPolygon::polygon_hits_sphere_slow_but_sure(CPolygon*,const CSphere*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public int polygon_hits_sphere_slow_but_sure(ACBindings.Internal.CSphere* object_, ACBindings.Internal.AC1Legacy.Vector3* contact_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00539750)(ref this, object_, contact_pt);

    /// <summary>
    /// <code>Offset: 0x00539A20
    /// void __thiscall CPolygon::adjust_to_placement_poly(CPolygon*,CSphere*,CSphere*,float,int,int)</code>
    /// </summary>
    public void adjust_to_placement_poly(ACBindings.Internal.CSphere* struck_sphere, ACBindings.Internal.CSphere* other_sphere, float radius, int center_solid, int solid_check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, ACBindings.Internal.CSphere*, float, int, int, void>)0x00539A20)(ref this, struck_sphere, other_sphere, radius, center_solid, solid_check);

    /// <summary>
    /// <code>Offset: 0x00539AD0
    /// int __thiscall CPolygon::point_in_polygon(CPolygon*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int point_in_polygon(ACBindings.Internal.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00539AD0)(ref this, point);

    /// <summary>
    /// <code>Offset: 0x00539BA0
    /// int __thiscall CPolygon::check_walkable(CPolygon*,CSphere*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int check_walkable(ACBindings.Internal.CSphere* sphere, ACBindings.Internal.AC1Legacy.Vector3* up) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00539BA0)(ref this, sphere, up);

    /// <summary>
    /// <code>Offset: 0x00539DF0
    /// int __thiscall CPolygon::check_small_walkable(CPolygon*,CSphere*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int check_small_walkable(ACBindings.Internal.CSphere* sphere, ACBindings.Internal.AC1Legacy.Vector3* up) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00539DF0)(ref this, sphere, up);

    /// <summary>
    /// <code>Offset: 0x0053A040
    /// int __thiscall CPolygon::find_crossed_edge(CPolygon*,CSphere*,const AC1Legacy::Vector3*,AC1Legacy::Vector3*)</code>
    /// </summary>
    public int find_crossed_edge(ACBindings.Internal.CSphere* sphere, ACBindings.Internal.AC1Legacy.Vector3* up, ACBindings.Internal.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053A040)(ref this, sphere, up, normal);

    /// <summary>
    /// <code>Offset: 0x0053A230
    /// int __thiscall CPolygon::pos_hits_sphere(CPolygon*,const CSphere*,const AC1Legacy::Vector3*,AC1Legacy::Vector3*,const CPolygon**)</code>
    /// </summary>
    public int pos_hits_sphere(ACBindings.Internal.CSphere* object_, ACBindings.Internal.AC1Legacy.Vector3* movement, ACBindings.Internal.AC1Legacy.Vector3* contact_pt, ACBindings.Internal.CPolygon** struck_poly) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CPolygon**, int>)0x0053A230)(ref this, object_, movement, contact_pt, struck_poly);

    /// <summary>
    /// <code>Offset: 0x0053A280
    /// int __thiscall CPolygon::hits_sphere(CPolygon*,const CSphere*)</code>
    /// </summary>
    public int hits_sphere(ACBindings.Internal.CSphere* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.CSphere*, int>)0x0053A280)(ref this, object_);

    /// <summary>
    /// <code>Offset: 0x0053A2A0
    /// int __thiscall CPolygon::walkable_hits_sphere(CPolygon*,SPHEREPATH*,const CSphere*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int walkable_hits_sphere(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.CSphere* object_, ACBindings.Internal.AC1Legacy.Vector3* up) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053A2A0)(ref this, path, object_, up);

    /// <summary>
    /// <code>Offset: 0x0053A320
    /// int __thiscall CPolygon::polygon_hits_ray(CPolygon*,const Ray*,long double*)</code>
    /// </summary>
    public int polygon_hits_ray(ACBindings.Internal.Ray* line, double* time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CPolygon, ACBindings.Internal.Ray*, double*, int>)0x0053A320)(ref this, line, time);
}

