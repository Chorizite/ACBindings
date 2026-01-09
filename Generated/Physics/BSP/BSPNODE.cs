namespace ACBindings;

// BSPNODE
public unsafe struct BSPNODE : System.IDisposable
{
    // Statics
    public static ACBindings.CPolygon* pack_poly = (ACBindings.CPolygon*)0x00846388;
    public static ACBindings.BSPTreeType* pack_tree_type = (ACBindings.BSPTreeType*)0x0084638C;

    // Child Types
    // BSPNODE_vtbl
    public unsafe struct BSPNODE_vtbl
    {
        // Members
        public System.IntPtr BSPNODE_dtor_0; // function pointer
        public System.IntPtr sphere_intersects_poly; // function pointer
        public System.IntPtr sphere_intersects_solid; // function pointer
        public System.IntPtr point_intersects_solid; // function pointer
        public System.IntPtr sphere_intersects_solid_poly; // function pointer
        public System.IntPtr TraceRay; // function pointer
        public System.IntPtr find_walkable; // function pointer
        public System.IntPtr hits_walkable; // function pointer

        // Methods
    }

    // Members
    public System.IntPtr __vftable; // vtable pointer
    public ACBindings.CSphere sphere;
    public ACBindings.Plane splitting_plane;
    public ACBindings._429348390AB0EFA2F7BE9421CDFA9E37 ___u3;
    public uint num_polys;
    public ACBindings.CPolygon** in_polys;
    public ACBindings.BSPNODE* pos_node;
    public ACBindings.BSPNODE* neg_node;

