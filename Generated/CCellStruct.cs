namespace ACBindings;

// CCellStruct
public unsafe struct CCellStruct : System.IDisposable
{
    // Members
    public uint cellstruct_id;
    public ACBindings.CVertexArray vertex_array;
    public uint num_portals;
    public ACBindings.CPolygon** portals;
    public uint num_surface_strips;
    public ACBindings.CSurfaceTriStrips* surface_strips;
    public uint num_polygons;
    public ACBindings.CPolygon* polygons;
    public ACBindings.BSPTREE* drawing_bsp;
    public uint num_physics_polygons;
    public ACBindings.CPolygon* physics_polygons;
    public ACBindings.BSPTREE* physics_bsp;
    public ACBindings.BSPTREE* cell_bsp;

    // Generated Constructor
    public CCellStruct() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall CCellStruct::CCellStruct(CCellStruct*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCellStruct, void>)0x005345B0)(ref this);
    // CPolygon* __thiscall CCellStruct::get_portal(CCellStruct*,unsigned __int16)
    public ACBindings.CPolygon* get_portal(ushort poly_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCellStruct, ushort, ACBindings.CPolygon*>)0x005345F0)(ref this, poly_id);
    // int __thiscall CCellStruct::point_in_cell(CCellStruct*,const AC1Legacy::Vector3*)
    public int point_in_cell(ACBindings.AC1Legacy.Vector3* origin) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCellStruct, ACBindings.AC1Legacy.Vector3*, int>)0x00534630)(ref this, origin);
    // BoundingType __thiscall CCellStruct::sphere_intersects_cell(CCellStruct*,const CSphere*)
    public ACBindings.BoundingType sphere_intersects_cell(ACBindings.CSphere* sphere) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCellStruct, ACBindings.CSphere*, ACBindings.BoundingType>)0x00534640)(ref this, sphere);
    // int __thiscall CCellStruct::box_intersects_cell(CCellStruct*,const BBox*)
    public int box_intersects_cell(ACBindings.BBox* box) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCellStruct, ACBindings.BBox*, int>)0x00534650)(ref this, box);
    // unsigned int __thiscall CCellStruct::pack_size(CCellStruct*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCellStruct, uint>)0x00534660)(ref this);
    // unsigned int __thiscall CCellStruct::Pack(CCellStruct*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCellStruct, void**, uint, uint>)0x00534760)(ref this, addr, size);
    // void __thiscall CCellStruct::Destroy(CCellStruct*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCellStruct, void>)0x00534910)(ref this);
    // int __thiscall CCellStruct::UnPack(CCellStruct*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCellStruct, void**, uint, int>)0x00534A40)(ref this, addr, size);
    // void __thiscall CCellStruct::~CCellStruct(CCellStruct*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CCellStruct, void>)0x00534CD0)(ref this);
}

