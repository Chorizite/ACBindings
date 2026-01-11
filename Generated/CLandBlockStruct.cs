namespace ACBindings.Internal;

public unsafe struct CLandBlockStruct : System.IDisposable
{
    // Statics
    public static ACBindings.Internal.CVec2Duv* land_uvs = (ACBindings.Internal.CVec2Duv*)0x00845CB8;

    // Members
    public ACBindings.Internal.RGBColor* vertex_lighting;
    public ACBindings.Internal.LandDefs.Direction trans_dir;
    public int side_vertex_count;
    public int side_polygon_count;
    public int side_cell_count;
    public ACBindings.Internal.LandDefs.WaterType water_type;
    public byte* height;
    public ushort* terrain;
    public ACBindings.Internal.CVertexArray vertex_array;
    public ACBindings.Internal.CPolygon* polygons;
    public uint num_surface_strips;
    public ACBindings.Internal.CSurfaceTriStrips* surface_strips;
    public uint block_surface_index;
    public ACBindings.Internal.CLandCell* lcell;
    public int* SWtoNEcut;

    // Generated Constructor
    public CLandBlockStruct() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00531B70
    /// void __thiscall CLandBlockStruct::CLandBlockStruct(CLandBlockStruct*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x00531B70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00531BD0
    /// void __thiscall CLandBlockStruct::InitPVArrays(CLandBlockStruct*)</code>
    /// </summary>
    public void InitPVArrays() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x00531BD0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00531E10
    /// CPolygon* __thiscall CLandBlockStruct::AddPolygon(CLandBlockStruct*,unsigned int,unsigned int,unsigned int,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CPolygon* AddPolygon(uint pindex, uint vindex0, uint vindex1, uint vindex2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, uint, uint, uint, uint, ACBindings.Internal.CPolygon*>)0x00531E10)(ref this, pindex, vindex0, vindex1, vindex2);

    /// <summary>
    /// <code>Offset: 0x00531F10
    /// unsigned int __thiscall CLandBlockStruct::pack_size(CLandBlockStruct*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, uint>)0x00531F10)(ref this);

    /// <summary>
    /// <code>Offset: 0x00531F20
    /// unsigned int __thiscall CLandBlockStruct::Pack(CLandBlockStruct*,void**,unsigned int)</code>
    /// </summary>
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void**, uint, uint>)0x00531F20)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005320C0
    /// void __thiscall CLandBlockStruct::AdjPlanes(CLandBlockStruct*)</code>
    /// </summary>
    public void AdjPlanes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x005320C0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00532120
    /// void __thiscall CLandBlockStruct::RemoveSurfaces(CLandBlockStruct*)</code>
    /// </summary>
    public void RemoveSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x00532120)(ref this);

    /// <summary>
    /// <code>Offset: 0x00532190
    /// void __thiscall CLandBlockStruct::Destroy(CLandBlockStruct*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x00532190)(ref this);

    /// <summary>
    /// <code>Offset: 0x00532290
    /// void __thiscall CLandBlockStruct::CalcCellWater(CLandBlockStruct*,int,int,int*,int*)</code>
    /// </summary>
    public void CalcCellWater(int cell_x, int cell_y, int* cell_has_water, int* cell_all_water) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, int, int, int*, int*, void>)0x00532290)(ref this, cell_x, cell_y, cell_has_water, cell_all_water);

    /// <summary>
    /// <code>Offset: 0x00532330
    /// float __thiscall CLandBlockStruct::calc_water_depth(CLandBlockStruct*,unsigned int,const AC1Legacy::Vector3*)</code>
    /// </summary>
    public float calc_water_depth(uint cell_id, ACBindings.Internal.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, uint, ACBindings.Internal.AC1Legacy.Vector3*, float>)0x00532330)(ref this, cell_id, point);

    /// <summary>
    /// <code>Offset: 0x00532440
    /// void __thiscall CLandBlockStruct::calc_lighting(CLandBlockStruct*)</code>
    /// </summary>
    public void calc_lighting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x00532440)(ref this);

    /// <summary>
    /// <code>Offset: 0x00532A50
    /// void __thiscall CLandBlockStruct::ConstructPolygons(CLandBlockStruct*,unsigned int)</code>
    /// </summary>
    public void ConstructPolygons(uint block_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, uint, void>)0x00532A50)(ref this, block_id);

    /// <summary>
    /// <code>Offset: 0x00532D10
    /// int __thiscall CLandBlockStruct::UnPack(CLandBlockStruct*,void**,unsigned int)</code>
    /// </summary>
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void**, uint, int>)0x00532D10)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00532EB0
    /// void __thiscall CLandBlockStruct::GetCellRotation(CLandBlockStruct*,unsigned int,int,int,bool*,unsigned int*,LandDefs::Rotation*)</code>
    /// </summary>
    public void GetCellRotation(uint block_id, int ix, int iy, byte* o_bSingleTextureCell, uint* o_surf_num, ACBindings.Internal.LandDefs.Rotation* o_rot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, uint, int, int, byte*, uint*, ACBindings.Internal.LandDefs.Rotation*, void>)0x00532EB0)(ref this, block_id, ix, iy, o_bSingleTextureCell, o_surf_num, o_rot);

    /// <summary>
    /// <code>Offset: 0x00533110
    /// void __thiscall CLandBlockStruct::TransAdjust(CLandBlockStruct*)</code>
    /// </summary>
    public void TransAdjust() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x00533110)(ref this);

    /// <summary>
    /// <code>Offset: 0x005334F0
    /// void __thiscall CLandBlockStruct::~CLandBlockStruct(CLandBlockStruct*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x005334F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00533520
    /// void __thiscall CLandBlockStruct::CalcWater(CLandBlockStruct*)</code>
    /// </summary>
    public void CalcWater() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x00533520)(ref this);

    /// <summary>
    /// <code>Offset: 0x00533610
    /// void __thiscall CLandBlockStruct::ConstructVertices(CLandBlockStruct*)</code>
    /// </summary>
    public void ConstructVertices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, void>)0x00533610)(ref this);

    /// <summary>
    /// <code>Offset: 0x005336E0
    /// void __thiscall CLandBlockStruct::ConstructUVs(CLandBlockStruct*,unsigned int)</code>
    /// </summary>
    public void ConstructUVs(uint block_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, uint, void>)0x005336E0)(ref this, block_id);

    /// <summary>
    /// <code>Offset: 0x005338F0
    /// int __thiscall CLandBlockStruct::generate(CLandBlockStruct*,unsigned int,unsigned int,LandDefs::Direction)</code>
    /// </summary>
    public int generate(uint block_id, uint poly_size, ACBindings.Internal.LandDefs.Direction tdir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.CLandBlockStruct, uint, uint, ACBindings.Internal.LandDefs.Direction, int>)0x005338F0)(ref this, block_id, poly_size, tdir);
}

