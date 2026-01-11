namespace ACBindings.Internal;

public unsafe struct TexMerge : System.IDisposable
{
    // Statics
    public static byte* tex_data = (byte*)0x0084271C;

    // Members
    public uint base_tex_size;
    public ACBindings.Internal.AC1Legacy.SmartArray___TerrainAlphaMap_ptr corner_terrain_maps;
    public ACBindings.Internal.AC1Legacy.SmartArray___TerrainAlphaMap_ptr side_terrain_maps;
    public ACBindings.Internal.AC1Legacy.SmartArray___RoadAlphaMap_ptr road_maps;
    public ACBindings.Internal.AC1Legacy.SmartArray___TMTerrainDesc_ptr terrain_desc;

    // Generated Constructor
    public TexMerge() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x00503E30
    /// void __thiscall TexMerge::CleanupSurface(TexMerge*,CSurface*)</code>
    /// </summary>
    public void CleanupSurface(ACBindings.Internal.CSurface* surf) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, ACBindings.Internal.CSurface*, void>)0x00503E30)(ref this, surf);

    /// <summary>
    /// <code>Offset: 0x00503E50
    /// int __thiscall TexMerge::GetRoadCode(TexMerge*,unsigned int,int*,unsigned int*)</code>
    /// </summary>
    public int GetRoadCode(uint pcode, int* road_fill, uint* rcode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, uint, int*, uint*, int>)0x00503E50)(ref this, pcode, road_fill, rcode);

    /// <summary>
    /// <code>Offset: 0x00503FB0
    /// void __thiscall TexMerge::TexMerge(TexMerge*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, void>)0x00503FB0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00503FE0
    /// int __thiscall TexMerge::CopyAndTile(TexMerge*,unsigned __int8*,unsigned int,TerrainTex*)</code>
    /// </summary>
    public int CopyAndTile(byte* data, uint tex_size, ACBindings.Internal.TerrainTex* terrain_tex) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, byte*, uint, ACBindings.Internal.TerrainTex*, int>)0x00503FE0)(ref this, data, tex_size, terrain_tex);

    /// <summary>
    /// <code>Offset: 0x00504060
    /// int __thiscall TexMerge::FindRoadAlpha(TexMerge*,unsigned int,RoadAlphaMap**,LandDefs::Rotation*,unsigned int)</code>
    /// </summary>
    public int FindRoadAlpha(uint rcode, ACBindings.Internal.RoadAlphaMap** alpha, ACBindings.Internal.LandDefs.Rotation* rot, uint pcode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, uint, ACBindings.Internal.RoadAlphaMap**, ACBindings.Internal.LandDefs.Rotation*, uint, int>)0x00504060)(ref this, rcode, alpha, rot, pcode);

    /// <summary>
    /// <code>Offset: 0x00504160
    /// int __thiscall TexMerge::FindTerrainAlpha(TexMerge*,unsigned int,TerrainAlphaMap**,LandDefs::Rotation*,unsigned int)</code>
    /// </summary>
    public int FindTerrainAlpha(uint tcode, ACBindings.Internal.TerrainAlphaMap** alpha, ACBindings.Internal.LandDefs.Rotation* rot, uint pcode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, uint, ACBindings.Internal.TerrainAlphaMap**, ACBindings.Internal.LandDefs.Rotation*, uint, int>)0x00504160)(ref this, tcode, alpha, rot, pcode);

    /// <summary>
    /// <code>Offset: 0x00504320
    /// int __thiscall TexMerge::Merge(TexMerge*,unsigned __int8*,unsigned int,ImgTex*,LandDefs::Rotation,TerrainTex*)</code>
    /// </summary>
    public int Merge(byte* data, uint tex_size, ACBindings.Internal.ImgTex* texture, ACBindings.Internal.LandDefs.Rotation rot, ACBindings.Internal.TerrainTex* terrain) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, byte*, uint, ACBindings.Internal.ImgTex*, ACBindings.Internal.LandDefs.Rotation, ACBindings.Internal.TerrainTex*, int>)0x00504320)(ref this, data, tex_size, texture, rot, terrain);

    /// <summary>
    /// <code>Offset: 0x005043A0
    /// TerrainTex* __thiscall TexMerge::GetTerrainTex(TexMerge*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.TerrainTex* GetTerrainTex(uint t1) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, uint, ACBindings.Internal.TerrainTex*>)0x005043A0)(ref this, t1);

    /// <summary>
    /// <code>Offset: 0x00504400
    /// unsigned int __thiscall TexMerge::pack_size(TexMerge*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, uint>)0x00504400)(ref this);

    /// <summary>
    /// <code>Offset: 0x00504440
    /// IDClass&lt;_tagDataID,32,0&gt;* __thiscall TexMerge::GetDetailTex(_DWORD*,IDClass&lt;_tagDataID,32,0&gt;*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.IDClass____tagDataID* GetDetailTex(ACBindings.Internal.IDClass____tagDataID* a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, ACBindings.Internal.IDClass____tagDataID*, uint, ACBindings.Internal.IDClass____tagDataID*>)0x00504440)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x00504710
    /// void __thiscall TexMerge::GetSubDataIDs(TexMerge*,QualifiedDataIDArray*)</code>
    /// </summary>
    public void GetSubDataIDs(ACBindings.Internal.QualifiedDataIDArray* id_array) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, ACBindings.Internal.QualifiedDataIDArray*, void>)0x00504710)(ref this, id_array);

    /// <summary>
    /// <code>Offset: 0x00504820
    /// int __thiscall TexMerge::GetTerrain(TexMerge*,unsigned int,TerrainTex**,unsigned int*)</code>
    /// </summary>
    public int GetTerrain(uint pcode, ACBindings.Internal.TerrainTex** terrain_tex, uint* tcode) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, uint, ACBindings.Internal.TerrainTex**, uint*, int>)0x00504820)(ref this, pcode, terrain_tex, tcode);

    /// <summary>
    /// <code>Offset: 0x00504B40
    /// unsigned int __thiscall TexMerge::Pack(TexMerge*,void**,unsigned int*)</code>
    /// </summary>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, void**, uint*, uint>)0x00504B40)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00504D80
    /// void __thiscall TexMerge::Destroy(TexMerge*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, void>)0x00504D80)(ref this);

    /// <summary>
    /// <code>Offset: 0x00504EB0
    /// int __thiscall TexMerge::FillTempTexBuffer(TexMerge*,unsigned int,unsigned int)</code>
    /// </summary>
    public int FillTempTexBuffer(uint pcode, uint tex_size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, uint, uint, int>)0x00504EB0)(ref this, pcode, tex_size);

    /// <summary>
    /// <code>Offset: 0x00505010
    /// int __thiscall TexMerge::UnPack(TexMerge*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, void**, uint*, int>)0x00505010)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00505330
    /// void __thiscall TexMerge::~TexMerge(TexMerge*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, void>)0x00505330)(ref this);

    /// <summary>
    /// <code>Offset: 0x00505370
    /// bool __cdecl TexMerge::RestoreSurface(CSurface*)</code>
    /// </summary>
    public static byte RestoreSurface(ACBindings.Internal.CSurface* surface) => ((delegate* unmanaged[Cdecl]<ACBindings.Internal.CSurface*, byte>)0x00505370)(surface);

    /// <summary>
    /// <code>Offset: 0x00505410
    /// CSurface* __thiscall TexMerge::MakeNewSurface(TexMerge*,unsigned int,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.CSurface* MakeNewSurface(uint pcode, uint size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TexMerge, uint, uint, ACBindings.Internal.CSurface*>)0x00505410)(ref this, pcode, size);
}

