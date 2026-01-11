namespace ACBindings.Internal;

public unsafe struct TerrainTex
{
    // Members
    public ACBindings.Internal.IDClass____tagDataID tex_gid;
    public ACBindings.Internal.ImgTex* base_texture;
    public float min_slope;
    public uint tex_tiling;
    public uint max_vert_bright;
    public uint min_vert_bright;
    public uint max_vert_saturate;
    public uint min_vert_saturate;
    public uint max_vert_hue;
    public uint min_vert_hue;
    public uint detail_tex_tiling;
    public ACBindings.Internal.IDClass____tagDataID detail_tex_gid;

    // Methods

    /// <summary>
    /// <code>Offset: 0x00503F70
    /// int __thiscall TerrainTex::InitEnd(TerrainTex*)</code>
    /// </summary>
    public int InitEnd() => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TerrainTex, int>)0x00503F70)(ref this);

    /// <summary>
    /// <code>Offset: 0x00504490
    /// unsigned int __thiscall TerrainTex::Pack(TerrainTex*,void**,unsigned int*)</code>
    /// </summary>
    public uint Pack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TerrainTex, void**, uint*, uint>)0x00504490)(ref this, addr, size);

    /// <summary>
    /// <code>Offset: 0x005045A0
    /// int __thiscall TerrainTex::UnPack(TerrainTex*,void**,unsigned int*)</code>
    /// </summary>
    public int UnPack(void** addr, uint* size) => ((delegate* unmanaged[Thiscall]<ref ACBindings.Internal.TerrainTex, void**, uint*, int>)0x005045A0)(ref this, addr, size);
}

