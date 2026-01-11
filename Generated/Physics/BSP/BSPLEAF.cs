namespace ACBindings.Internal;

public unsafe struct BSPLEAF
{
    // Base Classes
    public ACBindings.Internal.BSPNODE BaseClass_BSPNODE; // ACBindings.Internal.BSPNODE

    // Child Types
    public unsafe struct BSPLEAF_vtbl
    {
        // Members
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPLEAF*, void> BSPLEAF_dtor_0; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPLEAF*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, int> sphere_intersects_poly; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPLEAF*, ACBindings.Internal.CSphere*, int, int> sphere_intersects_solid; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPLEAF*, ACBindings.Internal.AC1Legacy.Vector3*, int> point_intersects_solid; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPLEAF*, ACBindings.Internal.CSphere*, float, int*, ACBindings.Internal.CPolygon**, int, int> sphere_intersects_solid_poly; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPLEAF*, ACBindings.Internal.Ray*, float*, ACBindings.Internal.Vector3*, uint> TraceRay; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPLEAF*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, int*, void> find_walkable; // function pointer
        public delegate* unmanaged[Thiscall]<ACBindings.Internal.BSPLEAF*, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int> hits_walkable; // function pointer

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

    /// <summary>
    /// <code>Offset: 0x0053E130
    /// void __thiscall BSPLEAF::BSPLEAF(BSPLEAF*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, void>)0x0053E130)(ref this);

    /// <summary>
    /// <code>Offset: 0x0053E150
    /// int __thiscall BSPLEAF::point_intersects_solid(BSPLEAF*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int point_intersects_solid(ACBindings.Internal.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053E150)(ref this, point);

    /// <summary>
    /// <code>Offset: 0x0053E160
    /// unsigned int __thiscall BSPLEAF::PackLeaf(BSPLEAF*,void**,unsigned int)</code>
    /// </summary>
    public uint PackLeaf(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, void**, uint, uint>)0x0053E160)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053E200
    /// int __thiscall BSPLEAF::UnPackLeaf(BSPLEAF*,void**,unsigned int)</code>
    /// </summary>
    public int UnPackLeaf(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, void**, uint, int>)0x0053E200)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x0053E2E0
    /// int __thiscall BSPLEAF::sphere_intersects_poly(BSPLEAF*,const CSphere*,const AC1Legacy::Vector3*,const CPolygon**,AC1Legacy::Vector3*)</code>
    /// </summary>
    public int sphere_intersects_poly(ACBindings.Internal.CSphere* check_pos, ACBindings.Internal.AC1Legacy.Vector3* movement, ACBindings.Internal.CPolygon** polygon, ACBindings.Internal.AC1Legacy.Vector3* contact_pt) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053E2E0)(ref this, check_pos, movement, polygon, contact_pt);

    /// <summary>
    /// <code>Offset: 0x0053E350
    /// int __thiscall BSPLEAF::sphere_intersects_solid(BSPLEAF*,const CSphere*,int)</code>
    /// </summary>
    public int sphere_intersects_solid(ACBindings.Internal.CSphere* check_pos, int center_check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, ACBindings.Internal.CSphere*, int, int>)0x0053E350)(ref this, check_pos, center_check);

    /// <summary>
    /// <code>Offset: 0x0053E3D0
    /// int __thiscall BSPLEAF::hits_walkable(BSPLEAF*,SPHEREPATH*,CSphere*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int hits_walkable(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.CSphere* valid_pos, ACBindings.Internal.AC1Legacy.Vector3* up) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x0053E3D0)(ref this, path, valid_pos, up);

    /// <summary>
    /// <code>Offset: 0x0053E450
    /// void __thiscall BSPLEAF::find_walkable(BSPLEAF*,SPHEREPATH*,CSphere*,const CPolygon**,const AC1Legacy::Vector3*,const AC1Legacy::Vector3*,int*)</code>
    /// </summary>
    public void find_walkable(ACBindings.Internal.SPHEREPATH* path, ACBindings.Internal.CSphere* valid_pos, ACBindings.Internal.CPolygon** polygon, ACBindings.Internal.AC1Legacy.Vector3* movement, ACBindings.Internal.AC1Legacy.Vector3* up, int* changed) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, ACBindings.Internal.SPHEREPATH*, ACBindings.Internal.CSphere*, ACBindings.Internal.CPolygon**, ACBindings.Internal.AC1Legacy.Vector3*, ACBindings.Internal.AC1Legacy.Vector3*, int*, void>)0x0053E450)(ref this, path, valid_pos, polygon, movement, up, changed);

    /// <summary>
    /// <code>Offset: 0x0053E4E0
    /// int __thiscall BSPLEAF::sphere_intersects_solid_poly(BSPLEAF*,const CSphere*,float,int*,const CPolygon**,int)</code>
    /// </summary>
    public int sphere_intersects_solid_poly(ACBindings.Internal.CSphere* check_pos, float radius, int* center_solid, ACBindings.Internal.CPolygon** hit_poly, int center_check) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.BSPLEAF, ACBindings.Internal.CSphere*, float, int*, ACBindings.Internal.CPolygon**, int, int>)0x0053E4E0)(ref this, check_pos, radius, center_solid, hit_poly, center_check);
}

