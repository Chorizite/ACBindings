namespace ACBindings;

// TerrainTex
public unsafe struct TerrainTex
{
    // Members
    public ACBindings.IDClass___tagDataID tex_gid;
    public ACBindings.ImgTex* base_texture;
    public float min_slope;
    public uint tex_tiling;
    public uint max_vert_bright;
    public uint min_vert_bright;
    public uint max_vert_saturate;
    public uint min_vert_saturate;
    public uint max_vert_hue;
    public uint min_vert_hue;
    public uint detail_tex_tiling;
    public ACBindings.IDClass___tagDataID detail_tex_gid;

    // Methods
    // int __thiscall TerrainTex::InitEnd(TerrainTex*)
    public int InitEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.TerrainTex, int>)0x00503F70)(ref this);
    // unsigned int __thiscall TerrainTex::Pack(TerrainTex*,void**,unsigned int*)
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TerrainTex, void**, uint*, uint>)0x00504490)(ref this, addr, size);
    // int __thiscall TerrainTex::UnPack(TerrainTex*,void**,unsigned int*)
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.TerrainTex, void**, uint*, int>)0x005045A0)(ref this, addr, size);
}

