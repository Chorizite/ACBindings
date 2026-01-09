namespace ACBindings;

// TexMerge
public unsafe struct TexMerge : System.IDisposable
{
    // Statics
    public static byte* tex_data = (byte*)0x0084271C;

    // Members
    public uint base_tex_size;
    public ACBindings.AC1Legacy.SmartArray__TerrainAlphaMap_ptr corner_terrain_maps;
    public ACBindings.AC1Legacy.SmartArray__TerrainAlphaMap_ptr side_terrain_maps;
    public ACBindings.AC1Legacy.SmartArray__RoadAlphaMap_ptr road_maps;
    public ACBindings.AC1Legacy.SmartArray__TMTerrainDesc_ptr terrain_desc;

    // Generated Constructor
    public TexMerge() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods
    // void __thiscall TexMerge::CleanupSurface(TexMerge*,CSurface*)
    public void CleanupSurface(ACBindings.CSurface* surf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, ACBindings.CSurface*, void>)0x00503E30)(ref this, surf);
    // int __thiscall TexMerge::GetRoadCode(TexMerge*,unsigned int,int*,unsigned int*)
    public int GetRoadCode(uint pcode, int* road_fill, uint* rcode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, uint, int*, uint*, int>)0x00503E50)(ref this, pcode, road_fill, rcode);
    // void __thiscall TexMerge::TexMerge(TexMerge*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, void>)0x00503FB0)(ref this);
    // int __thiscall TexMerge::CopyAndTile(TexMerge*,unsigned __int8*,unsigned int,TerrainTex*)
    public int CopyAndTile(byte* data, uint tex_size, ACBindings.TerrainTex* terrain_tex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, byte*, uint, ACBindings.TerrainTex*, int>)0x00503FE0)(ref this, data, tex_size, terrain_tex);
    // int __thiscall TexMerge::FindRoadAlpha(TexMerge*,unsigned int,RoadAlphaMap**,LandDefs::Rotation*,unsigned int)
    public int FindRoadAlpha(uint rcode, ACBindings.RoadAlphaMap** alpha, ACBindings.LandDefs.Rotation* rot, uint pcode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, uint, ACBindings.RoadAlphaMap**, ACBindings.LandDefs.Rotation*, uint, int>)0x00504060)(ref this, rcode, alpha, rot, pcode);
    // int __thiscall TexMerge::FindTerrainAlpha(TexMerge*,unsigned int,TerrainAlphaMap**,LandDefs::Rotation*,unsigned int)
    public int FindTerrainAlpha(uint tcode, ACBindings.TerrainAlphaMap** alpha, ACBindings.LandDefs.Rotation* rot, uint pcode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, uint, ACBindings.TerrainAlphaMap**, ACBindings.LandDefs.Rotation*, uint, int>)0x00504160)(ref this, tcode, alpha, rot, pcode);
    // int __thiscall TexMerge::Merge(TexMerge*,unsigned __int8*,unsigned int,ImgTex*,LandDefs::Rotation,TerrainTex*)
    public int Merge(byte* data, uint tex_size, ACBindings.ImgTex* texture, ACBindings.LandDefs.Rotation rot, ACBindings.TerrainTex* terrain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, byte*, uint, ACBindings.ImgTex*, ACBindings.LandDefs.Rotation, ACBindings.TerrainTex*, int>)0x00504320)(ref this, data, tex_size, texture, rot, terrain);
    // TerrainTex* __thiscall TexMerge::GetTerrainTex(TexMerge*,unsigned int)
    public ACBindings.TerrainTex* GetTerrainTex(uint t1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, uint, ACBindings.TerrainTex*>)0x005043A0)(ref this, t1);
    // unsigned int __thiscall TexMerge::pack_size(TexMerge*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, uint>)0x00504400)(ref this);
    // IDClass<_tagDataID,32,0>* __thiscall TexMerge::GetDetailTex(_DWORD*,IDClass<_tagDataID,32,0>*,unsigned int)
    public ACBindings.IDClass___tagDataID* GetDetailTex(ACBindings.IDClass___tagDataID* a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, ACBindings.IDClass___tagDataID*, uint, ACBindings.IDClass___tagDataID*>)0x00504440)(ref this, a2, a3);
    // void __thiscall TexMerge::GetSubDataIDs(TexMerge*,QualifiedDataIDArray*)
    public void GetSubDataIDs(ACBindings.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, ACBindings.QualifiedDataIDArray*, void>)0x00504710)(ref this, id_array);
    // int __thiscall TexMerge::GetTerrain(TexMerge*,unsigned int,TerrainTex**,unsigned int*)
    public int GetTerrain(uint pcode, ACBindings.TerrainTex** terrain_tex, uint* tcode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, uint, ACBindings.TerrainTex**, uint*, int>)0x00504820)(ref this, pcode, terrain_tex, tcode);
    // unsigned int __thiscall TexMerge::Pack(TexMerge*,void**,unsigned int*)
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, void**, uint*, uint>)0x00504B40)(ref this, addr, size);
    // void __thiscall TexMerge::Destroy(TexMerge*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, void>)0x00504D80)(ref this);
    // int __thiscall TexMerge::FillTempTexBuffer(TexMerge*,unsigned int,unsigned int)
    public int FillTempTexBuffer(uint pcode, uint tex_size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, uint, uint, int>)0x00504EB0)(ref this, pcode, tex_size);
    // int __thiscall TexMerge::UnPack(TexMerge*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, void**, uint*, int>)0x00505010)(ref this, addr, size);
    // void __thiscall TexMerge::~TexMerge(TexMerge*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, void>)0x00505330)(ref this);
    // bool __cdecl TexMerge::RestoreSurface(CSurface*)
    public static byte RestoreSurface(ACBindings.CSurface* surface) => ((delegate* unmanaged[Cdecl]<ACBindings.CSurface*, byte>)0x00505370)(surface);
    // CSurface* __thiscall TexMerge::MakeNewSurface(TexMerge*,unsigned int,unsigned int)
    public ACBindings.CSurface* MakeNewSurface(uint pcode, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TexMerge, uint, uint, ACBindings.CSurface*>)0x00505410)(ref this, pcode, size);
}

