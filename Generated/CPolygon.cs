namespace ACBindings;

// CPolygon
public unsafe struct CPolygon
{
    // Statics
    public static ACBindings.CVertexArray* pack_verts = (ACBindings.CVertexArray*)0x0084610C;

    // Members
    public ACBindings.CVertex** vertices;
    public ushort* vertex_ids;
    public ACBindings.Vec2Dscreen** screen;
    public short poly_id;
    public byte num_pts;
    public sbyte stippling;
    public int sides_type;
    public sbyte* pos_uv_indices;
    public sbyte* neg_uv_indices;
    public ushort pos_surface;
    public ushort neg_surface;
    public ACBindings.Plane plane;

    // Generated Constructor
    public CPolygon() {
        _ConstructorInternal();
    }

    // Methods
    // int __thiscall CPolygon::point_in_poly2D(CPolygon*,const AC1Legacy::Vector3*,Sidedness)
    public int point_in_poly2D(ACBindings.AC1Legacy.Vector3* point, ACBindings.Sidedness side) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, ACBindings.AC1Legacy.Vector3*, ACBindings.Sidedness, int>)0x00538DA0)(ref this, point, side);
    // void __thiscall CPolygon::Destroy(CPolygon*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, void>)0x00538E20)(ref this);
    // long double __thiscall CPolygon::adjust_sphere_to_poly(CPolygon*,CSphere*,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*)
    public double adjust_sphere_to_poly(ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3* curr_pos, ACBindings.AC1Legacy.Vector3* movement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, double>)0x00538EB0)(ref this, check_pos, curr_pos, movement);
    // int __thiscall CPolygon::adjust_sphere_to_plane(CPolygon*,SPHEREPATH*,CSphere*,const AC1Legacy::Vector3*)
    public int adjust_sphere_to_plane(ACBindings.SPHEREPATH* path, ACBindings.CSphere* valid_pos, ACBindings.AC1Legacy.Vector3* movement) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, ACBindings.SPHEREPATH*, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, int>)0x00538F50)(ref this, path, valid_pos, movement);
    // void __thiscall CPolygon::CPolygon(CPolygon*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, void>)0x005390E0)(ref this);
    // void __thiscall CPolygon::make_plane(CPolygon*)
    public void make_plane() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, void>)0x00539110)(ref this);
    // unsigned int __thiscall CPolygon::Pack(CPolygon*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, void**, uint, uint>)0x00539270)(ref this, addr, size);
    // int __thiscall CPolygon::UnPack(CPolygon*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, void**, uint, int>)0x00539390)(ref this, addr, size);
    // int __thiscall CPolygon::polygon_hits_sphere(CPolygon*,const CSphere*,AC1Legacy::Vector3*)
    public int polygon_hits_sphere(ACBindings.CSphere* object_, ACBindings.AC1Legacy.Vector3* contact_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, int>)0x00539500)(ref this, object_, contact_pt);
    // int __thiscall CPolygon::polygon_hits_sphere_slow_but_sure(CPolygon*,const CSphere*,AC1Legacy::Vector3*)
    public int polygon_hits_sphere_slow_but_sure(ACBindings.CSphere* object_, ACBindings.AC1Legacy.Vector3* contact_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, int>)0x00539750)(ref this, object_, contact_pt);
    // void __thiscall CPolygon::adjust_to_placement_poly(CPolygon*,CSphere*,CSphere*,float,int,int)
    public void adjust_to_placement_poly(ACBindings.CSphere* struck_sphere, ACBindings.CSphere* other_sphere, float radius, int center_solid, int solid_check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, ACBindings.CSphere*, ACBindings.CSphere*, float, int, int, void>)0x00539A20)(ref this, struck_sphere, other_sphere, radius, center_solid, solid_check);
    // int __thiscall CPolygon::point_in_polygon(CPolygon*,const AC1Legacy::Vector3*)
    public int point_in_polygon(ACBindings.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, ACBindings.AC1Legacy.Vector3*, int>)0x00539AD0)(ref this, point);
    // int __thiscall CPolygon::check_walkable(CPolygon*,CSphere*,const AC1Legacy::Vector3*)
    public int check_walkable(ACBindings.CSphere* sphere, ACBindings.AC1Legacy.Vector3* up) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, int>)0x00539BA0)(ref this, sphere, up);
    // int __thiscall CPolygon::check_small_walkable(CPolygon*,CSphere*,const AC1Legacy::Vector3*)
    public int check_small_walkable(ACBindings.CSphere* sphere, ACBindings.AC1Legacy.Vector3* up) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, int>)0x00539DF0)(ref this, sphere, up);
    // int __thiscall CPolygon::find_crossed_edge(CPolygon*,CSphere*,const AC1Legacy::Vector3*,AC1Legacy::Vector3*)
    public int find_crossed_edge(ACBindings.CSphere* sphere, ACBindings.AC1Legacy.Vector3* up, ACBindings.AC1Legacy.Vector3* normal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, int>)0x0053A040)(ref this, sphere, up, normal);
    // int __thiscall CPolygon::pos_hits_sphere(CPolygon*,const CSphere*,const AC1Legacy::Vector3*,AC1Legacy::Vector3*,const CPolygon**)
    public int pos_hits_sphere(ACBindings.CSphere* object_, ACBindings.AC1Legacy.Vector3* movement, ACBindings.AC1Legacy.Vector3* contact_pt, ACBindings.CPolygon** struck_poly) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, ACBindings.CPolygon**, int>)0x0053A230)(ref this, object_, movement, contact_pt, struck_poly);
    // int __thiscall CPolygon::hits_sphere(CPolygon*,const CSphere*)
    public int hits_sphere(ACBindings.CSphere* object_) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, ACBindings.CSphere*, int>)0x0053A280)(ref this, object_);
    // int __thiscall CPolygon::walkable_hits_sphere(CPolygon*,SPHEREPATH*,const CSphere*,const AC1Legacy::Vector3*)
    public int walkable_hits_sphere(ACBindings.SPHEREPATH* path, ACBindings.CSphere* object_, ACBindings.AC1Legacy.Vector3* up) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, ACBindings.SPHEREPATH*, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, int>)0x0053A2A0)(ref this, path, object_, up);
    // int __thiscall CPolygon::polygon_hits_ray(CPolygon*,const Ray*,long double*)
    public int polygon_hits_ray(ACBindings.Ray* line, double* time) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CPolygon, ACBindings.Ray*, double*, int>)0x0053A320)(ref this, line, time);
}