    // Generated Constructor
    public BSPNODE() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall BSPNODE::Destroy(BSPNODE*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, void>)0x0053CE10)(ref this);
    // void __thiscall BSPNODE::build_draw_portals_only(BSPNODE*,int)
    public void build_draw_portals_only(int portalPolyOrPortalContents) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, int, void>)0x0053CE60)(ref this, portalPolyOrPortalContents);
    // BoundingType __thiscall BSPNODE::sphere_intersects_cell_bsp(BSPNODE*,const CSphere*)
    public ACBindings.BoundingType sphere_intersects_cell_bsp(ACBindings.CSphere* curr_sphere) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, ACBindings.CSphere*, ACBindings.BoundingType>)0x0053CFC0)(ref this, curr_sphere);
    // int __thiscall BSPNODE::point_intersects_solid(BSPNODE*,const AC1Legacy::Vector3*)
    public int point_intersects_solid(ACBindings.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, ACBindings.AC1Legacy.Vector3*, int>)0x0053D070)(ref this, point);
    // void __thiscall BSPNODE::BSPNODE(BSPNODE*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, void>)0x0053D110)(ref this);
    // void __thiscall BSPNODE::~BSPNODE(BSPNODE*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, void>)0x0053D130)(ref this);
    // unsigned int __thiscall BSPNODE::pack_size(BSPNODE*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, uint>)0x0053D180)(ref this);
    // unsigned int __thiscall BSPNODE::Pack(BSPNODE*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, void**, uint, uint>)0x0053D1F0)(ref this, addr, size);
    // int __thiscall BSPNODE::UnPack(BSPNODE*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, void**, uint, int>)0x0053D2A0)(ref this, addr, size);
    // unsigned int __cdecl BSPNODE::pack_child_size(BSPNODE*)
    public static uint pack_child_size(ACBindings.BSPNODE* node) => ((delegate* unmanaged[Cdecl]<ACBindings.BSPNODE*, uint>)0x0053D410)(node);
    // unsigned int __cdecl BSPNODE::PackChild(BSPNODE*,void**,unsigned int)
    public static uint PackChild(ACBindings.BSPNODE* node, void** addr, uint size) => ((delegate* unmanaged[Cdecl]<ACBindings.BSPNODE*, void**, uint, uint>)0x0053D460)(node, addr, size);
    // int __cdecl BSPNODE::UnPackChild(BSPNODE**,void**,unsigned int)
    public static int UnPackChild(ACBindings.BSPNODE** node, void** addr, uint size) => ((delegate* unmanaged[Cdecl]<ACBindings.BSPNODE**, void**, uint, int>)0x0053D4D0)(node, addr, size);
    // int __thiscall BSPNODE::LinkPortalNodeChain(_DWORD*,_DWORD*)
    public int LinkPortalNodeChain(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, int*, int>)0x0053D5B0)(ref this, a2);
    // int __thiscall BSPNODE::box_intersects_cell_bsp(BSPNODE*,const BBox*)
    public int box_intersects_cell_bsp(ACBindings.BBox* box) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, ACBindings.BBox*, int>)0x0053D5E0)(ref this, box);
    // int __thiscall BSPNODE::sphere_intersects_poly(BSPNODE*,const CSphere*,const AC1Legacy::Vector3*,const CPolygon**,AC1Legacy::Vector3*)
    public int sphere_intersects_poly(ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3* movement, ACBindings.CPolygon** polygon, ACBindings.AC1Legacy.Vector3* contact_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, ACBindings.CPolygon**, ACBindings.AC1Legacy.Vector3*, int>)0x0053D790)(ref this, check_pos, movement, polygon, contact_pt);
    // int __thiscall BSPNODE::sphere_intersects_solid(BSPNODE*,const CSphere*,int)
    public int sphere_intersects_solid(ACBindings.CSphere* check_pos, int center_check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, ACBindings.CSphere*, int, int>)0x0053D850)(ref this, check_pos, center_check);
    // int __thiscall BSPNODE::hits_walkable(BSPNODE*,SPHEREPATH*,CSphere*,const AC1Legacy::Vector3*)
    public int hits_walkable(ACBindings.SPHEREPATH* path, ACBindings.CSphere* valid_pos, ACBindings.AC1Legacy.Vector3* up) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, ACBindings.SPHEREPATH*, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, int>)0x0053D930)(ref this, path, valid_pos, up);
    // void __thiscall BSPNODE::find_walkable(BSPNODE*,SPHEREPATH*,CSphere*,const CPolygon**,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,int*)
    public void find_walkable(ACBindings.SPHEREPATH* path, ACBindings.CSphere* valid_pos, ACBindings.CPolygon** polygon, ACBindings.AC1Legacy.Vector3* movement, ACBindings.AC1Legacy.Vector3* up, int* changed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, ACBindings.SPHEREPATH*, ACBindings.CSphere*, ACBindings.CPolygon**, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, int*, void>)0x0053D9E0)(ref this, path, valid_pos, polygon, movement, up, changed);
    // int __thiscall BSPNODE::sphere_intersects_solid_poly(BSPNODE*,const CSphere*,float,int*,const CPolygon**,int)
    public int sphere_intersects_solid_poly(ACBindings.CSphere* check_pos, float radius, int* center_solid, ACBindings.CPolygon** hit_poly, int center_check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, ACBindings.CSphere*, float, int*, ACBindings.CPolygon**, int, int>)0x0053DAB0)(ref this, check_pos, radius, center_solid, hit_poly, center_check);
    // unsigned int __thiscall BSPNODE::TraceRay(BSPNODE*,const Ray*,float*,Vector3*)
    public uint TraceRay(ACBindings.Ray* Ray, float* fDelta, ACBindings.Vector3* vImpactNormal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, ACBindings.Ray*, float*, ACBindings.Vector3*, uint>)0x0053DBB0)(ref this, Ray, fDelta, vImpactNormal);
    // char __thiscall BSPNODE::DetachPortalsAndPurgeNodes(_DWORD*,_DWORD*)
    public sbyte DetachPortalsAndPurgeNodes(int* a2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPNODE, int*, sbyte>)0x0053E0A0)(ref this, a2);
}

