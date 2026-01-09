namespace ACBindings;

// CLandBlockStruct
public unsafe struct CLandBlockStruct : System.IDisposable
{
    // Statics
    public static ACBindings.CVec2Duv* land_uvs = (ACBindings.CVec2Duv*)0x00845CB8;

    // Members
    public ACBindings.RGBColor* vertex_lighting;
    public ACBindings.LandDefs.Direction trans_dir;
    public int side_vertex_count;
    public int side_polygon_count;
    public int side_cell_count;
    public ACBindings.LandDefs.WaterType water_type;
    public byte* height;
    public ushort* terrain;
    public ACBindings.CVertexArray vertex_array;
    public ACBindings.CPolygon* polygons;
    public uint num_surface_strips;
    public ACBindings.CSurfaceTriStrips* surface_strips;
    public uint block_surface_index;
    public ACBindings.CLandCell* lcell;
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
    // void __thiscall CLandBlockStruct::CLandBlockStruct(CLandBlockStruct*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, void>)0x00531B70)(ref this);
    // void __thiscall CLandBlockStruct::InitPVArrays(CLandBlockStruct*)
    public void InitPVArrays() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, void>)0x00531BD0)(ref this);
    // CPolygon* __thiscall CLandBlockStruct::AddPolygon(CLandBlockStruct*,unsigned int,unsigned int,unsigned int,unsigned int)
    public ACBindings.CPolygon* AddPolygon(uint pindex, uint vindex0, uint vindex1, uint vindex2) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, uint, uint, uint, uint, ACBindings.CPolygon*>)0x00531E10)(ref this, pindex, vindex0, vindex1, vindex2);
    // unsigned int __thiscall CLandBlockStruct::pack_size(CLandBlockStruct*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, uint>)0x00531F10)(ref this);
    // unsigned int __thiscall CLandBlockStruct::Pack(CLandBlockStruct*,void**,unsigned int)
    public uint Pack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, void**, uint, uint>)0x00531F20)(ref this, addr, size);
    // void __thiscall CLandBlockStruct::AdjPlanes(CLandBlockStruct*)
    public void AdjPlanes() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, void>)0x005320C0)(ref this);
    // void __thiscall CLandBlockStruct::RemoveSurfaces(CLandBlockStruct*)
    public void RemoveSurfaces() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, void>)0x00532120)(ref this);
    // void __thiscall CLandBlockStruct::Destroy(CLandBlockStruct*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, void>)0x00532190)(ref this);
    // void __thiscall CLandBlockStruct::CalcCellWater(CLandBlockStruct*,int,int,int*,int*)
    public void CalcCellWater(int cell_x, int cell_y, int* cell_has_water, int* cell_all_water) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, int, int, int*, int*, void>)0x00532290)(ref this, cell_x, cell_y, cell_has_water, cell_all_water);
    // float __thiscall CLandBlockStruct::calc_water_depth(CLandBlockStruct*,unsigned int,const AC1Legacy::Vector3*)
    public float calc_water_depth(uint cell_id, ACBindings.AC1Legacy.Vector3* point) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, uint, ACBindings.AC1Legacy.Vector3*, float>)0x00532330)(ref this, cell_id, point);
    // void __thiscall CLandBlockStruct::calc_lighting(CLandBlockStruct*)
    public void calc_lighting() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, void>)0x00532440)(ref this);
    // void __thiscall CLandBlockStruct::ConstructPolygons(CLandBlockStruct*,unsigned int)
    public void ConstructPolygons(uint block_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, uint, void>)0x00532A50)(ref this, block_id);
    // int __thiscall CLandBlockStruct::UnPack(CLandBlockStruct*,void**,unsigned int)
    public int UnPack(void** addr, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, void**, uint, int>)0x00532D10)(ref this, addr, size);
    // void __thiscall CLandBlockStruct::GetCellRotation(CLandBlockStruct*,unsigned int,int,int,bool*,unsigned int*,LandDefs::Rotation*)
    public void GetCellRotation(uint block_id, int ix, int iy, byte* o_bSingleTextureCell, uint* o_surf_num, ACBindings.LandDefs.Rotation* o_rot) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, uint, int, int, byte*, uint*, ACBindings.LandDefs.Rotation*, void>)0x00532EB0)(ref this, block_id, ix, iy, o_bSingleTextureCell, o_surf_num, o_rot);
    // void __thiscall CLandBlockStruct::TransAdjust(CLandBlockStruct*)
    public void TransAdjust() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, void>)0x00533110)(ref this);
    // void __thiscall CLandBlockStruct::~CLandBlockStruct(CLandBlockStruct*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, void>)0x005334F0)(ref this);
    // void __thiscall CLandBlockStruct::CalcWater(CLandBlockStruct*)
    public void CalcWater() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, void>)0x00533520)(ref this);
    // void __thiscall CLandBlockStruct::ConstructVertices(CLandBlockStruct*)
    public void ConstructVertices() => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, void>)0x00533610)(ref this);
    // void __thiscall CLandBlockStruct::ConstructUVs(CLandBlockStruct*,unsigned int)
    public void ConstructUVs(uint block_id) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, uint, void>)0x005336E0)(ref this, block_id);
    // int __thiscall CLandBlockStruct::generate(CLandBlockStruct*,unsigned int,unsigned int,LandDefs::Direction)
    public int generate(uint block_id, uint poly_size, ACBindings.LandDefs.Direction tdir) => ((delegate* unmanaged[Thiscall]<ref ACBindings.CLandBlockStruct, uint, uint, ACBindings.LandDefs.Direction, int>)0x005338F0)(ref this, block_id, poly_size, tdir);
}

