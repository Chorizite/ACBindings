namespace ACBindings;

// BSPLEAF
public unsafe struct BSPLEAF
{
    // Base Classes
    public ACBindings.BSPNODE BaseClass_BSPNODE; // ACBindings.BSPNODE

    // Child Types
    // BSPLEAF_vtbl
    public unsafe struct BSPLEAF_vtbl
    {
        // Members
        public System.IntPtr BSPLEAF_dtor_0; // function pointer
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
    public uint leaf_index;
    public int solid;

    // Generated Constructor
    public BSPLEAF() {
        _ConstructorInternal();
    }

    // Methods
    // void __thiscall BSPLEAF::BSPLEAF(BSPLEAF*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPLEAF, void>)0x0053E130)(ref this);
    // int __thiscall BSPLEAF::point_intersects_solid(BSPLEAF*,const AC1Legacy::Vector3*)
    public int point_intersects_solid(ACBindings.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPLEAF, ACBindings.AC1Legacy.Vector3*, int>)0x0053E150)(ref this, point);
    // unsigned int __thiscall BSPLEAF::PackLeaf(BSPLEAF*,void**,unsigned int)
    public uint PackLeaf(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPLEAF, void**, uint, uint>)0x0053E160)(ref this, addr, size);
    // int __thiscall BSPLEAF::UnPackLeaf(BSPLEAF*,void**,unsigned int)
    public int UnPackLeaf(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPLEAF, void**, uint, int>)0x0053E200)(ref this, addr, size);
    // int __thiscall BSPLEAF::sphere_intersects_poly(BSPLEAF*,const CSphere*,const AC1Legacy::Vector3*,const CPolygon**,AC1Legacy::Vector3*)
    public int sphere_intersects_poly(ACBindings.CSphere* check_pos, ACBindings.AC1Legacy.Vector3* movement, ACBindings.CPolygon** polygon, ACBindings.AC1Legacy.Vector3* contact_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPLEAF, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, ACBindings.CPolygon**, ACBindings.AC1Legacy.Vector3*, int>)0x0053E2E0)(ref this, check_pos, movement, polygon, contact_pt);
    // int __thiscall BSPLEAF::sphere_intersects_solid(BSPLEAF*,const CSphere*,int)
    public int sphere_intersects_solid(ACBindings.CSphere* check_pos, int center_check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPLEAF, ACBindings.CSphere*, int, int>)0x0053E350)(ref this, check_pos, center_check);
    // int __thiscall BSPLEAF::hits_walkable(BSPLEAF*,SPHEREPATH*,CSphere*,const AC1Legacy::Vector3*)
    public int hits_walkable(ACBindings.SPHEREPATH* path, ACBindings.CSphere* valid_pos, ACBindings.AC1Legacy.Vector3* up) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPLEAF, ACBindings.SPHEREPATH*, ACBindings.CSphere*, ACBindings.AC1Legacy.Vector3*, int>)0x0053E3D0)(ref this, path, valid_pos, up);
    // void __thiscall BSPLEAF::find_walkable(BSPLEAF*,SPHEREPATH*,CSphere*,const CPolygon**,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,int*)
    public void find_walkable(ACBindings.SPHEREPATH* path, ACBindings.CSphere* valid_pos, ACBindings.CPolygon** polygon, ACBindings.AC1Legacy.Vector3* movement, ACBindings.AC1Legacy.Vector3* up, int* changed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPLEAF, ACBindings.SPHEREPATH*, ACBindings.CSphere*, ACBindings.CPolygon**, ACBindings.AC1Legacy.Vector3*, ACBindings.AC1Legacy.Vector3*, int*, void>)0x0053E450)(ref this, path, valid_pos, polygon, movement, up, changed);
    // int __thiscall BSPLEAF::sphere_intersects_solid_poly(BSPLEAF*,const CSphere*,float,int*,const CPolygon**,int)
    public int sphere_intersects_solid_poly(ACBindings.CSphere* check_pos, float radius, int* center_solid, ACBindings.CPolygon** hit_poly, int center_check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.BSPLEAF, ACBindings.CSphere*, float, int*, ACBindings.CPolygon**, int, int>)0x0053E4E0)(ref this, check_pos, radius, center_solid, hit_poly, center_check);
}

