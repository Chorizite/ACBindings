namespace ACBindings.Internal;

public unsafe struct LandSurf : System.IDisposable
{
    // Members
    public ACBindings.Internal.PalShift* pal_shift;
    public ACBindings.Internal.TexMerge* tex_merge;
    public System.IntPtr surf_info;
    public uint num_lsurf;
    public ACBindings.Internal.CSurface** lsurf;
    public uint num_unique_surfaces;
    public uint num_block_surfs;
    public ACBindings.Internal.AC1Legacy.SmartArray___CSurface_ptr block_surf_array;
    public byte* curr_tex;

    // Generated Constructor
    public LandSurf() {
        _ConstructorInternal();
    }

    // Generated Dispose
    public void Dispose() {
        _DestructorInternal();
    }

    // Methods

    /// <summary>
    /// <code>Offset: 0x005034F0
    /// unsigned int __thiscall LandSurf::pack_size(LandSurf*)</code>
    /// </summary>
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, uint>)0x005034F0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00503510
    /// unsigned int __thiscall LandSurf::NextFree(LandSurf*)</code>
    /// </summary>
    public uint NextFree() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, uint>)0x00503510)(ref this);

    /// <summary>
    /// <code>Offset: 0x005035E0
    /// unsigned int __thiscall LandSurf::GetDetailTiling(LandSurf*,unsigned int)</code>
    /// </summary>
    public uint GetDetailTiling(uint terrain_number) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, uint, uint>)0x005035E0)(ref this, terrain_number);

    /// <summary>
    /// <code>Offset: 0x00503600
    /// void __thiscall LandSurf::Destroy(LandSurf*)</code>
    /// </summary>
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, void>)0x00503600)(ref this);

    /// <summary>
    /// <code>Offset: 0x00503670
    /// unsigned int __thiscall LandSurf::Pack(LandSurf*,void**,unsigned int*)</code>
    /// </summary>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, void**, uint*, uint>)0x00503670)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005036D0
    /// int __thiscall LandSurf::UnPack(LandSurf*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, void**, uint*, int>)0x005036D0)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x00503770
    /// IDClass&lt;_tagDataID,32,0&gt;* __thiscall LandSurf::GetDetailTex(_DWORD*,IDClass&lt;_tagDataID,32,0&gt;*,unsigned int)</code>
    /// </summary>
    public ACBindings.Internal.IDClass____tagDataID* GetDetailTex(ACBindings.Internal.IDClass____tagDataID* a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, ACBindings.Internal.IDClass____tagDataID*, uint, ACBindings.Internal.IDClass____tagDataID*>)0x00503770)(ref this, a2, a3);

    /// <summary>
    /// <code>Offset: 0x005037A0
    /// void __thiscall LandSurf::~LandSurf(LandSurf*)</code>
    /// </summary>
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, void>)0x005037A0)(ref this);

    /// <summary>
    /// <code>Offset: 0x00503830
    /// void __thiscall LandSurf::LandSurf(LandSurf*)</code>
    /// </summary>
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, void>)0x00503830)(ref this);

    /// <summary>
    /// <code>Offset: 0x005038E0
    /// int __thiscall LandSurf::AddNewSurface(LandSurf*,CSurface*,unsigned int,unsigned int*)</code>
    /// </summary>
    public int AddNewSurface(ACBindings.Internal.CSurface* surf, uint pcode, uint* surf_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, ACBindings.Internal.CSurface*, uint, uint*, int>)0x005038E0)(ref this, surf, pcode, surf_num);

    /// <summary>
    /// <code>Offset: 0x00503950
    /// void __thiscall LandSurf::RemoveSurface(LandSurf*,unsigned int)</code>
    /// </summary>
    public void RemoveSurface(uint surf_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, uint, void>)0x00503950)(ref this, surf_num);

    /// <summary>
    /// <code>Offset: 0x00503AD0
    /// int __thiscall LandSurf::SelectTerrain(LandSurf*,int,int,unsigned int*,LandDefs::Rotation*,unsigned int*,unsigned int,int)</code>
    /// </summary>
    public int SelectTerrain(int x, int y, uint* surf_num, ACBindings.Internal.LandDefs.Rotation* rot, uint* pal_code, uint size, int minimize_pal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.LandSurf, int, int, uint*, ACBindings.Internal.LandDefs.Rotation*, uint*, uint, int, int>)0x00503AD0)(ref this, x, y, surf_num, rot, pal_code, size, minimize_pal);
}

