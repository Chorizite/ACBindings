namespace ACBindings;

// LandSurf
public unsafe struct LandSurf : System.IDisposable
{
    // Members
    public ACBindings.PalShift* pal_shift;
    public ACBindings.TexMerge* tex_merge;
    public System.IntPtr surf_info;
    public uint num_lsurf;
    public ACBindings.CSurface** lsurf;
    public uint num_unique_surfaces;
    public uint num_block_surfs;
    public ACBindings.AC1Legacy.SmartArray__CSurface_ptr block_surf_array;
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
    // unsigned int __thiscall LandSurf::pack_size(LandSurf*)
    public uint pack_size() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LandSurf, uint>)0x005034F0)(ref this);
    // unsigned int __thiscall LandSurf::NextFree(LandSurf*)
    public uint NextFree() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LandSurf, uint>)0x00503510)(ref this);
    // unsigned int __thiscall LandSurf::GetDetailTiling(LandSurf*,unsigned int)
    public uint GetDetailTiling(uint terrain_number) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LandSurf, uint, uint>)0x005035E0)(ref this, terrain_number);
    // void __thiscall LandSurf::Destroy(LandSurf*)
    public void Destroy() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LandSurf, void>)0x00503600)(ref this);
    // unsigned int __thiscall LandSurf::Pack(LandSurf*,void**,unsigned int*)
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LandSurf, void**, uint*, uint>)0x00503670)(ref this, addr, size);
    // int __thiscall LandSurf::UnPack(LandSurf*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LandSurf, void**, uint*, int>)0x005036D0)(ref this, addr, size);
    // IDClass<_tagDataID,32,0>* __thiscall LandSurf::GetDetailTex(_DWORD*,IDClass<_tagDataID,32,0>*,unsigned int)
    public ACBindings.IDClass___tagDataID* GetDetailTex(ACBindings.IDClass___tagDataID* a2, uint a3) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LandSurf, ACBindings.IDClass___tagDataID*, uint, ACBindings.IDClass___tagDataID*>)0x00503770)(ref this, a2, a3);
    // void __thiscall LandSurf::~LandSurf(LandSurf*)
    public void _DestructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LandSurf, void>)0x005037A0)(ref this);
    // void __thiscall LandSurf::LandSurf(LandSurf*)
    public void _ConstructorInternal() => ((delegate* unmanaged[Thiscall]<ref ACBindings.LandSurf, void>)0x00503830)(ref this);
    // int __thiscall LandSurf::AddNewSurface(LandSurf*,CSurface*,unsigned int,unsigned int*)
    public int AddNewSurface(ACBindings.CSurface* surf, uint pcode, uint* surf_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LandSurf, ACBindings.CSurface*, uint, uint*, int>)0x005038E0)(ref this, surf, pcode, surf_num);
    // void __thiscall LandSurf::RemoveSurface(LandSurf*,unsigned int)
    public void RemoveSurface(uint surf_num) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LandSurf, uint, void>)0x00503950)(ref this, surf_num);
    // int __thiscall LandSurf::SelectTerrain(LandSurf*,int,int,unsigned int*,LandDefs::Rotation*,unsigned int*,unsigned int,int)
    public int SelectTerrain(int x, int y, uint* surf_num, ACBindings.LandDefs.Rotation* rot, uint* pal_code, uint size, int minimize_pal) => ((delegate* unmanaged[Thiscall]<ref ACBindings.LandSurf, int, int, uint*, ACBindings.LandDefs.Rotation*, uint*, uint, int, int>)0x00503AD0)(ref this, x, y, surf_num, rot, pal_code, size, minimize_pal);
}

