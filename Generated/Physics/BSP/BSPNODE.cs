namespace ACBindings.Internal;

public unsafe struct BSPNODE : System.IDisposable
{
    // Statics
    public static ACBindings.Internal.CPolygon* pack_poly = (ACBindings.Internal.CPolygon*)0x00846388;
    public static ACBindings.Internal.BSPTreeType* pack_tree_type = (ACBindings.Internal.BSPTreeType*)0x0084638C;

    // Child Types
    public unsafe struct BSPNODE_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPNODE*, void> BSPNODE_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPNODE*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, int> sphere_intersects_poly; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPNODE*, ACBindings.Internal.CSphere*, int, int> sphere_intersects_solid; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPNODE*, ACBindings.Internal.AC1Legacy.Vector3*, int> point_intersects_solid; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPNODE*, ACBindings.Internal.CSphere*, float, int*, ACBindings.Internal.CPolygon**, int, int> sphere_intersects_solid_poly; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPNODE*, ACBindings.Internal.Ray*, float*, ACBindings.Internal.Vector3*, uint> TraceRay; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPNODE*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, int*, void> find_walkable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPNODE*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int> hits_walkable; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x0053CE10
    /// void __thiscall BSPNODE::Destroy(BSPNODE*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, void>)0x0053CE10)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053CE60
    /// void __thiscall BSPNODE::build_draw_portals_only(BSPNODE*,int)</code>
    /// </summary>
    public void build_draw_portals_only(int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, int, void>)0x0053CE60)(ref this, portalPolyOrPortalContents);

    /// <summary>
    /// <code>Offset: 0x0053CFC0
    /// BoundingType __thiscall BSPNODE::sphere_intersects_cell_bsp(BSPNODE*,const CSphere*)</code>
    /// </summary>
    public ACBindings.Internal.BoundingType sphere_intersects_cell_bsp(ACBindings.Internal.CSphere* curr_sphere) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.CSphere*, ACBindings.Internal.BoundingType>)0x0053CFC0)(ref this, curr_sphere);

    /// <summary>
    /// <code>Offset: 0x0053D070
    /// int __thiscall BSPNODE::point_intersects_solid(BSPNODE*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int point_intersects_solid(ACBindings.Internal.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053D070)(ref this, point);

    /// <summary>
    /// <code>Offset: 0x0053D110
    /// void __thiscall BSPNODE::BSPNODE(BSPNODE*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, void>)0x0053D110)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053D130
    /// void __thiscall BSPNODE::~BSPNODE(BSPNODE*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, void>)0x0053D130)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053D180
    /// unsigned int __thiscall BSPNODE::pack_size(BSPNODE*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, uint>)0x0053D180)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053D1F0
    /// unsigned int __thiscall BSPNODE::Pack(BSPNODE*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, void**, uint, uint>)0x0053D1F0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053D2A0
    /// int __thiscall BSPNODE::UnPack(BSPNODE*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, void**, uint, int>)0x0053D2A0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053D410
    /// unsigned int __cdecl BSPNODE::pack_child_size(BSPNODE*)</code>
    /// </summary>
    public static uint pack_child_size(ACBindings.Internal.BSPNODE* node) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.BSPNODE*, uint>)0x0053D410)(node);

    /// <summary>
    /// <code>Offset: 0x0053D460
    /// unsigned int __cdecl BSPNODE::PackChild(BSPNODE*,void**,unsigned int)</code>
    /// </summary>
    public static uint PackChild(ACBindings.Internal.BSPNODE* node, void** addr, uint size) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.BSPNODE*, void**, uint, uint>)0x0053D460)(node, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053D4D0
    /// int __cdecl BSPNODE::UnPackChild(BSPNODE**,void**,unsigned int)</code>
    /// </summary>
    public static int UnPackChild(ACBindings.Internal.BSPNODE** node, void** addr, uint size) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.BSPNODE**, void**, uint, int>)0x0053D4D0)(node, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053D5B0
    /// int __thiscall BSPNODE::LinkPortalNodeChain(_DWORD*,_DWORD*)</code>
    /// </summary>
    public int LinkPortalNodeChain(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, int*, int>)0x0053D5B0)(ref this, a2);

    /// <summary>
    /// <code>Offset: 0x0053D5E0
    /// int __thiscall BSPNODE::box_intersects_cell_bsp(BSPNODE*,const BBox*)</code>
    /// </summary>
    public int box_intersects_cell_bsp(ACBindings.Internal.BBox* box) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.BBox*, int>)0x0053D5E0)(ref this, box);

    /// <summary>
    /// <code>Offset: 0x0053D790
    /// int __thiscall BSPNODE::sphere_intersects_poly(BSPNODE*,const CSphere*,const AC1Legacy::Vector3*,const CPolygon**,AC1Legacy::Vector3*)</code>
    /// </summary>
    public int sphere_intersects_poly(ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* movement, ACBindings.Internal.CPolygon** polygon, ACBindings.Internal.AC1Legacy.Vector3* contact_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053D790)(ref this, check_pos, movement, polygon, contact_pt);

    /// <summary>
    /// <code>Offset: 0x0053D850
    /// int __thiscall BSPNODE::sphere_intersects_solid(BSPNODE*,const CSphere*,int)</code>
    /// </summary>
    public int sphere_intersects_solid(ACBindings.Internal.CSphere* check_pos, int center_check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.CSphere*, int, int>)0x0053D850)(ref this, check_pos, center_check);

    /// <summary>
    /// <code>Offset: 0x0053D930
    /// int __thiscall BSPNODE::hits_walkable(BSPNODE*,SPHEREPATH*,CSphere*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int hits_walkable(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.CSphere* valid_pos, ACBindings.Internal.AC1Legacy.Vector3* up) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053D930)(ref this, path, valid_pos, up);

    /// <summary>
    /// <code>Offset: 0x0053D9E0
    /// void __thiscall BSPNODE::find_walkable(BSPNODE*,SPHEREPATH*,CSphere*,const CPolygon**,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,int*)</code>
    /// </summary>
    public void find_walkable(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.CSphere* valid_pos, ACBindings.Internal.CPolygon** polygon, ACBindings.Internal.AC1Legacy.Vector3* movement, ACBindings.Internal.AC1Legacy.Vector3* up, int* changed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, int*, void>)0x0053D9E0)(ref this, path, valid_pos, polygon, movement, up, changed);

    /// <summary>
    /// <code>Offset: 0x0053DAB0
    /// int __thiscall BSPNODE::sphere_intersects_solid_poly(BSPNODE*,const CSphere*,float,int*,const CPolygon**,int)</code>
    /// </summary>
    public int sphere_intersects_solid_poly(ACBindings.Internal.CSphere* check_pos, float radius, int* center_solid, ACBindings.Internal.CPolygon** hit_poly, int center_check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.CSphere*, float, int*, ACBindings.Internal.CPolygon**, int, int>)0x0053DAB0)(ref this, check_pos, radius, center_solid, hit_poly, center_check);

    /// <summary>
    /// <code>Offset: 0x0053DBB0
    /// unsigned int __thiscall BSPNODE::TraceRay(BSPNODE*,const Ray*,float*,Vector3*)</code>
    /// </summary>
    public uint TraceRay(ACBindings.Internal.Ray* Ray, float* fDelta, ACBindings.Internal.Vector3* vImpactNormal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, ACBindings.Internal.Ray*, float*, ACBindings.Internal.Vector3*, uint>)0x0053DBB0)(ref this, Ray, fDelta, vImpactNormal);

    /// <summary>
    /// <code>Offset: 0x0053E0A0
    /// char __thiscall BSPNODE::DetachPortalsAndPurgeNodes(_DWORD*,_DWORD*)</code>
    /// </summary>
    public sbyte DetachPortalsAndPurgeNodes(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPNODE, int*, sbyte>)0x0053E0A0)(ref this, a2);
}

