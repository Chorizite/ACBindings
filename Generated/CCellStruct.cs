namespace ACBindings.Internal;

public unsafe struct CCellStruct : System.IDisposable
{
    // Members
    public uint cellstruct_id;
    public ACBindings.Internal.CVertexArray vertex_array;
    public uint num_portals;
    public ACBindings.Internal.CPolygon** portals;
    public uint num_surface_strips;
    public ACBindings.Internal.CSurfaceTriStrips* surface_strips;
    public uint num_polygons;
    public ACBindings.Internal.CPolygon* polygons;
    public ACBindings.Internal.BSPTREE* drawing_bsp;
    public uint num_physics_polygons;
    public ACBindings.Internal.CPolygon* physics_polygons;
    public ACBindings.Internal.BSPTREE* physics_bsp;
    public ACBindings.Internal.BSPTREE* cell_bsp;

    // Generated Constructor
    public CCellStruct() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005345B0
    /// void __thiscall CCellStruct::CCellStruct(CCellStruct*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, void>)0x005345B0)(ref this);

    /// <summary>
    /// <code>Offset: 0x005345F0
    /// CPolygon* __thiscall CCellStruct::get_portal(CCellStruct*,unsigned __int16)</code>
    /// </summary>
    public ACBindings.Internal.CPolygon* get_portal(ushort poly_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, ushort, ACBindings.Internal.CPolygon*>)0x005345F0)(ref this, poly_id);

    /// <summary>
    /// <code>Offset: 0x00534630
    /// int __thiscall CCellStruct::point_in_cell(CCellStruct*,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public int point_in_cell(ACBindings.Internal.AC1Legacy.Vector3* origin) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, ACBindings.Internal.AC1Legacy.Vector3*, int>)0x00534630)(ref this, origin);

    /// <summary>
    /// <code>Offset: 0x00534640
    /// BoundingType __thiscall CCellStruct::sphere_intersects_cell(CCellStruct*,const CSphere*)</code>
    /// </summary>
    public ACBindings.Internal.BoundingType sphere_intersects_cell(ACBindings.Internal.CSphere* sphere) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, ACBindings.Internal.CSphere*, ACBindings.Internal.BoundingType>)0x00534640)(ref this, sphere);

    /// <summary>
    /// <code>Offset: 0x00534650
    /// int __thiscall CCellStruct::box_intersects_cell(CCellStruct*,const BBox*)</code>
    /// </summary>
    public int box_intersects_cell(ACBindings.Internal.BBox* box) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, ACBindings.Internal.BBox*, int>)0x00534650)(ref this, box);

    /// <summary>
    /// <code>Offset: 0x00534660
    /// unsigned int __thiscall CCellStruct::pack_size(CCellStruct*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, uint>)0x00534660)(ref this);

    /// <summary>
    /// <code>Offset: 0x00534760
    /// unsigned int __thiscall CCellStruct::Pack(CCellStruct*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, void**, uint, uint>)0x00534760)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00534910
    /// void __thiscall CCellStruct::Destroy(CCellStruct*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, void>)0x00534910)(ref this);

    /// <summary>
    /// <code>Offset: 0x00534A40
    /// int __thiscall CCellStruct::UnPack(CCellStruct*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, void**, uint, int>)0x00534A40)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00534CD0
    /// void __thiscall CCellStruct::~CCellStruct(CCellStruct*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CCellStruct, void>)0x00534CD0)(ref this);
}

